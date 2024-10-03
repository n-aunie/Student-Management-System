<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblCreate = New Label()
        lblStudentManagement = New Label()
        lblFirst = New Label()
        lblPassword = New Label()
        lblEmail = New Label()
        lblLast = New Label()
        lblConfirm = New Label()
        btnCreate = New Button()
        txtFirst = New TextBox()
        txtLast = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtConfirm = New TextBox()
        SuspendLayout()
        ' 
        ' lblCreate
        ' 
        lblCreate.AutoSize = True
        lblCreate.Font = New Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblCreate.Location = New Point(230, 25)
        lblCreate.Name = "lblCreate"
        lblCreate.Size = New Size(327, 31)
        lblCreate.TabIndex = 1
        lblCreate.Text = "CREATE NEW ACCOUNT"
        ' 
        ' lblStudentManagement
        ' 
        lblStudentManagement.AutoSize = True
        lblStudentManagement.Font = New Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point)
        lblStudentManagement.Location = New Point(95, 110)
        lblStudentManagement.Name = "lblStudentManagement"
        lblStudentManagement.Size = New Size(117, 22)
        lblStudentManagement.TabIndex = 2
        lblStudentManagement.Text = "Your Details:"
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblFirst.Location = New Point(82, 160)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(112, 23)
        lblFirst.TabIndex = 3
        lblFirst.Text = "First Name : "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.Location = New Point(82, 283)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(95, 23)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password: "
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.Location = New Point(82, 243)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(59, 23)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email:"
        ' 
        ' lblLast
        ' 
        lblLast.AutoSize = True
        lblLast.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblLast.Location = New Point(82, 202)
        lblLast.Name = "lblLast"
        lblLast.Size = New Size(109, 23)
        lblLast.TabIndex = 6
        lblLast.Text = "Last Name : "
        ' 
        ' lblConfirm
        ' 
        lblConfirm.AutoSize = True
        lblConfirm.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblConfirm.Location = New Point(82, 320)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New Size(161, 23)
        lblConfirm.TabIndex = 7
        lblConfirm.Text = "Confirm Password:"
        ' 
        ' btnCreate
        ' 
        btnCreate.BackColor = SystemColors.ControlDark
        btnCreate.Location = New Point(307, 381)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(164, 29)
        btnCreate.TabIndex = 8
        btnCreate.Text = "CREATE ACCOUNT"
        btnCreate.UseVisualStyleBackColor = False
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(200, 160)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(241, 27)
        txtFirst.TabIndex = 9
        ' 
        ' txtLast
        ' 
        txtLast.Location = New Point(197, 202)
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(241, 27)
        txtLast.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(197, 243)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(241, 27)
        txtEmail.TabIndex = 11
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(197, 282)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(241, 27)
        txtPassword.TabIndex = 12
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Location = New Point(249, 319)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(241, 27)
        txtConfirm.TabIndex = 13
        ' 
        ' CreateAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(txtConfirm)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtLast)
        Controls.Add(txtFirst)
        Controls.Add(btnCreate)
        Controls.Add(lblConfirm)
        Controls.Add(lblLast)
        Controls.Add(lblEmail)
        Controls.Add(lblPassword)
        Controls.Add(lblFirst)
        Controls.Add(lblStudentManagement)
        Controls.Add(lblCreate)
        Name = "CreateAccount"
        Text = "REGISTRATION PAGE"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblCreate As Label
    Friend WithEvents lblStudentManagement As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblConfirm As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirm As TextBox
End Class
