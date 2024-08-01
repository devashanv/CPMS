Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AssocClass
    Private strStatus As String
    Private assocDate As Date
    Private coroSDate As Date
    Private coroEDate As Date
    Private coroPlace As String
    Private strPatNIC As String
    Private peoId As Integer


    Dim command As MySqlCommand
    Dim myConn As New MySqlConnection
    Public dataSet As DataSet
    Public dataReader As MySqlDataReader
    Dim conn As New connectionClass

    Dim query As String
    Dim resultRows As Integer



    Public Property Status() As String
        Set(value As String)
            strStatus = value
        End Set
        Get
            Return strStatus
        End Get
    End Property

    Public Property AssociateDate() As String
        Set(value As String)
            assocDate = value
        End Set
        Get
            Return assocDate
        End Get
    End Property

    Public Property CoSDate() As String
        Set(value As String)
            coroSDate = value
        End Set
        Get
            Return coroSDate
        End Get
    End Property

    Public Property CoEDate() As String
        Set(value As String)
            coroEDate = value
        End Set
        Get
            Return coroEDate
        End Get
    End Property

    Public Property CoPlace() As String
        Set(value As String)
            coroPlace = value
        End Set
        Get
            Return coroPlace
        End Get
    End Property

    Public Property PatientNIC() As String
        Set(value As String)
            strPatNIC = value
        End Set
        Get
            Return strPatNIC
        End Get
    End Property

    Public Property PeopleId() As String
        Set(value As String)
            peoId = value
        End Set
        Get
            Return peoId
        End Get
    End Property


    Public Sub addAssoc()

        conn.getConn()
        myConn = conn.myConn

        query = " INSERT INTO associate(status,assoc_date,coro_sdate,coro_edate,coro_place,pat_nic,peo_id)VALUES('" & Me.Status & "','" & Me.AssociateDate & "','" & Me.CoSDate & "','" & Me.CoEDate & "','" & Me.CoPlace & "','" & Me.PatientNIC & "','" & Me.PeopleId & "');"
        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

        If (resultRows > 0) Then
            MessageBox.Show("Successfully Added Associate ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not Added Associate,Check and Try Again ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Public Sub getAllAssoc()

        conn.getConn()
        myConn = conn.myConn

        query = "SELECT * FROM people,associate WHERE people.peo_id=associate.peo_id;"
        command = New MySqlCommand(query, myConn)
        dataReader = command.ExecuteReader()

    End Sub


    Public Sub getAssocPeople(inpField As String, inpValue As String)
        Dim srchField As String = inpField
        Dim srchValue As String = inpValue


        conn.getConn()
        myConn = conn.myConn

        If (srchField = "nic") Then
            query = "SELECT * FROM people,associate WHERE people.peo_id=associate.peo_id AND people.nic='" & srchValue & "';"

        ElseIf (srchField = "gn_divi") Then
            query = "SELECT * FROM people,associate WHERE people.peo_id=associate.peo_id AND people.gn_divi='" & srchValue & "';"

        ElseIf (srchField = "date") Then
            query = "SELECT * FROM people,associate WHERE people.peo_id=associate.peo_id AND associate.assoc_date='" & srchValue & "';"

        End If

        command = New MySqlCommand(query, myConn)
        dataReader = command.ExecuteReader()


    End Sub



End Class
