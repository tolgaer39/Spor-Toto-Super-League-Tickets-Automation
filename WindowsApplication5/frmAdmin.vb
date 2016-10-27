Public Class frmAdmin

    Private kullaniciid As String

    Sub New(_kullaniciid As String)
        InitializeComponent()
        kullaniciid = _kullaniciid
    End Sub
    Private Function saatmi() As Boolean
        Dim parcalar = TextBox1.Text.Split(":")
        If parcalar.Count < 2 Then Return False
        If (IsNumeric(parcalar(0)) And IsNumeric(parcalar(1))) Then
            If parcalar(0).Length = 2 And parcalar(1).Length = 2 Then
                If parcalar(0) >= 0 And parcalar(0) < 24 And parcalar(1) >= 0 And parcalar(1) < 60 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
            Else
                Return False
        End If
    End Function
    Public Sub zaman()
        Try
            If DateTimePicker1.Value < Now.ToShortDateString Then
                btn_MacEkle.Enabled = False
            ElseIf DateTimePicker1.Value > Now.ToShortDateString Then
                btn_MacEkle.Enabled = True
            ElseIf DateTimePicker1.Value = Now.ToShortDateString Then
                If saatmi() Then
                    If TextBox1.Text < Now.ToShortTimeString.ToString Then
                        btn_MacEkle.Enabled = False
                    Else
                        btn_MacEkle.Enabled = True
                    End If
                Else
                    btn_MacEkle.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Zaman hata")
        End Try
    End Sub
    Sub listele()
        Dim etkinlikid As Integer
        DataGridView1.Rows.Clear()
        Dim zaman As String = DateTimePicker1.Value
        Dim yenizaman() As String = zaman.Split(".")
        zaman = yenizaman(2) & "-" & yenizaman(1) & "-" & yenizaman(0)
        Dim etkinlik = Sorgu.etkinlikidcek(zaman)
        Try
            For i As Integer = 0 To etkinlik.Rows.Count - 1
                etkinlikid = etkinlik.Rows(i)("Etkinlik_id")
                Dim evsahibi = Sorgu.takimadicek("Ev_sahibi_id", etkinlikid)
                Dim rakip = Sorgu.takimadicek("rakip_id", etkinlikid)
                Dim stat = Sorgu.statadicek(etkinlikid)
                Dim tarihsaat = Sorgu.tarihsaatcek(etkinlikid)
                DataGridView1.Rows.Add(tarihsaat.Rows(0)("Tarih"), tarihsaat.Rows(0)("saat"), evsahibi.Rows(0)("Takim_Adi"), rakip.Rows(0)("Takim_Adi"), stat.Rows(0)("Stat_Adi"), etkinlikid)
            Next
        Catch ex As Exception
            MsgBox("Listeleme Hatası")
        End Try
    End Sub
    Private Sub TakimAdiCek()
        DataGridView1.Rows.Clear()
        Dim zaman As String = DateTimePicker1.Text
        ComboBox1.Items.Clear()
        ComboBox1.ResetText()
        Dim takimadi = Sorgu.tarihtekitakimlar(zaman)
        Try
            For i As Integer = 0 To takimadi.rows.count - 1
                ComboBox1.Items.Add(takimadi.rows(i)("Takim_adi"))
            Next
            ComboBox1.SelectedItem = ComboBox1.Items.Item(0)
        Catch ex As Exception
            MsgBox("Takim ekleme hatası ")
        End Try
        listele()
    End Sub
    Private Sub stadcek()
        cb_stat.Items.Clear()
        cb_stat.ResetText()
        ComboBox4.Items.Clear()
        ComboBox4.ResetText()
        ComboBox5.Items.Clear()
        ComboBox5.ResetText()
        Dim statlar = Sorgu.butunstatlar()
        For i As Integer = 0 To statlar.rows.count - 1
            cb_stat.Items.Add(statlar.rows(i)("stat_adi"))
            ComboBox4.Items.Add(statlar.rows(i)("stat_adi"))
            ComboBox5.Items.Add(statlar.rows(i)("stat_adi"))
        Next

        cb_stat.SelectedItem = cb_stat.Items.Item(0)
        ComboBox4.SelectedItem = cb_stat.Items.Item(0)
        ComboBox5.SelectedItem = cb_stat.Items.Item(0)
    End Sub
    Private Sub kullanicicek()
        lb_liste.Items.Clear()
        Dim kullanici = Sorgu.kullanicicek()
        For i As Integer = 0 To kullanici.rows.count - 1
            lb_liste.Items.Add(kullanici.rows(i)("kullanici_adi"))
        Next
    End Sub
    Private Sub karekrani()
        Try
            Dim biletler1 = Sorgu.butunbiletler()
            For i As Integer = 0 To biletler1.rows.count - 1
                DataGridView2.Rows.Add(biletler1.rows(i)("kullanici_adi"), biletler1.rows(i)("satis_tarih"), biletler1.rows(i)("satılan_bilet"), biletler1.rows(i)("kazanç"))
            Next
        Catch ex As Exception
            MsgBox("karekranı hatası")
        End Try
    End Sub
    Private Sub kullaniciturcek()
        cb_kullanicituru.ResetText()
        cb_kullanicituru.Items.Clear()
        Dim kullanicitur = Sorgu.kullaniciTuruCek()
        For i As Integer = 0 To kullanicitur.rows.count - 1
            cb_kullanicituru.Items.Add(kullanicitur.rows(i)("kullanici_turu"))
        Next
        cb_kullanicituru.SelectedItem = cb_kullanicituru.Items.Item(0)
    End Sub
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim zaman As String = Now.ToShortDateString
        Dim yenizaman() As String = zaman.Split(".")
        zaman = yenizaman(2) & "-" & yenizaman(1) & "-" & yenizaman(0)
        DateTimePicker1.Value = zaman
        TakimAdiCek()
        'kontrolzaman()
        TextBox1.Text = Now.ToShortTimeString
        stadcek()
        kullanicicek()
        kullaniciturcek()
        karekrani()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        Dim secilentakim As Integer = ComboBox1.SelectedIndex
        For i As Integer = 0 To ComboBox1.Items.Count - 1
            If Not (i = secilentakim) Then
                ComboBox2.Items.Add(ComboBox1.Items.Item(i))
            End If
        Next
        ComboBox2.SelectedItem = ComboBox2.Items.Item(0)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TakimAdiCek()
        zaman()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_MacEkle.Click
        Dim Ev_Sahibi_Adi As String = ComboBox1.SelectedItem.ToString()
        Dim Ev_Sahibi_id = Sorgu.takimidcek(Ev_Sahibi_Adi).rows(0)("takim_id")
        Dim Rakip_Adi As String = ComboBox2.SelectedItem.ToString
        Dim Rakip_id = Sorgu.takimidcek(Rakip_Adi).rows(0)("takim_id")
        Dim tarih As String = DateTimePicker1.Text
        Dim saat As String = TextBox1.Text
        Sorgu.etkinlikekle(Ev_Sahibi_id, Rakip_id, tarih, saat)
        TakimAdiCek()
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        zaman()
    End Sub

    Private Sub cb_stat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_stat.SelectedIndexChanged
        cb_Tribun.ResetText()
        cb_Tribun.Items.Clear()
        Dim statid As Integer = Sorgu.statadicek(cb_stat.SelectedItem.ToString).rows(0)("stat_id")
        Dim tribun = Sorgu.tribunadicek(statid)
        Try
            For i As Integer = 0 To tribun.Rows.Count - 1
                cb_Tribun.Items.Add(tribun.Rows(i)("Tribun_Adi"))
            Next
            cb_Tribun.SelectedItem = tribun.Rows(0)("Tribun_Adi")
            Dim tribun_id = Sorgu.tribunucretcek(cb_Tribun.Text, statid)
            tribunid = tribun_id.Rows(0)("Tribun_id")
            Dim ucret As Integer = Convert.ToInt32(tribun_id.Rows(0)("Ücret"))
            tb_ucret.Text = ucret
        Catch ex As Exception
            MsgBox("Tribun hatası")
        End Try
    End Sub

    Private Sub cb_Tribun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Tribun.SelectedIndexChanged, ComboBox3.SelectedIndexChanged
        Dim tribun_id = Sorgu.tribunucretcek(cb_Tribun.Text, Sorgu.statadicek(cb_stat.SelectedItem.ToString).rows(0)("stat_id"))
        tribunid = tribun_id.Rows(0)("Tribun_id")
        Dim ucret = Convert.ToInt32(tribun_id.Rows(0)("Ücret"))
        tb_ucret.Text = ucret
    End Sub

    Private Sub btn_ucretguncelle_Click(sender As Object, e As EventArgs) Handles btn_ucretguncelle.Click
        Try
            Dim tribun_id = Sorgu.tribunucretcek(cb_Tribun.Text, Sorgu.statadicek(cb_stat.SelectedItem.ToString).rows(0)("stat_id")).rows(0)("tribun_id")
            Sorgu.ucretguncelle(tribun_id, Convert.ToInt32(tb_ucret.Text))
        Catch ex As Exception
            MsgBox("Ücret Güncelleme Hatası")
        End Try
    End Sub

    Private Sub btn_TribunEkle_Click(sender As Object, e As EventArgs) Handles btn_TribunEkle.Click
        Try
            Dim statadi As String = ComboBox4.SelectedItem.ToString
            Dim tribunadi As String = TextBox3.Text
            If Not (tribunadi = "") Then
                Dim ucret As Integer = Convert.ToInt32(TextBox5.Text)
                Try
                    Dim tribunid = Sorgu.tribunidcek(statadi, tribunadi).rows(0)("Tribun_id")
                    MsgBox("Girilen Tribün Adi Mevcut")
                Catch ex As Exception
                    Sorgu.tribunekle(statadi, tribunadi, ucret)
                    stadcek()
                End Try
            Else
                MsgBox("Tribun Adı Boş Bırakılamaz")
            End If
        Catch ex As Exception
            MsgBox("Alanlar boş Bırakılamaz")
        End Try
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        ComboBox3.ResetText()
        ComboBox3.Items.Clear()
        Dim statid As Integer = Sorgu.statadicek(ComboBox5.SelectedItem.ToString).rows(0)("stat_id")
        Dim tribun = Sorgu.tribunadicek(statid)
        Try
            For i As Integer = 0 To tribun.Rows.Count - 1
                ComboBox3.Items.Add(tribun.Rows(i)("Tribun_Adi"))
            Next
            ComboBox3.SelectedItem = tribun.Rows(0)("Tribun_Adi")
            Dim tribun_id = Sorgu.tribunucretcek(ComboBox3.Text, statid)
            tribunid = tribun_id.Rows(0)("Tribun_id")
        Catch ex As Exception
            MsgBox("Tribun hatası")
        End Try
    End Sub

    Private Sub btn_Blokekle_Click(sender As Object, e As EventArgs) Handles btn_Blokekle.Click
        Try
            Dim statadi As String = ComboBox5.SelectedItem.ToString
            Dim tribunadi As String = ComboBox3.SelectedItem.ToString
            Dim tribunid As Integer = Convert.ToInt32(Sorgu.tribunidcek(statadi, tribunadi).rows(0)("Tribun_id"))
            Dim blokadi As String = TextBox4.Text
            If Not (blokadi = "") Then
                Dim max As Integer = Convert.ToInt32(TextBox2.Text)
                Try
                    Dim blokid = Sorgu.blokidcek(blokadi, tribunid).rows(0)("Blok_id")
                    MsgBox("Girilen Blok Mevcut")
                Catch ex As Exception
                    Sorgu.blokekle(blokadi, max, tribunid)
                End Try
            Else
                MsgBox("Blok Adı Boş Bırakılamaz")
            End If
        Catch ex As Exception
            MsgBox("Alanlar Boş Bırakılamaz")
        End Try
    End Sub

    Private Sub btn_sifresıfırla_Click(sender As Object, e As EventArgs) Handles btn_sifresıfırla.Click
        Try
            Sorgu.kullanicisifresifirla(lb_liste.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox("Şifre Sıfırlanamadı")
        End Try
    End Sub

    Private Sub btn_kullaniciekle_Click(sender As Object, e As EventArgs) Handles btn_kullaniciekle.Click
        Try
            Dim kullaniciadi As String = TextBox6.Text
            Dim kullanicisifre As String = TextBox7.Text
            If Not (kullaniciadi = "") And Not (kullanicisifre = "") Then
                Try
                    Dim kullanici = Sorgu.kullaniciidcek(TextBox6.Text).rows(0)("Kullanici_id")
                    MsgBox("Kullanıcı Mevcut")
                Catch ex As Exception
                    Sorgu.kullaniciekle(cb_kullanicituru.SelectedItem.ToString, kullaniciadi, kullanicisifre)
                    kullanicicek()
                End Try
            Else
                MsgBox("Alanlar Boş Bırakılamaz")
            End If
        Catch ex As Exception
            MsgBox("Alanlar Boş Bırakılamaz")
        End Try
    End Sub
End Class