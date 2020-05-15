<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.menu_Principal = New System.Windows.Forms.MenuStrip()
        Me.OpcaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_Principal
        '
        Me.menu_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcaoToolStripMenuItem, Me.SairToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.menu_Principal.Location = New System.Drawing.Point(0, 0)
        Me.menu_Principal.Name = "menu_Principal"
        Me.menu_Principal.Size = New System.Drawing.Size(789, 24)
        Me.menu_Principal.TabIndex = 0
        Me.menu_Principal.Text = "MenuStrip1"
        '
        'OpcaoToolStripMenuItem
        '
        Me.OpcaoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.PesquisaToolStripMenuItem1})
        Me.OpcaoToolStripMenuItem.Name = "OpcaoToolStripMenuItem"
        Me.OpcaoToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.OpcaoToolStripMenuItem.Text = "Opções"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'PesquisaToolStripMenuItem1
        '
        Me.PesquisaToolStripMenuItem1.Name = "PesquisaToolStripMenuItem1"
        Me.PesquisaToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.PesquisaToolStripMenuItem1.Text = "Pesquisa"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 450)
        Me.Controls.Add(Me.menu_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_Principal
        Me.Name = "frm_Principal"
        Me.Text = "Administradora de Condomínios - Prova"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menu_Principal.ResumeLayout(False)
        Me.menu_Principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_Principal As MenuStrip
    Friend WithEvents OpcaoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesquisaToolStripMenuItem1 As ToolStripMenuItem
End Class
