Public Class Sorgu

    Shared Function etkinlikidcek(ByVal zaman As String)
        Return baglan.vericek("select etkinlik_id from etkinlikler where tarih like '" & zaman & "' ")
    End Function

    Shared Function takimadicek(ByVal tur As String, ByVal etkinlikid As Integer)
        Return baglan.vericek("select takim_adi from takimlar where takim_id in( select " + tur + " from etkinlikler where etkinlik_id ='" & etkinlikid & "' )")
    End Function
    Shared Function takimadicek(ByVal takimid As Integer)
        Return baglan.vericek("select takim_adi from Takimlar where Takim_id = '" & takimid & "'")
    End Function

    Shared Function statadicek(ByVal etkinlikid As Integer)
        Return baglan.vericek("select stat_id ,stat_adi from statlar where stat_id in (select ev_sahibi_id from etkinlikler where etkinlik_id ='" & etkinlikid & "')")
    End Function
    Shared Function statadicek(ByVal statadi As String)
        Return baglan.vericek("Select Stat_id From Statlar Where Stat_Adi like '" & statadi & "' ")
    End Function
    Shared Function statadicektakimdan(ByVal statid As Integer)
        Return baglan.vericek("select stat_adi from Statlar where Stat_id = '" & evsahibiid & "'")
    End Function

    Shared Function tarihsaatcek(ByVal etkinlikid As Integer)
        Return baglan.vericek("select Tarih,Saat  from etkinlikler where etkinlik_id = '" & etkinlikid & "' ")
    End Function

    Shared Function tribunadicek(ByVal statid As Integer) As Object
        Return baglan.vericek("select Tribun_Adi from Tribunler where Stat_id = '" & statid & "' ")
    End Function
    Shared Function tribunucretcek(ByVal tribun As String, ByVal statid As Integer)
        Return baglan.vericek("select Tribun_id,Ücret from Tribunler where Tribun_Adi = '" & tribun & "' and stat_id = '" & statid & "' ")
    End Function
    Shared Function tribuncek(ByVal tribunid As Integer)
        Return baglan.vericek("select tribun_adi,ücret from tribunler where tribun_id= '" & tribunid & "'")
    End Function

    Shared Function blokadicek(ByVal tribunid As Integer)
        Return baglan.vericek("select Blok_id,Blok_Adi from Bloklar where Tribun_id = '" & tribunid & "' ")
    End Function
    Shared Function blokcek(ByVal blokid As Integer)
        Return baglan.vericek("select blok_adi from bloklar where blok_id= '" & blokid & "'")
    End Function
    Shared Function blokidcek(ByVal blok As String, ByVal tribunid As Integer)
        Return baglan.vericek("select Blok_id from Bloklar where blok_adi = '" & blok & "' and tribun_id = '" & tribunid & "' ")
    End Function

    Shared Function koltukcek(ByVal koltukid As Integer)
        Return baglan.vericek("select koltuk_no from koltuklar where koltuk_id= '" & koltukid & "'")
    End Function

    Shared Function biletcek(ByVal biletid As Integer)
        Return baglan.vericek("select Etkinlik_id,tribun_id,blok_id,koltuk_id,satis_tarih,satis_saat,kullanici_id from Biletler where Bilet_id ='" & biletid & "' ")
    End Function

    Shared Function etkinlikvericek(ByVal etkinlikid As Integer)
        Return baglan.vericek("select ev_sahibi_id,rakip_id,tarih,saat from Etkinlikler where Etkinlik_id ='" & etkinlikid & "' ")
    End Function

    Shared Function vezneadicek(ByVal biletid As Integer)
        Return baglan.vericek("select kullanici_adi from kullanicilar where kullanici_id =(select kullanici_id from biletler where bilet_id = '" & biletid & "' ) ")
    End Function

    Shared Function kullanicidogrumu(ByVal kullaniciadi As String, ByVal sifre As String)
        Return baglan.vericek("SELECT kullanici_tur FROM kullanicilar WHERE kullanici_Adi='" & kullaniciadi & "' AND kullanici_sifre='" & sifre & "'")
    End Function

    Shared Function kullaniciTuruCek(kullaniciAdi As String)
        Return baglan.vericek("SELECT kullanici_Turu FROM kullanici_turleri WHERE kullanici_Tur_id =(SELECT kullanici_Tur FROM kullanicilar WHERE kullanici_Adi = '" & kullaniciAdi & "')")
    End Function
    Shared Function kullaniciTuruCek()
        Return baglan.vericek("SELECT kullanici_Turu FROM kullanici_turleri ")
    End Function

    Shared Function biletsaydir(ByVal etkinlikid As Integer)
        Return baglan.vericek("select COUNT (*) as sayi from Biletler where Etkinlik_id ='" & etkinlikid & "'")
    End Function

    Shared Function biletceketkinlikten(ByVal etkinlikid As Integer)
        Return baglan.vericek("select bilet_id from biletler where etkinlik_id ='" & etkinlikid & "'")
    End Function

    Shared Function mustericek(biletid As String) As Object
        Return baglan.vericek("select musteri_Adi, musteri_soyadi,telefon from musteriler where  musteri_id =( select musteri_id from satislar where bilet_id ='" & biletid & "' )")
    End Function

    Shared Function musteriidcek(p1 As String, p2 As String, p3 As String)
        Return baglan.vericek("select musteri_id from musteriler where musteri_adi like '" & p1 & "' and musteri_soyadi like '" & p2 & "' and telefon like '" & p3 & "'")
    End Function

    Shared Sub biletekle(etkinlikid As Integer, tribunid As Integer, blokid As Integer, koltukid As Integer, tarih As String, saat As String, kullaniciid As Integer)
        baglan.ekle("insert into biletler (etkinlik_id,tribun_id,blok_id,koltuk_id,satis_tarih,satis_saat,kullanici_id) values (" & etkinlikid & "," & tribunid & "," & blokid & "," & koltukid & ",'" & tarih & "','" & saat & "'," & kullaniciid & " )")
    End Sub

    Shared Function kullaniciidcek(kullaniciAdi As String)
        Return baglan.vericek("select kullanici_id from kullanicilar where kullanici_adi like '" & kullaniciAdi & "'")
    End Function

    Shared Function ensoneklenenbiletidcek()
        Return baglan.vericek("select top 1  bilet_id from biletler order by bilet_id desc")
    End Function

    Shared Sub satisekle(musteriid As Integer, biletid As Integer)
        baglan.ekle("insert into satislar (musteri_id,bilet_id ) values (" & musteriid & "," & biletid & ") ")
    End Sub

    Shared Function maxkoltuksayisi(blokid As Integer)
        Return baglan.vericek("select max_koltuk_sayisi from bloklar where blok_id = '" & blokid & "'")
    End Function

    Shared Function satilankoltuksayisi(blokid As Integer, etkinlikid As Integer)
        Return baglan.vericek("select count(*)as sayi from koltuklar where blok_id ='" & blokid & "'and etkinlik_id= '" & etkinlikid & "'")
    End Function

    Shared Sub koltukekle(blokid As Integer, koltukno As Integer, etkinlikid As Integer)
        baglan.ekle("insert into koltuklar (blok_id,koltuk_no,etkinlik_id) values (" & blokid & "," & koltukno + 1 & "," & etkinlikid & ")")
    End Sub

    Shared Function ensonkoltukidcek()
        Return baglan.vericek("select top 1 koltuk_id from koltuklar order by koltuk_id desc")
    End Function

    Shared Function musteriidcek(tcno As String) As Object
        Return baglan.vericek("select musteri_id,musteri_adi,musteri_soyadi,telefon,adres from musteriler where tc_no = '" & tcno & "' ")
    End Function

    Shared Sub musteriekle(ad As String, soyad As String, telefon As String, adres As String, tcno As String)
        baglan.ekle("insert into musteriler (Musteri_Adi,musteri_soyadi,adres,telefon,tc_no) values ('" & ad & "','" & soyad & "','" & adres & "','" & telefon & "', '" & tcno & "')")
    End Sub

    Shared Function biletler(musteriid As Integer)
        Return baglan.vericek("select bilet_id from satislar where musteri_id = " & musteriid & "")
    End Function

    Shared Function tarihtekitakimlar(tarih As String)
        Return baglan.vericek("select takim_adi from Takimlar where Takim_id not in (select ev_sahibi_id from etkinlikler where tarih like '" & tarih & "') and Takim_id not in (select rakip_id from etkinlikler where tarih like '" & tarih & "')")
    End Function

    Shared Function takimidcek(Ev_Sahibi_Adi As String)
        Return baglan.vericek("select takim_id from takimlar where takim_adi like '" & Ev_Sahibi_Adi & "'")
    End Function

    Shared Sub etkinlikekle(Ev_Sahibi_id As Object, Rakip_id As Object, tarih As String, saat As String)
        baglan.ekle("insert into etkinlikler values(" & Ev_Sahibi_id & " ," & Rakip_id & ",'" & tarih & "','" & saat & "')")
    End Sub

    Shared Function butunstatlar()
        Return baglan.vericek("select * from statlar")
    End Function

    Shared Sub ucretguncelle(tribun_id As Integer, ucret As Integer)
        baglan.ekle("update Tribunler set ücret=" & ucret & " where Tribun_id=" & tribun_id & " ")
    End Sub

    Shared Function tribunidcek(statadi As String, tribunadi As String)
        Return baglan.vericek("select tribun_id from tribunler where tribun_adi = '" & tribunadi & "' and stat_id in(select stat_id from statlar where stat_adi = '" & statadi & "')")
    End Function

    Shared Sub tribunekle(statadi As String, tribunadi As String, ucret As Integer)
        baglan.ekle("insert into tribunler(Tribun_Adi,Stat_id,Ücret) values('" & tribunadi & "'," & Sorgu.statadicek(statadi).rows(0)("Stat_id") & "," & ucret & ")")
    End Sub

    Shared Sub blokekle(blokadi As String, max As Integer, tribunid As Integer)
        baglan.ekle("insert into bloklar(Blok_Adi,Max_Koltuk_Sayisi,Tribun_id) values('" & blokadi & "'," & max & "," & tribunid & ")")

    End Sub

    Shared Function kullanicicek() As Object
        Return baglan.vericek("select kullanici_adi from kullanicilar where kullanici_tur =2")
    End Function

    Shared Sub kullanicisifresifirla(kullaniciadi As String)
        baglan.ekle("update kullanicilar set kullanici_sifre =1234 where kullanici_adi ='" & kullaniciadi & "'")
    End Sub

    Shared Sub kullaniciekle(kullanicituru As String, kullaniciadi As String, kullanicisifresi As String)
        Dim kullanicitur As Integer = Sorgu.kullaniciturcek(kullanicituru).rows(0)("kullanici_tur_id")
        baglan.ekle("insert into kullanicilar (kullanici_adi,kullanici_sifre,kullanici_tur) values ('" & kullaniciadi & "', ' " & kullanicisifresi & "', '" & kullanicitur & "')")
    End Sub

    Shared Function kullaniciturcek(kullanicituradı As String)
        Return baglan.vericek("select kullanici_tur_id from kullanici_turleri where kullanici_turu ='" & kullanicituradı & "'")
    End Function

    Shared Function butunbiletler()
        Return baglan.vericek("select kullanici_adi,satis_tarih,COUNT (*)	as satılan_bilet,sum(ücret)as kazanç from biletler b, tribunler t, kullanicilar k where b.tribun_id = t.tribun_id And b.kullanici_id = k.kullanici_id group by kullanici_adi,satis_tarih order by Satis_Tarih asc , kullanici_adi asc ")
    End Function


   
End Class
