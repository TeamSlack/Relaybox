<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ArdPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ManCtrl = New System.Windows.Forms.GroupBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.CheckBox25 = New System.Windows.Forms.CheckBox()
        Me.CheckBox26 = New System.Windows.Forms.CheckBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.CheckBox27 = New System.Windows.Forms.CheckBox()
        Me.CheckBox28 = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.CheckBox29 = New System.Windows.Forms.CheckBox()
        Me.CheckBox30 = New System.Windows.Forms.CheckBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.HCH6 = New System.Windows.Forms.CheckBox()
        Me.LCH6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.HCH3 = New System.Windows.Forms.CheckBox()
        Me.LCH3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.HCH2 = New System.Windows.Forms.CheckBox()
        Me.LCH2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.HCH5 = New System.Windows.Forms.CheckBox()
        Me.LCH5 = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.HCH1 = New System.Windows.Forms.CheckBox()
        Me.LCH1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.HCH4 = New System.Windows.Forms.CheckBox()
        Me.LCH4 = New System.Windows.Forms.CheckBox()
        Me.SerialPortsBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.SerialDatBox = New System.Windows.Forms.RichTextBox()
        Me.ArdTest = New System.Windows.Forms.Button()
        Me.ArdCon = New System.Windows.Forms.Button()
        Me.SysTicks = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SysStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ManCtrl.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArdPort
        '
        Me.ArdPort.PortName = "COM34"
        Me.ArdPort.ReadTimeout = 500
        '
        'ManCtrl
        '
        Me.ManCtrl.CausesValidation = False
        Me.ManCtrl.Controls.Add(Me.GroupBox14)
        Me.ManCtrl.Controls.Add(Me.GroupBox11)
        Me.ManCtrl.Controls.Add(Me.GroupBox15)
        Me.ManCtrl.Controls.Add(Me.GroupBox4)
        Me.ManCtrl.Controls.Add(Me.GroupBox16)
        Me.ManCtrl.Controls.Add(Me.GroupBox12)
        Me.ManCtrl.Controls.Add(Me.GroupBox13)
        Me.ManCtrl.Controls.Add(Me.GroupBox3)
        Me.ManCtrl.Controls.Add(Me.GroupBox2)
        Me.ManCtrl.Controls.Add(Me.GroupBox8)
        Me.ManCtrl.Controls.Add(Me.GroupBox5)
        Me.ManCtrl.Controls.Add(Me.GroupBox6)
        Me.ManCtrl.Controls.Add(Me.GroupBox9)
        Me.ManCtrl.Controls.Add(Me.GroupBox7)
        Me.ManCtrl.Controls.Add(Me.GroupBox10)
        Me.ManCtrl.Enabled = False
        Me.ManCtrl.Location = New System.Drawing.Point(324, 6)
        Me.ManCtrl.Name = "ManCtrl"
        Me.ManCtrl.Size = New System.Drawing.Size(198, 308)
        Me.ManCtrl.TabIndex = 0
        Me.ManCtrl.TabStop = False
        Me.ManCtrl.Text = "Manual Control"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.CheckBox25)
        Me.GroupBox14.Controls.Add(Me.CheckBox26)
        Me.GroupBox14.Location = New System.Drawing.Point(136, 253)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox14.TabIndex = 15
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "CH15"
        '
        'CheckBox25
        '
        Me.CheckBox25.AutoSize = True
        Me.CheckBox25.Enabled = False
        Me.CheckBox25.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox25.TabIndex = 3
        Me.CheckBox25.Text = "HS"
        Me.CheckBox25.UseVisualStyleBackColor = True
        '
        'CheckBox26
        '
        Me.CheckBox26.AutoSize = True
        Me.CheckBox26.Enabled = False
        Me.CheckBox26.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox26.TabIndex = 2
        Me.CheckBox26.Text = "LS"
        Me.CheckBox26.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CheckBox19)
        Me.GroupBox11.Controls.Add(Me.CheckBox20)
        Me.GroupBox11.Location = New System.Drawing.Point(136, 195)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox11.TabIndex = 15
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "CH12"
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Enabled = False
        Me.CheckBox19.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox19.TabIndex = 3
        Me.CheckBox19.Text = "HS"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Enabled = False
        Me.CheckBox20.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox20.TabIndex = 2
        Me.CheckBox20.Text = "LS"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.CheckBox27)
        Me.GroupBox15.Controls.Add(Me.CheckBox28)
        Me.GroupBox15.Location = New System.Drawing.Point(68, 253)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(59, 52)
        Me.GroupBox15.TabIndex = 16
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "CH14"
        '
        'CheckBox27
        '
        Me.CheckBox27.AutoSize = True
        Me.CheckBox27.Enabled = False
        Me.CheckBox27.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox27.TabIndex = 3
        Me.CheckBox27.Text = "HS"
        Me.CheckBox27.UseVisualStyleBackColor = True
        '
        'CheckBox28
        '
        Me.CheckBox28.AutoSize = True
        Me.CheckBox28.Enabled = False
        Me.CheckBox28.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox28.TabIndex = 2
        Me.CheckBox28.Text = "LS"
        Me.CheckBox28.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox5)
        Me.GroupBox4.Controls.Add(Me.CheckBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(136, 137)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CH9"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox5.TabIndex = 3
        Me.CheckBox5.Text = "HS"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Enabled = False
        Me.CheckBox6.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox6.TabIndex = 2
        Me.CheckBox6.Text = "LS"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.CheckBox29)
        Me.GroupBox16.Controls.Add(Me.CheckBox30)
        Me.GroupBox16.Location = New System.Drawing.Point(6, 253)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox16.TabIndex = 17
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "CH13"
        '
        'CheckBox29
        '
        Me.CheckBox29.AutoSize = True
        Me.CheckBox29.Enabled = False
        Me.CheckBox29.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox29.TabIndex = 3
        Me.CheckBox29.Text = "HS"
        Me.CheckBox29.UseVisualStyleBackColor = True
        '
        'CheckBox30
        '
        Me.CheckBox30.AutoSize = True
        Me.CheckBox30.Enabled = False
        Me.CheckBox30.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox30.TabIndex = 2
        Me.CheckBox30.Text = "LS"
        Me.CheckBox30.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.CheckBox21)
        Me.GroupBox12.Controls.Add(Me.CheckBox22)
        Me.GroupBox12.Location = New System.Drawing.Point(68, 195)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(59, 52)
        Me.GroupBox12.TabIndex = 16
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "CH11"
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Enabled = False
        Me.CheckBox21.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox21.TabIndex = 3
        Me.CheckBox21.Text = "HS"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Enabled = False
        Me.CheckBox22.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox22.TabIndex = 2
        Me.CheckBox22.Text = "LS"
        Me.CheckBox22.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.CheckBox23)
        Me.GroupBox13.Controls.Add(Me.CheckBox24)
        Me.GroupBox13.Location = New System.Drawing.Point(6, 195)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox13.TabIndex = 17
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "CH10"
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Enabled = False
        Me.CheckBox23.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox23.TabIndex = 3
        Me.CheckBox23.Text = "HS"
        Me.CheckBox23.UseVisualStyleBackColor = True
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Enabled = False
        Me.CheckBox24.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox24.TabIndex = 2
        Me.CheckBox24.Text = "LS"
        Me.CheckBox24.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(68, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(59, 52)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CH8"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "HS"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox4.TabIndex = 2
        Me.CheckBox4.Text = "LS"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CH7"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "HS"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "LS"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.HCH6)
        Me.GroupBox8.Controls.Add(Me.LCH6)
        Me.GroupBox8.Location = New System.Drawing.Point(136, 79)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox8.TabIndex = 13
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "CH6"
        '
        'HCH6
        '
        Me.HCH6.AutoSize = True
        Me.HCH6.Enabled = False
        Me.HCH6.Location = New System.Drawing.Point(6, 29)
        Me.HCH6.Name = "HCH6"
        Me.HCH6.Size = New System.Drawing.Size(41, 17)
        Me.HCH6.TabIndex = 3
        Me.HCH6.Text = "HS"
        Me.HCH6.UseVisualStyleBackColor = True
        '
        'LCH6
        '
        Me.LCH6.AutoSize = True
        Me.LCH6.Enabled = False
        Me.LCH6.Location = New System.Drawing.Point(6, 13)
        Me.LCH6.Name = "LCH6"
        Me.LCH6.Size = New System.Drawing.Size(39, 17)
        Me.LCH6.TabIndex = 2
        Me.LCH6.Text = "LS"
        Me.LCH6.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.HCH3)
        Me.GroupBox5.Controls.Add(Me.LCH3)
        Me.GroupBox5.Location = New System.Drawing.Point(136, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CH3"
        '
        'HCH3
        '
        Me.HCH3.AutoSize = True
        Me.HCH3.Location = New System.Drawing.Point(6, 29)
        Me.HCH3.Name = "HCH3"
        Me.HCH3.Size = New System.Drawing.Size(41, 17)
        Me.HCH3.TabIndex = 3
        Me.HCH3.Text = "HS"
        Me.HCH3.UseVisualStyleBackColor = True
        '
        'LCH3
        '
        Me.LCH3.AutoSize = True
        Me.LCH3.Location = New System.Drawing.Point(6, 13)
        Me.LCH3.Name = "LCH3"
        Me.LCH3.Size = New System.Drawing.Size(39, 17)
        Me.LCH3.TabIndex = 2
        Me.LCH3.Text = "LS"
        Me.LCH3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.HCH2)
        Me.GroupBox6.Controls.Add(Me.LCH2)
        Me.GroupBox6.Location = New System.Drawing.Point(68, 21)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(59, 52)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "CH2"
        '
        'HCH2
        '
        Me.HCH2.AutoSize = True
        Me.HCH2.Location = New System.Drawing.Point(6, 29)
        Me.HCH2.Name = "HCH2"
        Me.HCH2.Size = New System.Drawing.Size(41, 17)
        Me.HCH2.TabIndex = 3
        Me.HCH2.Text = "HS"
        Me.HCH2.UseVisualStyleBackColor = True
        '
        'LCH2
        '
        Me.LCH2.AutoSize = True
        Me.LCH2.Location = New System.Drawing.Point(6, 13)
        Me.LCH2.Name = "LCH2"
        Me.LCH2.Size = New System.Drawing.Size(39, 17)
        Me.LCH2.TabIndex = 2
        Me.LCH2.Text = "LS"
        Me.LCH2.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.HCH5)
        Me.GroupBox9.Controls.Add(Me.LCH5)
        Me.GroupBox9.Location = New System.Drawing.Point(68, 79)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(59, 52)
        Me.GroupBox9.TabIndex = 12
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "CH5"
        '
        'HCH5
        '
        Me.HCH5.AutoSize = True
        Me.HCH5.Location = New System.Drawing.Point(6, 29)
        Me.HCH5.Name = "HCH5"
        Me.HCH5.Size = New System.Drawing.Size(41, 17)
        Me.HCH5.TabIndex = 3
        Me.HCH5.Text = "HS"
        Me.HCH5.UseVisualStyleBackColor = True
        '
        'LCH5
        '
        Me.LCH5.AutoSize = True
        Me.LCH5.Location = New System.Drawing.Point(6, 13)
        Me.LCH5.Name = "LCH5"
        Me.LCH5.Size = New System.Drawing.Size(39, 17)
        Me.LCH5.TabIndex = 2
        Me.LCH5.Text = "LS"
        Me.LCH5.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.HCH1)
        Me.GroupBox7.Controls.Add(Me.LCH1)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "CH1"
        '
        'HCH1
        '
        Me.HCH1.AutoSize = True
        Me.HCH1.Location = New System.Drawing.Point(6, 29)
        Me.HCH1.Name = "HCH1"
        Me.HCH1.Size = New System.Drawing.Size(41, 17)
        Me.HCH1.TabIndex = 1
        Me.HCH1.Text = "HS"
        Me.HCH1.UseVisualStyleBackColor = True
        '
        'LCH1
        '
        Me.LCH1.AutoSize = True
        Me.LCH1.Location = New System.Drawing.Point(6, 13)
        Me.LCH1.Name = "LCH1"
        Me.LCH1.Size = New System.Drawing.Size(39, 17)
        Me.LCH1.TabIndex = 0
        Me.LCH1.Text = "LS"
        Me.LCH1.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.HCH4)
        Me.GroupBox10.Controls.Add(Me.LCH4)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 79)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(56, 52)
        Me.GroupBox10.TabIndex = 11
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "CH4"
        '
        'HCH4
        '
        Me.HCH4.AutoSize = True
        Me.HCH4.Location = New System.Drawing.Point(6, 29)
        Me.HCH4.Name = "HCH4"
        Me.HCH4.Size = New System.Drawing.Size(41, 17)
        Me.HCH4.TabIndex = 1
        Me.HCH4.Text = "HS"
        Me.HCH4.UseVisualStyleBackColor = True
        '
        'LCH4
        '
        Me.LCH4.AutoSize = True
        Me.LCH4.Location = New System.Drawing.Point(6, 13)
        Me.LCH4.Name = "LCH4"
        Me.LCH4.Size = New System.Drawing.Size(39, 17)
        Me.LCH4.TabIndex = 0
        Me.LCH4.Text = "LS"
        Me.LCH4.UseVisualStyleBackColor = True
        '
        'SerialPortsBox
        '
        Me.SerialPortsBox.FormattingEnabled = True
        Me.SerialPortsBox.Location = New System.Drawing.Point(72, 20)
        Me.SerialPortsBox.Name = "SerialPortsBox"
        Me.SerialPortsBox.Size = New System.Drawing.Size(80, 21)
        Me.SerialPortsBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COM Ports:"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.ArdTest)
        Me.GroupBox17.Controls.Add(Me.ArdCon)
        Me.GroupBox17.Controls.Add(Me.Label1)
        Me.GroupBox17.Controls.Add(Me.SerialPortsBox)
        Me.GroupBox17.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(320, 51)
        Me.GroupBox17.TabIndex = 3
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Setup"
        '
        'SerialDatBox
        '
        Me.SerialDatBox.Location = New System.Drawing.Point(6, 15)
        Me.SerialDatBox.Name = "SerialDatBox"
        Me.SerialDatBox.Size = New System.Drawing.Size(309, 234)
        Me.SerialDatBox.TabIndex = 5
        Me.SerialDatBox.Text = ""
        '
        'ArdTest
        '
        Me.ArdTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArdTest.Location = New System.Drawing.Point(237, 13)
        Me.ArdTest.Name = "ArdTest"
        Me.ArdTest.Size = New System.Drawing.Size(73, 33)
        Me.ArdTest.TabIndex = 4
        Me.ArdTest.Text = "Test Connection"
        Me.ArdTest.UseVisualStyleBackColor = True
        '
        'ArdCon
        '
        Me.ArdCon.Location = New System.Drawing.Point(158, 13)
        Me.ArdCon.Name = "ArdCon"
        Me.ArdCon.Size = New System.Drawing.Size(73, 33)
        Me.ArdCon.TabIndex = 3
        Me.ArdCon.Text = "Connect!"
        Me.ArdCon.UseVisualStyleBackColor = True
        '
        'SysTicks
        '
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.SerialDatBox)
        Me.GroupBox18.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(321, 255)
        Me.GroupBox18.TabIndex = 6
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Serial Log:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SysStat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 314)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(684, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SysStat
        '
        Me.SysStat.Name = "SysStat"
        Me.SysStat.Size = New System.Drawing.Size(120, 17)
        Me.SysStat.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 336)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox18)
        Me.Controls.Add(Me.GroupBox17)
        Me.Controls.Add(Me.ManCtrl)
        Me.Name = "Form1"
        Me.Text = "Relay Control Sys"
        Me.ManCtrl.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArdPort As IO.Ports.SerialPort
    Friend WithEvents ManCtrl As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents CheckBox25 As CheckBox
    Friend WithEvents CheckBox26 As CheckBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents CheckBox27 As CheckBox
    Friend WithEvents CheckBox28 As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents CheckBox29 As CheckBox
    Friend WithEvents CheckBox30 As CheckBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox22 As CheckBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents CheckBox23 As CheckBox
    Friend WithEvents CheckBox24 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents HCH6 As CheckBox
    Friend WithEvents LCH6 As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents HCH3 As CheckBox
    Friend WithEvents LCH3 As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents HCH2 As CheckBox
    Friend WithEvents LCH2 As CheckBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents HCH5 As CheckBox
    Friend WithEvents LCH5 As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents HCH1 As CheckBox
    Friend WithEvents LCH1 As CheckBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents HCH4 As CheckBox
    Friend WithEvents LCH4 As CheckBox
    Friend WithEvents SerialPortsBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents ArdTest As Button
    Friend WithEvents ArdCon As Button
    Friend WithEvents SysTicks As Timer
    Friend WithEvents SerialDatBox As RichTextBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SysStat As ToolStripStatusLabel
End Class
