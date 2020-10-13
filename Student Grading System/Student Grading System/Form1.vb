Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sublabel.Click

    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        TextBox2.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub convertbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertbtn.Click
        Try
            If TextBox1.Text < 40 Then
                TextBox2.Text = "F"
            Else
                If TextBox1.Text <= 50 Then
                    TextBox2.Text = "D"
                Else
                    If TextBox1.Text <= 60 Then
                        TextBox2.Text = "C"
                    Else
                        If TextBox1.Text <= 70 Then
                            TextBox2.Text = "B"
                        Else
                            If TextBox1.Text <= 80 Then
                                TextBox2.Text = "B+"
                            Else
                                If TextBox1.Text <= 90 Then
                                    TextBox2.Text = "A"
                                Else
                                    If TextBox1.Text <= 100 Then
                                        TextBox2.Text = "A+"
                                    Else
                                        If TextBox1.Text > 100 Then
                                            MsgBox("Please enter only integer values upto 100")
                                        End If
                                End If
                            End If
                        End If
                    End If
                End If
                End If
            End If
        Catch
            MsgBox("Error: Please enter only integer values upto 100")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
        Catch
            MsgBox("Error: Please select from drop down menu only.")
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub mainlabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainlabel.Click

    End Sub

    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbtn.Click
        Application.Exit()

    End Sub
End Class
