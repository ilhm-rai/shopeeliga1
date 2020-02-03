Imports MySql.Data.MySqlClient
Module Database
    Private conn As New MySqlConnection("server=localhost;User Id=root;database=shopeeticket")
    Private dataAdapter As MySqlDataAdapter
    Private dataSet As DataSet
    Public dataTable As DataTable
    Private sql As String
    Public oldData As String
    Private cmd As MySqlCommand
    Public dataReader As MySqlDataReader
    Public role As Integer
    Public row As Integer
    Public id_user As Integer
    Private deleteConfirmation As Integer
    Public addNew As Boolean

    Public Function openConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return conn
    End Function

    Public Function closeConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Return conn
    End Function

    Public Sub LoadData(ByVal table As String, ByVal dataGridView As DataGridView, Optional field As String = "*", Optional condition As String = "")
        openConnection()
        sql = "SELECT " & field & " FROM " & table & " " & condition
        dataAdapter = New MySqlDataAdapter(sql, conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)
        dataTable = dataSet.Tables(0)
        dataGridView.DataSource = dataTable
        closeConnection()
    End Sub

    Public Sub ExecuteReader(ByVal table As String, ByVal field As String, Optional condition As String = "")
        sql = "SELECT " & field & " FROM " & table & " " & condition
        cmd = New MySqlCommand(sql, conn)
        dataReader = cmd.ExecuteReader
    End Sub

    Public Sub ExecuteQuery(ByVal table As String, ByVal field As String, Optional ByVal condition As String = "")
        sql = "SELECT * FROM " & table & " " & condition
        dataAdapter = New MySqlDataAdapter(sql, conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet, table)
        dataTable = dataSet.Tables(0)
    End Sub

    Public Sub AddNewData(ByVal table As String, ByVal fields As String, ByVal values As String)
        openConnection()
        sql = "INSERT INTO " & table & " (" & fields & ") " & "VALUES(" & values & ")"
        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        closeConnection()
    End Sub

    Public Sub UpdateData(ByVal table As String, ByVal fieldsToChange As String, ByVal id As String, ByVal value As String)
        openConnection()
        sql = "UPDATE " & table & " SET " & fieldsToChange & " WHERE " & id & "=" & value
        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        closeConnection()
    End Sub

    Public Sub DeleteData(ByVal table As String, ByVal id As String, ByVal value As String)
        openConnection()
        deleteConfirmation = MessageBox.Show("Apakah anda yakin?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If deleteConfirmation = 6 Then
            sql = "DELETE FROM " & table & " WHERE " & id & "=" & value
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End If
        closeConnection()
    End Sub

    Public Sub AddDataComboBox(ByVal table As String, ByVal field As String, ByVal cbDisplay As ComboBox, ByVal cbValue As ComboBox)
        openConnection()
        ExecuteReader(table, field)
        While dataReader.Read
            cbDisplay.Items.Add(dataReader.GetString(0))
            cbValue.Items.Add(dataReader.GetString(1))
        End While
        closeConnection()
    End Sub

    Public Sub LoadMatches(ByVal dataGridView As DataGridView)
        openConnection()
        dataGridView.Rows.Clear()
        ExecuteReader("matches", "*", "ORDER BY matchday DESC")
        While dataReader.Read
            dataGridView.Rows.Add(dataReader.GetString("id_match"), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3), dataReader.GetValue(4), _
                                  dataReader.GetValue(5), dataReader.GetMySqlDateTime(6), dataReader.GetValue(7) & " " & dataReader.GetValue(8), dataReader.GetValue(7), _
                                  dataReader.GetValue(8), dataReader.GetValue(9))
        End While
        closeConnection()
    End Sub

    Public Sub LoadTickets(ByVal dataGridView As DataGridView)
        openConnection()
        dataGridView.Rows.Clear()
        ExecuteReader("tickets t", "id_ticket, t.id_match, m.home_team, m.away_team, m.matchday, m.kickoff, m.time_location, m.venue, " _
                      & "stock_normal, stock_vip, normal_price, vip_price, m.stock_ticket", "INNER JOIN matches m ON m.id_match = t.id_match ORDER BY m.matchday DESC")
        While dataReader.Read
            dataGridView.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3), dataReader.GetMySqlDateTime(4),
                                  dataReader.GetValue(5) & " " & dataReader.GetValue(6), dataReader.GetValue(7), dataReader.GetValue(12), dataReader.GetInt32(8),
                                  dataReader.GetInt32(9), dataReader.GetValue(10), dataReader.GetValue(11))
        End While
        closeConnection()
    End Sub

    Public Sub GenerateId(ByVal table As String, ByVal field As String, ByVal chooseTextBox As TextBox, ByVal uniqueId As String)
        openConnection()
        Dim month As String
        If Now.Month.ToString.Length = 1 Then
            month = "0" & Now.Month
        Else
            month = Now.Month
        End If
        Dim pattern = Now.Year & month & "0"
        chooseTextBox.Clear()
        dataSet = New DataSet
        dataAdapter = New MySqlDataAdapter("SELECT " & field & " FROM " & table & " ORDER BY " & field & " DESC", conn)
        dataAdapter.Fill(dataSet)
        dataTable = dataSet.Tables(0)
        If dataTable.Rows.Count > 0 Then
            chooseTextBox.Text = uniqueId & Format(Convert.ToInt32(Strings.Right(dataTable.Rows(0)(0), 1)) + 1, pattern)
        Else
            chooseTextBox.Text = uniqueId & Now.Year & month & "1"
        End If
        closeConnection()
    End Sub

End Module
