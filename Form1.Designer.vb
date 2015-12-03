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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
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
        CType(Me.NUD_Delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(14, 54)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(132, 186)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From:"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(190, 54)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(132, 186)
        Me.ListBox2.Sorted = True
        Me.ListBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "-->"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(346, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 87)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Start / Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(519, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Results:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(523, 31)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(78, 209)
        Me.TextBox1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Average:"
        '
        'Lbl_Avg
        '
        Me.Lbl_Avg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Avg.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Avg.Location = New System.Drawing.Point(625, 43)
        Me.Lbl_Avg.Name = "Lbl_Avg"
        Me.Lbl_Avg.Size = New System.Drawing.Size(114, 28)
        Me.Lbl_Avg.TabIndex = 9
        Me.Lbl_Avg.Text = "000 ms"
        Me.Lbl_Avg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(622, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fail:"
        '
        'Lbl_Fail
        '
        Me.Lbl_Fail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Fail.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fail.Location = New System.Drawing.Point(625, 98)
        Me.Lbl_Fail.Name = "Lbl_Fail"
        Me.Lbl_Fail.Size = New System.Drawing.Size(114, 28)
        Me.Lbl_Fail.TabIndex = 13
        Me.Lbl_Fail.Text = "0 %"
        Me.Lbl_Fail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(622, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 14)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Reply Address:"
        '
        'Lbl_ReAddr
        '
        Me.Lbl_ReAddr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ReAddr.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ReAddr.Location = New System.Drawing.Point(635, 210)
        Me.Lbl_ReAddr.Name = "Lbl_ReAddr"
        Me.Lbl_ReAddr.Size = New System.Drawing.Size(104, 18)
        Me.Lbl_ReAddr.TabIndex = 15
        Me.Lbl_ReAddr.Text = "0.0.0.0"
        Me.Lbl_ReAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(622, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 14)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Total sent:"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Total.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(630, 153)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(109, 28)
        Me.Lbl_Total.TabIndex = 17
        Me.Lbl_Total.Text = "0"
        Me.Lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NUD_Delay
        '
        Me.NUD_Delay.Increment = New Decimal(New Integer() {250, 0, 0, 0})
        Me.NUD_Delay.Location = New System.Drawing.Point(426, 75)
        Me.NUD_Delay.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me.NUD_Delay.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NUD_Delay.Name = "NUD_Delay"
        Me.NUD_Delay.Size = New System.Drawing.Size(73, 22)
        Me.NUD_Delay.TabIndex = 18
        Me.NUD_Delay.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(343, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 14)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Delay (ms)"
        '
        'CB_S
        '
        Me.CB_S.FormattingEnabled = True
        Me.CB_S.Location = New System.Drawing.Point(14, 26)
        Me.CB_S.Name = "CB_S"
        Me.CB_S.Size = New System.Drawing.Size(132, 22)
        Me.CB_S.TabIndex = 20
        Me.CB_S.Text = "localhost"
        '
        'CB_T
        '
        Me.CB_T.FormattingEnabled = True
        Me.CB_T.Location = New System.Drawing.Point(190, 26)
        Me.CB_T.Name = "CB_T"
        Me.CB_T.Size = New System.Drawing.Size(132, 22)
        Me.CB_T.TabIndex = 21
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 252)
        Me.Controls.Add(Me.CB_T)
        Me.Controls.Add(Me.CB_S)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.NUD_Delay)
        Me.Controls.Add(Me.Lbl_Total)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Lbl_ReAddr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Lbl_Fail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Lbl_Avg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = Global.QuickPing.My.Resources.Resources.Internet_Access
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Quick Ping"
        CType(Me.NUD_Delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
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

End Class
