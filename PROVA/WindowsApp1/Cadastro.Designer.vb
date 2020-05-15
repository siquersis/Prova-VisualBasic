<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro))
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_cpf_cnpj = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.cbo_tipoPessoa = New System.Windows.Forms.ComboBox()
        Me.ADM_CONDataSet = New WindowsApp1.ADM_CONDataSet()
        Me.TBCONDOMINOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_CONDOMINOSTableAdapter = New WindowsApp1.ADM_CONDataSetTableAdapters.TB_CONDOMINOSTableAdapter()
        CType(Me.ADM_CONDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBCONDOMINOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(21, 29)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(38, 13)
        Me.lbl_nome.TabIndex = 1
        Me.lbl_nome.Text = "Nome:"
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.Location = New System.Drawing.Point(21, 106)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(56, 13)
        Me.lbl_endereco.TabIndex = 2
        Me.lbl_endereco.Text = "Endereço:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(21, 140)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(38, 13)
        Me.lbl_email.TabIndex = 3
        Me.lbl_email.Text = "E-mail:"
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Location = New System.Drawing.Point(21, 172)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefone.TabIndex = 5
        Me.lbl_telefone.Text = "Telefone:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(58, 26)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(304, 20)
        Me.txt_nome.TabIndex = 8
        '
        'txt_cpf_cnpj
        '
        Me.txt_cpf_cnpj.Location = New System.Drawing.Point(185, 67)
        Me.txt_cpf_cnpj.Name = "txt_cpf_cnpj"
        Me.txt_cpf_cnpj.Size = New System.Drawing.Size(177, 20)
        Me.txt_cpf_cnpj.TabIndex = 9
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(79, 103)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(276, 20)
        Me.txt_endereco.TabIndex = 11
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(79, 137)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(211, 20)
        Me.txt_email.TabIndex = 12
        '
        'txt_tel
        '
        Me.txt_tel.Location = New System.Drawing.Point(79, 169)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(176, 20)
        Me.txt_tel.TabIndex = 13
        '
        'btn_salvar
        '
        Me.btn_salvar.Image = Global.WindowsApp1.My.Resources.Resources.save
        Me.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salvar.Location = New System.Drawing.Point(377, 26)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(160, 138)
        Me.btn_salvar.TabIndex = 0
        Me.btn_salvar.UseVisualStyleBackColor = True
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(21, 70)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_tipo.TabIndex = 14
        Me.lbl_tipo.Text = "Tipo:"
        '
        'cbo_tipoPessoa
        '
        Me.cbo_tipoPessoa.DataSource = Me.TBCONDOMINOSBindingSource
        Me.cbo_tipoPessoa.FormattingEnabled = True
        Me.cbo_tipoPessoa.Location = New System.Drawing.Point(58, 67)
        Me.cbo_tipoPessoa.Name = "cbo_tipoPessoa"
        Me.cbo_tipoPessoa.Size = New System.Drawing.Size(121, 21)
        Me.cbo_tipoPessoa.TabIndex = 15
        '
        'ADM_CONDataSet
        '
        Me.ADM_CONDataSet.DataSetName = "ADM_CONDataSet"
        Me.ADM_CONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBCONDOMINOSBindingSource
        '
        Me.TBCONDOMINOSBindingSource.DataMember = "TB_CONDOMINOS"
        Me.TBCONDOMINOSBindingSource.DataSource = Me.ADM_CONDataSet
        '
        'TB_CONDOMINOSTableAdapter
        '
        Me.TB_CONDOMINOSTableAdapter.ClearBeforeFill = True
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 242)
        Me.Controls.Add(Me.cbo_tipoPessoa)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_cpf_cnpj)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_endereco)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.btn_salvar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        CType(Me.ADM_CONDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBCONDOMINOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salvar As Button
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_endereco As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cpf_cnpj As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents cbo_tipoPessoa As ComboBox
    Friend WithEvents ADM_CONDataSet As ADM_CONDataSet
    Friend WithEvents TBCONDOMINOSBindingSource As BindingSource
    Friend WithEvents TB_CONDOMINOSTableAdapter As ADM_CONDataSetTableAdapters.TB_CONDOMINOSTableAdapter
End Class
