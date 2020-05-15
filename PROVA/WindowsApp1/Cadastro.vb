
Public Class Cadastro
    Private DB As New Conexao
    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ADM_CONDataSet.TB_CONDOMINOS' table. You can move, or remove it, as needed.
        Me.TB_CONDOMINOSTableAdapter.Fill(Me.ADM_CONDataSet.TB_CONDOMINOS)

    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click

        Dim DS As DataSet = DB.ExecuteQuery("Insert into TB_CONDOMINOS Values (@Nome,@Endereco, @Email, @Telefone, @CPF, @CNPJ)")
        'Validação para campos em branco
        If txt_nome.Text = "" And
                txt_endereco.Text = "" And
                txt_email.Text = "" And
                cbo_tipoPessoa.SelectedIndex = "" And
                txt_cpf_cnpj.Text = "" And
                txt_tel.Text = "" Then
            MsgBox("Preencimento Obrigatório")
            txt_nome.Focus()
        End If

    End Sub
End Class