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
            this.cbxSexo.Size = new System.Drawing.Size(42, 21);
            this.cbxSexo.TabIndex = 3;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(351, 12);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(99, 20);
            this.dtpDataNasc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 15);
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
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Enabled = false;
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
            this.txtMãe.Enabled = false;
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
            this.txtNacionalidade.Enabled = false;
            this.txtNacionalidade.Location = new System.Drawing.Point(651, 38);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(159, 20);
            this.txtNacionalidade.TabIndex = 18;
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.Enabled = false;
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
            this.txtEmail.Enabled = false;
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
            this.txtProfissao.Enabled = false;
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
            this.txtResponsavel.Enabled = false;
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
            this.txtCep.Enabled = false;
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
            this.txtRua.Enabled = false;
            this.txtRua.Location = new System.Drawing.Point(489, 117);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(321, 20);
            this.txtRua.TabIndex = 33;
            // 
            // FrmCadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 488);
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
    }
}

