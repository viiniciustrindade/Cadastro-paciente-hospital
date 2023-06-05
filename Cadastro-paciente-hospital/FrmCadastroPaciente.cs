using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_paciente_hospital
{
    public partial class FrmCadastroPaciente : Form
    {
        public FrmCadastroPaciente()
        {
            InitializeComponent();
        }

        private void FrmCadastroPaciente_Load(object sender, EventArgs e)
        {

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
            lblExibirIdade.Text = $"Idade: {idade} anos";
            lblExibirIdade.Visible = true;
        }
    }

}
