Imports System.Data.SQLite
Imports System.IO



Public Class Form1

    Private githubClicks As Integer = 0 ' Variable de clicks para el secreto de la foto

    ' Cadena de conexión a la base de datos SQLite
    Dim connectionString As String = "Data Source=data.db;Version=3;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Verificar si la base de datos existe
        If Not File.Exists("data.db") Then
            Dim respuesta As DialogResult = MessageBox.Show("La base de datos no existe. ¿Desea crearla?", "Crear Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                ' Código para crear la tabla (similar a lo que tienes en el botón)
                Try
                    Using conn As New SQLiteConnection(connectionString)
                        conn.Open()
                        Dim sql As String = "CREATE TABLE consejo (id INTEGER NOT NULL PRIMARY KEY,consejo VARCHAR NOT NULL);" & "CREATE TABLE donaciones (id INTEGER NOT NULL,cantidad INTEGER NOT NULL,nombre_donador TEXT NOT NULL,PRIMARY KEY(id));"
                        Dim cmd As New SQLiteCommand(sql, conn)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al crear la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("No se ha creado la base de datos. La aplicación no puede continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close() ' Cierra la aplicación si no se crea la base de datos
            End If
        Else
            MessageBox.Show("Base de datos detectada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Verificar si el archivo de la base de datos ha sido borrado y reiniciar el programa
        If Not File.Exists("data.db") Then
            MessageBox.Show("El archivo de la base de datos ha sido borrado. La aplicación se reiniciará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConsejo.Click

        Try

            Using conn As New SQLiteConnection(connectionString)

                conn.Open()
                Dim sql As String = "SELECT CONSEJO FROM CONSEJO ORDER BY RANDOM() LIMIT 1"
                Dim cmd As New SQLiteCommand(sql, conn)

                ' Ejecutar la consulta y obtener el resultado
                Dim consejo As String = Convert.ToString(cmd.ExecuteScalar())

                conn.Close()

                ' Verificar si la consulta no devolvió ningún resultado
                If String.IsNullOrEmpty(consejo) Then
                    MessageBox.Show("No se han encontrado consejos en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' Mostrar el consejo en un MessageBox
                    MessageBox.Show(consejo, "Consejo sabio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using

        Catch ex As Exception

            MessageBox.Show("Error, no se encuentra ningún consejo en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try




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

            MessageBox.Show("No has donado nada :(", "Donaciones a Reimu", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf IsNumeric(input) AndAlso Val(input) > 0 Then

            ' en este caso, se agrega un numero de donación válido, por ende pregunta por el nombre para seguir y registrar la donación

            Dim nombreDonador As String = InputBox("Ingrese su nombre", "Donación a Reimu")

            If Not String.IsNullOrEmpty(nombreDonador) Then


                Try ' probar si no se meten datos raros ej, decimales

                    ' Logica donación (cumple donación y nombre correcto)

                    Using conexion As New SQLiteConnection(connectionString)
                        conexion.Open()

                        Dim sql As String = "INSERT INTO Donaciones (cantidad, nombre_donador) VALUES (@Cantidad, @NombreDonador)"

                        Using cmd As New SQLiteCommand(sql, conexion)

                            cmd.Parameters.AddWithValue("@Cantidad", input)
                            cmd.Parameters.AddWithValue("@NombreDonador", nombreDonador)

                            cmd.ExecuteNonQuery()

                        End Using


                        MessageBox.Show("La donación se ha registrado correctamente en la base de datos.")

                        If input > 0 And input < 501 Then

                            My.Computer.Audio.Play(My.Resources.donation_low, AudioPlayMode.Background)

                        ElseIf input > 500 And input < 1001 Then

                            My.Computer.Audio.Play(My.Resources.donation_average, AudioPlayMode.Background)

                        ElseIf input > 1000 And input < 1501 Then

                            My.Computer.Audio.Play(My.Resources.donation_high, AudioPlayMode.Background)

                        Else

                            My.Computer.Audio.Play(My.Resources.donation_higher, AudioPlayMode.Background)

                        End If

                        MessageBox.Show($"Has donado {input} a Reimu ;)", "Donaciones a Reimu")


                    End Using




                Catch ex As Exception

                    ' Manejar la excepción aquí, por ejemplo, meter datos raros o decimales

                    MessageBox.Show("Error, no se pudo ingresar correctamente la donación, por favor verifique que esté escrito en números enteros. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try

            Else

                ' nombre no valido, no se hace ninguna donación

                MessageBox.Show("Por favor, ingrese un nombre válido.", "Nombre inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)

                MessageBox.Show("Error, no se ha registrado ninguna donación en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


        ElseIf input = "0" Then

            MessageBox.Show("¡Oh no! Has donado 0 ;(", "Donaciones a Reimu", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("Por favor, ingresa una cantidad válida mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnAdminControl.Click

        Me.Hide()
        DataMenu.Show()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        MessageBox.Show("Chau mi rey", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    Private Sub TitleP2_Click(sender As Object, e As EventArgs) Handles titleP2.Click
        My.Computer.Audio.Play(My.Resources.fumo, AudioPlayMode.Background)
    End Sub
End Class
