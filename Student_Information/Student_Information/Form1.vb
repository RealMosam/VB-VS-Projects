Public Class Form1

    Private Sub StudentTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataDataSet.StudentTable' table. You can move, or remove it, as needed.
        Me.StudentTableTableAdapter.Fill(Me.StudentDataDataSet.StudentTable)

    End Sub

    Private Sub DepartmentLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PreBnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreBnt.Click
        Try
            StudentTableBindingSource.MovePrevious()
        Catch ex As Exception
            MsgBox("Error: End of previous.")
        End Try

    End Sub

    Private Sub NextBnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextBnt.Click
        Try
            StudentTableBindingSource.MoveNext()
        Catch ex As Exception
            MsgBox("Error: End of next.")
        End Try
    End Sub

    Private Sub SaveBnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBnt.Click
        Try
            StudentTableBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(StudentDataDataSet)
            MsgBox("Data Saved Successfully!")
        Catch ex As Exception
            MsgBox("Error: Unable to save data.")
        End Try
    End Sub

    Private Sub DeleteBnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBnt.Click
        Try
            StudentTableBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(StudentDataDataSet)
            MsgBox("Current Record Deleted Successfully!")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddBnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBnt.Click
        Try
            StudentTableBindingSource.AddNew()
        Catch ex1 As Exception
            MsgBox("Error: Please recheck the fields and try again.")
        End Try

    End Sub

    Private Sub EditBnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBnt.Click
        Application.Exit()


    End Sub
End Class
