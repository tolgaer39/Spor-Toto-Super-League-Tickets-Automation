<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.tbSifre = New System.Windows.Forms.TextBox()
        Me.tbKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Şifre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnGiris.Location = New System.Drawing.Point(17, 59)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(238, 30)
        Me.btnGiris.TabIndex = 3
        Me.btnGiris.Text = "Giriş"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'tbSifre
        '
        Me.tbSifre.Location = New System.Drawing.Point(99, 32)
        Me.tbSifre.Name = "tbSifre"
        Me.tbSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbSifre.Size = New System.Drawing.Size(156, 21)
        Me.tbSifre.TabIndex = 2
        '
        'tbKullaniciAdi
        '
        Me.tbKullaniciAdi.Location = New System.Drawing.Point(99, 6)
        Me.tbKullaniciAdi.Name = "tbKullaniciAdi"
        Me.tbKullaniciAdi.Size = New System.Drawing.Size(156, 21)
        Me.tbKullaniciAdi.TabIndex = 1
        '
        'formLogin
        '
        Me.AcceptButton = Me.btnGiris
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(264, 97)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.tbSifre)
        Me.Controls.Add(Me.tbKullaniciAdi)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giriş"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGiris As System.Windows.Forms.Button
    Friend WithEvents tbSifre As System.Windows.Forms.TextBox
    Friend WithEvents tbKullaniciAdi As System.Windows.Forms.TextBox
End Class
