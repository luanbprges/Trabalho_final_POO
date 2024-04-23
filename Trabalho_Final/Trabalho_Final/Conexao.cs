using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql; //Referencia do provider de conexão do Postgresql.
using System.Windows.Forms;

namespace WfaCadastrodeCliente
{
    public class Conexao
    {
        NpgsqlConnection con = new NpgsqlConnection("Server = localhost; Port = 5432;Username = postgres; " +
                                                    "Password = aluno; Database = dbAlunos");

        public void getConectar()
        {
            con.Open();
            MessageBox.Show("Conectado");


        }

    }
}
