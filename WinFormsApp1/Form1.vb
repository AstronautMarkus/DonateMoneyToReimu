Public Class Form1

    Private githubClicks As Integer = 0 ' Variable de clicks para el secreto de la foto



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConsejo.Click

        ' Generar un número aleatorio entre 1 y 5
        Dim random As New Random()

        Dim numero As Integer = random.Next(1, 6)

        ' Mostrar mensajes diferentes según el valor de la variable "numero"

        Select Case numero
            Case 1
                MessageBox.Show("En el mundo de la informática, la paciencia es una virtud y la perseverancia es la clave del éxito.", "Consejo sabio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("La seguridad informática es como un escudo invisible; nunca te das cuenta de su importancia hasta que la necesitas desesperadamente.", "Consejo sabio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                MessageBox.Show("La tecnología avanza a pasos agigantados, pero nunca olvides que la creatividad y la innovación son el motor que impulsa el progreso en la informática.", "Consejo sabio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                MessageBox.Show("En la era digital, la información es poder, pero solo aquellos que la gestionan de manera inteligente pueden convertirla en conocimiento valioso.", "Consejo sabio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5
                MessageBox.Show("La informática es un puente que conecta mundos. Asegúrate de construir puentes fuertes y seguros para un futuro digital sólido y confiable.", "Consejo sabio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnDonate.Click

        Dim input As String = InputBox("¿Cuánto dinero quieres donar?", "Donación a Reimu")

        If String.IsNullOrEmpty(input) Then
            MessageBox.Show("No has donado nada :(", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf IsNumeric(input) AndAlso Val(input) > 0 Then
            MessageBox.Show($"Has donado {input} a Reimu ;)", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("Proximamente los consejos serán cientos y por una base de datos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("¿Alguien está leyendo esto?", "¿Hola?", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
