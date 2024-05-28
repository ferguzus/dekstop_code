Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub admin_username_TextChanged(sender As Object, e As EventArgs) Handles admin_username.TextChanged

    End Sub

    Private Sub admin_password_TextChanged(sender As Object, e As EventArgs) Handles admin_password.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel9_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel9.Click

    End Sub

    Private Sub Guna2HtmlLabel10_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel10.Click

    End Sub

    Private Sub Guna2HtmlLabel11_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel11.Click

    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click

    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click

    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub Guna2PictureBox8_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox8.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                ' Check if the username exists
                Dim storedPassword As String = String.Empty
                Using cmd As New MySqlCommand("SELECT `admin_password` FROM `admin` WHERE `admin_username` = @Username", conn)
                    cmd.Parameters.AddWithValue("@Username", admin_username.Text)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            storedPassword = dr("admin_password").ToString()
                        End If
                    End Using
                End Using

                ' If the username does not exist
                If String.IsNullOrEmpty(storedPassword) Then
                    MsgBox("Wrong username", vbCritical, "Login Failed")
                    admin_username.Clear()
                    Return
                End If

                ' Verify the password
                If BCrypt.Net.BCrypt.Verify(admin_password.Text, storedPassword) Then
                    MsgBox("Login success!", vbInformation, "Login")
                    Me.Hide()
                    Dim manageStudentForm As New Dashboard()
                    manageStudentForm.ShowDialog()
                    Me.Close()
                Else
                    MsgBox("Wrong password", vbCritical, "Login Failed")
                    admin_password.Clear()
                End If

            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, vbCritical, "Login Failed")
        End Try
    End Sub
End Class