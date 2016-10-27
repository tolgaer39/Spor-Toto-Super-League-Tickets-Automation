<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_TribunEkle = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Blokekle = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_ucretguncelle = New System.Windows.Forms.Button()
        Me.cb_Tribun = New System.Windows.Forms.ComboBox()
        Me.tb_ucret = New System.Windows.Forms.TextBox()
        Me.cb_stat = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Tarih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Takim1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Takim2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stat_Adi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.etkinlikid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_MacEkle = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.vezneadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarih1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biletsay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kazanç = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cb_kullanicituru = New System.Windows.Forms.ComboBox()
        Me.btn_kullaniciekle = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btn_sifresıfırla = New System.Windows.Forms.Button()
        Me.lb_liste = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(19, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(757, 470)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(749, 444)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stat Kontrolleri"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(732, 313)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ekle"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ComboBox4)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.btn_TribunEkle)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(566, 119)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tribun Ekle"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(78, 22)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(387, 21)
        Me.ComboBox4.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tribun Adı"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(78, 62)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 21)
        Me.TextBox3.TabIndex = 6
        '
        'btn_TribunEkle
        '
        Me.btn_TribunEkle.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_TribunEkle.Location = New System.Drawing.Point(10, 89)
        Me.btn_TribunEkle.Name = "btn_TribunEkle"
        Me.btn_TribunEkle.Size = New System.Drawing.Size(457, 23)
        Me.btn_TribunEkle.TabIndex = 8
        Me.btn_TribunEkle.Text = "Tribün Ekle"
        Me.btn_TribunEkle.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Stat Adı"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(254, 61)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(116, 21)
        Me.TextBox5.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(204, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Ucret"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.ComboBox5)
        Me.GroupBox5.Controls.Add(Me.ComboBox3)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.btn_Blokekle)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TextBox4)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 144)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(566, 163)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Blok Ekle"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(320, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 21)
        Me.TextBox2.TabIndex = 12
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(78, 27)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(387, 21)
        Me.ComboBox5.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(79, 60)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(132, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Tribün"
        '
        'btn_Blokekle
        '
        Me.btn_Blokekle.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_Blokekle.Location = New System.Drawing.Point(10, 135)
        Me.btn_Blokekle.Name = "btn_Blokekle"
        Me.btn_Blokekle.Size = New System.Drawing.Size(457, 23)
        Me.btn_Blokekle.TabIndex = 13
        Me.btn_Blokekle.Text = "Blok Ekle"
        Me.btn_Blokekle.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Blok Adı"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Stat Adı"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(206, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Max Koltuk Sayısı"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(79, 91)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(116, 21)
        Me.TextBox4.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.btn_ucretguncelle)
        Me.GroupBox1.Controls.Add(Me.cb_Tribun)
        Me.GroupBox1.Controls.Add(Me.tb_ucret)
        Me.GroupBox1.Controls.Add(Me.cb_stat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Güncelle"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Tribün"
        '
        'btn_ucretguncelle
        '
        Me.btn_ucretguncelle.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_ucretguncelle.Location = New System.Drawing.Point(22, 86)
        Me.btn_ucretguncelle.Name = "btn_ucretguncelle"
        Me.btn_ucretguncelle.Size = New System.Drawing.Size(451, 23)
        Me.btn_ucretguncelle.TabIndex = 4
        Me.btn_ucretguncelle.Text = "Guncelle"
        Me.btn_ucretguncelle.UseVisualStyleBackColor = False
        '
        'cb_Tribun
        '
        Me.cb_Tribun.FormattingEnabled = True
        Me.cb_Tribun.Location = New System.Drawing.Point(85, 50)
        Me.cb_Tribun.Name = "cb_Tribun"
        Me.cb_Tribun.Size = New System.Drawing.Size(132, 21)
        Me.cb_Tribun.TabIndex = 2
        '
        'tb_ucret
        '
        Me.tb_ucret.Location = New System.Drawing.Point(286, 51)
        Me.tb_ucret.Name = "tb_ucret"
        Me.tb_ucret.Size = New System.Drawing.Size(76, 21)
        Me.tb_ucret.TabIndex = 3
        '
        'cb_stat
        '
        Me.cb_stat.FormattingEnabled = True
        Me.cb_stat.Location = New System.Drawing.Point(85, 19)
        Me.cb_stat.Name = "cb_stat"
        Me.cb_stat.Size = New System.Drawing.Size(388, 21)
        Me.cb_stat.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Stat Adı"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(240, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Ucret"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Controls.Add(Me.btn_MacEkle)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.ComboBox2)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(749, 444)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Maç Kontrolleri"
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
        Me.DataGridView1.Location = New System.Drawing.Point(21, 150)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(709, 272)
        Me.DataGridView1.TabIndex = 0
        '
        'Tarih
        '
        DataGridViewCellStyle13.Format = "d"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Tarih.DefaultCellStyle = DataGridViewCellStyle13
        Me.Tarih.HeaderText = "Tarih"
        Me.Tarih.Name = "Tarih"
        Me.Tarih.ReadOnly = True
        Me.Tarih.Width = 80
        '
        'Saat
        '
        DataGridViewCellStyle14.Format = "t"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Saat.DefaultCellStyle = DataGridViewCellStyle14
        Me.Saat.HeaderText = "Saat"
        Me.Saat.MinimumWidth = 4
        Me.Saat.Name = "Saat"
        Me.Saat.ReadOnly = True
        Me.Saat.Width = 49
        '
        'Takim1
        '
        Me.Takim1.HeaderText = "Ev Sahibi"
        Me.Takim1.MinimumWidth = 4
        Me.Takim1.Name = "Takim1"
        Me.Takim1.ReadOnly = True
        Me.Takim1.Width = 170
        '
        'Takim2
        '
        Me.Takim2.HeaderText = "Rakip"
        Me.Takim2.MinimumWidth = 4
        Me.Takim2.Name = "Takim2"
        Me.Takim2.ReadOnly = True
        Me.Takim2.Width = 170
        '
        'Stat_Adi
        '
        Me.Stat_Adi.HeaderText = "Stat Adı"
        Me.Stat_Adi.Name = "Stat_Adi"
        Me.Stat_Adi.ReadOnly = True
        Me.Stat_Adi.Width = 235
        '
        'etkinlikid
        '
        Me.etkinlikid.HeaderText = "Etkinlik ID"
        Me.etkinlikid.Name = "etkinlikid"
        Me.etkinlikid.ReadOnly = True
        Me.etkinlikid.Visible = False
        '
        'btn_MacEkle
        '
        Me.btn_MacEkle.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_MacEkle.Enabled = False
        Me.btn_MacEkle.Location = New System.Drawing.Point(21, 100)
        Me.btn_MacEkle.Name = "btn_MacEkle"
        Me.btn_MacEkle.Size = New System.Drawing.Size(709, 30)
        Me.btn_MacEkle.TabIndex = 5
        Me.btn_MacEkle.Text = "Maç Ekle"
        Me.btn_MacEkle.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(664, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Saat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tarih"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rakip"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ev Sahibi"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(668, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 21)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "hh:mm"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(21, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(158, 21)
        Me.DateTimePicker1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(426, 63)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(232, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(187, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(232, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(749, 444)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Kullanıcı Kontrolleri"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeight = 21
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vezneadi, Me.tarih1, Me.biletsay, Me.kazanç})
        Me.DataGridView2.Location = New System.Drawing.Point(308, 51)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(405, 344)
        Me.DataGridView2.TabIndex = 0
        '
        'vezneadi
        '
        Me.vezneadi.HeaderText = "Vezne Adı"
        Me.vezneadi.Name = "vezneadi"
        Me.vezneadi.ReadOnly = True
        '
        'tarih1
        '
        DataGridViewCellStyle16.Format = "d"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.tarih1.DefaultCellStyle = DataGridViewCellStyle16
        Me.tarih1.HeaderText = "Tarih"
        Me.tarih1.Name = "tarih1"
        Me.tarih1.ReadOnly = True
        '
        'biletsay
        '
        Me.biletsay.HeaderText = "Satılan Bilet Sayısı"
        Me.biletsay.Name = "biletsay"
        Me.biletsay.ReadOnly = True
        '
        'kazanç
        '
        Me.kazanç.HeaderText = "Kazanç"
        Me.kazanç.Name = "kazanç"
        Me.kazanç.ReadOnly = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextBox7)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.cb_kullanicituru)
        Me.GroupBox8.Controls.Add(Me.btn_kullaniciekle)
        Me.GroupBox8.Controls.Add(Me.TextBox6)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Location = New System.Drawing.Point(43, 263)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(254, 132)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Kullanıcı Ekle"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(104, 71)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(140, 21)
        Me.TextBox7.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Kullanıcı Şifresi"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Kullanıcı Türü"
        '
        'cb_kullanicituru
        '
        Me.cb_kullanicituru.FormattingEnabled = True
        Me.cb_kullanicituru.Location = New System.Drawing.Point(104, 18)
        Me.cb_kullanicituru.Name = "cb_kullanicituru"
        Me.cb_kullanicituru.Size = New System.Drawing.Size(140, 21)
        Me.cb_kullanicituru.TabIndex = 2
        '
        'btn_kullaniciekle
        '
        Me.btn_kullaniciekle.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_kullaniciekle.Location = New System.Drawing.Point(7, 97)
        Me.btn_kullaniciekle.Name = "btn_kullaniciekle"
        Me.btn_kullaniciekle.Size = New System.Drawing.Size(234, 23)
        Me.btn_kullaniciekle.TabIndex = 5
        Me.btn_kullaniciekle.Text = "Kullanıcı Ekle"
        Me.btn_kullaniciekle.UseVisualStyleBackColor = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(104, 46)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(140, 21)
        Me.TextBox6.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kullanıcı Adı"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btn_sifresıfırla)
        Me.GroupBox7.Controls.Add(Me.lb_liste)
        Me.GroupBox7.Location = New System.Drawing.Point(43, 46)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(254, 211)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Kullanıcılar"
        '
        'btn_sifresıfırla
        '
        Me.btn_sifresıfırla.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_sifresıfırla.Location = New System.Drawing.Point(7, 182)
        Me.btn_sifresıfırla.Name = "btn_sifresıfırla"
        Me.btn_sifresıfırla.Size = New System.Drawing.Size(238, 23)
        Me.btn_sifresıfırla.TabIndex = 1
        Me.btn_sifresıfırla.Text = "Şifreyi Sıfırla"
        Me.btn_sifresıfırla.UseVisualStyleBackColor = False
        '
        'lb_liste
        '
        Me.lb_liste.FormattingEnabled = True
        Me.lb_liste.Location = New System.Drawing.Point(7, 19)
        Me.lb_liste.Name = "lb_liste"
        Me.lb_liste.Size = New System.Drawing.Size(237, 160)
        Me.lb_liste.TabIndex = 0
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(791, 485)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Kontrol"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btn_MacEkle As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_stat As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cb_Tribun As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tb_ucret As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents btn_TribunEkle As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_ucretguncelle As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Blokekle As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cb_kullanicituru As System.Windows.Forms.ComboBox
    Friend WithEvents btn_kullaniciekle As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_sifresıfırla As System.Windows.Forms.Button
    Friend WithEvents lb_liste As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents vezneadi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tarih1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biletsay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kazanç As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tarih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Takim1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Takim2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stat_Adi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents etkinlikid As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
