﻿'Program created by Catherine Williams January 2020
' Program requires one file on the C drive entitled "C:\TimeOutPathList.txt". The first line of the file should contain the address to the folder where you want data to be saved. Make sure that file address ends with a \
' v. 1.1 Fixes issue with timing of interval to SR+ after timeout; also fixes the title of the file that the program looks for the warn about duplicate files; also makes data for all components get calculated (wasn't being calculate for last component)
' v. 1.3 Made sure VI 2 works; updated output file name; fixed 2 s timeout
' v. 1.4 Fixed issue with the program not being able to find the file that contains the path to the data folder, translated the program to Spanish and added design changes



Imports System.IO
Public Class frmMain
    Dim mc_strPathList As String = "C:\TimeOutPathList.txt" 'Cambiado de constante a variable por el bien de la trama' 
    Dim m_strDataFilePath As String
    Dim m_strrawDataFileName As String
    Dim m_boolWhatToDo As Boolean

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmBlack.Show()
        frmBlack.Enabled = False
        txtParticipantID.Focus()
        txtExperimenterID.Enabled = False
        cmbSessionNumber.Enabled = False
        cmbFirstComponent.Enabled = False
        ActiveGroupBoxes(False)
        btnChangeParameters.Enabled = False
        btnStart.Enabled = False
        cmbLeft.SelectedItem = "Target"
        cmbMiddle.SelectedItem = "Control"
        cmbRight.SelectedItem = "Alternative"
        Me.Location = New System.Drawing.Point(0, 0)
        '' vieja linea comentada 
        'MsgBox("'" & mc_strPathList & "' no encontrado. Sesión.", MsgBoxStyle.Critical, "Time Out")
        'mc_strPathList = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TimeOutPathList.txt")
        'If Not File.Exists(mc_strPathList) Then
        ' Si el archivo no existe, crearlo en la carpeta de documentos del usuario
        '    mc_strPathList = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TimeOutPathList.txt")
        '    File.WriteAllText(mc_strPathList, String.Empty)
        '    MsgBox("'" & mc_strPathList & "' no encontrado. Se creó en la carpeta de documentos del usuario.", MsgBoxStyle.Information, "Time Out")
        'End If
        MsgBox("La ruta por defecto de guardado es: 'Documentos/Resultados test'" & Environment.NewLine & "Si desea cambiarla, contacte a soporte", MsgBoxStyle.Information)

        ' Leer la ruta del archivo
        'Dim ReadDataPaths As New StreamReader(New FileStream(mc_strPathList, FileMode.Open, FileAccess.Read))
        'm_strDataFilePath = ReadDataPaths.ReadLine
        'ReadDataPaths.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If CheckDataFile() = True Then
            Me.Visible = False
            frmExperiment.Visible = True
            SetUpExperimentLayout()
        End If
    End Sub

    Private Sub SetUpExperimentLayout()
        ActivateButtons(False)
        frmExperiment.lblPoints.Location = New System.Drawing.Point(frmExperiment.Width / 2 - 75, 20)
        frmExperiment.btnStartExperiment.Location = New System.Drawing.Point(frmExperiment.Width / 2 - 45, frmExperiment.Height / 2 - 20)
        frmExperiment.btnMiddle.Location = New System.Drawing.Point(frmExperiment.Width / 2 - 102, frmExperiment.Height / 2 - 22)
        frmExperiment.btnRight.Location = New System.Drawing.Point(frmExperiment.Width / 2 + 237, frmExperiment.Height / 2 - 22)
        frmExperiment.btnLeft.Location = New System.Drawing.Point(frmExperiment.Width / 2 - 441, frmExperiment.Height / 2 - 22)
        frmExperiment.grpConsumatory.Location = New System.Drawing.Point(frmExperiment.Width / 2 - frmExperiment.grpConsumatory.Width / 2, frmExperiment.Height / 2 - frmExperiment.grpConsumatory.Height / 2)
        frmExperiment.lblTimeOut.Location = New System.Drawing.Point(frmExperiment.Width / 2 - frmExperiment.lblTimeOut.Width / 2, frmExperiment.lblPoints.Height + 20 + frmExperiment.lblTimeOut.Height / 2)
    End Sub

    Private Sub ActivateButtons(boolOnOff As Boolean)
        frmExperiment.btnMiddle.Visible = boolOnOff
        frmExperiment.btnRight.Visible = boolOnOff
        frmExperiment.btnLeft.Visible = boolOnOff
        frmExperiment.lblPoints.Visible = boolOnOff
        frmExperiment.grpConsumatory.Visible = boolOnOff
        frmExperiment.lblTimeOut.Visible = boolOnOff
    End Sub

    Private Function CheckDataFile() As Boolean
        m_strrawDataFileName = m_strDataFilePath & " Resultados para " & txtParticipantID.Text & " para la sesión  " & cmbSessionNumber.SelectedItem & ".txt"
        Dim boolstatus As Boolean = True
        If File.Exists(m_strrawDataFileName) Then
            If MsgBox("Este sujeto ya tiene un archivo para hoy. ¿Esta seguro que desea sobreescribirlo?", vbYesNo) = vbNo Then
                boolstatus = False
                Return boolstatus
                Exit Function
            End If
        End If
        'Investigar a que se refieren con lever, puede ser un slider, palanca o boton' 
        If cmbLeft.SelectedItem = cmbMiddle.SelectedItem Or cmbLeft.SelectedItem = cmbRight.SelectedItem Or cmbMiddle.SelectedItem = cmbRight.SelectedItem Then
            MsgBox("Por favor asigne cada palanca a un rol diferente")
            boolstatus = False
            Return boolstatus
            Exit Function
        End If
        If cmbLeft.SelectedItem = "" Or cmbMiddle.SelectedItem = "" Or cmbRight.SelectedItem = "" Then
            MsgBox("Por favor asigne un rol a cada palanca")
            boolstatus = False
            Return boolstatus
            Exit Function
        End If
        'Investigar roles'
        'Investigar tambien el tema de 
        If nudPhase1Duration.Value <> 20 Or nudPhase2Duration.Value <> 20 Or nudPhase3Duration.Value <> 20 Then
            If MsgBox("La duracion de al menos una fase no es 20, ¿Tienes permiso para hacer esto?", vbYesNo) = vbNo Then
                boolstatus = False
                Return boolstatus
                Exit Function
            End If
        End If
        If nudComponentDuration.Value <> 2 Then
            If MsgBox("La duracion del componente no es 2s, ¿Tienes permiso para hacer esto?", vbYesNo) = vbNo Then
                boolstatus = False
                Return boolstatus
                Exit Function
            End If
        End If
        If nudScheduleMean.Value <> 2 Then
            If MsgBox("El valor de VI no es 2, ¿Tienes permiso para hacer esto?", vbYesNo) = vbNo Then
                boolstatus = False
                Return boolstatus
                Exit Function
            End If
        End If
        If nudItems.Value <> 10 Then
            If MsgBox("La cantidad de valores VI no es 10, ¿Tienes permiso para hacer esto?", vbYesNo) = vbNo Then
                boolstatus = False
                Return boolstatus
                Exit Function
            End If
        End If
        If nudTimeOutDuration.Value <> 2 Then
            If MsgBox("El tiempo de espera minimo no es 2s, ¿Tienes permiso para hacer esto?", vbYesNo) = vbNo Then
                boolstatus = False
                Return boolstatus
                Exit Function
            End If
        End If
        Return boolstatus
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChangeParameters.Click
        If m_boolWhatToDo = False Then
            ActiveGroupBoxes(True)
            m_boolWhatToDo = True
        Else
            ActiveGroupBoxes(False)
            m_boolWhatToDo = False
        End If
    End Sub

    Private Sub ActiveGroupBoxes(OnOff As Boolean)
        GroupBox2.Enabled = OnOff
        GroupBox4.Enabled = OnOff
        GroupBox3.Enabled = OnOff
        If OnOff = False Then
            btnStart.Enabled = True
            btnChangeParameters.Text = "Cambiar ajustes"
        Else
            btnStart.Enabled = False
            btnChangeParameters.Text = "Guardar ajustes"
        End If
    End Sub

    Private Sub cmbFirstComponent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFirstComponent.SelectedIndexChanged
        btnStart.Enabled = True
        btnChangeParameters.Enabled = True
    End Sub

    Private Sub txtParticipantID_TextChanged(sender As Object, e As EventArgs) Handles txtParticipantID.TextChanged
        txtExperimenterID.Enabled = True
    End Sub

    Private Sub cmbSessionNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSessionNumber.SelectedIndexChanged
        cmbFirstComponent.Enabled = True
    End Sub

    Private Sub txtExperimenterID_TextChanged(sender As Object, e As EventArgs) Handles txtExperimenterID.TextChanged
        cmbSessionNumber.Enabled = True
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
