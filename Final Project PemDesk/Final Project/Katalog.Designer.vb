<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Katalog
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
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.dgv_katalog = New System.Windows.Forms.DataGridView()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_kembali2 = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.txb_harga = New System.Windows.Forms.TextBox()
        Me.txb_nama = New System.Windows.Forms.TextBox()
        Me.txb_kode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_stock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_katalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(688, 76)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(116, 85)
        Me.btn_tambah.TabIndex = 18
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'dgv_katalog
        '
        Me.dgv_katalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_katalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_katalog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode, Me.nama, Me.harga, Me.stock})
        Me.dgv_katalog.Location = New System.Drawing.Point(57, 180)
        Me.dgv_katalog.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgv_katalog.Name = "dgv_katalog"
        Me.dgv_katalog.RowHeadersWidth = 62
        Me.dgv_katalog.RowTemplate.Height = 28
        Me.dgv_katalog.Size = New System.Drawing.Size(747, 199)
        Me.dgv_katalog.TabIndex = 17
        '
        'kode
        '
        Me.kode.HeaderText = "Kode Menu"
        Me.kode.MinimumWidth = 8
        Me.kode.Name = "kode"
        Me.kode.ReadOnly = True
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Menu"
        Me.nama.MinimumWidth = 8
        Me.nama.Name = "nama"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 8
        Me.harga.Name = "harga"
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.MinimumWidth = 8
        Me.stock.Name = "stock"
        '
        'btn_kembali2
        '
        Me.btn_kembali2.Location = New System.Drawing.Point(660, 406)
        Me.btn_kembali2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btn_kembali2.Name = "btn_kembali2"
        Me.btn_kembali2.Size = New System.Drawing.Size(144, 39)
        Me.btn_kembali2.TabIndex = 13
        Me.btn_kembali2.Text = "Kembali"
        Me.btn_kembali2.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(581, 122)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(99, 39)
        Me.btn_hapus.TabIndex = 15
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(472, 122)
        Me.btn_ubah.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(101, 39)
        Me.btn_ubah.TabIndex = 16
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'txb_harga
        '
        Me.txb_harga.Location = New System.Drawing.Point(175, 139)
        Me.txb_harga.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txb_harga.Name = "txb_harga"
        Me.txb_harga.Size = New System.Drawing.Size(223, 22)
        Me.txb_harga.TabIndex = 10
        '
        'txb_nama
        '
        Me.txb_nama.Location = New System.Drawing.Point(175, 99)
        Me.txb_nama.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txb_nama.Name = "txb_nama"
        Me.txb_nama.Size = New System.Drawing.Size(267, 22)
        Me.txb_nama.TabIndex = 11
        '
        'txb_kode
        '
        Me.txb_kode.Location = New System.Drawing.Point(175, 58)
        Me.txb_kode.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txb_kode.Name = "txb_kode"
        Me.txb_kode.ReadOnly = True
        Me.txb_kode.Size = New System.Drawing.Size(267, 22)
        Me.txb_kode.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Harga Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Kode Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Katalog Menu"
        '
        'txb_stock
        '
        Me.txb_stock.Location = New System.Drawing.Point(531, 76)
        Me.txb_stock.Name = "txb_stock"
        Me.txb_stock.Size = New System.Drawing.Size(149, 22)
        Me.txb_stock.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(469, 77)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Stock :"
        '
        'Katalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 471)
        Me.Controls.Add(Me.txb_stock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.dgv_katalog)
        Me.Controls.Add(Me.btn_kembali2)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.txb_harga)
        Me.Controls.Add(Me.txb_nama)
        Me.Controls.Add(Me.txb_kode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Katalog"
        Me.Text = "Katalog"
        CType(Me.dgv_katalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_tambah As Button
    Friend WithEvents dgv_katalog As DataGridView
    Friend WithEvents btn_kembali2 As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents txb_harga As TextBox
    Friend WithEvents txb_nama As TextBox
    Friend WithEvents txb_kode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents txb_stock As TextBox
    Friend WithEvents Label5 As Label
End Class
