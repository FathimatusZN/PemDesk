<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiwayatTransaksi
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
        Me.dgv_riwayat = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.txb_pemasukan = New System.Windows.Forms.TextBox()
        CType(Me.dgv_riwayat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Riwayat Transaksi"
        '
        'dgv_riwayat
        '
        Me.dgv_riwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_riwayat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_riwayat.Location = New System.Drawing.Point(16, 62)
        Me.dgv_riwayat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_riwayat.Name = "dgv_riwayat"
        Me.dgv_riwayat.RowHeadersWidth = 51
        Me.dgv_riwayat.Size = New System.Drawing.Size(824, 313)
        Me.dgv_riwayat.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. Invoice"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Pembeli"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Total"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(551, 399)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Pemasukan"
        '
        'btn_kembali
        '
        Me.btn_kembali.Location = New System.Drawing.Point(16, 399)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(191, 43)
        Me.btn_kembali.TabIndex = 2
        Me.btn_kembali.Text = "Kembali ke Transaksi"
        Me.btn_kembali.UseVisualStyleBackColor = True
        '
        'txb_pemasukan
        '
        Me.txb_pemasukan.Location = New System.Drawing.Point(679, 398)
        Me.txb_pemasukan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txb_pemasukan.Name = "txb_pemasukan"
        Me.txb_pemasukan.Size = New System.Drawing.Size(160, 22)
        Me.txb_pemasukan.TabIndex = 3
        '
        'RiwayatTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 471)
        Me.Controls.Add(Me.txb_pemasukan)
        Me.Controls.Add(Me.btn_kembali)
        Me.Controls.Add(Me.dgv_riwayat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RiwayatTransaksi"
        Me.Text = "RiwayatTransaksi"
        CType(Me.dgv_riwayat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_riwayat As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents txb_pemasukan As TextBox
End Class
