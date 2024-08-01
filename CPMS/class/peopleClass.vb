Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class peopleClass

    Private strFirstName As String
    Private strLastName As String
    Private dteDate As Date
    Private strNIC As String
    Private strGender As String
    Private strAddress As String
    Private strDistrict As String
    Private strCity As String
    Private strMOHDivi As String
    Private strGnDivi As String
    Private strTele As String
    Private strEmail As String


    Dim command As MySqlCommand
    Dim myConn As New MySqlConnection
    Public dataSet As DataSet
    Dim conn As New connectionClass

    Dim query As String
    Dim resultRows As Integer
    Public x As Integer


    Public Property FirstName() As String
        Set(value As String)

            strFirstName = value
        End Set
        Get
            Return strFirstName
        End Get
    End Property

    Public Property LastName() As String
        Set(value As String)

            strLastName = value
        End Set
        Get
            Return strLastName
        End Get
    End Property

    Public Property DOB() As Date
        Set(value As Date)

            dteDate = value
        End Set
        Get
            Return dteDate
        End Get
    End Property

    Public Property NIC() As String
        Set(value As String)

            strNIC = value
        End Set
        Get
            Return strNIC
        End Get
    End Property

    Public Property Gender() As String
        Set(value As String)

            strGender = value
        End Set
        Get
            Return strGender
        End Get
    End Property

    Public Property Address() As String
        Set(value As String)

            strAddress = value
        End Set
        Get
            Return strAddress
        End Get
    End Property

    Public Property District() As String
        Set(value As String)

            strDistrict = value
        End Set
        Get
            Return strDistrict
        End Get
    End Property

    Public Property City() As String
        Set(value As String)

            strCity = value
        End Set
        Get
            Return strCity
        End Get
    End Property

    Public Property MOHDivi() As String
        Set(value As String)

            strMOHDivi = value
        End Set
        Get
            Return strMOHDivi
        End Get
    End Property

    Public Property GNDivi() As String
        Set(value As String)

            strGnDivi = value
        End Set
        Get
            Return strGnDivi
        End Get
    End Property

    Public Property Email() As String
        Set(value As String)

            strEmail = value
        End Set
        Get
            Return strEmail
        End Get
    End Property

    Public Property Telephone() As String
        Set(value As String)

            strTele = value
        End Set
        Get
            Return strTele
        End Get
    End Property


    Public Sub addStudent()

        'get conn
        conn.getConn()
        myConn = conn.myConn

        query = "INSERT INTO people(fname,lname,dob,nic,gender,address,city,district,moh_divi,gn_divi,email,telephone)VALUES('" & Me.FirstName & "','" & Me.LastName & "','" & Me.DOB & "','" & Me.NIC & "','" & Me.Gender & "','" & Me.Address & "','" & Me.City & "','" & Me.District & "','" & Me.MOHDivi & "','" & Me.GNDivi & "','" & Me.Email & "','" & Me.Telephone & "');"

        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

        If (resultRows > 0) Then
            MessageBox.Show("Successfully Added People " & Me.FirstName & " " & Me.LastName, "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not Added People ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    Public Sub getPeople(nic As String)

        Dim dataAdapter As MySqlDataAdapter
        Dim getNIC As String = nic


        conn.getConn()
        myConn = conn.myConn

        query = "SELECT * FROM people WHERE nic='" & getNIC & "';"
        dataSet = New DataSet
        dataAdapter = New MySqlDataAdapter(query, myConn)

        x = dataAdapter.Fill(dataSet, "people")

        If (x = 1) Then

        Else
            MessageBox.Show("Not People exist,Check NIC and Try Again", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmProfile.txtProNIC.Focus()

        End If


    End Sub


    Public Sub delePeople(id As Integer)
        Dim deleId As Integer = id

        conn.getConn()
        myConn = conn.myConn

        query = "DELETE FROM people WHERE peo_id='" & deleId & "';"

        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

        If (resultRows > 0) Then
            MessageBox.Show("Successfully Deleted People ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not Deleted People ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Public Sub updatePeople(id As Integer)
        Dim updateId As Integer = id

        conn.getConn()
        myConn = conn.myConn

        query = "UPDATE people SET fname = '" & Me.FirstName & "', lname = '" & Me.LastName & "', dob = '" & Me.DOB & "', nic = '" & Me.NIC & "', gender = '" & Me.Gender & "', address = '" & Me.Address & "', city = '" & Me.City & "', district = '" & Me.District & "', moh_divi = '" & Me.MOHDivi & "', gn_divi = '" & Me.GNDivi & "', email = '" & Me.Email & "', telephone = '" & Me.Telephone & "' WHERE people.peo_id = '" & updateId & "';"
        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

        If (resultRows > 0) Then
            MessageBox.Show("Successfully Updated People " & Me.FirstName & " " & Me.LastName & "'s Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not Updated People ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
End Class
