Public Class Pesquisa
    Private DB As New Conexao
    Private Sub btn_Pesquisa_Click(sender As Object, e As EventArgs) Handles btn_Pesquisa.Click
        DB.conectaBanco() 'Abre a conexão com o Banco de Dados
        Dim DS As DataSet = DB.ExecuteQuery("SELECT * FROM TB_CONDOMINOS")

        grid_consulta.DataSource = DS.Tables(0)
        DB.fechaBanco()
    End Sub
End Class