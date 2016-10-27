<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_ucret = New System.Windows.Forms.Label()
        Me.tb_cizgi = New System.Windows.Forms.TextBox()
        Me.tb_barkod = New System.Windows.Forms.TextBox()
        Me.lbl_vezne = New System.Windows.Forms.Label()
        Me.lbl_satissaat = New System.Windows.Forms.Label()
        Me.lbl_satistarih = New System.Windows.Forms.Label()
        Me.lbl_statadi = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_koltuk = New System.Windows.Forms.Label()
        Me.lbl_blok = New System.Windows.Forms.Label()
        Me.lbl_tribun = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_tarih = New System.Windows.Forms.Label()
        Me.lbl_saat = New System.Windows.Forms.Label()
        Me.lbl_rakip = New System.Windows.Forms.Label()
        Me.lbl_evsahibi = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Button1.Location = New System.Drawing.Point(318, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Çıktısını Al"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_ucret)
        Me.GroupBox1.Controls.Add(Me.tb_cizgi)
        Me.GroupBox1.Controls.Add(Me.tb_barkod)
        Me.GroupBox1.Controls.Add(Me.lbl_vezne)
        Me.GroupBox1.Controls.Add(Me.lbl_satissaat)
        Me.GroupBox1.Controls.Add(Me.lbl_satistarih)
        Me.GroupBox1.Controls.Add(Me.lbl_statadi)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbl_koltuk)
        Me.GroupBox1.Controls.Add(Me.lbl_blok)
        Me.GroupBox1.Controls.Add(Me.lbl_tribun)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_tarih)
        Me.GroupBox1.Controls.Add(Me.lbl_saat)
        Me.GroupBox1.Controls.Add(Me.lbl_rakip)
        Me.GroupBox1.Controls.Add(Me.lbl_evsahibi)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(832, 215)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(697, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Düzenlenme Tarihi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(697, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Satıcı Şube"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(697, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bilet Fiyatı"
        '
        'lbl_ucret
        '
        Me.lbl_ucret.AutoSize = True
        Me.lbl_ucret.Location = New System.Drawing.Point(719, 86)
        Me.lbl_ucret.Name = "lbl_ucret"
        Me.lbl_ucret.Size = New System.Drawing.Size(36, 13)
        Me.lbl_ucret.TabIndex = 13
        Me.lbl_ucret.Text = "ücret"
        '
        'tb_cizgi
        '
        Me.tb_cizgi.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_cizgi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cizgi.Enabled = False
        Me.tb_cizgi.Location = New System.Drawing.Point(679, 0)
        Me.tb_cizgi.Multiline = True
        Me.tb_cizgi.Name = "tb_cizgi"
        Me.tb_cizgi.ReadOnly = True
        Me.tb_cizgi.Size = New System.Drawing.Size(12, 215)
        Me.tb_cizgi.TabIndex = 12
        Me.tb_cizgi.Text = "|||||||||||||||||||||||||||||||||"
        '
        'tb_barkod
        '
        Me.tb_barkod.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_barkod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_barkod.Enabled = False
        Me.tb_barkod.Location = New System.Drawing.Point(94, 37)
        Me.tb_barkod.Multiline = True
        Me.tb_barkod.Name = "tb_barkod"
        Me.tb_barkod.ReadOnly = True
        Me.tb_barkod.Size = New System.Drawing.Size(12, 143)
        Me.tb_barkod.TabIndex = 11
        '
        'lbl_vezne
        '
        Me.lbl_vezne.AutoSize = True
        Me.lbl_vezne.Location = New System.Drawing.Point(719, 130)
        Me.lbl_vezne.Name = "lbl_vezne"
        Me.lbl_vezne.Size = New System.Drawing.Size(64, 13)
        Me.lbl_vezne.TabIndex = 9
        Me.lbl_vezne.Text = "Vezne Adi"
        '
        'lbl_satissaat
        '
        Me.lbl_satissaat.AutoSize = True
        Me.lbl_satissaat.Location = New System.Drawing.Point(719, 50)
        Me.lbl_satissaat.Name = "lbl_satissaat"
        Me.lbl_satissaat.Size = New System.Drawing.Size(105, 13)
        Me.lbl_satissaat.TabIndex = 9
        Me.lbl_satissaat.Text = "Bilet satılma saat"
        '
        'lbl_satistarih
        '
        Me.lbl_satistarih.AutoSize = True
        Me.lbl_satistarih.Location = New System.Drawing.Point(719, 37)
        Me.lbl_satistarih.Name = "lbl_satistarih"
        Me.lbl_satistarih.Size = New System.Drawing.Size(107, 13)
        Me.lbl_satistarih.TabIndex = 9
        Me.lbl_satistarih.Text = "Bilet satılma tarih"
        '
        'lbl_statadi
        '
        Me.lbl_statadi.AutoSize = True
        Me.lbl_statadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_statadi.Location = New System.Drawing.Point(300, 66)
        Me.lbl_statadi.Name = "lbl_statadi"
        Me.lbl_statadi.Size = New System.Drawing.Size(110, 20)
        Me.lbl_statadi.TabIndex = 8
        Me.lbl_statadi.Text = "Stadyum Adı"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 163)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(547, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "---------------------------------------------------------------------------------" & _
    "---------------------------"
        '
        'lbl_koltuk
        '
        Me.lbl_koltuk.AutoSize = True
        Me.lbl_koltuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_koltuk.Location = New System.Drawing.Point(549, 160)
        Me.lbl_koltuk.Name = "lbl_koltuk"
        Me.lbl_koltuk.Size = New System.Drawing.Size(63, 20)
        Me.lbl_koltuk.TabIndex = 5
        Me.lbl_koltuk.Text = "Label7"
        '
        'lbl_blok
        '
        Me.lbl_blok.AutoSize = True
        Me.lbl_blok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_blok.Location = New System.Drawing.Point(374, 160)
        Me.lbl_blok.Name = "lbl_blok"
        Me.lbl_blok.Size = New System.Drawing.Size(63, 20)
        Me.lbl_blok.TabIndex = 5
        Me.lbl_blok.Text = "Label7"
        '
        'lbl_tribun
        '
        Me.lbl_tribun.AutoSize = True
        Me.lbl_tribun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_tribun.Location = New System.Drawing.Point(168, 160)
        Me.lbl_tribun.Name = "lbl_tribun"
        Me.lbl_tribun.Size = New System.Drawing.Size(63, 20)
        Me.lbl_tribun.TabIndex = 5
        Me.lbl_tribun.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(538, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "KOLTUK NO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(365, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "BLOK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "TRİBÜN"
        '
        'lbl_tarih
        '
        Me.lbl_tarih.AutoSize = True
        Me.lbl_tarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_tarih.Location = New System.Drawing.Point(301, 96)
        Me.lbl_tarih.Name = "lbl_tarih"
        Me.lbl_tarih.Size = New System.Drawing.Size(39, 16)
        Me.lbl_tarih.TabIndex = 1
        Me.lbl_tarih.Text = "Tarih"
        '
        'lbl_saat
        '
        Me.lbl_saat.AutoSize = True
        Me.lbl_saat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_saat.Location = New System.Drawing.Point(407, 96)
        Me.lbl_saat.Name = "lbl_saat"
        Me.lbl_saat.Size = New System.Drawing.Size(36, 16)
        Me.lbl_saat.TabIndex = 1
        Me.lbl_saat.Text = "Saat"
        '
        'lbl_rakip
        '
        Me.lbl_rakip.AutoSize = True
        Me.lbl_rakip.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_rakip.Location = New System.Drawing.Point(443, 28)
        Me.lbl_rakip.Name = "lbl_rakip"
        Me.lbl_rakip.Size = New System.Drawing.Size(67, 25)
        Me.lbl_rakip.TabIndex = 0
        Me.lbl_rakip.Text = "Rakip"
        '
        'lbl_evsahibi
        '
        Me.lbl_evsahibi.AutoSize = True
        Me.lbl_evsahibi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_evsahibi.Location = New System.Drawing.Point(134, 28)
        Me.lbl_evsahibi.Name = "lbl_evsahibi"
        Me.lbl_evsahibi.Size = New System.Drawing.Size(103, 25)
        Me.lbl_evsahibi.TabIndex = 0
        Me.lbl_evsahibi.Text = "Ev Sahibi"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(425, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "-"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(862, 275)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bilet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_statadi As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_koltuk As System.Windows.Forms.Label
    Friend WithEvents lbl_blok As System.Windows.Forms.Label
    Friend WithEvents lbl_tribun As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_saat As System.Windows.Forms.Label
    Friend WithEvents lbl_rakip As System.Windows.Forms.Label
    Friend WithEvents lbl_evsahibi As System.Windows.Forms.Label
    Friend WithEvents lbl_tarih As System.Windows.Forms.Label
    Friend WithEvents lbl_satistarih As System.Windows.Forms.Label
    Friend WithEvents lbl_satissaat As System.Windows.Forms.Label
    Friend WithEvents lbl_vezne As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents tb_barkod As System.Windows.Forms.TextBox
    Friend WithEvents tb_cizgi As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ucret As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
