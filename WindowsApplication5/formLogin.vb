Public Class formLogin

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        Dim kullaniciAdi As String = tbKullaniciAdi.Text
        Dim sifre As String = tbSifre.Text
        Try
            Dim degisken As String = Sorgu.kullanicidogrumu(kullaniciAdi, sifre).rows(0)("Kullanici_tur")
            Try
                Dim kullaniciid As Integer = Sorgu.kullaniciidcek(kullaniciAdi).rows(0)("Kullanici_id")
                If degisken = "1" Then

                    Dim fa As New frmAdmin(kullaniciid)
                    Me.Hide()
                    fa.ShowDialog()

                    Me.Close()
                    'MsgBox("11")
                ElseIf degisken = "2" Then
                    Dim f1 As New Form1(kullaniciid)
                    Me.Hide()
                    f1.ShowDialog()
                    Me.Close()
                    'MsgBox("22")
                End If
            Catch ex As Exception
                'MsgBox("")
            End Try
        Catch ex As Exception
            MsgBox("Şifre Hatalı")
        End Try
    End Sub

    Private Sub tbKullaniciAdi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbKullaniciAdi.TextChanged

    End Sub
End Class