Public Class Form1
    Private Sub frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub menu_Principal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menu_Principal.ItemClicked

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PesquisaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PesquisaToolStripMenuItem1.Click
        Pesquisa.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Cadastro.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Sobre.Show()
    End Sub
End Class
