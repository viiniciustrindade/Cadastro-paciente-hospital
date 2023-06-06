using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_paciente_hospital
{
    public class DaoConnection
    {
        public static SqlConnection GetConexao() 
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True;MultipleActiveResultSets=true;");
            connection.Open();

            return connection;
        }
    }
}
