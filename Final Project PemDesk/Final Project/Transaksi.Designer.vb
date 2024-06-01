<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.dgv_transaksi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_riwayat_transaksi = New System.Windows.Forms.Button()
        Me.txb_nama = New System.Windows.Forms.TextBox()
        Me.txb_invoice = New System.Windows.Forms.TextBox()
        Me.txb_total = New System.Windows.Forms.TextBox()
        Me.cbo_menu = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Pembeli"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pilih Menu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(641, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total"
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(608, 52)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(96, 34)
        Me.btn_tambah.TabIndex = 1
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(608, 92)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(96, 36)
        Me.btn_hapus.TabIndex = 2
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(711, 52)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(107, 76)
        Me.btn_simpan.TabIndex = 3
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'dgv_transaksi
        '
        Me.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_transaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_transaksi.Location = New System.Drawing.Point(21, 144)
        Me.dgv_transaksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_transaksi.Name = "dgv_transaksi"
        Me.dgv_transaksi.RowHeadersWidth = 51
        Me.dgv_transaksi.RowTemplate.Height = 24
        Me.dgv_transaksi.Size = New System.Drawing.Size(796, 226)
        Me.dgv_transaksi.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama Item"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Harga"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jumlah"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sub Total"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'btn_riwayat_transaksi
        '
        Me.btn_riwayat_transaksi.Location = New System.Drawing.Point(21, 388)
        Me.btn_riwayat_transaksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_riwayat_transaksi.Name = "btn_riwayat_transaksi"
        Me.btn_riwayat_transaksi.Size = New System.Drawing.Size(139, 38)
        Me.btn_riwayat_transaksi.TabIndex = 5
        Me.btn_riwayat_transaksi.Text = "Riwayat Transaksi"
        Me.btn_riwayat_transaksi.UseVisualStyleBackColor = True
        '
        'txb_nama
        '
        Me.txb_nama.Location = New System.Drawing.Point(141, 60)
        Me.txb_nama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txb_nama.Name = "txb_nama"
        Me.txb_nama.Size = New System.Drawing.Size(224, 22)
        Me.txb_nama.TabIndex = 6
        '
        'txb_invoice
        '
        Me.txb_invoice.Location = New System.Drawing.Point(608, 14)
        Me.txb_invoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txb_invoice.Name = "txb_invoice"
        Me.txb_invoice.ReadOnly = True
        Me.txb_invoice.Size = New System.Drawing.Size(208, 22)
        Me.txb_invoice.TabIndex = 8
        '
        'txb_total
        '
        Me.txb_total.Location = New System.Drawing.Point(689, 388)
        Me.txb_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txb_total.Name = "txb_total"
        Me.txb_total.ReadOnly = True
        Me.txb_total.Size = New System.Drawing.Size(127, 22)
        Me.txb_total.TabIndex = 9
        '
        'cbo_menu
        '
        Me.cbo_menu.FormattingEnabled = True
        Me.cbo_menu.Location = New System.Drawing.Point(141, 91)
        Me.cbo_menu.Name = "cbo_menu"
        Me.cbo_menu.Size = New System.Drawing.Size(224, 24)
        Me.cbo_menu.TabIndex = 10
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 471)
        Me.Controls.Add(Me.cbo_menu)
        Me.Controls.Add(Me.txb_total)
        Me.Controls.Add(Me.txb_invoice)
        Me.Controls.Add(Me.txb_nama)
        Me.Controls.Add(Me.btn_riwayat_transaksi)
        Me.Controls.Add(Me.dgv_transaksi)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        CType(Me.dgv_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents dgv_transaksi As DataGridView
    Friend WithEvents btn_riwayat_transaksi As Button
    Friend WithEvents txb_nama As TextBox
    Friend WithEvents txb_invoice As TextBox
    Friend WithEvents txb_total As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cbo_menu As ComboBox
End Class
