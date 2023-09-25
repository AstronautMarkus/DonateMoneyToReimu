Imports System.Data.SQLite



Public Class Form1

    Private githubClicks As Integer = 0 ' Variable de clicks para el secreto de la foto

    ' Cadena de conexión a la base de datos SQLite
    Dim connectionString As String = "Data Source=data.db;Version=3;"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConsejo.Click

        Using conn As New SQLiteConnection(connectionString)

            conn.Open()
            Dim sql As String = "SELECT CONSEJO FROM CONSEJO ORDER BY RANDOM() LIMIT 1"
            Dim cmd As New SQLiteCommand(sql, conn)

            ' Ejecutar la consulta y obtener el resultado
            Dim consejo As String = Convert.ToString(cmd.ExecuteScalar())

            conn.Close()

            ' Mostrar el consejo en un MessageBox
            MessageBox.Show(consejo, "Consejo sabio", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Using


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles imgReimu.Click

        Dim github_markus As String = "https://github.com/AstronautMarkus"
        githubClicks += 1

        Try

            If githubClicks = 3 Then
                Process.Start("cmd", "/c start " & github_markus)
                githubClicks = 0
            End If

        Catch ex As Exception

            ' Manejar la excepción aquí, por ejemplo, mostrar un mensaje de error.

            MessageBox.Show("Error al abrir el enlace: " & ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnDonate.Click

        Dim input As String = InputBox("¿Cuánto dinero quieres donar?", "Donación a Reimu")

        If String.IsNullOrEmpty(input) Then

            MessageBox.Show("No has donado nada :(", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf IsNumeric(input) AndAlso Val(input) > 0 Then

            MessageBox.Show($"Has donado {input} a Reimu ;)", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf input = "0" Then

            MessageBox.Show("¡Oh no! Has donado 0 ;(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnComingSoon.Click

        Me.Hide()
        DataMenu.Show()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        MessageBox.Show("Chau mi rey", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

End Class
