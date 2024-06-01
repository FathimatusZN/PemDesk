<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karyawan
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
        Me.btn_kembali3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txb_namakar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_shift = New System.Windows.Forms.TextBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.cbo_jeniskelamin = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_kembali3
        '
        Me.btn_kembali3.Location = New System.Drawing.Point(31, 389)
        Me.btn_kembali3.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_kembali3.Name = "btn_kembali3"
        Me.btn_kembali3.Size = New System.Drawing.Size(108, 41)
        Me.btn_kembali3.TabIndex = 12
        Me.btn_kembali3.Text = "Kembali"
        Me.btn_kembali3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 143)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(738, 223)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama Karyawan"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Jenis Kelamin"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Shift"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "No. Telp"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'txb_namakar
        '
        Me.txb_namakar.Location = New System.Drawing.Point(139, 66)
        Me.txb_namakar.Margin = New System.Windows.Forms.Padding(4)
        Me.txb_namakar.Name = "txb_namakar"
        Me.txb_namakar.Size = New System.Drawing.Size(249, 22)
        Me.txb_namakar.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Kelamin : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Karyawan"
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(663, 56)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(106, 40)
        Me.btn_simpan.TabIndex = 13
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(422, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Shift :"
        '
        'txb_shift
        '
        Me.txb_shift.Location = New System.Drawing.Point(484, 68)
        Me.txb_shift.Name = "txb_shift"
        Me.txb_shift.Size = New System.Drawing.Size(111, 22)
        Me.txb_shift.TabIndex = 14
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(663, 102)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(106, 34)
        Me.btn_edit.TabIndex = 15
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'cbo_jeniskelamin
        '
        Me.cbo_jeniskelamin.FormattingEnabled = True
        Me.cbo_jeniskelamin.Location = New System.Drawing.Point(139, 97)
        Me.cbo_jeniskelamin.Name = "cbo_jeniskelamin"
        Me.cbo_jeniskelamin.Size = New System.Drawing.Size(249, 24)
        Me.cbo_jeniskelamin.TabIndex = 16
        '
        'Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbo_jeniskelamin)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.txb_shift)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_kembali3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txb_namakar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Karyawan"
        Me.Text = "stock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_kembali3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txb_namakar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txb_shift As TextBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cbo_jeniskelamin As ComboBox
End Class
