Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Form1
    Dim conStr As String = "Data Source=MPIYUSH3510-AMD;Initial Catalog=Medical;Integrated Security=true"
    Dim sqlCmd As SqlCommand
    Dim Connection As SqlConnection
    Dim dtAdapater As SqlDataAdapter
    Dim dtSet As DataSet
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Connection = New SqlConnection("Data Source=MPIYUSH3510-AMD;Initial Catalog=Medical;Integrated Security=true")
        Try
            Connection.Open()
            If Connection.State = ConnectionState.Open Then
                ' MsgBox("Connected To Medical Database !")
            End If
        Catch ec As Exception
            MsgBox(ec.Message)
        End Try

        If TextBoxMid.Text = "" And TextBoxName.Text = "" And ComboBoxType.Text = "" And TextBoxCompany.Text = "" And TextBoxRate.Text = "" Then
            MsgBox("All fields are empty !")
            Return
        End If

        If TextBoxMid.Text = "" Then
            MsgBox("Please Enter Mid !")
            Return
        End If

        If TextBoxName.Text = "" Then
            MsgBox("Name can't be empty !")
            Return
        End If

        If ComboBoxType.Text = "" Then
            MsgBox("Please Select Type correctly !")
            Return
        End If

        If TextBoxCompany.Text = "" Then
            MsgBox("enter u r Company !")
            Return
        End If

        If TextBoxRate.Text = "" Then
            MsgBox("Rate Can't be empty !")
            Return
        End If

        CreatetblMedicine()
        InsertIntotblMedicine()
        ButtonClear_Click(sender, e)
        ShowDataFromtblMedicine()
    End Sub

    Public Sub CreatetblMedicine()
        Try
            sqlCmd = New SqlCommand("Create table tblMedicine(mid int Unique,name varchar(40),type varchar(10),company varchar(20),rate int)", Connection)
            sqlCmd.ExecuteNonQuery()
            'MsgBox("Table Created !")
        Catch ec As Exception
            MsgBox(ec.Message)
        End Try
    End Sub

    Public Sub InsertIntotblMedicine()
        Try
            Dim mid As Integer = Convert.ToInt32(TextBoxMid.Text)
            Dim name As String = TextBoxName.Text
            Dim type As String = ComboBoxType.Text
            Dim company As String = TextBoxCompany.Text
            Dim rate As Integer = Convert.ToInt32(TextBoxRate.Text)

            sqlCmd = New SqlCommand("insert into tblMedicine values(@mid,@name,@type,@company,@rate)", Connection)
            sqlCmd.Parameters.AddWithValue("@mid", mid)
            sqlCmd.Parameters.AddWithValue("@name", name)
            sqlCmd.Parameters.AddWithValue("@type", type)
            sqlCmd.Parameters.AddWithValue("@company", company)
            sqlCmd.Parameters.AddWithValue("@rate", rate)
            sqlCmd.ExecuteNonQuery()
            MsgBox("Inserted !")
        Catch ec As Exception
            MsgBox(ec.Message)
        End Try
    End Sub

    Public Sub ShowDataFromtblMedicine()
        Try
            dtAdapater = New SqlDataAdapter("select * from tblMedicine order by mid", Connection)
            dtSet = New DataSet()
            dtAdapater.Fill(dtSet, "tblMedicine")
            DataGridViewReader.DataSource = dtSet.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Connection = New SqlConnection(conStr)
        Connection.Open()
        Try
            dtAdapater = New SqlDataAdapter("select * from tblMedicine order by mid", Connection)
            dtSet = New DataSet()
            dtAdapater.Fill(dtSet, "tblMedicine")
            DataGridViewReader.DataSource = dtSet.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If TextBoxMid.Text = "" Then
            MsgBox("Please Enter Mid !")
            Return
        End If

        If TextBoxName.Text = "" Then
            MsgBox("Name can't be empty !")
            Return
        End If

        If ComboBoxType.Text = "" Then
            MsgBox("Please select correctly !")
            Return
        End If

        If TextBoxCompany.Text = "" Then
            MsgBox("Company can't choose  !")
            Return
        End If

        If TextBoxRate.Text = "" Then
            MsgBox("Rate Can't be empty !")
            Return
        End If

        Try
            Dim mid As Integer = Convert.ToInt32(TextBoxMid.Text)
            Dim name As String = TextBoxName.Text
            Dim type As String = ComboBoxType.Text
            Dim company As String = TextBoxCompany.Text
            Dim rate As Integer = Convert.ToInt32(TextBoxRate.Text)

            sqlCmd = New SqlCommand("Update tblMedicine set name=@name,type=@type,company=@company,rate=@rate where mid=@mid", Connection)
            sqlCmd.Parameters.AddWithValue("@name", name)
            sqlCmd.Parameters.AddWithValue("@type", type)
            sqlCmd.Parameters.AddWithValue("@company", company)
            sqlCmd.Parameters.AddWithValue("@rate", rate)
            sqlCmd.Parameters.AddWithValue("@mid", mid)
            sqlCmd.ExecuteNonQuery()
            MsgBox("Update !")

            ButtonRefresh_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ButtonClear_Click(sender, e)
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Connection = New SqlConnection("Data Source=MPIYUSH3510-AMD;Initial Catalog=Medical;Integrated Security=true")
        Connection.Open()

        If DataGridViewReader.RowCount = 0 Then
            MsgBox("unable to deleted, table is empty !", MsgBoxStyle.Critical, "failed")
            Return
        End If

        If MsgBox("Delete record ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            If DataGridViewReader.AreAllCellsSelected(0) = True Then
                sqlCmd = New SqlCommand("delete from tblMedicine", Connection)
                sqlCmd.ExecuteNonQuery()
                ButtonRefresh_Click(sender, e)
            End If
        Catch ec As Exception
            MsgBox(ec.Message)
        End Try

        Try
            For Each row As DataGridViewRow In DataGridViewReader.SelectedRows
                If row.Selected Then
                    sqlCmd = New SqlCommand("delete from tblMedicine where mid = '" & row.DataBoundItem(0).ToString & "'", Connection)
                    sqlCmd.ExecuteNonQuery()
                    ButtonRefresh_Click(sender, e)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxMid.Clear()
        TextBoxName.Clear()
        ComboBoxType.SelectedItem = "- Choose Item -"
        TextBoxRate.Clear()
        TextBoxCompany.Clear()
    End Sub

    Private Sub CheckBoxCondition_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCondition.CheckedChanged
        Connection = New SqlConnection(conStr)
        Connection.Open()
        If CheckState.Checked Then
            Try
                dtAdapater = New SqlDataAdapter("select * from tblMedicine where rate < 500 and type LIKE 'syrup' ", Connection)
                dtSet = New DataSet()
                dtAdapater.Fill(dtSet, "tblMedicine")
                DataGridViewReader.DataSource = dtSet.Tables(0).DefaultView
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If CheckState.Unchecked Then
            ButtonRefresh_Click(sender, e)
        End If
    End Sub
End Class
