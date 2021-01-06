Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'report_dbDataSet.student' table. You can move, or remove it, as needed.
        Me.studentTableAdapter.Fill(Me.report_dbDataSet.student)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Report1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Report1ToolStripMenuItem.Click
        ReportViewer1.Visible = True
    End Sub
End Class
