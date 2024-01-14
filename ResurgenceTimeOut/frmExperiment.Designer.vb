<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExperiment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnMiddle = New System.Windows.Forms.Button()
        Me.btnStartExperiment = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.tmrClicked = New System.Windows.Forms.Timer(Me.components)
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPoints = New System.Windows.Forms.Button()
        Me.grpConsumatory = New System.Windows.Forms.GroupBox()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.tmrPhase = New System.Windows.Forms.Timer(Me.components)
        Me.tmrComponent = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTimeOut = New System.Windows.Forms.Timer(Me.components)
        Me.lblSessionEnd = New System.Windows.Forms.Label()
        Me.grpConsumatory.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMiddle
        '
        Me.btnMiddle.BackColor = System.Drawing.Color.Black
        Me.btnMiddle.CausesValidation = False
        Me.btnMiddle.ForeColor = System.Drawing.Color.Black
        Me.btnMiddle.Location = New System.Drawing.Point(392, 188)
        Me.btnMiddle.Name = "btnMiddle"
        Me.btnMiddle.Size = New System.Drawing.Size(204, 44)
        Me.btnMiddle.TabIndex = 0
        Me.btnMiddle.TabStop = False
        Me.btnMiddle.UseVisualStyleBackColor = False
        '
        'btnStartExperiment
        '
        Me.btnStartExperiment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartExperiment.Location = New System.Drawing.Point(448, 244)
        Me.btnStartExperiment.Name = "btnStartExperiment"
        Me.btnStartExperiment.Size = New System.Drawing.Size(90, 40)
        Me.btnStartExperiment.TabIndex = 1
        Me.btnStartExperiment.Text = "INICIAR"
        Me.btnStartExperiment.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Black
        Me.btnRight.CausesValidation = False
        Me.btnRight.ForeColor = System.Drawing.Color.Black
        Me.btnRight.Location = New System.Drawing.Point(676, 187)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(204, 44)
        Me.btnRight.TabIndex = 2
        Me.btnRight.TabStop = False
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Black
        Me.btnLeft.CausesValidation = False
        Me.btnLeft.ForeColor = System.Drawing.Color.Black
        Me.btnLeft.Location = New System.Drawing.Point(96, 188)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(204, 44)
        Me.btnLeft.TabIndex = 3
        Me.btnLeft.TabStop = False
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'tmrClicked
        '
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(416, 24)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(164, 39)
        Me.lblPoints.TabIndex = 4
        Me.lblPoints.Text = "Puntos: 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 44.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(96, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 67)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "+1"
        '
        'btnPoints
        '
        Me.btnPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoints.Location = New System.Drawing.Point(36, 120)
        Me.btnPoints.Name = "btnPoints"
        Me.btnPoints.Size = New System.Drawing.Size(224, 40)
        Me.btnPoints.TabIndex = 6
        Me.btnPoints.Text = "Tomar punto"
        Me.btnPoints.UseVisualStyleBackColor = True
        '
        'grpConsumatory
        '
        Me.grpConsumatory.Controls.Add(Me.btnPoints)
        Me.grpConsumatory.Controls.Add(Me.Label1)
        Me.grpConsumatory.Location = New System.Drawing.Point(20, 16)
        Me.grpConsumatory.Name = "grpConsumatory"
        Me.grpConsumatory.Size = New System.Drawing.Size(300, 176)
        Me.grpConsumatory.TabIndex = 7
        Me.grpConsumatory.TabStop = False
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.BackColor = System.Drawing.Color.Silver
        Me.lblTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.ForeColor = System.Drawing.Color.Black
        Me.lblTimeOut.Location = New System.Drawing.Point(320, 76)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(339, 75)
        Me.lblTimeOut.TabIndex = 8
        Me.lblTimeOut.Text = "TIME OUT"
        '
        'tmrPhase
        '
        '
        'tmrComponent
        '
        '
        'tmrTimeOut
        '
        '
        'lblSessionEnd
        '
        Me.lblSessionEnd.AllowDrop = True
        Me.lblSessionEnd.AutoSize = True
        Me.lblSessionEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSessionEnd.Location = New System.Drawing.Point(67, 359)
        Me.lblSessionEnd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSessionEnd.Name = "lblSessionEnd"
        Me.lblSessionEnd.Size = New System.Drawing.Size(1444, 39)
        Me.lblSessionEnd.TabIndex = 12
        Me.lblSessionEnd.Text = "Por favor toque la puerta para avisar al experimentar que esta parte del estudio " &
    "ha concluido."
        Me.lblSessionEnd.Visible = False
        '
        'frmExperiment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(957, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSessionEnd)
        Me.Controls.Add(Me.lblTimeOut)
        Me.Controls.Add(Me.grpConsumatory)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnStartExperiment)
        Me.Controls.Add(Me.btnMiddle)
        Me.Name = "frmExperiment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpConsumatory.ResumeLayout(False)
        Me.grpConsumatory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMiddle As Button
    Friend WithEvents btnStartExperiment As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents tmrClicked As Timer
    Friend WithEvents lblPoints As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPoints As Button
    Friend WithEvents grpConsumatory As GroupBox
    Friend WithEvents lblTimeOut As Label
    Friend WithEvents tmrPhase As Timer
    Friend WithEvents tmrComponent As Timer
    Friend WithEvents tmrTimeOut As Timer
    Friend WithEvents lblSessionEnd As Label
End Class
