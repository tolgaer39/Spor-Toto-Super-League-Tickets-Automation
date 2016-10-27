<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BiletID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MacZamanı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvSahibi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rakip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatısZamanı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VezneAdı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_ara = New System.Windows.Forms.Button()
        Me.btn_bilet = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BiletID, Me.MacZamanı, Me.EvSahibi, Me.Rakip, Me.SatısZamanı, Me.VezneAdı})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(14, 94)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(726, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'BiletID
        '
        Me.BiletID.HeaderText = "Bilet ID"
        Me.BiletID.Name = "BiletID"
        Me.BiletID.ReadOnly = True
        Me.BiletID.Width = 49
        '
        'MacZamanı
        '
        Me.MacZamanı.HeaderText = "Mac Zamanı"
        Me.MacZamanı.Name = "MacZamanı"
        Me.MacZamanı.ReadOnly = True
        Me.MacZamanı.Width = 150
        '
        'EvSahibi
        '
        Me.EvSahibi.HeaderText = "Ev Sahibi"
        Me.EvSahibi.Name = "EvSahibi"
        Me.EvSahibi.ReadOnly = True
        Me.EvSahibi.Width = 149
        '
        'Rakip
        '
        Me.Rakip.HeaderText = "Rakip"
        Me.Rakip.Name = "Rakip"
        Me.Rakip.ReadOnly = True
        Me.Rakip.Width = 149
        '
        'SatısZamanı
        '
        Me.SatısZamanı.HeaderText = "Satış Zamanı"
        Me.SatısZamanı.Name = "SatısZamanı"
        Me.SatısZamanı.ReadOnly = True
        Me.SatısZamanı.Width = 129
        '
        'VezneAdı
        '
        Me.VezneAdı.HeaderText = "Vezne Adı"
        Me.VezneAdı.Name = "VezneAdı"
        Me.VezneAdı.ReadOnly = True
        Me.VezneAdı.Width = 97
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(239, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Button1.Location = New System.Drawing.Point(7, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Barkod ile"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Button2.Location = New System.Drawing.Point(239, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Tc No ile"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_ara)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 76)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bilet Sorgulama"
        '
        'btn_ara
        '
        Me.btn_ara.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_ara.Enabled = False
        Me.btn_ara.Location = New System.Drawing.Point(476, 19)
        Me.btn_ara.Name = "btn_ara"
        Me.btn_ara.Size = New System.Drawing.Size(55, 51)
        Me.btn_ara.TabIndex = 2
        Me.btn_ara.Text = "Ara"
        Me.btn_ara.UseVisualStyleBackColor = False
        '
        'btn_bilet
        '
        Me.btn_bilet.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btn_bilet.Location = New System.Drawing.Point(14, 371)
        Me.btn_bilet.Name = "btn_bilet"
        Me.btn_bilet.Size = New System.Drawing.Size(726, 31)
        Me.btn_bilet.TabIndex = 3
        Me.btn_bilet.Text = "Bileti Görüntüle"
        Me.btn_bilet.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(756, 412)
        Me.Controls.Add(Me.btn_bilet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bilet Sorgulama"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ara As System.Windows.Forms.Button
    Friend WithEvents btn_bilet As System.Windows.Forms.Button
    Friend WithEvents BiletID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MacZamanı As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EvSahibi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rakip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatısZamanı As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VezneAdı As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
