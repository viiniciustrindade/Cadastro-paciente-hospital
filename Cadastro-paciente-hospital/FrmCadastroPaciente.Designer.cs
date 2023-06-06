namespace Cadastro_paciente_hospital
{
    partial class FrmCadastroPaciente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExibirIdade = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMãe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtNaturalidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxGrauInstucao = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtContatoAlternativo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.mskTelefoneContatoAlternativo = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.btnInternacao = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNaturalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInstrucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContatoAlternativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefoneContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObeservacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(87, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxSexo.Location = new System.Drawing.Point(193, 12);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(47, 21);
            this.cbxSexo.TabIndex = 3;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(346, 12);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(104, 20);
            this.dtpDataNasc.TabIndex = 4;
            this.dtpDataNasc.Value = new System.DateTime(2004, 7, 14, 0, 0, 0, 0);
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataNasc_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de nascimento";
            // 
            // lblExibirIdade
            // 
            this.lblExibirIdade.AutoSize = true;
            this.lblExibirIdade.ForeColor = System.Drawing.Color.Red;
            this.lblExibirIdade.Location = new System.Drawing.Point(456, 15);
            this.lblExibirIdade.Name = "lblExibirIdade";
            this.lblExibirIdade.Size = new System.Drawing.Size(45, 13);
            this.lblExibirIdade.TabIndex = 6;
            this.lblExibirIdade.Text = "23 anos";
            this.lblExibirIdade.Visible = false;
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(87, 38);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(224, 20);
            this.txtNomePaciente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cpf";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(346, 38);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(104, 20);
            this.mskCpf.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rg";
            // 
            // mskRg
            // 
            this.mskRg.Location = new System.Drawing.Point(483, 38);
            this.mskRg.Mask = "00,000,000-0";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(81, 20);
            this.mskRg.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mãe";
            // 
            // txtMãe
            // 
            this.txtMãe.Location = new System.Drawing.Point(87, 64);
            this.txtMãe.Name = "txtMãe";
            this.txtMãe.Size = new System.Drawing.Size(224, 20);
            this.txtMãe.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cor";
            // 
            // cbxCor
            // 
            this.cbxCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCor.FormattingEnabled = true;
            this.cbxCor.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Pardo",
            "Amarelo",
            "Indígena"});
            this.cbxCor.Location = new System.Drawing.Point(346, 64);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(104, 21);
            this.cbxCor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(570, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nacionalidade";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(651, 38);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(159, 20);
            this.txtNacionalidade.TabIndex = 18;
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.Location = new System.Drawing.Point(390, 90);
            this.txtNaturalidade.Name = "txtNaturalidade";
            this.txtNaturalidade.Size = new System.Drawing.Size(156, 20);
            this.txtNaturalidade.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Naturalidade";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(494, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(552, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Grau de instrução";
            // 
            // cbxGrauInstucao
            // 
            this.cbxGrauInstucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrauInstucao.FormattingEnabled = true;
            this.cbxGrauInstucao.Items.AddRange(new object[] {
            "Ensino Fundamental Incompleto",
            "Ensino Fundamental Completo",
            "Ensino Médio Incompleto",
            "Ensino Médio Completo",
            "Ensino Técnico Incompleto",
            "Ensino Técnico Completo",
            "Ensino Superior Incompleto",
            "Ensino Superior Completo",
            "Especialização",
            "Mestrado",
            "Doutorado",
            "Pós-doutorado"});
            this.cbxGrauInstucao.Location = new System.Drawing.Point(649, 90);
            this.cbxGrauInstucao.Name = "cbxGrauInstucao";
            this.cbxGrauInstucao.Size = new System.Drawing.Size(161, 21);
            this.cbxGrauInstucao.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Profissão";
            // 
            // txtProfissao
            // 
            this.txtProfissao.Location = new System.Drawing.Point(87, 91);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(224, 20);
            this.txtProfissao.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Responsavel";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(87, 117);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(224, 20);
            this.txtResponsavel.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Cep";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(349, 117);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(101, 20);
            this.txtCep.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(456, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(489, 117);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(321, 20);
            this.txtRua.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(87, 141);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(111, 20);
            this.txtBairro.TabIndex = 35;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(248, 141);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(202, 20);
            this.txtCidade.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(203, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Cidade";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(458, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(510, 141);
            this.mskTelefone.Mask = "(00) 00000 - 0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(90, 20);
            this.mskTelefone.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(605, 144);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Celular";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(648, 141);
            this.mskCelular.Mask = "(00) 00000 - 0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(90, 20);
            this.mskCelular.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 170);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Nome contato alternativo";
            // 
            // txtContatoAlternativo
            // 
            this.txtContatoAlternativo.Location = new System.Drawing.Point(144, 167);
            this.txtContatoAlternativo.Name = "txtContatoAlternativo";
            this.txtContatoAlternativo.Size = new System.Drawing.Size(214, 20);
            this.txtContatoAlternativo.TabIndex = 43;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(364, 170);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "Telefone contato alternativo";
            // 
            // mskTelefoneContatoAlternativo
            // 
            this.mskTelefoneContatoAlternativo.Location = new System.Drawing.Point(510, 167);
            this.mskTelefoneContatoAlternativo.Mask = "(00) 00000 - 0000";
            this.mskTelefoneContatoAlternativo.Name = "mskTelefoneContatoAlternativo";
            this.mskTelefoneContatoAlternativo.Size = new System.Drawing.Size(90, 20);
            this.mskTelefoneContatoAlternativo.TabIndex = 45;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 201);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(89, 193);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(721, 37);
            this.txtObservacoes.TabIndex = 47;
            // 
            // btnInternacao
            // 
            this.btnInternacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInternacao.Location = new System.Drawing.Point(722, 235);
            this.btnInternacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInternacao.Name = "btnInternacao";
            this.btnInternacao.Size = new System.Drawing.Size(88, 21);
            this.btnInternacao.TabIndex = 48;
            this.btnInternacao.Text = "Internação";
            this.btnInternacao.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(632, 235);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 21);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(542, 235);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 21);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodPaciente,
            this.colNomePaciente,
            this.colSexo,
            this.colDataNasc,
            this.colCpf,
            this.colRg,
            this.colNacionalidade,
            this.colMae,
            this.colCor,
            this.colEmail,
            this.colProfissao,
            this.colNaturalidade,
            this.colInstrucao,
            this.colResponsavel,
            this.colCep,
            this.colRua,
            this.colBairro,
            this.colCidade,
            this.colTelefone,
            this.colCelular,
            this.colContatoAlternativo,
            this.colTelefoneContato,
            this.colObeservacoes});
            this.dadosGrid.Location = new System.Drawing.Point(14, 261);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(796, 217);
            this.dadosGrid.TabIndex = 51;
            // 
            // colCodPaciente
            // 
            this.colCodPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodPaciente.FillWeight = 152.2843F;
            this.colCodPaciente.HeaderText = "Codigo paciente";
            this.colCodPaciente.MinimumWidth = 6;
            this.colCodPaciente.Name = "colCodPaciente";
            this.colCodPaciente.ReadOnly = true;
            // 
            // colNomePaciente
            // 
            this.colNomePaciente.HeaderText = "Nome paciente";
            this.colNomePaciente.MinimumWidth = 6;
            this.colNomePaciente.Name = "colNomePaciente";
            this.colNomePaciente.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.MinimumWidth = 6;
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colDataNasc
            // 
            this.colDataNasc.HeaderText = "Data de nascimento";
            this.colDataNasc.MinimumWidth = 6;
            this.colDataNasc.Name = "colDataNasc";
            this.colDataNasc.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "Cpf";
            this.colCpf.MinimumWidth = 6;
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colRg
            // 
            this.colRg.HeaderText = "Rg";
            this.colRg.MinimumWidth = 6;
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            this.colRg.Visible = false;
            // 
            // colNacionalidade
            // 
            this.colNacionalidade.HeaderText = "Nacionalidade";
            this.colNacionalidade.MinimumWidth = 6;
            this.colNacionalidade.Name = "colNacionalidade";
            this.colNacionalidade.ReadOnly = true;
            this.colNacionalidade.Visible = false;
            // 
            // colMae
            // 
            this.colMae.HeaderText = "Mãe";
            this.colMae.MinimumWidth = 6;
            this.colMae.Name = "colMae";
            this.colMae.ReadOnly = true;
            this.colMae.Visible = false;
            // 
            // colCor
            // 
            this.colCor.HeaderText = "Cor";
            this.colCor.MinimumWidth = 6;
            this.colCor.Name = "colCor";
            this.colCor.ReadOnly = true;
            this.colCor.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            // 
            // colProfissao
            // 
            this.colProfissao.HeaderText = "Profissão";
            this.colProfissao.MinimumWidth = 6;
            this.colProfissao.Name = "colProfissao";
            this.colProfissao.ReadOnly = true;
            this.colProfissao.Visible = false;
            // 
            // colNaturalidade
            // 
            this.colNaturalidade.HeaderText = "Naturalidade";
            this.colNaturalidade.MinimumWidth = 6;
            this.colNaturalidade.Name = "colNaturalidade";
            this.colNaturalidade.ReadOnly = true;
            this.colNaturalidade.Visible = false;
            // 
            // colInstrucao
            // 
            this.colInstrucao.HeaderText = "Grau de instrução";
            this.colInstrucao.MinimumWidth = 6;
            this.colInstrucao.Name = "colInstrucao";
            this.colInstrucao.ReadOnly = true;
            this.colInstrucao.Visible = false;
            // 
            // colResponsavel
            // 
            this.colResponsavel.HeaderText = "Responsavel";
            this.colResponsavel.MinimumWidth = 6;
            this.colResponsavel.Name = "colResponsavel";
            this.colResponsavel.ReadOnly = true;
            this.colResponsavel.Visible = false;
            // 
            // colCep
            // 
            this.colCep.HeaderText = "Cep";
            this.colCep.MinimumWidth = 6;
            this.colCep.Name = "colCep";
            this.colCep.ReadOnly = true;
            this.colCep.Visible = false;
            // 
            // colRua
            // 
            this.colRua.HeaderText = "Rua";
            this.colRua.MinimumWidth = 6;
            this.colRua.Name = "colRua";
            this.colRua.ReadOnly = true;
            this.colRua.Visible = false;
            // 
            // colBairro
            // 
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.MinimumWidth = 6;
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Visible = false;
            // 
            // colCidade
            // 
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.MinimumWidth = 6;
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            this.colCidade.Visible = false;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.MinimumWidth = 6;
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Visible = false;
            // 
            // colCelular
            // 
            this.colCelular.HeaderText = "Celular";
            this.colCelular.MinimumWidth = 6;
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            this.colCelular.Visible = false;
            // 
            // colContatoAlternativo
            // 
            this.colContatoAlternativo.HeaderText = "Contato alternativo";
            this.colContatoAlternativo.MinimumWidth = 6;
            this.colContatoAlternativo.Name = "colContatoAlternativo";
            this.colContatoAlternativo.ReadOnly = true;
            this.colContatoAlternativo.Visible = false;
            // 
            // colTelefoneContato
            // 
            this.colTelefoneContato.HeaderText = "Telefone contato";
            this.colTelefoneContato.MinimumWidth = 6;
            this.colTelefoneContato.Name = "colTelefoneContato";
            this.colTelefoneContato.ReadOnly = true;
            this.colTelefoneContato.Visible = false;
            // 
            // colObeservacoes
            // 
            this.colObeservacoes.HeaderText = "Oberservações";
            this.colObeservacoes.MinimumWidth = 6;
            this.colObeservacoes.Name = "colObeservacoes";
            this.colObeservacoes.ReadOnly = true;
            this.colObeservacoes.Visible = false;
            // 
            // FrmCadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 488);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInternacao);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.mskTelefoneContatoAlternativo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtContatoAlternativo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxGrauInstucao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNaturalidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMãe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskRg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.lblExibirIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroPaciente";
            this.Text = "Cadastro paciente";
            this.Load += new System.EventHandler(this.FrmCadastroPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExibirIdade;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMãe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxCor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtNaturalidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxGrauInstucao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtContatoAlternativo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox mskTelefoneContatoAlternativo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Button btnInternacao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMae;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNaturalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInstrucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContatoAlternativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefoneContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObeservacoes;
    }
}

