<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Kasir
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
        Me.btn_transaksi = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_riwayat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome, Kasir!"
        '
        'btn_transaksi
        '
        Me.btn_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transaksi.Location = New System.Drawing.Point(365, 138)
        Me.btn_transaksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_transaksi.Name = "btn_transaksi"
        Me.btn_transaksi.Size = New System.Drawing.Size(133, 53)
        Me.btn_transaksi.TabIndex = 4
        Me.btn_transaksi.Text = "Transaksi"
        Me.btn_transaksi.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(365, 282)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(133, 46)
        Me.btn_keluar.TabIndex = 6
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btn_riwayat
        '
        Me.btn_riwayat.Location = New System.Drawing.Point(365, 208)
        Me.btn_riwayat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_riwayat.Name = "btn_riwayat"
        Me.btn_riwayat.Size = New System.Drawing.Size(133, 47)
        Me.btn_riwayat.TabIndex = 7
        Me.btn_riwayat.Text = "Riwayat Transaksi"
        Me.btn_riwayat.UseVisualStyleBackColor = True
        '
        'Home_Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 471)
        Me.Controls.Add(Me.btn_riwayat)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_transaksi)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Home_Kasir"
        Me.Text = "Home_Kasir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_transaksi As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents btn_riwayat As Button
End Class
