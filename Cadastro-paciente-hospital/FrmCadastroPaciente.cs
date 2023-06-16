using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cadastro_paciente_hospital
{
    public partial class FrmCadastroPaciente : Form
    {
        public FrmCadastroPaciente()
        {
            InitializeComponent();
        }
        private void LoadId()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtHospCadPac') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());


                txtCodigo.Text = proximoID.ToString();
            }
        }
            private void FrmCadastroPaciente_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
            LoadId();
            btnExcluir.Enabled = false;
            cbxSituacao.Text = "Vivo";

        }
        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
        private void dtpDataNasc_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataNascimento = dtpDataNasc.Value;
            int idade = CalcularIdade(dataNascimento);
            lblExibirIdade.Text = $"{idade} anos";
            lblExibirIdade.Visible = true;
 
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                PacienteDAO dao = new PacienteDAO(connection);
                List<PacienteModel> pacientes = dao.GetPacientes();
                foreach (PacienteModel paciente in pacientes)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodPaciente.Index].Value = paciente.codPaciente;
                    row.Cells[colSexo.Index].Value = paciente.sexo;
                    row.Cells[colDataNasc.Index].Value = paciente.dataNascimento.Substring(0, 10); ;
                    row.Cells[colNomePaciente.Index].Value = paciente.nomePaciente;
                    row.Cells[colCpf.Index].Value = paciente.cpf.Insert(9, "-").Insert(6, ".").Insert(3, ".");
                    row.Cells[colRg.Index].Value = paciente.rg;
                    row.Cells[colNacionalidade.Index].Value = paciente.nacionalidade;
                    row.Cells[colNaturalidade.Index].Value = paciente.naturalidade;
                    row.Cells[colMae.Index].Value = paciente.mae;
                    row.Cells[colCor.Index].Value = paciente.cor;
                    row.Cells[colEmail.Index].Value = paciente.email;
                    row.Cells[colProfissao.Index].Value = paciente.profissao;
                    row.Cells[colInstrucao.Index].Value = paciente.grauDeInstrucao;
                    row.Cells[colResponsavel.Index].Value = paciente.responsavel;
                    row.Cells[colCep.Index].Value = paciente.cep;
                    row.Cells[colRua.Index].Value = paciente.rua;
                    row.Cells[colBairro.Index].Value = paciente.bairro;
                    row.Cells[colCidade.Index].Value = paciente.cidade;
                    row.Cells[colTelefone.Index].Value = paciente.telefone;
                    row.Cells[colCelular.Index].Value = paciente.celular;
                    row.Cells[colContatoAlternativo.Index].Value = paciente.nomeContato;
                    row.Cells[colTelefoneContato.Index].Value = paciente.telefoneContato;
                    row.Cells[colObeservacoes.Index].Value = paciente.observacoes;
                    row.Cells[colSituacao.Index].Value = paciente.situacao;
                }
            }
        }
        private void ApagarCampos()
        {
            txtCodigo.Text = "";
            cbxSexo.SelectedIndex = -1;
            txtNomePaciente.Text = "";
            mskCpf.Text = "";
            mskRg.Text = "";
            txtNacionalidade.Text = "";
            txtMae.Text = "";
            cbxCor.Text = "";
            txtEmail.Text = "";
            txtProfissao.Text = "";
            txtNaturalidade.Text = "";
            cbxGrauInstucao.SelectedIndex = -1;
            txtResponsavel.Text = "";
            txtCep.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            mskTelefone.Text = "";
            mskCelular.Text = "";
            txtContatoAlternativo.Text = "";
            mskTelefoneContatoAlternativo.Text = "";
            txtObservacoes.Text = "";
            cbxSituacao.Visible = false;
            label25.Visible = false;
            cbxSituacao.Text = "Vivo";
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    PacienteDAO dao = new PacienteDAO(connection);
                    bool verificaRegistros = dao.Validacoes(new PacienteModel()
                    {
                        sexo = cbxSexo.Text,
                        cor = cbxCor.Text,
                    });
                    if (verificaRegistros)
                    {
                        int count = dao.VerificaRegistros(new PacienteModel()
                        {
                            codPaciente = txtCodigo.Text
                        });

                        if (count > 0)
                        {
                           
                            dao.Alterar(new PacienteModel()
                            {
                                codPaciente = txtCodigo.Text,
                                sexo = cbxSexo.Text,
                                nomePaciente = txtNomePaciente.Text,
                                cpf = mskCpf.Text.Replace(".", "").Replace("-", ""),
                                rg = mskRg.Text.Replace(".", "").Replace("-", ""),
                                nacionalidade = txtNacionalidade.Text,
                                mae = txtMae.Text,
                                cor = cbxCor.Text,
                                email = txtEmail.Text,
                                profissao = txtProfissao.Text,
                                naturalidade = txtNaturalidade.Text,
                                dataNascimento = dtpDataNasc.Value.Date.ToString(),
                                grauDeInstrucao = cbxGrauInstucao.Text,
                                responsavel = txtResponsavel.Text,
                                cep = txtCep.Text,
                                uf = cbxUf.Text,
                                rua = txtRua.Text,
                                bairro = txtBairro.Text,
                                cidade = txtCidade.Text,
                                telefone = mskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                                celular = mskCelular.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                                nomeContato = txtContatoAlternativo.Text,
                                telefoneContato = mskTelefoneContatoAlternativo.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                                observacoes = txtObservacoes.Text,
                                situacao = cbxSituacao.Text
                            });
                            MessageBox.Show("Registro do paciente atualizado com sucesso!");
                            ApagarCampos();
                        }
                        else
                        {
                            dao.Salvar(new PacienteModel()
                            {
                                sexo = cbxSexo.Text,
                                nomePaciente = txtNomePaciente.Text,
                                cpf = mskCpf.Text.Replace(".", "").Replace("-", ""),
                                rg = mskRg.Text.Replace(".", "").Replace("-", ""),
                                nacionalidade = txtNacionalidade.Text,
                                mae = txtMae.Text,
                                cor = cbxCor.Text,
                                email = txtEmail.Text,
                                profissao = txtProfissao.Text,
                                naturalidade = txtNaturalidade.Text,
                                dataNascimento = dtpDataNasc.Value.Date.ToString(),
                                grauDeInstrucao = cbxGrauInstucao.Text,
                                responsavel = txtResponsavel.Text,
                                cep = txtCep.Text,
                                uf = cbxUf.Text,
                                rua = txtRua.Text,
                                bairro = txtBairro.Text,
                                cidade = txtCidade.Text,
                                telefone = mskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                                celular = mskCelular.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                                nomeContato = txtContatoAlternativo.Text,
                                telefoneContato = mskTelefoneContatoAlternativo.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                                observacoes = txtObservacoes.Text,
                                situacao = cbxSituacao.Text
                            });
                            MessageBox.Show("Registro do paciente Salvo com sucesso!");
                            ApagarCampos();
                        }
                    }
                    CarregarUsuariosGrid();
                    LoadId();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar o registro!\n{ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxSexo.Text))
            {
                MessageBox.Show("Paciente não foi selecionado!", "Atenção");
                return;
            }
            DialogResult conf = MessageBox.Show("Deseja excluir o registro do paciente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try 
            { 
                if (conf == DialogResult.Yes)
                { 
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        PacienteDAO dao = new PacienteDAO(connection);
                            dao.Excluir(new PacienteModel()
                            {
                                codPaciente = txtCodigo.Text
                            });
                    }
                    MessageBox.Show("Registro excluído com sucesso!");
                    CarregarUsuariosGrid();
                    ApagarCampos();
                    LoadId();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir o registro!\n{ex.Message}");
            }
        }

        private void dadosGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            { 
                txtCodigo.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodPaciente.Index].Value + "";
                txtNomePaciente.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomePaciente.Index].Value + "";
                cbxSexo.Text = dadosGrid.Rows[e.RowIndex].Cells[colSexo.Index].Value + "";
                dtpDataNasc.Text = dadosGrid.Rows[e.RowIndex].Cells[colDataNasc.Index].Value + "";
                mskCpf.Text = dadosGrid.Rows[e.RowIndex].Cells[colCpf.Index].Value + "";
                mskRg.Text = dadosGrid.Rows[e.RowIndex].Cells[colRg.Index].Value + "";
                txtNacionalidade.Text = dadosGrid.Rows[e.RowIndex].Cells[colNacionalidade.Index].Value + "";
                txtNaturalidade.Text = dadosGrid.Rows[e.RowIndex].Cells[colNaturalidade.Index].Value + "";
                txtMae.Text = dadosGrid.Rows[e.RowIndex].Cells[colMae.Index].Value + "";
                cbxCor.Text = dadosGrid.Rows[e.RowIndex].Cells[colCor.Index].Value + "";
                txtEmail.Text = dadosGrid.Rows[e.RowIndex].Cells[colEmail.Index].Value + "";
                txtProfissao.Text = dadosGrid.Rows[e.RowIndex].Cells[colProfissao.Index].Value + "";
                cbxGrauInstucao.Text = dadosGrid.Rows[e.RowIndex].Cells[colInstrucao.Index].Value + "";
                txtResponsavel.Text = dadosGrid.Rows[e.RowIndex].Cells[colResponsavel.Index].Value + "";
                txtCep.Text = dadosGrid.Rows[e.RowIndex].Cells[colCep.Index].Value + "";
                txtRua.Text = dadosGrid.Rows[e.RowIndex].Cells[colRua.Index].Value + "";
                txtBairro.Text = dadosGrid.Rows[e.RowIndex].Cells[colBairro.Index].Value + "";
                txtCidade.Text = dadosGrid.Rows[e.RowIndex].Cells[colCidade.Index].Value + "";
                mskTelefone.Text = dadosGrid.Rows[e.RowIndex].Cells[colTelefone.Index].Value + "";
                mskCelular.Text = dadosGrid.Rows[e.RowIndex].Cells[colTelefone.Index].Value + "";
                mskTelefoneContatoAlternativo.Text = dadosGrid.Rows[e.RowIndex].Cells[colTelefoneContato.Index].Value + "";
                txtContatoAlternativo.Text = dadosGrid.Rows[e.RowIndex].Cells[colContatoAlternativo.Index].Value + "";
                txtObservacoes.Text = dadosGrid.Rows[e.RowIndex].Cells[colObeservacoes.Index].Value + "";
                cbxSituacao.Text = dadosGrid.Rows[e.RowIndex].Cells[colSituacao.Index].Value + "";
                if (string.IsNullOrEmpty(this.cbxSexo.Text))
                {
                    btnExcluir.Enabled = false;
                    LoadId();
                }
                else
                {
                    btnExcluir.Enabled = true;
                    cbxSituacao.Visible = true;
                    label25.Visible = true;
                }
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Somente números são permitidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInternacao_Click(object sender, EventArgs e)
        {
            Registro_de_internacao.FrmRegistroDeInternacao frmRegistroDeInternacao = new Registro_de_internacao.FrmRegistroDeInternacao();
            frmRegistroDeInternacao.ShowDialog();
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("O e-mail fornecido não é válido.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        private void mskCpf_Validating(object sender, CancelEventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                PacienteDAO dao = new PacienteDAO(connection);
                int count = dao.VerficaCpf(new PacienteModel()
                {
                    cpf = mskCpf.Text.Replace(".", "").Replace("-", "")
                });
                if (count > 0)
                { MessageBox.Show("O CPF fornecido ja foi cadastrado.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error); e.Cancel = true; }
            }
        }

        private void mskRg_Validating(object sender, CancelEventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                PacienteDAO dao = new PacienteDAO(connection);
                int count = dao.VerficaRg(new PacienteModel()
                {
                    rg = mskRg.Text.Replace(".", "").Replace("-", "")
                });
                if (count > 0)
                { MessageBox.Show("O RG fornecido ja foi cadastrado.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error); e.Cancel = true; }
            }
        }
    }
}
