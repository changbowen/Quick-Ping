Public Class Form1
    Private Shared ReadOnly AllDC As New List(Of DirectoryServices.ActiveDirectory.DomainController)
    'Dim ippool(,) As String = {{"APACSIN", "192.168.34."}, {"APACHKG", "192.168.56."}, {"EMEACOP", "192.168.107."}, {"APACBEI", "192.168.33."}, {"APACSHI", "192.168.60."}, {"APACDEL", "192.168.35."}, {"APACBLR", "192.168.37."}, {"apacmum", "192.168.36."}, {"EMEASWE", "192.168.101."}, {"EMEAMIL", "192.168.100."}, {"EMEAPAR", "192.168.98."}, {"NABOS", "192.168.1."}, {"NANYC", "192.168.4."}, {"EMEAJOB", "192.168.104."}, {"EMEAAMS", "192.168.99."}, {"EMEAMUC", "192.168.97."}, {"EMEALON", "192.168.96."}, {"NASFO", "192.168.6."}, {"APACSYD", "192.168.57."}, {"NARCH", "192.168.2."}, {"EMEAMAD", "192.168.102."}, {"APACMALF", "192.168.61."}, {"NABOXWDS2012", "192.168.3."}}
    Private running As Boolean = False
    Delegate Sub myDelegate(ByVal a As String, ByVal b As String, ByVal c As String)
    Private cht As DataVisualization.Charting.Chart
    Private chtSer As DataVisualization.Charting.Series
    Private ReadOnly h_orig As Integer = Height
    Private Const chtheight As Integer = 70

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        running = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill proxy
        Dim regiset = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings")
        Dim proxystr As String = regiset.GetValue("ProxyServer", "")
        If proxystr.Length > 0 Then CbB_Proxy.Items.Add(proxystr)
        CbB_Proxy.SelectedIndex = 0

        TLP.RowCount = 0
        TLP.RowStyles.Clear()
        TLP.Padding = New Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0)

        'adding gateway to GB_To
        For Each card In Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
            If card.OperationalStatus = Net.NetworkInformation.OperationalStatus.Up Then
                For Each gw In card.GetIPProperties.GatewayAddresses
                    CB_T.Items.Add(gw.Address.ToString)
                Next
            End If
        Next

        'showing label cover
        Dim cover1 As New Label
        With cover1
            .AutoSize = False
            .Text = "Populating DC list..."
            .TextAlign = ContentAlignment.MiddleCenter
            .Size = ListBox1.Size
            .Location = ListBox1.Location
        End With
        GB_From.Controls.Add(cover1)
        cover1.BringToFront()
        Dim cover2 As New Label
        With cover2
            .AutoSize = False
            .Text = "Populating DC list..."
            .TextAlign = ContentAlignment.MiddleCenter
            .Size = ListBox2.Size
            .Location = ListBox2.Location
        End With
        GB_To.Controls.Add(cover2)
        cover2.BringToFront()

        Task.Run(Sub()
                     Try
                         For Each dc As DirectoryServices.ActiveDirectory.DomainController In DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain.DomainControllers
                             AllDC.Add(dc)
                         Next
                         'AllDC.AddRange(DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain.DomainControllers)
                         Invoke(Sub()
                                    For Each DC As DirectoryServices.ActiveDirectory.DomainController In AllDC
                                        ListBox1.Items.Add(DC.Name)
                                        ListBox2.Items.Add(DC.Name)
                                    Next
                                    GB_From.Controls.Remove(cover1)
                                    GB_To.Controls.Remove(cover2)
                                End Sub)
                     Catch
                         Invoke(Sub()
                                    cover1.Text = "Failed to populate DC list"
                                    cover2.Text = "Failed to populate DC list"
                                End Sub)
                     End Try
                 End Sub)

        'guess location and change LB selection
        'this was for Text100 environment
        'Dim objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\cimv2")
        'Dim ipconfigset = objWMIService.ExecQuery("Select IPAddress from Win32_NetworkAdapterConfiguration where IPEnabled=true and WINSPrimaryServer is NOT NULL")
        'Dim ipaddr As String = Nothing
        'For Each ipconfig In ipconfigset
        '    For i = LBound(ipconfig.IPAddress) To UBound(ipconfig.IPAddress)
        '        If ipconfig.IPAddress(i).ToString.StartsWith("192") Then
        '            ipaddr = ipconfig.IPAddress(i)
        '        End If
        '    Next
        'Next
        'For i = 0 To ippool.GetUpperBound(0)
        '    If ipaddr.StartsWith(ippool(i, 1)) Then
        '        ListBox1.SelectedIndex = ListBox1.FindString(ippool(i, 0))
        '        ListBox2.SelectedIndex = ListBox2.FindString(ippool(i, 0))
        '    End If
        'Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If running = False Then
            If CB_S.Text = "" Then CB_S.Text = "localhost"
            If CB_T.Text = "" Then CB_T.Text = "localhost"
            If CbB_Proxy.SelectedIndex > 0 AndAlso CB_S.Text.ToLower <> "localhost" Then MsgBox("In Proxy Mode, source / from address will always be localhost.", MsgBoxStyle.Exclamation) : CB_S.Text = "localhost"
            Dim sourcesvr As String = CB_S.Text
            Dim targetsvr As String = CB_T.Text
            ListBox1.Enabled = False
            ListBox2.Enabled = False
            CB_S.Enabled = False
            CB_T.Enabled = False
            NUD_Delay.Enabled = False
            UpdateComboBox(CB_S)
            UpdateComboBox(CB_T)
            TextBox1.Clear()

            'adding chart
            If TLP.Height <= chtheight * 2 Then Height += chtheight
            TLP.RowCount += 1
            TLP.RowStyles.Add(New RowStyle(SizeType.Absolute, chtheight))
            cht = New DataVisualization.Charting.Chart
            cht.Dock = DockStyle.Fill
            'cht.Size = New Size(TLP.ClientSize.Width - 30, chtheight)
            cht.BackColor = Color.FromKnownColor(KnownColor.Control)
            AddHandler cht.GetToolTipText, Sub(sender1 As Object, e1 As DataVisualization.Charting.ToolTipEventArgs)
                                               Dim htr = e1.HitTestResult
                                               Select Case htr.ChartElementType
                                                   Case DataVisualization.Charting.ChartElementType.DataPoint
                                                       Dim p = htr.Series.Points(htr.PointIndex)
                                                       Select Case p.Color
                                                           Case Color.Red
                                                               e1.Text = "Timed out"
                                                           Case Color.Gray
                                                               e1.Text = "Waiting..."
                                                           Case Else
                                                               e1.Text = p.YValues(0) & " ms"
                                                       End Select
                                               End Select
                                           End Sub

            cht.ChartAreas.Add("mainArea")
            With cht.ChartAreas("mainArea")
                .BackColor = Color.FromKnownColor(KnownColor.Control)
                .AxisX.LabelStyle.Enabled = False
                .AxisX.LineColor = Color.FromKnownColor(KnownColor.Control)
                .AxisY.LineColor = Color.FromKnownColor(KnownColor.Control)
                .AxisY.LabelStyle.Font = New Font(.AxisX.LabelStyle.Font.FontFamily, 5)
                .AxisY.Interval = 200
                .AxisY.MajorTickMark.Enabled = False
                .AxisX.MajorGrid.Enabled = False
                '.AxisY.MajorGrid.Enabled = False
                .AxisY.MajorGrid.LineColor = Color.LightGray
                '.AxisX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Hours
                '.AxisX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Hours
                '.AxisX.Interval = 1
                '.AxisX.ScaleView.SmallScrollSizeType = DataVisualization.Charting.DateTimeIntervalType.Hours
                '.AxisX.ScaleView.SmallScrollSize = 8
                '.AxisX.ScaleView.SizeType = DataVisualization.Charting.DateTimeIntervalType.Hours
                '.AxisX.ScaleView.Size = 24
                '.AxisX.ScrollBar.Enabled = True
                '.AxisX.ScrollBar.ButtonStyle = DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll
                If CB_LockMax.Checked Then .AxisY.Maximum = 600
            End With

            chtSer = cht.Series.Add("mainSer")
            'cht.Series("mainSer")("PixelPointWidth") = "5"
            chtSer.Points.Clear()
            running = True
            Dim pingthread As Threading.Thread
            If CbB_Proxy.SelectedIndex = 0 Then
                With cht.Titles.Add("mainTitle")
                    .Text = "From " & CB_S.Text & " to " & CB_T.Text
                    .Font = New Font(Font.FontFamily, 8)
                    .Alignment = ContentAlignment.TopLeft
                End With
                pingthread = New Threading.Thread(Sub() Ping(sourcesvr, targetsvr, Convert.ToInt32(NUD_Delay.Value)))
            Else
                With cht.Titles.Add("mainTitle")
                    .Text = "From " & CB_S.Text & " to " & CB_T.Text & " via " & CbB_Proxy.Text
                    .Font = New Font(Font.FontFamily, 8)
                    .Alignment = ContentAlignment.TopLeft
                End With
                pingthread = New Threading.Thread(Sub() ProxyPing(targetsvr, TB_ProxyAddr.Text, TB_ProxyPort.Text, Convert.ToInt32(NUD_Delay.Value)))
            End If
            TLP.Controls.Add(cht)
            TLP.ScrollControlIntoView(cht)

            pingthread.IsBackground = True
            pingthread.Start()
        Else
            ListBox1.Enabled = False
            ListBox2.Enabled = False
            NUD_Delay.Enabled = False
            Button1.Enabled = False
            running = False
        End If
    End Sub

    Private Sub ProxyPing(ByVal target As String, ByVal proxy_svr As String, ByVal proxy_port As Integer, ByVal delay As Integer)
        Dim restimetemp As Integer = 0, countall As Integer = 0, count As Integer = 0
        Dim Lock_RT_C_CA As New Object

        Dim allpingthrd As New List(Of Task)
        Do While running = True
            allpingthrd.Add(Task.Run(
              Sub()
                  Try
                      Dim currPoint As Integer
                      Invoke(Sub()
                                 SyncLock Lock_RT_C_CA
                                     countall += 1
                                     currPoint = chtSer.Points.AddXY(countall, 0)
                                     'total count
                                     Lbl_Total.Text = countall
                                 End SyncLock
                                 chtSer.Points(currPoint).Color = Color.Gray
                                 TextBox1.Text = "Ping..." & vbCrLf & TextBox1.Text
                             End Sub)

                      Dim request = Net.WebRequest.Create(New UriBuilder("http", target).Uri)
                      request.Proxy = New Net.WebProxy(New UriBuilder("http", proxy_svr, proxy_port).Uri)
                      Dim timer As New Stopwatch
                      Dim resp As Net.WebResponse
                      Dim elapsed As Long = -1
                      Try
                          timer.Start()
                          resp = request.GetResponse()
                      Catch
                      Finally
                          timer.Stop()
                          If resp IsNot Nothing Then
                              elapsed = timer.ElapsedMilliseconds
                              resp.Dispose()
                          Else
                              elapsed = -1
                          End If
                      End Try

                      If elapsed > 0 Then
                          SyncLock Lock_RT_C_CA
                              restimetemp += elapsed
                              count += 1
                          End SyncLock
                      End If

                      Invoke(Sub()
                                 If elapsed <> -1 Then
                                     Dim tmparray = TextBox1.Lines
                                     tmparray(tmparray.Length - 2 - currPoint) = elapsed.ToString & " ms"
                                     TextBox1.Lines = tmparray
                                     cht.Series("mainSer").Points(currPoint).SetValueY(elapsed)
                                     If elapsed < 150 Then
                                         chtSer.Points(currPoint).Color = Color.Green
                                     ElseIf elapsed >= 150 Then
                                         chtSer.Points(currPoint).Color = Color.Yellow
                                     End If
                                 Else
                                     Dim tmparray = TextBox1.Lines
                                     tmparray(tmparray.Length - 2 - currPoint) = "Timed Out"
                                     TextBox1.Lines = tmparray
                                     chtSer.Points(currPoint).SetValueY(1000)
                                     chtSer.Points(currPoint).Color = Color.Red
                                 End If
                                 'TextBox1.ScrollToCaret()
                                 SyncLock Lock_RT_C_CA
                                     'average ping
                                     If count > 0 Then
                                         Lbl_Avg.Text = (restimetemp \ count).ToString & " ms"
                                     End If
                                     'loss
                                     Lbl_Fail.Text = Math.Round((countall - count) / countall * 100).ToString & " %"
                                 End SyncLock

                                 Lbl_ReAddr.Text = "N/A"
                             End Sub)
                  Catch ex As Exception
                      running = False
                      MsgBox("The current connection has encountered an error retrieving data." & vbCrLf & "Error message: " & ex.Message & vbCrLf & "Proxy server: " & proxy_svr & vbCrLf & "Target server: " & target, MsgBoxStyle.Exclamation)
                      Invoke(Sub()
                                 ListBox1.Enabled = True
                                 ListBox2.Enabled = True
                                 CB_S.Enabled = True
                                 CB_T.Enabled = True
                                 NUD_Delay.Enabled = True
                                 Button1.Enabled = True
                             End Sub)
                  End Try
              End Sub))
            If delay > 5000 Then
                Dim d = delay
                While running
                    If d > 5000 Then
                        Threading.Thread.Sleep(5000)
                        d -= 5000
                    ElseIf d > 0 Then
                        Threading.Thread.Sleep(d)
                        Exit While
                    End If
                End While
            Else
                Threading.Thread.Sleep(delay)
            End If
        Loop

        Task.WaitAll(allpingthrd.ToArray)
        Invoke(Sub()
                   ListBox1.Enabled = True
                   ListBox2.Enabled = True
                   CB_S.Enabled = True
                   CB_T.Enabled = True
                   NUD_Delay.Enabled = True
                   Button1.Enabled = True
               End Sub)
    End Sub

    Private Sub Ping(ByVal source As String, ByVal target As String, ByVal delay As Integer)
        Dim restimetemp As Integer = 0, countall As Integer = 0, count As Integer = 0 ', countL As Integer = 0 , response As Integer = 0, responseRT As Integer = 0, loss As Single = 0, responsePA As String = ""
        Dim objWMIService, objSWbemLocator
        Dim Lock_RT_C_CA As New Object
        Try
            objSWbemLocator = CreateObject("WbemScripting.SWbemLocator")
            objWMIService = objSWbemLocator.ConnectServer(source)
        Catch ex As Exception
            MsgBox("The current connection has encountered an error while initiating. Please retry connections." & vbCrLf & "Error message: " & ex.Message & vbCrLf & "Source server: " & source, MsgBoxStyle.Exclamation)
            If objWMIService IsNot Nothing Then Runtime.InteropServices.Marshal.FinalReleaseComObject(objWMIService)
            objWMIService = Nothing
            If objSWbemLocator IsNot Nothing Then Runtime.InteropServices.Marshal.FinalReleaseComObject(objSWbemLocator)
            objSWbemLocator = Nothing
            running = False
        End Try

        Dim allpingthrd As New List(Of Task)
        Do While running = True
            allpingthrd.Add(
                Task.Run(Sub()
                             Try
                                 Dim responsePA = "", responseRT = -1
                                 Dim currPoint As Integer
                                 Invoke(Sub()
                                            SyncLock Lock_RT_C_CA
                                                countall += 1
                                                currPoint = chtSer.Points.AddXY(countall, 0)
                                                'total count
                                                Lbl_Total.Text = countall
                                            End SyncLock
                                            chtSer.Points(currPoint).Color = Color.Gray
                                            TextBox1.Text = "Ping..." & vbCrLf & TextBox1.Text
                                        End Sub)
                                 Dim resultset = objWMIService.Get("Win32_PingStatus.Address='" & target & "'")
                                 If Not IsDBNull(resultset.StatusCode) Then
                                     If resultset.StatusCode = 0 Then
                                         responsePA = resultset.ProtocolAddress
                                         responseRT = resultset.ResponseTime
                                         SyncLock Lock_RT_C_CA
                                             restimetemp += responseRT
                                             count += 1
                                         End SyncLock
                                         'Else
                                         '    countL += 1
                                         '    responseRT = -1
                                     End If
                                     'Else
                                     '    countL += 1
                                     '    responseRT = -1
                                 End If
                                 If resultset IsNot Nothing Then
                                     Runtime.InteropServices.Marshal.FinalReleaseComObject(resultset)
                                     resultset = Nothing
                                 End If

                                 Invoke(Sub()
                                            If responseRT <> -1 Then
                                                Dim tmparray = TextBox1.Lines
                                                tmparray(tmparray.Length - 2 - currPoint) = responseRT.ToString & " ms"
                                                TextBox1.Lines = tmparray
                                                cht.Series("mainSer").Points(currPoint).SetValueY(responseRT)
                                                If responseRT < 150 Then
                                                    chtSer.Points(currPoint).Color = Color.Green
                                                ElseIf responseRT >= 150 Then
                                                    chtSer.Points(currPoint).Color = Color.Yellow
                                                End If
                                            Else
                                                Dim tmparray = TextBox1.Lines
                                                tmparray(tmparray.Length - 2 - currPoint) = "Timed Out"
                                                TextBox1.Lines = tmparray
                                                chtSer.Points(currPoint).SetValueY(1000)
                                                chtSer.Points(currPoint).Color = Color.Red
                                            End If
                                            'TextBox1.ScrollToCaret()
                                            SyncLock Lock_RT_C_CA
                                                'average ping
                                                If count > 0 Then
                                                    Lbl_Avg.Text = (restimetemp \ count).ToString & " ms"
                                                End If
                                                'loss
                                                Lbl_Fail.Text = Math.Round((countall - count) / countall * 100).ToString & " %"
                                            End SyncLock

                                            If responsePA = "" Then
                                                Lbl_ReAddr.Text = "N/A"
                                            Else
                                                Lbl_ReAddr.Text = responsePA
                                            End If
                                        End Sub)
                             Catch ex As Exception
                                 running = False
                                 MsgBox("The current connection has encountered an error retrieving data." & vbCrLf & "Error message: " & ex.Message & vbCrLf & "Source server: " & source & vbCrLf & "Target server: " & target, MsgBoxStyle.Exclamation)
                                 If objWMIService IsNot Nothing Then Runtime.InteropServices.Marshal.ReleaseComObject(objWMIService)
                                 'objWMIService = Nothing
                                 If objSWbemLocator IsNot Nothing Then Runtime.InteropServices.Marshal.ReleaseComObject(objSWbemLocator)
                                 'objSWbemLocator = Nothing
                                 Invoke(Sub()
                                            ListBox1.Enabled = True
                                            ListBox2.Enabled = True
                                            CB_S.Enabled = True
                                            CB_T.Enabled = True
                                            NUD_Delay.Enabled = True
                                            Button1.Enabled = True
                                        End Sub)
                             End Try
                         End Sub))
            If delay > 5000 Then
                Dim d = delay
                While running
                    If d > 5000 Then
                        Threading.Thread.Sleep(5000)
                        d -= 5000
                    ElseIf d > 0 Then
                        Threading.Thread.Sleep(d)
                        Exit While
                    End If
                End While
            Else
                Threading.Thread.Sleep(delay)
            End If
        Loop

        Task.WaitAll(allpingthrd.ToArray)
        If objWMIService IsNot Nothing Then
            Runtime.InteropServices.Marshal.FinalReleaseComObject(objWMIService)
            objWMIService = Nothing
        End If
        If objSWbemLocator IsNot Nothing Then
            Runtime.InteropServices.Marshal.FinalReleaseComObject(objSWbemLocator)
            objSWbemLocator = Nothing
        End If
        Invoke(Sub()
                   ListBox1.Enabled = True
                   ListBox2.Enabled = True
                   CB_S.Enabled = True
                   CB_T.Enabled = True
                   NUD_Delay.Enabled = True
                   Button1.Enabled = True
               End Sub)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        CB_T.Text = ListBox2.SelectedItem.ToString
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        CB_S.Text = ListBox1.SelectedItem.ToString
    End Sub

    Private Sub CB_S_MouseClick(sender As Object, e As MouseEventArgs) Handles CB_S.MouseClick
        CB_S.SelectAll()
    End Sub

    Private Sub CB_T_MouseClick(sender As Object, e As MouseEventArgs) Handles CB_T.MouseClick
        CB_T.SelectAll()
    End Sub

    Private Sub UpdateComboBox(target As ComboBox)
        If target.Text <> "" AndAlso Not target.Items.Contains(target.Text) Then
            target.Items.Add(target.Text)
        End If
    End Sub

    Private Sub CbB_Proxy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbB_Proxy.SelectedIndexChanged
        If CbB_Proxy.SelectedIndex = 1 Then
            TB_ProxyAddr.Enabled = True
            TB_ProxyPort.Enabled = True
            ListBox1.Enabled = False
        ElseIf CbB_Proxy.SelectedIndex = 0 Then 'direct
            TB_ProxyAddr.Enabled = False
            TB_ProxyPort.Enabled = False
            ListBox1.Enabled = True
            TB_ProxyAddr.Clear()
            TB_ProxyPort.Clear()
        Else
            TB_ProxyAddr.Enabled = False
            TB_ProxyPort.Enabled = False
            ListBox1.Enabled = False
            Dim split = CbB_Proxy.Text.Split(":"c)
            TB_ProxyAddr.Text = split(0)
            TB_ProxyPort.Text = split(1)
        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim h = Height - h_orig
        If h > 0 Then
            TLP.Height = h
        Else
            TLP.Height = 0
        End If
    End Sub

    Private Sub CB_LockMax_CheckedChanged(sender As Object, e As EventArgs) Handles CB_LockMax.CheckedChanged
        If cht IsNot Nothing AndAlso cht.ChartAreas("mainArea") IsNot Nothing Then
            If CB_LockMax.Checked Then
                cht.ChartAreas("mainArea").AxisY.Maximum = 600
            Else
                cht.ChartAreas("mainArea").AxisY.Maximum = Double.NaN
            End If
        End If
    End Sub

    Private Sub MI_Clear_Click(sender As Object, e As EventArgs) Handles MI_Clear.Click
        TLP.Controls.Clear()
        TLP.RowCount = 0
        TLP.RowStyles.Clear()
    End Sub
End Class
