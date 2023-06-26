using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_paciente_hospital
{
    public class PacienteDAO
    {
        private SqlConnection Connection { get; }
        public PacienteDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("INSERT INTO mvtHospCadPac (sexoPaciente, dataNascPaciente, nomePaciente, nomeMaePaciente, cpfPaciente, rgPaciente, corPaciente, nacionalidade, naturalidade," +
                        "grauDeInstrucao, profissao, responsavel, cep, bairro, cidade, telefone, telefoneCelular, uf, rua, contatoAlternativo, telefoneContatoAlternativo, emailPaciente, oberservacaoPaciente, situacao, numero) " +
                        "VALUES(@sexoPaciente, @dataNascPaciente, @nomePaciente, @nomeMaePaciente, @cpfPaciente, @rgPaciente, @corPaciente, @nacionalidade, @naturalidade," +
                        "@grauDeInstrucao, @profissao, @responsavel, @cep, @bairro, @cidade, @telefone, @telefoneCelular, @uf, @rua, @contatoAlternativo, @telefoneContatoAlternativo, @emailPaciente, @observacaoPaciente, @situacao, @numero)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@sexoPaciente", paciente.sexo));
                    command.Parameters.Add(new SqlParameter("@dataNascPaciente", paciente.dataNascimento));
                    command.Parameters.Add(new SqlParameter("@nomePaciente", paciente.nomePaciente));
                    command.Parameters.Add(new SqlParameter("@nomeMaePaciente", paciente.mae));
                    command.Parameters.Add(new SqlParameter("@cpfPaciente", paciente.cpf));
                    command.Parameters.Add(new SqlParameter("@rgPaciente", paciente.rg));
                    command.Parameters.Add(new SqlParameter("@corPaciente", paciente.cor));
                    command.Parameters.Add(new SqlParameter("@nacionalidade", paciente.nacionalidade));
                    command.Parameters.Add(new SqlParameter("@naturalidade", paciente.naturalidade));
                    command.Parameters.Add(new SqlParameter("@grauDeInstrucao", paciente.grauDeInstrucao));
                    command.Parameters.Add(new SqlParameter("@profissao", paciente.profissao));
                    command.Parameters.Add(new SqlParameter("@responsavel", paciente.responsavel));
                    command.Parameters.Add(new SqlParameter("@cep", paciente.cep));
                    command.Parameters.Add(new SqlParameter("@bairro", paciente.bairro));
                    command.Parameters.Add(new SqlParameter("@cidade", paciente.cidade));
                    command.Parameters.Add(new SqlParameter("@telefone", paciente.telefone));
                    command.Parameters.Add(new SqlParameter("@telefoneCelular", paciente.celular));
                    command.Parameters.Add(new SqlParameter("@uf", paciente.uf));
                    command.Parameters.Add(new SqlParameter("@rua", paciente.rua));
                    command.Parameters.Add(new SqlParameter("@contatoAlternativo", paciente.nomeContato));
                    command.Parameters.Add(new SqlParameter("@telefoneContatoAlternativo", paciente.telefoneContato));
                    command.Parameters.Add(new SqlParameter("@emailPaciente", paciente.email));
                    command.Parameters.Add(new SqlParameter("@observacaoPaciente", paciente.observacoes));
                    command.Parameters.Add(new SqlParameter("@situacao", paciente.situacao));
                    command.Parameters.Add(new SqlParameter("@numero", paciente.numero));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public bool Validacoes(PacienteModel paciente)
        {
            if (string.IsNullOrEmpty(paciente.sexo) || string.IsNullOrWhiteSpace(paciente.sexo))
            {
                MessageBox.Show("Informe o campo [Sexo]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(paciente.cor) || string.IsNullOrWhiteSpace(paciente.cor))
            {
                MessageBox.Show("Informe o campo [Cor]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public int VerificaRegistros(PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codPaciente) FROM mvtHospCadPac WHERE codPaciente = @codPaciente");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codPaciente", paciente.codPaciente);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }
        public void Alterar(PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    //Excluir(codAutor, t);

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtHospCadPac SET sexoPaciente = @sexoPaciente, dataNascPaciente = @dataNascPaciente, nomePaciente = @nomePaciente, nomeMaePaciente = @nomeMaePaciente, cpfPaciente = @cpfPaciente," +
                        $"rgPaciente = @rgPaciente, corPaciente = @corPaciente, nacionalidade = @nacionalidade, naturalidade = @naturalidade, grauDeInstrucao = @grauDeInstrucao," +
                        $"profissao = @profissao, responsavel = @responsavel, cep = @cep, bairro = @bairro, cidade = @cidade, telefone = @telefone, telefoneCelular = @telefoneCelular, uf = @uf, rua = @rua, " +
                        $"contatoAlternativo = @contatoAlternativo, telefoneContatoAlternativo = @telefoneContatoAlternativo, numero = @numero, emailPaciente = @emailPaciente, oberservacaoPaciente = @observacaoPaciente, situacao = @situacao WHERE codPaciente = @codPaciente");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codPaciente", paciente.codPaciente);
                    command.Parameters.Add(new SqlParameter("@sexoPaciente", paciente.sexo));
                    command.Parameters.Add(new SqlParameter("@dataNascPaciente", paciente.dataNascimento));
                    command.Parameters.Add(new SqlParameter("@nomePaciente", paciente.nomePaciente));
                    command.Parameters.Add(new SqlParameter("@nomeMaePaciente", paciente.mae));
                    command.Parameters.Add(new SqlParameter("@cpfPaciente", paciente.cpf));
                    command.Parameters.Add(new SqlParameter("@rgPaciente", paciente.rg));
                    command.Parameters.Add(new SqlParameter("@corPaciente", paciente.cor));
                    command.Parameters.Add(new SqlParameter("@nacionalidade", paciente.nacionalidade));
                    command.Parameters.Add(new SqlParameter("@naturalidade", paciente.naturalidade));
                    command.Parameters.Add(new SqlParameter("@grauDeInstrucao", paciente.grauDeInstrucao));
                    command.Parameters.Add(new SqlParameter("@profissao", paciente.profissao));
                    command.Parameters.Add(new SqlParameter("@responsavel", paciente.responsavel));
                    command.Parameters.Add(new SqlParameter("@cep", paciente.cep));
                    command.Parameters.Add(new SqlParameter("@bairro", paciente.bairro));
                    command.Parameters.Add(new SqlParameter("@cidade", paciente.cidade));
                    command.Parameters.Add(new SqlParameter("@telefone", paciente.telefone));
                    command.Parameters.Add(new SqlParameter("@telefoneCelular", paciente.celular));
                    command.Parameters.Add(new SqlParameter("@uf", paciente.uf));
                    command.Parameters.Add(new SqlParameter("@rua", paciente.rua));
                    command.Parameters.Add(new SqlParameter("@contatoAlternativo", paciente.nomeContato));
                    command.Parameters.Add(new SqlParameter("@telefoneContatoAlternativo", paciente.telefoneContato));
                    command.Parameters.Add(new SqlParameter("@emailPaciente", paciente.email));
                    command.Parameters.Add(new SqlParameter("@observacaoPaciente", paciente.observacoes));
                    command.Parameters.Add(new SqlParameter("@situacao", paciente.situacao));
                    command.Parameters.Add(new SqlParameter("@numero", paciente.numero));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public int VerficaCpf(PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(cpfPaciente) FROM mvtHospCadPac WHERE cpfPaciente = @cpfPaciente");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@cpfPaciente", paciente.cpf);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }
        public int VerficaRg(PacienteModel paciente)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(rgPaciente) FROM mvtHospCadPac WHERE rgPaciente = @rgPaciente");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@rgPaciente", paciente.rg);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }
        public void Excluir(PacienteModel paciente, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtMovPac WHERE codPaciente = @codPaciente");
                sql.AppendLine($"DELETE FROM mvtHospRegInt WHERE codPaciente = @codPaciente");
                sql.AppendLine($"DELETE FROM mvtHospCadPac WHERE codPaciente = @codPaciente");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codPaciente", paciente.codPaciente));
                command.ExecuteNonQuery();
            }
        }
        public List<PacienteModel> GetPacientes()
        {
            List<PacienteModel> pacientes = new List<PacienteModel>();
            SqlCommand command = Connection.CreateCommand();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT codPaciente, sexoPaciente, dataNascPaciente, nomePaciente, nomeMaePaciente, cpfPaciente, rgPaciente, corPaciente, nacionalidade, naturalidade," +
                "grauDeInstrucao, profissao, responsavel, cep, bairro, cidade, telefone, telefoneCelular, uf, rua, contatoAlternativo, telefoneContatoAlternativo, emailPaciente, oberservacaoPaciente, situacao, numero" +
                " FROM mvtHospCadPac ORDER BY codPaciente ASC");
            command.CommandText = sql.ToString();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    pacientes.Add(PopulateDr(dr));
                }
            }
            //}
            return pacientes;
        }
        public int CarregarID()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtHospCadPac') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());
                return proximoID;
            }
        }
        private PacienteModel PopulateDr(SqlDataReader dr)
        {
            string codPaciente = "";
            string sexoPaciente = "";
            string dataNascPaciente = "";
            string nomePaciente = "";
            string nomeMaePaciente = "";
            string cpfPaciente = "";
            string rgPaciente = "";
            string corPaciente = "";
            string nacionalidade = "";
            string naturalidade = "";
            string grauDeInstrucao = "";
            string profissao = "";
            string responsavel = "";
            string cep = "";
            string bairro = "";
            string cidade = "";
            string telefone = "";
            string telefoneCelular = "";
            string uf = "";
            string rua = "";
            string contatoAlternativo = "";
            string telefoneContatoAlternativo = "";
            string emailPaciente = "";
            string oberservacaoPaciente = "";
            string situacao = "";
            string numero = "";

            if (DBNull.Value != dr["codPaciente"])
            {
                codPaciente = dr["codPaciente"] + "";
            }
            if (DBNull.Value != dr["sexoPaciente"])
            {
                sexoPaciente = dr["sexoPaciente"] + "";
            }
            if (DBNull.Value != dr["dataNascPaciente"])
            {
                dataNascPaciente = dr["dataNascPaciente"].ToString().Substring(0, 10) + "";
            }
            if (DBNull.Value != dr["nomePaciente"])
            {
                nomePaciente = dr["nomePaciente"] + "";
            }
            if (DBNull.Value != dr["cpfPaciente"])
            {
                string cpf = dr["cpfPaciente"].ToString();
                if (cpf.Length == 11)
                {
                    cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";
                }
                cpfPaciente = cpf;
            }
            if (DBNull.Value != dr["nomeMaePaciente"])
            {
                nomeMaePaciente = dr["nomeMaePaciente"] + "";
            }
            if (DBNull.Value != dr["rgPaciente"])
            {
                rgPaciente = dr["rgPaciente"] + "";
            }
            if (DBNull.Value != dr["corPaciente"])
            {
                corPaciente = dr["corPaciente"] + "";
            }           
            if (DBNull.Value != dr["numero"])
            {
                numero = dr["numero"] + "";
            }
            if (DBNull.Value != dr["nacionalidade"])
            {
                nacionalidade = dr["nacionalidade"] + "";
            }
            if (DBNull.Value != dr["naturalidade"])
            {
                naturalidade = dr["naturalidade"] + "";
            }
            if (DBNull.Value != dr["grauDeInstrucao"])
            {
                grauDeInstrucao = dr["grauDeInstrucao"] + "";
            }
            if (DBNull.Value != dr["profissao"])
            {
                profissao = dr["profissao"] + "";
            }
            if (DBNull.Value != dr["responsavel"])
            {
                responsavel = dr["responsavel"] + "";
            }
            if (DBNull.Value != dr["cep"])
            {
                cep = dr["cep"] + "";
            }
            if (DBNull.Value != dr["bairro"])
            {
                bairro = dr["bairro"] + "";
            }
            if (DBNull.Value != dr["cidade"])
            {
                cidade = dr["cidade"] + "";
            }
            if (DBNull.Value != dr["telefone"])
            {
                telefone = dr["telefone"] + "";
            }
            if (DBNull.Value != dr["telefoneCelular"])
            {
                telefoneCelular = dr["telefoneCelular"] + "";
            }
            if (DBNull.Value != dr["uf"])
            {
                uf = dr["uf"] + "";
            } 
            if (DBNull.Value != dr["rua"])
            {
                rua = dr["rua"] + "";
            }
            if (DBNull.Value != dr["telefoneContatoAlternativo"])
            {
                telefoneContatoAlternativo = dr["telefoneContatoAlternativo"] + "";
            }
            if (DBNull.Value != dr["contatoAlternativo"])
            {
                contatoAlternativo = dr["contatoAlternativo"] + "";
            }
            if (DBNull.Value != dr["emailPaciente"])
            {
                emailPaciente = dr["emailPaciente"] + "";
            }
            if (DBNull.Value != dr["oberservacaoPaciente"])
            {
                oberservacaoPaciente = dr["oberservacaoPaciente"] + "";
            }
            if (DBNull.Value != dr["situacao"])
            {
                situacao = dr["situacao"] + "";
            }
            return new PacienteModel()
            {
                codPaciente = codPaciente,
                sexo = sexoPaciente,
                dataNascimento = dataNascPaciente,
                nomePaciente = nomePaciente,
                mae = nomeMaePaciente,
                cpf = cpfPaciente,
                rg = rgPaciente,
                cor = corPaciente,
                nacionalidade = nacionalidade,
                naturalidade = naturalidade,
                grauDeInstrucao = grauDeInstrucao,
                profissao = profissao,
                responsavel = responsavel,
                cep = cep,
                bairro = bairro,
                cidade = cidade,
                telefone = telefone,
                celular = telefoneCelular,
                uf = uf,
                nomeContato = contatoAlternativo,
                telefoneContato = telefoneContatoAlternativo,
                email = emailPaciente,
                observacoes = oberservacaoPaciente,
                situacao = situacao,
                rua = rua,
                numero = numero
            };
        }
    }
}
