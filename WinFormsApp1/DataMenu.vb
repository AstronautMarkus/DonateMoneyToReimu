Imports System.Data.SQLite
Imports System.IO

Public Class DataMenu

    ' Cadena de conexión a la base de datos SQLite

    Dim conn As New SQLiteConnection("Data Source=data.db;Version=3;UseUTF8Encoding=True;")

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Verificar si el archivo de la base de datos ha sido borrado y reiniciar el programa
        If Not File.Exists("data.db") Then
            MessageBox.Show("El archivo de la base de datos ha sido borrado. La aplicación se reiniciará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End If
    End Sub



    Private Sub BtnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click ' para salir

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub BtnCargarDatos_Click(sender As Object, e As EventArgs) Handles BtnCargarDatos.Click  ' no me lo borre compa Handles BtnCargarDatos.Click

        conn.Open()

        Dim sqlConsejo As String = "select id, consejo from consejo;"
        Dim sqlDonaciones As String = "select id, cantidad, nombre_donador from donaciones;"


        Dim da As New SQLiteDataAdapter(sqlConsejo, conn)
        Dim de As New SQLiteDataAdapter(sqlDonaciones, conn)


        Dim dataDonaciones As New Data.DataTable
        Dim dataConsejos As New Data.DataTable


        da.Fill(dataConsejos)
        de.Fill(dataDonaciones)


        conn.Close()

        Me.DataGridConsejos.DataSource = dataConsejos
        Me.DataGridDonaciones.DataSource = dataDonaciones


    End Sub

    Private Sub DonacionesTotalTextBox_TextChangedBtnCargarDatos_Click(sender As Object, e As EventArgs) Handles BtnCargarDatos.Click

        Try
            conn.Open()

            ' Consulta SQL para contar registros en la tabla donaciones

            Dim sqlDonacionesTotal As String = "SELECT printf('$%,d', SUM(cantidad)) AS suma_donaciones FROM donaciones;"

            ' Crear un comando SQL y asociarlo con la conexión
            Dim cmd As New SQLiteCommand(sqlDonacionesTotal, conn)

            ' Ejecutar la consulta y obtener el resultado
            Dim result As Object = cmd.ExecuteScalar()

            ' Verificar si el resultado no es nulo
            If result IsNot Nothing Then
                ' Mostrar el resultado en el TextBox
                DonacionesTotalTextBox.Text = result.ToString()
            ElseIf result = "0" Then
                ' Si no hay resultados, mostrar un mensaje o realizar alguna otra acción
                DonacionesTotalTextBox.Text = "No se encontraron registros.".ToString()
            End If
            conn.Close()
        Catch ex As Exception
            ' Manejar cualquier excepción que pueda ocurrir
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnDeleteConsejos_Click(sender As Object, e As EventArgs) Handles BtnDeleteConsejos.Click

        conn.Open()

        ' Consulta para contar los registros en la tabla
        Dim sqlCountConsejos As String = "SELECT COUNT(*) FROM CONSEJO;"
        Dim cmdCount As New SQLiteCommand(sqlCountConsejos, conn)

        ' Ejecutar la consulta para contar los registros
        Dim rowCount As Integer = CInt(cmdCount.ExecuteScalar())

        ' Cerrar la conexión
        conn.Close()

        If rowCount = 0 Then
            MessageBox.Show("No hay consejos para eliminar en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            Dim DeleteConsejos As DialogResult = MessageBox.Show("¿Quiere eliminar los consejos de la base de datos?", "Alerta", MessageBoxButtons.YesNo)

            If DeleteConsejos = DialogResult.Yes Then

                conn.Open()

                Dim sqlDeleteAllConsejos As String = "DELETE FROM CONSEJO;"

                Dim cmdDelete As New SQLiteCommand(sqlDeleteAllConsejos, conn)

                ' Ejecutar el comando para borrar los datos
                cmdDelete.ExecuteNonQuery()

                conn.Close()

                ' Se borraron todos los datos
                MessageBox.Show("Los datos han sido eliminados correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRestaurarConsejos.Click

        conn.Open()

        ' Consulta para contar los registros en la tabla
        Dim sqlCountConsejos As String = "SELECT COUNT(*) FROM CONSEJO;"
        Dim cmdCount As New SQLiteCommand(sqlCountConsejos, conn)

        ' Ejecutar la consulta para contar los registros
        Dim rowCount As Integer = CInt(cmdCount.ExecuteScalar())

        ' Cerrar la conexión
        conn.Close()

        If rowCount = 60 Then
            MessageBox.Show("Los consejos están cargados en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try

                conn.Open()

                Dim CargarConsejos As String = My.Resources.consejosList

                Dim cmdDelete As New SQLiteCommand(CargarConsejos, conn)

                ' Ejecutar el comando para cargar los consejos
                cmdDelete.ExecuteNonQuery()

                conn.Close()

                MessageBox.Show("Consejos cargados exitosamente a la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Catch ex As Exception

                MessageBox.Show("Error, no se pudieron cargar los consejos a la base de datos. " & ex.Message)

            End Try



        End If


    End Sub

    Private Sub BtnDeleteDonaciones_Click(sender As Object, e As EventArgs) Handles BtnDeleteDonaciones.Click


        conn.Open()

        ' Consulta para contar los registros en la tabla
        Dim sqlCountDonaciones As String = "SELECT COUNT(*) FROM DONACIONES;"
        Dim cmdCount As New SQLiteCommand(sqlCountDonaciones, conn)

        ' Ejecutar la consulta para contar los registros
        Dim rowCount As Integer = CInt(cmdCount.ExecuteScalar())

        ' Cerrar la conexión
        conn.Close()


        If rowCount < 1 Then

            MessageBox.Show("No hay donaciones para eliminar en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Dim DeleteDonaciones As DialogResult = MessageBox.Show("¿Quiere eliminar las donaciones de la base de datos?", "Alerta", MessageBoxButtons.YesNo)

            If DeleteDonaciones = DialogResult.Yes Then
                conn.Open()

                Dim sqlDeleteAllConsejos As String = "DELETE FROM DONACIONES;"

                Dim cmdDelete As New SQLiteCommand(sqlDeleteAllConsejos, conn)

                ' Ejecutar el comando para borrar los datos
                cmdDelete.ExecuteNonQuery()

                conn.Close()

                ' Se borraron todos los datos
                MessageBox.Show("Las donaciones han sido borradas correctamente.", "Reimu estará triste", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If



    End Sub

    Private Sub BtnRandDonaciones_Click(sender As Object, e As EventArgs) Handles BtnRandDonaciones.Click



        Try

            conn.Open()

            Dim CargarDonaciones As String = My.Resources.donacionesList

            Dim cmdDelete As New SQLiteCommand(CargarDonaciones, conn)

            ' Ejecutar el comando para cargar los consejos
            cmdDelete.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("Donaciones al azar cargadas exitosamente a la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception

            MessageBox.Show("Error, no se pudieron cargar los consejos a la base de datos. " & ex.Message)

        End Try



    End Sub

End Class