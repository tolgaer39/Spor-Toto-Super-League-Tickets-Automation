'Imports System.Security.Cryptography
'Imports System.Security.Policy

Public Class Form3

    Private biletid As Integer

    Sub New(_biletid As Integer)
        InitializeComponent()
        biletid = _biletid
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim biletid As Integer = 1
        'Dim şifrele As New MD5Cng
        'lbl_barkod.Text = şifrele.Hash(biletid)
        tb_barkod.Text = Integer.MaxValue - biletid
        Dim sorgu1 = Sorgu.biletcek(biletid)

        etkinlikid = sorgu1.Rows(0)("Etkinlik_id")
        tribunid = sorgu1.Rows(0)("tribun_id")
        blokid = sorgu1.rows(0)("blok_id")
        koltukid = sorgu1.Rows(0)("koltuk_id")
        lbl_satistarih.Text = sorgu1.rows(0)("Satis_tarih")
        lbl_satissaat.Text = sorgu1.rows(0)("Satis_saat").ToString
        lbl_tribun.Text = Sorgu.tribuncek(tribunid).Rows(0)("tribun_adi")
        lbl_ucret.Text = Sorgu.tribuncek(tribunid).Rows(0)("ücret") & " TL"
        lbl_blok.Text = Sorgu.blokcek(blokid).Rows(0)("blok_adi")
        lbl_koltuk.Text = Sorgu.koltukcek(koltukid).Rows(0)("koltuk_no")

        Dim sorgu2 = Sorgu.etkinlikvericek(etkinlikid)
        evsahibiid = sorgu2.Rows(0)("Ev_sahibi_id")
        rakipid = sorgu2.Rows(0)("Rakip_id")
        lbl_tarih.Text = sorgu2.Rows(0)("tarih")
        lbl_saat.Text = sorgu2.Rows(0)("saat").ToString
        lbl_evsahibi.Text = Sorgu.takimadicek(evsahibiid).Rows(0)("Takim_Adi")
        lbl_rakip.Text = Sorgu.takimadicek(rakipid).Rows(0)("Takim_Adi")
        lbl_statadi.Text = Sorgu.statadicektakimdan(evsahibiid).Rows(0)("stat_adi")
        lbl_vezne.Text = Sorgu.vezneadicek(biletid).rows(0)("Kullanici_Adi")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''''' bileti yazdır

    End Sub
End Class