<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        lblLoginPage = New Label()
        lblStudentManagement = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        linkForgot = New LinkLabel()
        btnLogin = New Button()
        linkaccount = New LinkLabel()
        SuspendLayout()
        ' 
        ' lblLoginPage
        ' 
        lblLoginPage.AutoSize = True
        lblLoginPage.Font = New Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblLoginPage.Location = New Point(245, 30)
        lblLoginPage.Name = "lblLoginPage"
        lblLoginPage.Size = New Size(182, 31)
        lblLoginPage.TabIndex = 0
        lblLoginPage.Text = "LOGIN PAGE"
        ' 
        ' lblStudentManagement
        ' 
        lblStudentManagement.AutoSize = True
        lblStudentManagement.Font = New Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudentManagement.Location = New Point(138, 111)
        lblStudentManagement.Name = "lblStudentManagement"
        lblStudentManagement.Size = New Size(322, 29)
        lblStudentManagement.TabIndex = 1
        lblStudentManagement.Text = "Student Manangement System"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.Location = New Point(76, 201)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(104, 23)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username : "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.Location = New Point(76, 262)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(100, 23)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password : "
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(186, 200)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(241, 27)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(186, 262)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(241, 27)
        txtPassword.TabIndex = 5
        ' 
        ' linkForgot
        ' 
        linkForgot.AutoSize = True
        linkForgot.Location = New Point(424, 306)
        linkForgot.Name = "linkForgot"
        linkForgot.Size = New Size(125, 20)
        linkForgot.TabIndex = 6
        linkForgot.TabStop = True
        linkForgot.Text = "Forgot Password?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ControlDark
        btnLogin.Location = New Point(236, 326)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 7
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' linkaccount
        ' 
        linkaccount.AutoSize = True
        linkaccount.Location = New Point(201, 370)
        linkaccount.Name = "linkaccount"
        linkaccount.Size = New Size(163, 20)
        linkaccount.TabIndex = 8
        linkaccount.TabStop = True
        linkaccount.Text = "Don't have an account?"
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(linkaccount)
        Controls.Add(btnLogin)
        Controls.Add(linkForgot)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblStudentManagement)
        Controls.Add(lblLoginPage)
        Name = "LoginPage"
        Text = "Login Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLoginPage As Label
    Friend WithEvents lblStudentManagement As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents linkForgot As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents linkaccount As LinkLabel
End Class
