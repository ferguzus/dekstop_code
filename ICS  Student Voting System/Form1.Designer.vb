<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.admin_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.admin_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox6 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox8 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admin_username
        '
        Me.admin_username.BorderRadius = 4
        Me.admin_username.BorderThickness = 2
        Me.admin_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_username.DefaultText = ""
        Me.admin_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_username.FocusedState.BorderColor = System.Drawing.Color.LimeGreen
        Me.admin_username.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold)
        Me.admin_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.admin_username.Location = New System.Drawing.Point(139, 191)
        Me.admin_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.admin_username.Name = "admin_username"
        Me.admin_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_username.PlaceholderText = "Your username"
        Me.admin_username.SelectedText = ""
        Me.admin_username.Size = New System.Drawing.Size(262, 38)
        Me.admin_username.TabIndex = 116
        Me.admin_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'admin_password
        '
        Me.admin_password.BorderRadius = 4
        Me.admin_password.BorderThickness = 2
        Me.admin_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_password.DefaultText = ""
        Me.admin_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_password.FocusedState.BorderColor = System.Drawing.Color.LimeGreen
        Me.admin_password.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold)
        Me.admin_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.admin_password.Location = New System.Drawing.Point(139, 262)
        Me.admin_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.admin_password.Name = "admin_password"
        Me.admin_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.admin_password.PlaceholderText = "Your password"
        Me.admin_password.SelectedText = ""
        Me.admin_password.Size = New System.Drawing.Size(262, 38)
        Me.admin_password.TabIndex = 114
        Me.admin_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.admin_password.UseSystemPasswordChar = True
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(141, 243)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(58, 21)
        Me.Guna2HtmlLabel9.TabIndex = 113
        Me.Guna2HtmlLabel9.Text = "Password"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(206, 88)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(135, 39)
        Me.Guna2HtmlLabel10.TabIndex = 112
        Me.Guna2HtmlLabel10.Text = "Admin Login"
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(140, 172)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(62, 21)
        Me.Guna2HtmlLabel11.TabIndex = 110
        Me.Guna2HtmlLabel11.Text = "Username"
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.BorderRadius = 2
        Me.Guna2PictureBox5.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(207, 122)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(30, 5)
        Me.Guna2PictureBox5.TabIndex = 117
        Me.Guna2PictureBox5.TabStop = False
        '
        'Guna2PictureBox6
        '
        Me.Guna2PictureBox6.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox6.Image = CType(resources.GetObject("Guna2PictureBox6.Image"), System.Drawing.Image)
        Me.Guna2PictureBox6.ImageRotate = 0!
        Me.Guna2PictureBox6.Location = New System.Drawing.Point(139, 85)
        Me.Guna2PictureBox6.Name = "Guna2PictureBox6"
        Me.Guna2PictureBox6.Size = New System.Drawing.Size(50, 50)
        Me.Guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox6.TabIndex = 111
        Me.Guna2PictureBox6.TabStop = False
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BackColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.BorderRadius = 4
        Me.Guna2GradientButton1.BorderThickness = 2
        Me.Guna2GradientButton1.CheckedState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.CheckedState.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.CheckedState.FillColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientButton1.CheckedState.ForeColor = System.Drawing.Color.Red
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.Red
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(216, 380)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(118, 38)
        Me.Guna2GradientButton1.TabIndex = 119
        Me.Guna2GradientButton1.Text = "Exit"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderRadius = 4
        Me.Guna2CustomGradientPanel1.BorderThickness = 2
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_login)
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(12, 43)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(510, 421)
        Me.Guna2CustomGradientPanel1.TabIndex = 120
        '
        'btn_login
        '
        Me.btn_login.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_login.BorderRadius = 4
        Me.btn_login.BorderThickness = 2
        Me.btn_login.CheckedState.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_login.CheckedState.FillColor = System.Drawing.Color.White
        Me.btn_login.CheckedState.ForeColor = System.Drawing.Color.LimeGreen
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.LimeGreen
        Me.btn_login.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.HoverState.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_login.HoverState.FillColor = System.Drawing.Color.White
        Me.btn_login.HoverState.ForeColor = System.Drawing.Color.LimeGreen
        Me.btn_login.Location = New System.Drawing.Point(127, 293)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(262, 38)
        Me.btn_login.TabIndex = 116
        Me.btn_login.Text = "Login"
        '
        'Guna2PictureBox8
        '
        Me.Guna2PictureBox8.Image = CType(resources.GetObject("Guna2PictureBox8.Image"), System.Drawing.Image)
        Me.Guna2PictureBox8.ImageRotate = 0!
        Me.Guna2PictureBox8.Location = New System.Drawing.Point(8, 5)
        Me.Guna2PictureBox8.Name = "Guna2PictureBox8"
        Me.Guna2PictureBox8.Size = New System.Drawing.Size(31, 30)
        Me.Guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox8.TabIndex = 122
        Me.Guna2PictureBox8.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 9)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(57, 25)
        Me.Guna2HtmlLabel1.TabIndex = 121
        Me.Guna2HtmlLabel1.Text = "CDM IRS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 476)
        Me.Controls.Add(Me.Guna2PictureBox8)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.Guna2PictureBox5)
        Me.Controls.Add(Me.admin_username)
        Me.Controls.Add(Me.admin_password)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Controls.Add(Me.Guna2PictureBox6)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents admin_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents admin_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox6 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2PictureBox8 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
End Class
