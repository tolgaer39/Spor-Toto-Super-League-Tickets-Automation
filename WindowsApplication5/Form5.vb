Public Class Form5
    Private Sub bilets(biletid As Integer)
        Dim bilet = Sorgu.biletcek(biletid)
        Dim vezne As String = Sorgu.vezneadicek(biletid).rows(0)("Kullanici_Adi")
        Dim satistarih = bilet.rows(0)("Satis_Tarih")
        Dim satissaat = bilet.rows(0)("Satis_Saat").ToString

        Dim etkinlikid As Integer = bilet.rows(0)("Etkinlik_id")
        Dim evsahibiadi As String = Sorgu.takimadicek("ev_sahibi_id", etkinlikid).rows(0)("Takim_adi")
        Dim rakipadi As String = Sorgu.takimadicek("rakip_id", etkinlikid).rows(0)("Takim_adi")
        Dim mactarihi As String = Sorgu.tarihsaatcek(etkinlikid).rows(0)("tarih")
        Dim macsaati As String = Sorgu.tarihsaatcek(etkinlikid).rows(0)("Saat").ToString
        DataGridView1.Rows.Add(biletid, mactarihi & " " & macsaati, evsahibiadi, rakipadi, satistarih & " " & satissaat, vezne)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        Label1.Text = "Barkod Numarası Girin"
        TextBox1.Enabled = True
        btn_ara.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Label1.Text = "TC Numarası Girin"
        TextBox1.Enabled = True
        btn_ara.Enabled = True
    End Sub

    Private Sub btn_ara_Click(sender As Object, e As EventArgs) Handles btn_ara.Click
        DataGridView1.Rows.Clear()
        If Label1.Text = "Barkod Numarası Girin" Then
            Try
                Dim biletid As Integer = Integer.MaxValue - Convert.ToInt32(TextBox1.Text)
                bilets(biletid)
            Catch ex As Exception
                MsgBox("Barkod Hatası")
            End Try
            


        ElseIf Label1.Text = "TC Numarası Girin" Then
            Try
                Dim musteriid = Sorgu.musteriidcek(TextBox1.Text).rows(0)("musteri_id")
                Dim biletler = Sorgu.biletler(musteriid)


                For i As Integer = 0 To biletler.rows.count - 1
                    bilets(biletler.rows(i)("bilet_id"))
                    'Dim bilet = Convert.ToInt32(Sorgu.biletcek(biletler.rows(i)("bilet_id")))
                    'bilets(bilet)
                Next

            Catch ex As Exception
                MsgBox("Tc No Hatası")
            End Try

        End If

    End Sub

    Private Sub btn_bilet_Click(sender As Object, e As EventArgs) Handles btn_bilet.Click
        Try
            Dim seciliindex As Integer = DataGridView1.CurrentCell.RowIndex
            Dim f3 As New Form3(DataGridView1.Rows(seciliindex).Cells(0).Value)
            f3.ShowDialog()
        Catch ex As Exception
            MsgBox("Bilet Seçiniz")
        End Try
        
    End Sub
End Class