Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class patientClass
    Private strStatus As String
    Private infactDate As Date
    Private coroSDate As Date
    Private coroEDate As Date
    Private coroPlace As String
    Private peoId As Integer

    Dim command As MySqlCommand
    Dim myConn As New MySqlConnection
    Public dataSet As DataSet
    Public dataReader As MySqlDataReader
    Dim conn As New connectionClass

    'dash readers
    Public allReader, recoReader, currReader, deadReader As MySqlDataReader
    Public ans1, ans2, ans3, ans4 As String
    'Dim command1,command2,command3,command4 As MySqlCommand

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

    Public Property InfDate() As String
        Set(value As String)
            infactDate = value
        End Set
        Get
            Return infactDate
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

    Public Property PeopleId() As String
        Set(value As String)
            peoId = value
        End Set
        Get
            Return peoId
        End Get
    End Property


    Public Sub addPatient()

        conn.getConn()
        myConn = conn.myConn

        query = " INSERT INTO patient(status,infact_date,coro_sdate,coro_edate,coro_place,peo_id)VALUES('" & Me.Status & "','" & Me.InfDate & "','" & Me.CoSDate & "','" & Me.CoEDate & "','" & Me.CoPlace & "','" & Me.PeopleId & "');"
        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()


        If (resultRows > 0) Then
            MessageBox.Show("Successfully Added Patient ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            MessageBox.Show("Not Added Patient,Check and Try Again ", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    Public Sub getAllPatient()

        conn.getConn()
        myConn = conn.myConn

        query = "SELECT * FROM people,patient WHERE people.peo_id=patient.peo_id;"
        command = New MySqlCommand(query, myConn)
        dataReader = command.ExecuteReader()

    End Sub


    Public Sub getPatPeople(inpField As String, inpValue As String)
        Dim srchField As String = inpField
        Dim srchValue As String = inpValue


        conn.getConn()
        myConn = conn.myConn

        If (srchField = "nic") Then
            query = "SELECT * FROM people,patient WHERE people.peo_id=patient.peo_id AND people.nic='" & srchValue & "';"

        ElseIf (srchField = "gn_divi") Then
            query = "SELECT * FROM people,patient WHERE people.peo_id=patient.peo_id AND people.gn_divi='" & srchValue & "';"

        ElseIf (srchField = "date") Then
            query = "SELECT * FROM people,patient WHERE people.peo_id=patient.peo_id AND patient.infact_date='" & srchValue & "';"

        End If

        command = New MySqlCommand(query, myConn)
        dataReader = command.ExecuteReader()


    End Sub

    'Dash Bord counts
    Public Sub getTotalPati()
        Dim countAll As String

        conn.getConn()
        myConn = conn.myConn

        countAll = "SELECT COUNT(pat_id) FROM patient;"
        command = New MySqlCommand(countAll, myConn)
        allReader = command.ExecuteReader()

        allReader.Read()

    End Sub

    Public Sub getCurrCase()
        Dim contCurrent As String

        conn.getConn()
        myConn = conn.myConn

        contCurrent = "SELECT COUNT(pat_id) FROM patient WHERE status='Corontine';"
        command = New MySqlCommand(contCurrent, myConn)
        currReader = command.ExecuteReader()

        currReader.Read()
    End Sub

    Public Sub getTotRecover()
        Dim countRecover As String

        conn.getConn()
        myConn = conn.myConn

        countRecover = "SELECT COUNT(pat_id) FROM patient WHERE status='Recovered';"
        command = New MySqlCommand(countRecover, myConn)
        recoReader = command.ExecuteReader()

        recoReader.Read()
    End Sub

    Public Sub getTotDead()
        Dim countDead As String

        conn.getConn()
        myConn = conn.myConn

        countDead = "SELECT COUNT(pat_id) FROM patient WHERE status='Dead';"
        command = New MySqlCommand(countDead, myConn)
        deadReader = command.ExecuteReader()

        deadReader.Read()

    End Sub



  

    







End Class
