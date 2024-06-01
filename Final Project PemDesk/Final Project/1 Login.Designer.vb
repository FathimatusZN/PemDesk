<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txb_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_password = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rb_pemilik = New System.Windows.Forms.RadioButton()
        Me.rbKasir = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kedai KUQURUYUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'txb_username
        '
        Me.txb_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_username.Location = New System.Drawing.Point(379, 174)
        Me.txb_username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txb_username.Name = "txb_username"
        Me.txb_username.Size = New System.Drawing.Size(228, 30)
        Me.txb_username.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'txb_password
        '
        Me.txb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txb_password.Location = New System.Drawing.Point(379, 218)
        Me.txb_password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txb_password.Name = "txb_password"
        Me.txb_password.Size = New System.Drawing.Size(228, 30)
        Me.txb_password.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(379, 266)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(151, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(350, 329)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(172, 41)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pilih role"
        '
        'rb_pemilik
        '
        Me.rb_pemilik.AutoSize = True
        Me.rb_pemilik.Location = New System.Drawing.Point(379, 135)
        Me.rb_pemilik.Name = "rb_pemilik"
        Me.rb_pemilik.Size = New System.Drawing.Size(72, 20)
        Me.rb_pemilik.TabIndex = 6
        Me.rb_pemilik.TabStop = True
        Me.rb_pemilik.Text = "Pemilik"
        Me.rb_pemilik.UseVisualStyleBackColor = True
        '
        'rbKasir
        '
        Me.rbKasir.AutoSize = True
        Me.rbKasir.Location = New System.Drawing.Point(498, 135)
        Me.rbKasir.Name = "rbKasir"
        Me.rbKasir.Size = New System.Drawing.Size(58, 20)
        Me.rbKasir.TabIndex = 7
        Me.rbKasir.TabStop = True
        Me.rbKasir.Text = "Kasir"
        Me.rbKasir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 471)
        Me.Controls.Add(Me.rbKasir)
        Me.Controls.Add(Me.rb_pemilik)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txb_password)
        Me.Controls.Add(Me.txb_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txb_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_password As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents rb_pemilik As RadioButton
    Friend WithEvents rbKasir As RadioButton
End Class
