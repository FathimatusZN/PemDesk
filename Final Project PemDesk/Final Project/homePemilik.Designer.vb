<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homePemilik
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
        Me.btn_laporan = New System.Windows.Forms.Button()
        Me.btn_katalog = New System.Windows.Forms.Button()
        Me.btn_karyawan = New System.Windows.Forms.Button()
        Me.btn_keluar2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_laporan
        '
        Me.btn_laporan.Location = New System.Drawing.Point(355, 134)
        Me.btn_laporan.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_laporan.Name = "btn_laporan"
        Me.btn_laporan.Size = New System.Drawing.Size(155, 60)
        Me.btn_laporan.TabIndex = 0
        Me.btn_laporan.Text = "Laporan"
        Me.btn_laporan.UseVisualStyleBackColor = True
        '
        'btn_katalog
        '
        Me.btn_katalog.Location = New System.Drawing.Point(355, 209)
        Me.btn_katalog.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_katalog.Name = "btn_katalog"
        Me.btn_katalog.Size = New System.Drawing.Size(155, 63)
        Me.btn_katalog.TabIndex = 1
        Me.btn_katalog.Text = "Katalog"
        Me.btn_katalog.UseVisualStyleBackColor = True
        '
        'btn_karyawan
        '
        Me.btn_karyawan.Location = New System.Drawing.Point(355, 286)
        Me.btn_karyawan.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_karyawan.Name = "btn_karyawan"
        Me.btn_karyawan.Size = New System.Drawing.Size(155, 60)
        Me.btn_karyawan.TabIndex = 2
        Me.btn_karyawan.Text = "Karyawan"
        Me.btn_karyawan.UseVisualStyleBackColor = True
        '
        'btn_keluar2
        '
        Me.btn_keluar2.Location = New System.Drawing.Point(355, 362)
        Me.btn_keluar2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_keluar2.Name = "btn_keluar2"
        Me.btn_keluar2.Size = New System.Drawing.Size(155, 60)
        Me.btn_keluar2.TabIndex = 3
        Me.btn_keluar2.Text = "Keluar"
        Me.btn_keluar2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 55)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome, Pemilik!"
        '
        'homePemilik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 471)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_keluar2)
        Me.Controls.Add(Me.btn_karyawan)
        Me.Controls.Add(Me.btn_katalog)
        Me.Controls.Add(Me.btn_laporan)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "homePemilik"
        Me.Text = "homePemilik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_laporan As Button
    Friend WithEvents btn_katalog As Button
    Friend WithEvents btn_karyawan As Button
    Friend WithEvents btn_keluar2 As Button
    Friend WithEvents Label1 As Label
End Class
