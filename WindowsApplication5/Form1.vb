Public Class Form1

    Private kullaniciid As String
    Private Sub kontrolzaman()
        Try
            Dim seciliindex As Integer = DataGridView1.CurrentCell.RowIndex
            If DataGridView1.Rows(seciliindex).Cells(0).Value < Now.Date Then
                Btn_BiletSat.Enabled = False
            ElseIf DataGridView1.Rows(seciliindex).Cells(0).Value = Now.Date Then
                If DataGridView1.Rows(seciliindex).Cells(1).Value < Now.TimeOfDay Then
                    Btn_BiletSat.Enabled = False
                Else
                    Btn_BiletSat.Enabled = True
                End If
            Else
                Btn_BiletSat.Enabled = True
            End If

        Catch ex As Exception

        End Try
        End Sub

    Sub New(_kullaniciid As Integer)
        InitializeComponent()
        kullaniciid = _kullaniciid
    End Sub

    Sub listele()
        Dim etkinlikid As Integer
        DataGridView1.Rows.Clear()
        Dim zaman As String = DateTimePicker1.Text
        'zaman = zaman.Replace(":", "-")
        Dim etkinlik = Sorgu.etkinlikidcek(zaman)
        Try
            For i As Integer = 0 To etkinlik.Rows.Count - 1
                etkinlikid = etkinlik.Rows(i)("Etkinlik_id")
                Dim evsahibi = Sorgu.takimadicek("Ev_sahibi_id", etkinlikid)
                Dim rakip = Sorgu.takimadicek("rakip_id", etkinlikid)
                Dim stat = Sorgu.statadicek(etkinlikid)
                Dim tarihsaat = Sorgu.tarihsaatcek(etkinlikid)

                DataGridView1.Rows.Add(tarihsaat.Rows(0)("Tarih"), tarihsaat.Rows(0)("saat"), evsahibi.Rows(0)("Takim_Adi"), rakip.Rows(0)("Takim_Adi"), stat.Rows(0)("Stat_Adi"), etkinlikid)
                Btn_BiletSat.Enabled = True
            Next
        Catch ex As Exception
            MsgBox("hata123")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now
        'Dim zaman As String = String.Format("{0:yyyy:MM:dd}", DateTime.Now)
        listele()
    End Sub

    Private Sub Btn_BiletSat_Click(sender As Object, e As EventArgs) Handles Btn_BiletSat.Click
        Try
            Dim seciliindex As Integer = DataGridView1.CurrentCell.RowIndex
            Dim f2 As New Form2(seciliindex, DataGridView1, kullaniciid)
            f2.ShowDialog()
        Catch ex As Exception
            MsgBox("Maç Seçiniz")
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        listele()
        kontrolzaman()
    End Sub

    Private Sub btn_SatılanBiletler_Click(sender As Object, e As EventArgs) Handles btn_SatılanBiletler.Click
        Try
            Dim f4 As New Form4(DataGridView1.CurrentCell.RowIndex, DataGridView1)
            f4.ShowDialog()
        Catch ex As Exception
            MsgBox("Maç Seçiniz")
        End Try
        
    End Sub

    Private Sub btn_biletsorgula_Click(sender As Object, e As EventArgs) Handles btn_biletsorgula.Click
        Dim f5 As New Form5()
        f5.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellcurrentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        kontrolzaman()
    End Sub
End Class
