<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_Avg = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbl_Fail = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Lbl_ReAddr = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.NUD_Delay = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CB_S = New System.Windows.Forms.ComboBox()
        Me.CB_T = New System.Windows.Forms.ComboBox()
        Me.GB_Proxy = New System.Windows.Forms.GroupBox()
        Me.TB_ProxyAddr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbB_Proxy = New System.Windows.Forms.ComboBox()
        Me.GB_From = New System.Windows.Forms.GroupBox()
        Me.GB_To = New System.Windows.Forms.GroupBox()
        Me.GB_Results = New System.Windows.Forms.GroupBox()
        Me.TLP = New System.Windows.Forms.TableLayoutPanel()
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MI_Clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.CB_LockMax = New System.Windows.Forms.CheckBox()
        Me.NUD_ProxyPort = New System.Windows.Forms.NumericUpDown()
        CType(Me.NUD_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Proxy.SuspendLayout()
        Me.GB_From.SuspendLayout()
        Me.GB_To.SuspendLayout()
        Me.GB_Results.SuspendLayout()
        Me.CMS.SuspendLayout()
        CType(Me.NUD_ProxyPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(6, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(132, 186)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(6, 42)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(132, 186)
        Me.ListBox2.Sorted = True
        Me.ListBox2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(312, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 68)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Start / Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(6, 14)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(107, 214)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.WordWrap = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Average:"
        '
        'Lbl_Avg
        '
        Me.Lbl_Avg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Avg.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Avg.Location = New System.Drawing.Point(123, 34)
        Me.Lbl_Avg.Name = "Lbl_Avg"
        Me.Lbl_Avg.Size = New System.Drawing.Size(164, 28)
        Me.Lbl_Avg.TabIndex = 9
        Me.Lbl_Avg.Text = "000 ms"
        Me.Lbl_Avg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(167, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fail:"
        '
        'Lbl_Fail
        '
        Me.Lbl_Fail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Fail.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fail.Location = New System.Drawing.Point(123, 89)
        Me.Lbl_Fail.Name = "Lbl_Fail"
        Me.Lbl_Fail.Size = New System.Drawing.Size(164, 28)
        Me.Lbl_Fail.TabIndex = 13
        Me.Lbl_Fail.Text = "0 %"
        Me.Lbl_Fail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 14)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Reply Address:"
        '
        'Lbl_ReAddr
        '
        Me.Lbl_ReAddr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ReAddr.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ReAddr.Location = New System.Drawing.Point(119, 201)
        Me.Lbl_ReAddr.Name = "Lbl_ReAddr"
        Me.Lbl_ReAddr.Size = New System.Drawing.Size(168, 18)
        Me.Lbl_ReAddr.TabIndex = 15
        Me.Lbl_ReAddr.Text = "0.0.0.0"
        Me.Lbl_ReAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(167, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 14)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Total sent:"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Total.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(123, 144)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(164, 28)
        Me.Lbl_Total.TabIndex = 17
        Me.Lbl_Total.Text = "0"
        Me.Lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NUD_Delay
        '
        Me.NUD_Delay.Increment = New Decimal(New Integer() {250, 0, 0, 0})
        Me.NUD_Delay.Location = New System.Drawing.Point(402, 113)
        Me.NUD_Delay.Maximum = New Decimal(New Integer() {86400000, 0, 0, 0})
        Me.NUD_Delay.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NUD_Delay.Name = "NUD_Delay"
        Me.NUD_Delay.Size = New System.Drawing.Size(90, 22)
        Me.NUD_Delay.TabIndex = 18
        Me.NUD_Delay.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(309, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 14)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Delay (ms)"
        '
        'CB_S
        '
        Me.CB_S.FormattingEnabled = True
        Me.CB_S.Items.AddRange(New Object() {"localhost"})
        Me.CB_S.Location = New System.Drawing.Point(6, 14)
        Me.CB_S.Name = "CB_S"
        Me.CB_S.Size = New System.Drawing.Size(132, 22)
        Me.CB_S.TabIndex = 20
        '
        'CB_T
        '
        Me.CB_T.FormattingEnabled = True
        Me.CB_T.Items.AddRange(New Object() {"localhost", "www.google.com", "www.bing.com", "www.baidu.com", "www.yahoo.com"})
        Me.CB_T.Location = New System.Drawing.Point(6, 14)
        Me.CB_T.Name = "CB_T"
        Me.CB_T.Size = New System.Drawing.Size(132, 22)
        Me.CB_T.TabIndex = 21
        '
        'GB_Proxy
        '
        Me.GB_Proxy.Controls.Add(Me.TB_ProxyAddr)
        Me.GB_Proxy.Controls.Add(Me.Label1)
        Me.GB_Proxy.Controls.Add(Me.CbB_Proxy)
        Me.GB_Proxy.Controls.Add(Me.NUD_ProxyPort)
        Me.GB_Proxy.Location = New System.Drawing.Point(312, 12)
        Me.GB_Proxy.Name = "GB_Proxy"
        Me.GB_Proxy.Size = New System.Drawing.Size(180, 93)
        Me.GB_Proxy.TabIndex = 22
        Me.GB_Proxy.TabStop = False
        Me.GB_Proxy.Text = "Protocol"
        '
        'TB_ProxyAddr
        '
        Me.TB_ProxyAddr.Location = New System.Drawing.Point(6, 65)
        Me.TB_ProxyAddr.Name = "TB_ProxyAddr"
        Me.TB_ProxyAddr.Size = New System.Drawing.Size(104, 22)
        Me.TB_ProxyAddr.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Address & Port"
        Me.Label1.UseMnemonic = False
        '
        'CbB_Proxy
        '
        Me.CbB_Proxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbB_Proxy.FormattingEnabled = True
        Me.CbB_Proxy.Items.AddRange(New Object() {"ICMP", "HTTP (No Proxy)", "HTTP (Custom Proxy)"})
        Me.CbB_Proxy.Location = New System.Drawing.Point(6, 14)
        Me.CbB_Proxy.Name = "CbB_Proxy"
        Me.CbB_Proxy.Size = New System.Drawing.Size(168, 22)
        Me.CbB_Proxy.TabIndex = 0
        '
        'GB_From
        '
        Me.GB_From.Controls.Add(Me.CB_S)
        Me.GB_From.Controls.Add(Me.ListBox1)
        Me.GB_From.Location = New System.Drawing.Point(12, 12)
        Me.GB_From.Name = "GB_From"
        Me.GB_From.Size = New System.Drawing.Size(144, 234)
        Me.GB_From.TabIndex = 22
        Me.GB_From.TabStop = False
        Me.GB_From.Text = "From"
        '
        'GB_To
        '
        Me.GB_To.Controls.Add(Me.ListBox2)
        Me.GB_To.Controls.Add(Me.CB_T)
        Me.GB_To.Location = New System.Drawing.Point(162, 12)
        Me.GB_To.Name = "GB_To"
        Me.GB_To.Size = New System.Drawing.Size(144, 234)
        Me.GB_To.TabIndex = 22
        Me.GB_To.TabStop = False
        Me.GB_To.Text = "To"
        '
        'GB_Results
        '
        Me.GB_Results.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Results.Controls.Add(Me.Label5)
        Me.GB_Results.Controls.Add(Me.Lbl_Avg)
        Me.GB_Results.Controls.Add(Me.Label7)
        Me.GB_Results.Controls.Add(Me.Lbl_Fail)
        Me.GB_Results.Controls.Add(Me.Label9)
        Me.GB_Results.Controls.Add(Me.Lbl_Total)
        Me.GB_Results.Controls.Add(Me.TextBox1)
        Me.GB_Results.Controls.Add(Me.Lbl_ReAddr)
        Me.GB_Results.Controls.Add(Me.Label11)
        Me.GB_Results.Location = New System.Drawing.Point(498, 12)
        Me.GB_Results.Name = "GB_Results"
        Me.GB_Results.Size = New System.Drawing.Size(294, 234)
        Me.GB_Results.TabIndex = 22
        Me.GB_Results.TabStop = False
        Me.GB_Results.Text = "Results"
        '
        'TLP
        '
        Me.TLP.AutoScroll = True
        Me.TLP.ColumnCount = 1
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP.ContextMenuStrip = Me.CMS
        Me.TLP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLP.Location = New System.Drawing.Point(0, 258)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 1
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP.Size = New System.Drawing.Size(804, 0)
        Me.TLP.TabIndex = 24
        '
        'CMS
        '
        Me.CMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_Clear})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(102, 26)
        '
        'MI_Clear
        '
        Me.MI_Clear.Name = "MI_Clear"
        Me.MI_Clear.Size = New System.Drawing.Size(101, 22)
        Me.MI_Clear.Text = "Clear"
        '
        'CB_LockMax
        '
        Me.CB_LockMax.AutoSize = True
        Me.CB_LockMax.Checked = True
        Me.CB_LockMax.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_LockMax.Location = New System.Drawing.Point(312, 144)
        Me.CB_LockMax.Name = "CB_LockMax"
        Me.CB_LockMax.Size = New System.Drawing.Size(131, 18)
        Me.CB_LockMax.TabIndex = 25
        Me.CB_LockMax.Text = "Lock max to 600"
        Me.CB_LockMax.UseVisualStyleBackColor = True
        '
        'NUD_ProxyPort
        '
        Me.NUD_ProxyPort.Location = New System.Drawing.Point(116, 65)
        Me.NUD_ProxyPort.Maximum = New Decimal(New Integer() {86400000, 0, 0, 0})
        Me.NUD_ProxyPort.Name = "NUD_ProxyPort"
        Me.NUD_ProxyPort.Size = New System.Drawing.Size(58, 22)
        Me.NUD_ProxyPort.TabIndex = 3
        Me.NUD_ProxyPort.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 258)
        Me.Controls.Add(Me.CB_LockMax)
        Me.Controls.Add(Me.TLP)
        Me.Controls.Add(Me.GB_Results)
        Me.Controls.Add(Me.GB_From)
        Me.Controls.Add(Me.GB_To)
        Me.Controls.Add(Me.GB_Proxy)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.NUD_Delay)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = Global.QuickPing.My.Resources.Resources.Internet_Access
        Me.Name = "Form1"
        Me.Text = "Quick Ping"
        CType(Me.NUD_Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Proxy.ResumeLayout(False)
        Me.GB_Proxy.PerformLayout()
        Me.GB_From.ResumeLayout(False)
        Me.GB_To.ResumeLayout(False)
        Me.GB_Results.ResumeLayout(False)
        Me.GB_Results.PerformLayout()
        Me.CMS.ResumeLayout(False)
        CType(Me.NUD_ProxyPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Avg As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Fail As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ReAddr As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents NUD_Delay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CB_S As System.Windows.Forms.ComboBox
    Friend WithEvents CB_T As System.Windows.Forms.ComboBox
    Friend WithEvents GB_Proxy As System.Windows.Forms.GroupBox
    Friend WithEvents GB_From As System.Windows.Forms.GroupBox
    Friend WithEvents GB_To As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Results As System.Windows.Forms.GroupBox
    Friend WithEvents TB_ProxyAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbB_Proxy As System.Windows.Forms.ComboBox
    Friend WithEvents TLP As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CB_LockMax As System.Windows.Forms.CheckBox
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MI_Clear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUD_ProxyPort As NumericUpDown
End Class
