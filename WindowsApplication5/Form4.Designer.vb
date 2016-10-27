<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Biletid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusteriAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusteriSoyadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Biletgoster = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeight = 21
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Biletid, Me.MusteriAdi, Me.MusteriSoyadi, Me.Telefon})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(14, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(417, 230)
        Me.DataGridView1.TabIndex = 0
        '
        'Biletid
        '
        Me.Biletid.HeaderText = "Bilet ID"
        Me.Biletid.Name = "Biletid"
        Me.Biletid.ReadOnly = True
        '
        'MusteriAdi
        '
        Me.MusteriAdi.HeaderText = "Müşteri Adı"
        Me.MusteriAdi.Name = "MusteriAdi"
        Me.MusteriAdi.ReadOnly = True
        '
        'MusteriSoyadi
        '
        Me.MusteriSoyadi.HeaderText = "Müşteri Soyadı"
        Me.MusteriSoyadi.Name = "MusteriSoyadi"
        Me.MusteriSoyadi.ReadOnly = True
        '
        'Telefon
        '
        Me.Telefon.HeaderText = "Telefon"
        Me.Telefon.Name = "Telefon"
        Me.Telefon.ReadOnly = True
        Me.Telefon.Width = 114
        '
        'btn_Biletgoster
        '
        Me.btn_Biletgoster.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_Biletgoster.Location = New System.Drawing.Point(14, 248)
        Me.btn_Biletgoster.Name = "btn_Biletgoster"
        Me.btn_Biletgoster.Size = New System.Drawing.Size(417, 32)
        Me.btn_Biletgoster.TabIndex = 1
        Me.btn_Biletgoster.Text = "Bilet"
        Me.btn_Biletgoster.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(446, 289)
        Me.Controls.Add(Me.btn_Biletgoster)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biletler"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Biletgoster As System.Windows.Forms.Button
    Friend WithEvents Biletid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MusteriAdi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MusteriSoyadi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefon As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
