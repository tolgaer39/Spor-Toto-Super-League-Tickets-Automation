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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_biletsorgula = New System.Windows.Forms.Button()
        Me.btn_SatılanBiletler = New System.Windows.Forms.Button()
        Me.Btn_BiletSat = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Tarih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Takim1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Takim2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stat_Adi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.etkinlikid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_biletsorgula)
        Me.GroupBox1.Controls.Add(Me.btn_SatılanBiletler)
        Me.GroupBox1.Controls.Add(Me.Btn_BiletSat)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 363)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Haftanın Maçları"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Maç Tarihi :"
        '
        'btn_biletsorgula
        '
        Me.btn_biletsorgula.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_biletsorgula.Location = New System.Drawing.Point(511, 42)
        Me.btn_biletsorgula.Name = "btn_biletsorgula"
        Me.btn_biletsorgula.Size = New System.Drawing.Size(209, 22)
        Me.btn_biletsorgula.TabIndex = 5
        Me.btn_biletsorgula.Text = "Bilet Sorgulama"
        Me.btn_biletsorgula.UseVisualStyleBackColor = False
        '
        'btn_SatılanBiletler
        '
        Me.btn_SatılanBiletler.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_SatılanBiletler.Location = New System.Drawing.Point(376, 313)
        Me.btn_SatılanBiletler.Name = "btn_SatılanBiletler"
        Me.btn_SatılanBiletler.Size = New System.Drawing.Size(345, 35)
        Me.btn_SatılanBiletler.TabIndex = 4
        Me.btn_SatılanBiletler.Text = "Satılan Biletler"
        Me.btn_SatılanBiletler.UseVisualStyleBackColor = False
        '
        'Btn_BiletSat
        '
        Me.Btn_BiletSat.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Btn_BiletSat.Location = New System.Drawing.Point(26, 313)
        Me.Btn_BiletSat.Name = "Btn_BiletSat"
        Me.Btn_BiletSat.Size = New System.Drawing.Size(344, 35)
        Me.Btn_BiletSat.TabIndex = 3
        Me.Btn_BiletSat.Text = "Bilet Sat"
        Me.Btn_BiletSat.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tarih, Me.Saat, Me.Takim1, Me.Takim2, Me.Stat_Adi, Me.etkinlikid})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(26, 88)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(694, 219)
        Me.DataGridView1.TabIndex = 2
        '
        'Tarih
        '
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Tarih.DefaultCellStyle = DataGridViewCellStyle7
        Me.Tarih.HeaderText = "Tarih"
        Me.Tarih.Name = "Tarih"
        Me.Tarih.ReadOnly = True
        Me.Tarih.Width = 80
        '
        'Saat
        '
        DataGridViewCellStyle8.Format = "t"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Saat.DefaultCellStyle = DataGridViewCellStyle8
        Me.Saat.HeaderText = "Saat"
        Me.Saat.MinimumWidth = 4
        Me.Saat.Name = "Saat"
        Me.Saat.ReadOnly = True
        Me.Saat.Width = 50
        '
        'Takim1
        '
        Me.Takim1.HeaderText = "Ev Sahibi"
        Me.Takim1.MinimumWidth = 4
        Me.Takim1.Name = "Takim1"
        Me.Takim1.ReadOnly = True
        Me.Takim1.Width = 165
        '
        'Takim2
        '
        Me.Takim2.HeaderText = "Rakip"
        Me.Takim2.MinimumWidth = 4
        Me.Takim2.Name = "Takim2"
        Me.Takim2.ReadOnly = True
        Me.Takim2.Width = 165
        '
        'Stat_Adi
        '
        Me.Stat_Adi.HeaderText = "Stat Adı"
        Me.Stat_Adi.Name = "Stat_Adi"
        Me.Stat_Adi.ReadOnly = True
        Me.Stat_Adi.Width = 230
        '
        'etkinlikid
        '
        Me.etkinlikid.HeaderText = "Etkinlik ID"
        Me.etkinlikid.Name = "etkinlikid"
        Me.etkinlikid.ReadOnly = True
        Me.etkinlikid.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.CustomFormat = "yyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(149, 21)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(778, 410)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_BiletSat As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_SatılanBiletler As System.Windows.Forms.Button
    Friend WithEvents btn_biletsorgula As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tarih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Takim1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Takim2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stat_Adi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents etkinlikid As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
