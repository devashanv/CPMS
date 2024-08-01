Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class connectionClass
    Public myConn As MySqlConnection


    Public Sub getConn()

        myConn = New MySqlConnection()
        myConn.ConnectionString = "SERVER=localhost;DATABASE=cpms;UID=root;PASSWORD=avroot98;"

        Try
            myConn.Open()

        Catch ex As Exception

            MessageBox.Show("DB Connection Error", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub

End Class
