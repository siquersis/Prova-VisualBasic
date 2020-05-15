<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesquisa
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
        Me.grid_consulta = New System.Windows.Forms.DataGridView()
        Me.lbl_Pesquisa = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_Pesquisa = New System.Windows.Forms.Button()
        CType(Me.grid_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_consulta
        '
        Me.grid_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_consulta.Location = New System.Drawing.Point(12, 105)
        Me.grid_consulta.Name = "grid_consulta"
        Me.grid_consulta.Size = New System.Drawing.Size(776, 266)
        Me.grid_consulta.TabIndex = 0
        '
        'lbl_Pesquisa
        '
        Me.lbl_Pesquisa.AutoSize = True
        Me.lbl_Pesquisa.Location = New System.Drawing.Point(12, 26)
        Me.lbl_Pesquisa.Name = "lbl_Pesquisa"
        Me.lbl_Pesquisa.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Pesquisa.TabIndex = 1
        Me.lbl_Pesquisa.Text = "Pesquisa: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 20)
        Me.TextBox1.TabIndex = 2
        '
        'btn_Pesquisa
        '
        Me.btn_Pesquisa.Image = Global.WindowsApp1.My.Resources.Resources.pesquisa1
        Me.btn_Pesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Pesquisa.Location = New System.Drawing.Point(253, 26)
        Me.btn_Pesquisa.Name = "btn_Pesquisa"
        Me.btn_Pesquisa.Size = New System.Drawing.Size(78, 73)
        Me.btn_Pesquisa.TabIndex = 3
        Me.btn_Pesquisa.UseVisualStyleBackColor = True
        '
        'Pesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 383)
        Me.Controls.Add(Me.btn_Pesquisa)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_Pesquisa)
        Me.Controls.Add(Me.grid_consulta)
        Me.Name = "Pesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisa"
        CType(Me.grid_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_consulta As DataGridView
    Friend WithEvents lbl_Pesquisa As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_Pesquisa As Button
End Class
