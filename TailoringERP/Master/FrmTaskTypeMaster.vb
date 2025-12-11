Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class FrmTaskTypeMaster

#Region "Declare"
    Dim con As New SqlConnection("Data Source=DESKTOP-CFFNINL\SUNRISE;Initial Catalog=dbSTE_Demo;Integrated Security=True;TrustServerCertificate=True;")
    Dim TaskTypeId As Integer = 0
    Dim edit_insert As Integer = -1
#End Region

#Region "Functions"

    Private Function ValidateInputs() As Boolean

        If txtTaskType.Text.Trim() = "" Then
            MsgBox("Enter Task Type.", MsgBoxStyle.Exclamation)
            txtTaskType.Focus()
            Return False
        End If

        If txtTaskDetail.Text.Trim() = "" Then
            MsgBox("Enter Task Detail.", MsgBoxStyle.Exclamation)
            txtTaskDetail.Focus()
            Return False
        End If

        If ColorPickEdit1.EditValue Is Nothing Then
            MsgBox("Select Color.", MsgBoxStyle.Exclamation)
            Return False
        End If

        Return True
    End Function

#End Region

#Region "Methods"

    Private Sub ClearFields()
        txtTaskType.Text = ""
        txtTaskDetail.Text = ""
        ColorPickEdit1.EditValue = Nothing
        TaskTypeId = 0
    End Sub

    Private Sub DisableControls()
        gbTask.Enabled = False

        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False

        edit_insert = -1
    End Sub
    Private Sub RefreshForm()
        LoadGrid()
        ClearFields()
        DisableControls()
        edit_insert = -1
    End Sub

    Private Sub EnableControls()
        gbTask.Enabled = True

        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
    End Sub

    Private Sub LoadGrid()
        Try
            Dim da As New SqlDataAdapter("SELECT * FROM tbl_TaskTypeMaster ORDER BY TaskTypeId DESC", con)
            Dim dt As New DataTable
            da.Fill(dt)


            For Each row As DataRow In dt.Rows
                If row("TaskColor") IsNot DBNull.Value Then
                    Dim colorValue As String = row("TaskColor").ToString().Trim()

                    If colorValue.StartsWith("#") Then
                        row("TaskColor") = ColorTranslator.FromHtml(colorValue)
                    ElseIf IsNumeric(colorValue) Then
                        Dim argb As Integer
                        If Integer.TryParse(colorValue, argb) Then
                            row("TaskColor") = Color.FromArgb(argb)
                        End If
                    End If
                End If
            Next

            gcData.DataSource = dt

            ' Hide TaskTypeId
            If gvData.Columns.ColumnByFieldName("TaskTypeId") IsNot Nothing Then
                gvData.Columns("TaskTypeId").Visible = False
            End If

            ' Display Color in Grid
            Dim colorRepo As New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
            gcData.RepositoryItems.Add(colorRepo)

            If gvData.Columns.ColumnByFieldName("TaskColor") IsNot Nothing Then
                gvData.Columns("TaskColor").ColumnEdit = colorRepo
                gvData.Columns("TaskColor").Caption = "Color"
                gvData.Columns("TaskColor").Width = 80
            End If

            gvData.BestFitColumns()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub InsertRecord()
        Try
            Dim qry As String =
                    "INSERT INTO tbl_TaskTypeMaster (TaskType, TaskDetail, TaskDocId, SOPId, TaskColor)
                     VALUES (@TaskType, @TaskDetail, 0, 0, @TaskColor)"

            Dim cmd As New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@TaskType", txtTaskType.Text)
            cmd.Parameters.AddWithValue("@TaskDetail", txtTaskDetail.Text)

            cmd.Parameters.AddWithValue("@TaskColor", ColorTranslator.ToHtml(ColorPickEdit1.Color))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Record Saved.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    Private Sub UpdateRecord()
        Try
            Dim qry As String =
                    "UPDATE tbl_TaskTypeMaster SET
                     TaskType=@TaskType,
                     TaskDetail=@TaskDetail,
                     TaskColor=@TaskColor
                     WHERE TaskTypeId=@ID"

            Dim cmd As New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@TaskType", txtTaskType.Text)
            cmd.Parameters.AddWithValue("@TaskDetail", txtTaskDetail.Text)
            cmd.Parameters.AddWithValue("@TaskColor", ColorTranslator.ToHtml(ColorPickEdit1.Color))
            cmd.Parameters.AddWithValue("@ID", TaskTypeId)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Record Updated.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    Private Sub DeleteRecord()
        Try
            Dim qry As String = "DELETE FROM tbl_TaskTypeMaster WHERE TaskTypeId=@ID"

            Dim cmd As New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@ID", TaskTypeId)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Record Deleted.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

#End Region

#Region "Events"
    Private Sub FrmTaskTypeMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        DisableControls()
        RefreshForm()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ClearFields()
        EnableControls()
        txtTaskType.Focus()
        edit_insert = 1
        TaskTypeId = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Exit Sub

        If edit_insert = 1 Then
            InsertRecord()
        ElseIf edit_insert = 0 Then
            UpdateRecord()
        Else
            MsgBox("Invalid operation.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        LoadGrid()
        ClearFields()
        DisableControls()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TaskTypeId = 0 Then
            MsgBox("Select a record first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        EnableControls()
        txtTaskType.Focus()
        edit_insert = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearFields()
        DisableControls()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If TaskTypeId = 0 Then
            MsgBox("Select a record first.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DeleteRecord()
            LoadGrid()
            ClearFields()
            DisableControls()
        End If
    End Sub


    Private Sub gvData_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) _
    Handles gvData.RowClick

        Try
            TaskTypeId = CInt(gvData.GetRowCellValue(e.RowHandle, "TaskTypeId"))

            txtTaskType.Text = gvData.GetRowCellValue(e.RowHandle, "TaskType").ToString()
            txtTaskDetail.Text = gvData.GetRowCellValue(e.RowHandle, "TaskDetail").ToString()


            Dim colorValue As String = gvData.GetRowCellValue(e.RowHandle, "TaskColor").ToString().Trim()

            If String.IsNullOrWhiteSpace(colorValue) Then
                ColorPickEdit1.EditValue = Nothing
            ElseIf colorValue.StartsWith("#") Then
                ColorPickEdit1.EditValue = ColorTranslator.FromHtml(colorValue)
            ElseIf IsNumeric(colorValue) Then
                Dim argb As Integer
                If Integer.TryParse(colorValue, argb) Then
                    ColorPickEdit1.EditValue = Color.FromArgb(argb)
                Else
                    ColorPickEdit1.EditValue = Nothing
                End If
            Else

                ColorPickEdit1.EditValue = Nothing
            End If

            btnAdd.Enabled = False
            btnSave.Enabled = False
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnCancel.Enabled = True

        Catch ex As Exception
            MsgBox("Error while loading color: " & ex.Message)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshForm()
    End Sub

    Private Sub txt_TaskType_TextChanged(sender As Object, e As EventArgs) Handles txt_TaskType.TextChanged
        Try
            Dim searchText As String = txt_TaskType.Text.Trim()

            If searchText = "" Then
                gvData.ActiveFilter.Clear()
            Else
                gvData.ActiveFilterString = $"[TaskType] LIKE '%{searchText}%'"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

End Class
