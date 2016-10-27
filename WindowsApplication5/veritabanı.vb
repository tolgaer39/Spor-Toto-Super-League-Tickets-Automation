Imports System.Data.SqlClient
Public Class baglanti
    Dim connetionString
    Dim command As SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim ds As New DataSet
    Dim connection
    Sub New()
        connetionString = " Data Source=169.254.144.172;Initial Catalog=Bilet_Satis;User ID=sa;Password=123456789"
        'connetionString = "Integrated Security=SSPI;Initial Catalog=Bilet_Satis;Data Source=(local)"
        connection = New SqlConnection(connetionString)
    End Sub

    Sub ekle(ByVal sql As String)                   ' ekleme işlemleri
        command = New SqlCommand(sql, connection)
        adapter.SelectCommand = command
        Try
            adapter.Fill(ds)
            ' MsgBox("veri ekleme başarılı")
        Catch ex As Exception
        End Try
        adapter.Dispose()
        command.Dispose()
    End Sub
    Function vericek(ByVal sql As String) As DataTable          'veri tabanından çekme
        command = New SqlCommand(sql, connection)
        adapter.SelectCommand = command
        ds = Nothing
        ds = New DataSet
        Try
            adapter.Fill(ds)
            'MsgBox("veri çekme başarılı")
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function





End Class
