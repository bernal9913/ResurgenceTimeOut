<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudScheduleMean = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudItems = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbLeft = New System.Windows.Forms.ComboBox()
        Me.cmbMiddle = New System.Windows.Forms.ComboBox()
        Me.cmbRight = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudPhase1Duration = New System.Windows.Forms.NumericUpDown()
        Me.nudPhase2Duration = New System.Windows.Forms.NumericUpDown()
        Me.nudPhase3Duration = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudTimeOutDuration = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nudComponentDuration = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbFirstComponent = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtParticipantID = New System.Windows.Forms.TextBox()
        Me.txtExperimenterID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbSessionNumber = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnChangeParameters = New System.Windows.Forms.Button()
        CType(Me.nudScheduleMean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase1Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase2Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPhase3Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeOutDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudComponentDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(268, 267)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(283, 29)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Iniciar"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor(es) IV:"
        '
        'nudScheduleMean
        '
        Me.nudScheduleMean.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudScheduleMean.Location = New System.Drawing.Point(281, 25)
        Me.nudScheduleMean.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudScheduleMean.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudScheduleMean.Name = "nudScheduleMean"
        Me.nudScheduleMean.Size = New System.Drawing.Size(100, 26)
        Me.nudScheduleMean.TabIndex = 2
        Me.nudScheduleMean.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "# Valores IV:"
        '
        'nudItems
        '
        Me.nudItems.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudItems.Location = New System.Drawing.Point(281, 51)
        Me.nudItems.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me.nudItems.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudItems.Name = "nudItems"
        Me.nudItems.Size = New System.Drawing.Size(100, 26)
        Me.nudItems.TabIndex = 4
        Me.nudItems.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Palanca izquierda:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Palanca centro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Palanca derecha:"
        '
        'cmbLeft
        '
        Me.cmbLeft.FormattingEnabled = True
        Me.cmbLeft.Items.AddRange(New Object() {"Target", "Alternative", "Control"})
        Me.cmbLeft.Location = New System.Drawing.Point(214, 19)
        Me.cmbLeft.Name = "cmbLeft"
        Me.cmbLeft.Size = New System.Drawing.Size(173, 28)
        Me.cmbLeft.TabIndex = 8
        '
        'cmbMiddle
        '
        Me.cmbMiddle.FormattingEnabled = True
        Me.cmbMiddle.Items.AddRange(New Object() {"Target", "Alternative", "Control"})
        Me.cmbMiddle.Location = New System.Drawing.Point(214, 45)
        Me.cmbMiddle.Name = "cmbMiddle"
        Me.cmbMiddle.Size = New System.Drawing.Size(173, 28)
        Me.cmbMiddle.TabIndex = 9
        '
        'cmbRight
        '
        Me.cmbRight.FormattingEnabled = True
        Me.cmbRight.Items.AddRange(New Object() {"Target", "Alternative", "Control"})
        Me.cmbRight.Location = New System.Drawing.Point(214, 72)
        Me.cmbRight.Name = "cmbRight"
        Me.cmbRight.Size = New System.Drawing.Size(173, 28)
        Me.cmbRight.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Duración fase 1 (min):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Duración fase 2 (min):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Duración fase 3 (min):"
        '
        'nudPhase1Duration
        '
        Me.nudPhase1Duration.DecimalPlaces = 1
        Me.nudPhase1Duration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase1Duration.Location = New System.Drawing.Point(281, 19)
        Me.nudPhase1Duration.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudPhase1Duration.Name = "nudPhase1Duration"
        Me.nudPhase1Duration.Size = New System.Drawing.Size(100, 26)
        Me.nudPhase1Duration.TabIndex = 14
        Me.nudPhase1Duration.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'nudPhase2Duration
        '
        Me.nudPhase2Duration.DecimalPlaces = 1
        Me.nudPhase2Duration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase2Duration.Location = New System.Drawing.Point(281, 46)
        Me.nudPhase2Duration.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudPhase2Duration.Name = "nudPhase2Duration"
        Me.nudPhase2Duration.Size = New System.Drawing.Size(100, 26)
        Me.nudPhase2Duration.TabIndex = 15
        Me.nudPhase2Duration.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'nudPhase3Duration
        '
        Me.nudPhase3Duration.DecimalPlaces = 1
        Me.nudPhase3Duration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPhase3Duration.Location = New System.Drawing.Point(281, 72)
        Me.nudPhase3Duration.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudPhase3Duration.Name = "nudPhase3Duration"
        Me.nudPhase3Duration.Size = New System.Drawing.Size(100, 26)
        Me.nudPhase3Duration.TabIndex = 16
        Me.nudPhase3Duration.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(243, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Min. Tiempo de Espera (seg):"
        '
        'nudTimeOutDuration
        '
        Me.nudTimeOutDuration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudTimeOutDuration.Location = New System.Drawing.Point(281, 77)
        Me.nudTimeOutDuration.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nudTimeOutDuration.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTimeOutDuration.Name = "nudTimeOutDuration"
        Me.nudTimeOutDuration.Size = New System.Drawing.Size(100, 26)
        Me.nudTimeOutDuration.TabIndex = 22
        Me.nudTimeOutDuration.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Duración del componente (min):"
        '
        'nudComponentDuration
        '
        Me.nudComponentDuration.DecimalPlaces = 1
        Me.nudComponentDuration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudComponentDuration.Location = New System.Drawing.Point(281, 101)
        Me.nudComponentDuration.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudComponentDuration.Name = "nudComponentDuration"
        Me.nudComponentDuration.Size = New System.Drawing.Size(100, 26)
        Me.nudComponentDuration.TabIndex = 24
        Me.nudComponentDuration.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Primer componente:"
        '
        'cmbFirstComponent
        '
        Me.cmbFirstComponent.FormattingEnabled = True
        Me.cmbFirstComponent.Items.AddRange(New Object() {"Timeout", "No Timeout"})
        Me.cmbFirstComponent.Location = New System.Drawing.Point(214, 93)
        Me.cmbFirstComponent.Name = "cmbFirstComponent"
        Me.cmbFirstComponent.Size = New System.Drawing.Size(173, 28)
        Me.cmbFirstComponent.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 20)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "ID del Participante: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Iniciales de experi:"
        '
        'txtParticipantID
        '
        Me.txtParticipantID.Location = New System.Drawing.Point(214, 14)
        Me.txtParticipantID.Name = "txtParticipantID"
        Me.txtParticipantID.Size = New System.Drawing.Size(173, 26)
        Me.txtParticipantID.TabIndex = 29
        '
        'txtExperimenterID
        '
        Me.txtExperimenterID.Location = New System.Drawing.Point(214, 41)
        Me.txtExperimenterID.Name = "txtExperimenterID"
        Me.txtExperimenterID.Size = New System.Drawing.Size(173, 26)
        Me.txtExperimenterID.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 20)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Número de sesión:"
        '
        'cmbSessionNumber
        '
        Me.cmbSessionNumber.FormattingEnabled = True
        Me.cmbSessionNumber.Items.AddRange(New Object() {"1", "2"})
        Me.cmbSessionNumber.Location = New System.Drawing.Point(214, 66)
        Me.cmbSessionNumber.Name = "cmbSessionNumber"
        Me.cmbSessionNumber.Size = New System.Drawing.Size(173, 28)
        Me.cmbSessionNumber.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbSessionNumber)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbFirstComponent)
        Me.GroupBox1.Controls.Add(Me.txtExperimenterID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtParticipantID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(392, 137)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de la sesión "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 20)
        Me.Label15.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.nudComponentDuration)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.nudPhase1Duration)
        Me.GroupBox2.Controls.Add(Me.nudPhase2Duration)
        Me.GroupBox2.Controls.Add(Me.nudPhase3Duration)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(407, 8)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(386, 137)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Duración"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbLeft)
        Me.GroupBox3.Controls.Add(Me.cmbMiddle)
        Me.GroupBox3.Controls.Add(Me.cmbRight)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 156)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(392, 106)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lever Assignment"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 20)
        Me.Label16.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 20)
        Me.Label18.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 20)
        Me.Label17.TabIndex = 27
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Silver
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.nudScheduleMean)
        Me.GroupBox4.Controls.Add(Me.nudTimeOutDuration)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.nudItems)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(407, 156)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(386, 106)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Programa de Refuerzo"
        '
        'btnChangeParameters
        '
        Me.btnChangeParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeParameters.Location = New System.Drawing.Point(268, 302)
        Me.btnChangeParameters.Name = "btnChangeParameters"
        Me.btnChangeParameters.Size = New System.Drawing.Size(283, 29)
        Me.btnChangeParameters.TabIndex = 36
        Me.btnChangeParameters.Text = "Cambiar ajustes de la sesión"
        Me.btnChangeParameters.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(804, 354)
        Me.Controls.Add(Me.btnChangeParameters)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resurgence & Timeout v. 1.3 2/16/2020; Traducción en proceso"
        CType(Me.nudScheduleMean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase1Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase2Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPhase3Duration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeOutDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudComponentDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nudScheduleMean As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents nudItems As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbLeft As ComboBox
    Friend WithEvents cmbMiddle As ComboBox
    Friend WithEvents cmbRight As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nudPhase1Duration As NumericUpDown
    Friend WithEvents nudPhase2Duration As NumericUpDown
    Friend WithEvents nudPhase3Duration As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents nudTimeOutDuration As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents nudComponentDuration As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbFirstComponent As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtParticipantID As TextBox
    Friend WithEvents txtExperimenterID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbSessionNumber As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnChangeParameters As Button
End Class
