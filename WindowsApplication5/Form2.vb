Public Class Form2

    Private satir As Integer
    Private datagridf1 As DataGridView
    Private kullaniciid As Integer
    Dim musteriid As Integer
    Dim satilankoltuksayisi As Integer
    Dim ucret As Integer

    Private Sub ekle(e As EventArgs, musteriid As Integer, ucret As Integer)
        Dim tarih As String = Now.Date
        Dim dizi As Array = tarih.Split(".")
        Dim yenitarih As String = dizi(2) & "/" & dizi(1) & "/" & dizi(0)
        Dim saat As String = TimeOfDay

        Try
            Dim adet As Integer = cb_Adet.SelectedItem
            For i As Integer = 1 To adet
                satilankoltuksayisi = Convert.ToInt32(Sorgu.satilankoltuksayisi(blokid, etkinlikid).rows(0)("sayi"))
                Sorgu.koltukekle(blokid, satilankoltuksayisi, etkinlikid)
                Dim koltukid As Integer = Sorgu.ensonkoltukidcek().rows(0)("koltuk_id")
                'MsgBox("koltuk id aldı")
                Sorgu.biletekle(etkinlikid, tribunid, blokid, koltukid, yenitarih, saat, kullaniciid)
                'MsgBox("bilet eklendi")
                Dim biletid As Integer = Sorgu.ensoneklenenbiletidcek().rows(0)("bilet_id")
                Sorgu.satisekle(musteriid, biletid)
                'MsgBox("satis eklendi")
                Form2_Load(Me, e)
                Dim f3 As New Form3(biletid)
                f3.Show()
            Next
        Catch ex As Exception
            MsgBox("bilet ekleme hatası")
        End Try
    End Sub
    Sub New(_satir As Integer, _datagridview1 As DataGridView, _kullaniciid As Integer)
        InitializeComponent()
        satir = _satir
        datagridf1 = _datagridview1
        kullaniciid = _kullaniciid
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''''PictureBox1.Load("myproject\1.jpg")
        lbl_Tarih.Text = datagridf1.Rows(satir).Cells(0).Value.ToString
        Lbl_Saat.Text = datagridf1.Rows(satir).Cells(1).Value.ToString
        Lbl_evsahibi.Text = datagridf1.Rows(satir).Cells(2).Value.ToString
        lbl_Rakip.Text = datagridf1.Rows(satir).Cells(3).Value.ToString
        lbl_stat.Text = datagridf1.Rows(satir).Cells(4).Value.ToString
        etkinlikid = Convert.ToInt32(datagridf1.Rows(satir).Cells(5).Value)
        Dim tablo = Sorgu.statadicek(lbl_stat.Text)
        statid = tablo.Rows(0)("Stat_id")
        'Dim statid1 As Integer = 6
        PictureBox1.ImageLocation = "C:\Users\Big Mex\Documents\Visual Studio 2012\Projects\28\WindowsApplication5\WindowsApplication5\image\" & statid & ".jpg"
        'MsgBox(PictureBox1.ImageLocation())




        cb_Tribun.ResetText()
        cb_Tribun.Items.Clear()
        cb_Blok.ResetText()
        cb_Blok.Items.Clear()
        Dim tribun = Sorgu.tribunadicek(statid)

        Try
            For i As Integer = 0 To tribun.Rows.Count - 1
                cb_Tribun.Items.Add(tribun.Rows(i)("Tribun_Adi"))
            Next
            cb_Tribun.SelectedItem = tribun.Rows(0)("Tribun_Adi")
            cb_Adet.SelectedItem = cb_Adet.Items.Item(0)
            btn_Buy.Enabled = True
            Dim tribun_id = Sorgu.tribunucretcek(cb_Tribun.Text, statid)
            tribunid = tribun_id.Rows(0)("Tribun_id")
            ucret = Convert.ToInt32(tribun_id.Rows(0)("Ücret"))
            tb_ucret.Text = ucret * Convert.ToInt32(cb_Adet.SelectedItem)
        Catch ex As Exception
            MsgBox("Tribun hatası")
            btn_Buy.Enabled = False
        End Try
        '''' tribün adlarını ekleme
    End Sub

    Private Sub cb_Tribun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Tribun.SelectedIndexChanged
        cb_Blok.ResetText()
        cb_Blok.Items.Clear()
        '''' tribün değişince tribünün id sine göre blokları ve ücreti değiştir
        Dim tribun_id = Sorgu.tribunucretcek(cb_Tribun.Text, statid)
        tribunid = tribun_id.Rows(0)("Tribun_id")
        ucret = Convert.ToInt32(tribun_id.Rows(0)("Ücret"))
        tb_ucret.Text = ucret * Convert.ToInt32(cb_Adet.SelectedItem)
        Dim blok = Sorgu.blokadicek(tribunid)
        For i As Integer = 0 To blok.Rows.Count - 1
            cb_Blok.Items.Add(blok.Rows(i)("Blok_Adi"))
        Next
        cb_Blok.SelectedItem = blok.Rows(0)("Blok_Adi")
        blokid = blok.Rows(0)("Blok_id")
    End Sub

    Private Sub cb_Blok_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Blok.SelectedIndexChanged
        Dim blok_id = Sorgu.blokidcek(cb_Blok.SelectedItem, tribunid)
        blokid = blok_id.Rows(0)("Blok_id")
        Dim maxkoltuksayisi As Integer = Convert.ToInt32(Sorgu.maxkoltuksayisi(blokid).rows(0)("max_koltuk_sayisi"))
        satilankoltuksayisi = Convert.ToInt32(Sorgu.satilankoltuksayisi(blokid, etkinlikid).rows(0)("sayi"))
        Dim boşkoltuksayisi As Integer = maxkoltuksayisi - satilankoltuksayisi
        If boşkoltuksayisi < 9 Then
            cb_Adet.Items.Clear()
            cb_Adet.ResetText()
            For i As Integer = 1 To boşkoltuksayisi
                cb_Adet.Items.Add(i)
            Next
        Else
            cb_Adet.Items.Clear()
            cb_Adet.ResetText()
            For i As Integer = 1 To 9
                cb_Adet.Items.Add(i)
            Next
            cb_Adet.SelectedIndex() = 0
        End If
        '''' kapasite yazdır- bilet satmak için kapasite işlemi yap
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub btn_Buy_Click(sender As Object, e As EventArgs) Handles btn_Buy.Click
        If Not tb_ad.Text = "" And Not tb_soyad.Text = "" And Not tb_Tel.Text = "" And Not tb_Adres.Text = "" And Not cb_Tribun.Text = "" And Not cb_Blok.Text = "" And Not cb_Adet.Text = "" Then
            Dim tcno As String = tb_tcno.Text
            Dim ad As String = tb_ad.Text
            Dim soyad As String = tb_soyad.Text
            Dim telefon As String = tb_Tel.Text
            Dim adres As String = tb_Adres.Text
            Try
                Dim musteriid = Sorgu.musteriidcek(tcno).rows(0)("musteri_id")
                ekle(e, musteriid, ucret)

            Catch ex As Exception
                Sorgu.musteriekle(ad, soyad, telefon, adres, tcno)
                musteriid = Sorgu.musteriidcek(tcno).rows(0)("musteri_id")
                ekle(e, musteriid, ucret)
            End Try

        Else
            MsgBox("Tüm Alanlar Doldurulmalıdır")
        End If
    End Sub

    Private Sub tb_tcno_leave(sender As Object, e As EventArgs) Handles tb_tcno.Leave
        Try
                Dim musteri = Sorgu.musteriidcek(tb_tcno.Text)
                'MsgBox("musteri aldı")
                musteriid = musteri.rows(0)("musteri_id")
                tb_ad.Text = musteri.rows(0)("musteri_adi").ToString
                tb_soyad.Text = musteri.rows(0)("musteri_soyadi").ToString
                tb_Tel.Text = musteri.rows(0)("telefon").ToString
                tb_Adres.Text = musteri.rows(0)("Adres").ToString
        Catch ex As Exception
            'MsgBox("musteri alamadı")
        End Try
    End Sub

    Private Sub cb_Adet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Adet.SelectedIndexChanged
        'Dim tribun_id = Sorgu.tribunucretcek(cb_Tribun.Text, statid)
        'tribunid = tribun_id.Rows(0)("Tribun_id")
        'ucret = Convert.ToInt32(tribun_id.Rows(0)("Ücret"))
        tb_ucret.Text = ucret * Convert.ToInt32(cb_Adet.SelectedItem)
    End Sub




    Private Sub tb_tcno_TextChanged(sender As Object, e As EventArgs) Handles tb_tcno.TextChanged
        If Not IsNumeric(tb_tcno.Text) Then
            tb_tcno.Text = ""
        End If
    End Sub
End Class