Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class userClass
    Dim command As MySqlCommand
    Dim myConn As New MySqlConnection
    Public dataSet As DataSet
    Dim conn As New connectionClass

    Dim query As String
    Dim resultRows As Integer
    Public peo_user As Integer

    Dim strNIC As String
    Dim strPsswd As String
    Dim intPeoId As Integer
    Dim strDesig As String
    Dim strUType As String



    Public Property NIC() As String
        Set(value As String)
            strNIC = value
        End Set
        Get
            Return strNIC
        End Get
    End Property

    Public Property Password() As String
        Set(value As String)
            strPsswd = value
        End Set
        Get
            Return strPsswd
        End Get
    End Property

    Public Property PeoId() As Integer
        Set(value As Integer)
            intPeoId = value
        End Set
        Get
            Return intPeoId
        End Get
    End Property

    Public Property Designation() As String
        Set(value As String)
            strDesig = value
        End Set
        Get
            Return strDesig
        End Get
    End Property

    Public Property UType() As String
        Set(value As String)
            strUType = value
        End Set
        Get
            Return strUType
        End Get
    End Property


    Public Sub addUser()

        conn.getConn()
        myConn = conn.myConn

        query = "INSERT INTO user(nic,psswd,designation,u_type,peo_id)VALUES('" & Me.NIC & "','" & Me.Password & "','" & Me.Designation & "','" & Me.UType & "','" & Me.PeoId & "');"
        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

        If (resultRows > 0) Then
            MessageBox.Show("Successfully Added User " & Me.NIC, "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not Added User", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    Public Sub getUser(PeoId As Integer)
        Dim dataAdpter As MySqlDataAdapter
        Dim id As Integer = PeoId

        conn.getConn()
        myConn = conn.myConn

        query = "SELECT * FROM user WHERE peo_id='" & id & "';"
        dataSet = New DataSet
        dataAdpter = New MySqlDataAdapter(query, myConn)

        peo_user = dataAdpter.Fill(dataSet, "user")


    End Sub

    Public Sub deleUser(id As Integer)
        Dim deleId As Integer = id

        conn.getConn()
        myConn = conn.myConn

        query = " DELETE FROM user WHERE peo_id='" & deleId & "';"
        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

        If (resultRows > 0) Then
            MessageBox.Show("Successfully Deleted User Account ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not Deleted User Account ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Public Sub getNICUser(nic As String)
        Dim dataAdpter As MySqlDataAdapter
        Dim userNic As String = nic

        conn.getConn()
        myConn = conn.myConn

        query = "SELECT * FROM user WHERE nic='" & userNic & "';"
        dataSet = New DataSet
        dataAdpter = New MySqlDataAdapter(query, myConn)

        peo_user = dataAdpter.Fill(dataSet, "user")

    End Sub

    Public Sub resetPassword(id As Integer, newPass As String)
        Dim userId As Integer = id
        Dim newPswrd As String = newPass


        conn.getConn()
        myConn = conn.myConn

        query = "UPDATE user SET psswd = '" & newPswrd & "' WHERE user.u_id = '" & userId & "';"
        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

        If (resultRows > 0) Then
            MessageBox.Show("Successfully Reseted Password ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not Reseted Password ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
End Class
