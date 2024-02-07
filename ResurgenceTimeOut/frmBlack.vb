Public Class frmBlack

    ' al presionar esc se termina el programa
    Private Sub frmBlack_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub

End Class