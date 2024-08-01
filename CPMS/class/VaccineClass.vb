Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class VaccineClass
    Dim intDose As Integer
    Dim strVaccName As String
    Dim dteDate As Date
    Dim strPlace As String
    Dim intPeoId As Integer

    Dim myConn As New MySqlConnection
    Public dataSet As DataSet
    Dim conn As New connectionClass
    Public dataReader As MySqlDataReader
    Dim command As MySqlCommand

    Dim query As String
    Dim resultRows As Integer
    Public peo_vacc As Integer
    Public all_vac As Integer



    Public Property Dose() As Integer
        Set(value As Integer)
            intDose = value
        End Set
        Get
            Return intDose
        End Get
    End Property

    Public Property VaccName() As String
        Set(value As String)
            strVaccName = value
        End Set
        Get
            Return strVaccName
        End Get
    End Property

    Public Property VaccDate() As Date
        Set(value As Date)
            dteDate = value
        End Set
        Get
            Return dteDate
        End Get
    End Property

    Public Property VaccPlace() As String
        Set(value As String)
            strPlace = value
        End Set
        Get
            Return strPlace
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

    Public Sub addVaccine()

        conn.getConn()
        myConn = conn.myConn

        query = "INSERT INTO vaccine(dose,vacc_name,date,place,peo_id)VALUES('" & Me.Dose & "','" & Me.VaccName & "','" & Me.VaccDate & "','" & Me.VaccPlace & "','" & Me.PeoId & "');"

        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

        If (resultRows > 0) Then

        Else
            MessageBox.Show("Not Added Vaccination Details", "CPMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Sub getVaccine(peoID As Integer)
        Dim dataAdpter As MySqlDataAdapter
        Dim id As Integer = peoID

        conn.getConn()
        myConn = conn.myConn

        query = "SELECT * FROM vaccine WHERE vaccine.peo_id = (SELECT peo_id FROM people WHERE peo_id='" & id & "');"
        dataSet = New DataSet
        dataAdpter = New MySqlDataAdapter(query, myConn)

        peo_vacc = dataAdpter.Fill(dataSet, "vaccine")


    End Sub

    Public Sub deleVaccine(peoVaccId As Integer)
        Dim deleId As Integer = peoVaccId

        conn.getConn()
        myConn = conn.myConn

        query = "DELETE FROM vaccine WHERE peo_id ='" & deleId & "';"
        command = New MySqlCommand(query, myConn)
        resultRows = command.ExecuteNonQuery()

    End Sub

    Public Sub getAllVaccine()

        conn.getConn()
        myConn = conn.myConn

        query = "SELECT * FROM people,vaccine WHERE people.peo_id=vaccine.peo_id ;"
        command = New MySqlCommand(query, myConn)
        dataReader = command.ExecuteReader()


    End Sub

    Public Sub getSrchVaccine(inpField As String, inpValue As String)
        Dim srchField As String = inpField
        Dim srchValue As String = inpValue


        conn.getConn()
        myConn = conn.myConn

        If (srchField = "nic") Then
            query = "SELECT * FROM people,vaccine WHERE people.peo_id=vaccine.peo_id AND people.nic ='" & srchValue & "';"
            
        ElseIf (srchField = "moh_divi") Then
            query = "SELECT * FROM people,vaccine WHERE people.peo_id=vaccine.peo_id AND people.moh_divi ='" & srchValue & "';"

        ElseIf (srchField = "vacc_name") Then
            query = "SELECT * FROM people,vaccine WHERE people.peo_id=vaccine.peo_id AND vaccine.vacc_name ='" & srchValue & "';"

        ElseIf (srchField = "dose") Then
            query = "SELECT * FROM people,vaccine WHERE people.peo_id=vaccine.peo_id AND vaccine.dose ='" & srchValue & "';"

        ElseIf (srchField = "date") Then
            query = "SELECT * FROM people,vaccine WHERE people.peo_id=vaccine.peo_id AND vaccine.date ='" & srchValue & "';"

        End If

        command = New MySqlCommand(query, myConn)
        dataReader = command.ExecuteReader()


    End Sub

End Class
