using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAMBAM
{
    class Connection
    {
        static string conexaoString = "DATA SOURCE=DESKTOP-EGEHPJ2; INITIAL CATALOG=BancoAluno; Trusted_Connection=True";
        static SqlConnection conn;

        public SqlConnection conectar()
        {
            conn = new SqlConnection(conexaoString);
            try
            {
                conn.Open();
                //MessageBox.Show("Banco conectado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao se conectar ao banco de dados " + e, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return conn;
        }
        public void desconectar()
        {
            conn.Close();
        }
    }
}

