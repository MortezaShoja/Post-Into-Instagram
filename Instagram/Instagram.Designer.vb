<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instagram
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.btnSaveLocations = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NuDelay = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblMouseY = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMouseX = New System.Windows.Forms.Label()
        Me.TimerPointing = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDelay = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NuAddPhotoX = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NuAddPhotoY = New System.Windows.Forms.NumericUpDown()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NuNextShareX = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NuNextShareY = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NuCaptionX = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NuCaptionY = New System.Windows.Forms.NumericUpDown()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.GroupBox12.SuspendLayout()
        CType(Me.NuDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NuAddPhotoX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuAddPhotoY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.NuNextShareX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuNextShareY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.NuCaptionX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuCaptionY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.cboGender)
        Me.GroupBox12.Controls.Add(Me.btnSaveLocations)
        Me.GroupBox12.Controls.Add(Me.Label31)
        Me.GroupBox12.Controls.Add(Me.Label10)
        Me.GroupBox12.Controls.Add(Me.NuDelay)
        Me.GroupBox12.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(233, 106)
        Me.GroupBox12.TabIndex = 29
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Sleep after sending"
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Women", "Men", "Kids"})
        Me.cboGender.Location = New System.Drawing.Point(7, 23)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(218, 21)
        Me.cboGender.TabIndex = 31
        Me.cboGender.Text = "Women"
        '
        'btnSaveLocations
        '
        Me.btnSaveLocations.Location = New System.Drawing.Point(167, 66)
        Me.btnSaveLocations.Name = "btnSaveLocations"
        Me.btnSaveLocations.Size = New System.Drawing.Size(57, 28)
        Me.btnSaveLocations.TabIndex = 24
        Me.btnSaveLocations.Text = "Save"
        Me.btnSaveLocations.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(19, 68)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 13)
        Me.Label31.TabIndex = 29
        Me.Label31.Text = "Delay :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(117, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Minutes"
        '
        'NuDelay
        '
        Me.NuDelay.Location = New System.Drawing.Point(65, 66)
        Me.NuDelay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NuDelay.Name = "NuDelay"
        Me.NuDelay.Size = New System.Drawing.Size(47, 20)
        Me.NuDelay.TabIndex = 3
        Me.NuDelay.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblMouseY)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblMouseX)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(233, 50)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mouse Location"
        '
        'lblMouseY
        '
        Me.lblMouseY.AutoSize = True
        Me.lblMouseY.Location = New System.Drawing.Point(204, 22)
        Me.lblMouseY.Name = "lblMouseY"
        Me.lblMouseY.Size = New System.Drawing.Size(19, 13)
        Me.lblMouseY.TabIndex = 5
        Me.lblMouseY.Text = "----"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(143, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Mouse Y :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Mouse X :"
        '
        'lblMouseX
        '
        Me.lblMouseX.AutoSize = True
        Me.lblMouseX.Location = New System.Drawing.Point(80, 22)
        Me.lblMouseX.Name = "lblMouseX"
        Me.lblMouseX.Size = New System.Drawing.Size(19, 13)
        Me.lblMouseX.TabIndex = 2
        Me.lblMouseX.Text = "----"
        '
        'TimerPointing
        '
        Me.TimerPointing.Enabled = True
        '
        'TimerDelay
        '
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtError)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.btnStart)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(227, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Send Post"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.NuAddPhotoY)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.NuAddPhotoX)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(214, 43)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Add Photo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(107, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Y :"
        '
        'NuAddPhotoX
        '
        Me.NuAddPhotoX.Location = New System.Drawing.Point(37, 16)
        Me.NuAddPhotoX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuAddPhotoX.Name = "NuAddPhotoX"
        Me.NuAddPhotoX.Size = New System.Drawing.Size(47, 20)
        Me.NuAddPhotoX.TabIndex = 17
        Me.NuAddPhotoX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "X :"
        '
        'NuAddPhotoY
        '
        Me.NuAddPhotoY.Location = New System.Drawing.Point(133, 14)
        Me.NuAddPhotoY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuAddPhotoY.Name = "NuAddPhotoY"
        Me.NuAddPhotoY.Size = New System.Drawing.Size(47, 20)
        Me.NuAddPhotoY.TabIndex = 18
        Me.NuAddPhotoY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(7, 338)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(215, 35)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.NuNextShareY)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.NuNextShareX)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 55)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(214, 43)
        Me.GroupBox6.TabIndex = 26
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Next  Share Ok"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(107, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Y :"
        '
        'NuNextShareX
        '
        Me.NuNextShareX.Location = New System.Drawing.Point(37, 16)
        Me.NuNextShareX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuNextShareX.Name = "NuNextShareX"
        Me.NuNextShareX.Size = New System.Drawing.Size(47, 20)
        Me.NuNextShareX.TabIndex = 17
        Me.NuNextShareX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "X :"
        '
        'NuNextShareY
        '
        Me.NuNextShareY.Location = New System.Drawing.Point(133, 14)
        Me.NuNextShareY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuNextShareY.Name = "NuNextShareY"
        Me.NuNextShareY.Size = New System.Drawing.Size(47, 20)
        Me.NuNextShareY.TabIndex = 18
        Me.NuNextShareY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.NuCaptionY)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.NuCaptionX)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Location = New System.Drawing.Point(7, 105)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(214, 43)
        Me.GroupBox8.TabIndex = 27
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "CaptionBox"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(107, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Y :"
        '
        'NuCaptionX
        '
        Me.NuCaptionX.Location = New System.Drawing.Point(37, 16)
        Me.NuCaptionX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuCaptionX.Name = "NuCaptionX"
        Me.NuCaptionX.Size = New System.Drawing.Size(47, 20)
        Me.NuCaptionX.TabIndex = 17
        Me.NuCaptionX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "X :"
        '
        'NuCaptionY
        '
        Me.NuCaptionY.Location = New System.Drawing.Point(133, 14)
        Me.NuCaptionY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuCaptionY.Name = "NuCaptionY"
        Me.NuCaptionY.Size = New System.Drawing.Size(47, 20)
        Me.NuCaptionY.TabIndex = 18
        Me.NuCaptionY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(7, 153)
        Me.txtError.Margin = New System.Windows.Forms.Padding(2)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtError.Size = New System.Drawing.Size(213, 180)
        Me.txtError.TabIndex = 28
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(10, 181)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(235, 405)
        Me.TabControl1.TabIndex = 30
        '
        'Instagram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(253, 598)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox3)
        Me.MinimizeBox = False
        Me.Name = "Instagram"
        Me.Text = "Instagram"
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.NuDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NuAddPhotoX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuAddPhotoY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.NuNextShareX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuNextShareY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.NuCaptionX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuCaptionY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveLocations As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NuDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMouseY As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblMouseX As System.Windows.Forms.Label
    Friend WithEvents TimerPointing As System.Windows.Forms.Timer
    Friend WithEvents TimerDelay As System.Windows.Forms.Timer
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents NuCaptionY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents NuCaptionX As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents NuNextShareY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NuNextShareX As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents NuAddPhotoY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NuAddPhotoX As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
