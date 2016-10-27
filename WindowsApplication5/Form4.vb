Public Class Form4

    Private satir As Integer
    Private datagridf1 As DataGridView
    Sub New(_satir As Integer, _datagridf1 As DataGridView)
        InitializeComponent()
        satir = _satir
        datagridf1 = _datagridf1
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim etkinlikid As Integer = Convert.ToInt32(datagridf1.Rows(satir).Cells(5).Value)
        Dim satirsay As String = Sorgu.biletsaydir(etkinlikid).rows(0)("Sayi")
        For i As Integer = 0 To satirsay - 1


            Dim biletid As String = Sorgu.biletceketkinlikten(etkinlikid).rows(i)("bilet_id")
            Dim musteri = Sorgu.mustericek(biletid)
            Dim musteriadi As String = musteri.rows(0)("musteri_adi")
            Dim musterisoyadi As String = musteri.rows(0)("musteri_soyadi")
            Dim telefon As String = musteri.rows(0)("telefon")

            DataGridView1.Rows.Add(biletid, musteriadi, musterisoyadi, telefon)

        Next
    End Sub

    Private Sub btn_Biletgoster_Click(sender As Object, e As EventArgs) Handles btn_Biletgoster.Click
        Try
            Dim a As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)
            Dim f3 As New Form3(a)
            f3.ShowDialog()
        Catch ex As Exception
            MsgBox("Bilet Seçiniz")
        End Try
        

    End Sub
End Class