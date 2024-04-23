using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WfaCadastrodeCliente;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Trabalho_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notchecked();
        }

        public void notchecked()
        {
            if ((rbAluno.Checked != true) && (rbMateria.Checked != true))
            {
                lb_nome.Text = string.Empty;
                lb_matricula.Text = string.Empty;
                lb_nascimento.Text = string.Empty;

                tb_nome.Visible = false;
                tb_matricula.Visible = false;
                tb_nascimento.Visible = false;
            }

        }

        private void MensagemBotao(string nomelabel)
        {
            MessageBox.Show("Voce deve Informar o " + nomelabel + "!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool CheckTextBoxes()
        {
            bool check = true;

            if (tb_nascimento.MaskCompleted == false)    // Verifica se a mascara foi digitada completamente
            {
                MensagemBotao(lb_nascimento.Text);
                check = false;
            }
            else if (tb_nome.Text.Trim() == string.Empty) // Verifica se a texte box está vazia
            {
                MensagemBotao(lb_nome.Text);
                check = false;
            }
            else if (tb_matricula.Text.Trim() == string.Empty)
            {
                MensagemBotao(lb_matricula.Text);
                check = false;
            }

            return check;
        }

        public void limparTextbox()
        {
            tb_nome.Text = string.Empty;
            tb_matricula.Text = string.Empty;
            tb_nascimento.Text = string.Empty;

            tb_ident.Text = string.Empty;
            tb_mat.Text = string.Empty;
        }

        private void rbAluno_CheckedChanged(object sender, EventArgs e)
        {
            limparTextbox();
            lb_nome.Text = "Nome do Aluno:";
            lb_matricula.Text = "N° de Matrícula:";
            lb_nascimento.Text = "Data de Nascimento:";

            tb_nome.Visible = true;
            tb_matricula.Visible = true;
            tb_nascimento.Visible = true;
            tb_nascimento.Mask = "00.00.0000"; //Cria mascara para data de nascimento
        }

        private void rbMateria_CheckedChanged(object sender, EventArgs e)
        {
            limparTextbox();
            lb_nome.Text = "Nome da Matéria:";
            lb_matricula.Text = "Código da Disciplina:";
            lb_nascimento.Text = string.Empty;

            tb_nome.Visible = true;
            tb_matricula.Visible = true;
            tb_nascimento.Visible = false;
            tb_nascimento.Mask = "";
        }

        private void bt_salvarA_Click(object sender, EventArgs e)
        {
            if ((CheckTextBoxes()) && (rbAluno.Checked == true))
            {
                Aluno a = new Aluno(tb_nome.Text, tb_matricula.Text, tb_nascimento.Text);

                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("INSERT INTO aluno(nome_aluno,matricula_aluno,nascimento_aluno) " +
                                                    "values('{0}','{1}','{2}')", a.Nome, a.N_matricula, a.Nascimento);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Aluno Cadastrado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparTextbox();
            }

            else if ((CheckTextBoxes()) && (rbMateria.Checked == true))
            {
                Materia m = new Materia(tb_nome.Text, tb_matricula.Text);

                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("INSERT INTO materia(nome_materia,codigo_materia) " +
                                                    "values('{0}','{1}')", m.Nome, m.Codigo);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Matéria Cadastrada com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparTextbox();

            }

        }

        private void bt_delA_Click(object sender, EventArgs e)
        {
            if (rbAluno.Checked == true)
            {
                string matricula = tb_matricula.Text;

                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("DELETE FROM aluno WHERE matricula_aluno = '{0}'", matricula);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("Aluno Excluido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparTextbox();
            }

            else if (rbMateria.Checked == true)
            {
                string codigo = tb_matricula.Text;

                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("DELETE FROM materia WHERE codigo_materia = '{0}'", codigo);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("Matéria Excluida com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparTextbox();
            }
        }

        private void bt_attA_Click(object sender, EventArgs e)
        {
            if (rbMateria.Checked == true)
            {
                string codigo = tb_matricula.Text;

                Materia m = new Materia(tb_nome.Text, tb_matricula.Text);

                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("UPDATE materia SET nome_materia = '" + m.Nome 
                     + "' Where codigo_materia = '" + codigo + "'");

                MessageBox.Show(commandText);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {

                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("Matéria Atualizada com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparTextbox();
            }

            else if (rbAluno.Checked == true)
            {
                string matricula = tb_matricula.Text;

                Aluno a = new Aluno(tb_nome.Text, tb_matricula.Text, tb_nascimento.Text);

                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

                con.Open(); // Abre a conexao com o banco

                string commandText = String.Format("UPDATE aluno SET nome_aluno = '"
                    + a.Nome + "' , nascimento_aluno = '" + a.Nascimento
                    + "' Where matricula_aluno = '" + matricula + "'");
                MessageBox.Show(commandText);

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                {

                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("Aluno Atualizado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparTextbox();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas

            string commandText = "SELECT * FROM aluno_materia ORDER BY matricula_aluno";

            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con)) // faz a ligação em bd e o datatable
            {
                Adpt.Fill(dt);
            }

            dGV.DataSource = dt;

            con.Close();  // Fecha a Conexao com o    

            limparTextbox();
        }

        private void btMatricula_Click(object sender, EventArgs e)
        {
            string matricula = tb_ident.Text;
            string codigo = tb_mat.Text;

            bool alunoExistente = false;
            bool materiaExistente = false;

            string conexao = new ConexaoString().ConnString();
            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();
                string queryAluno = $"SELECT 1 FROM aluno WHERE matricula_aluno = '{matricula}'";
                using (NpgsqlCommand cmdAluno = new NpgsqlCommand(queryAluno, con))
                {
                    using (NpgsqlDataReader reader = cmdAluno.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            alunoExistente = true;
                        }
                    }
                }
            }

            // Verifica se o código da matéria existe na tabela materia
            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();
                string queryMateria = $"SELECT 1 FROM materia WHERE codigo_materia = '{codigo}'";
                using (NpgsqlCommand cmdMateria = new NpgsqlCommand(queryMateria, con))
                {
                    using (NpgsqlDataReader reader = cmdMateria.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            materiaExistente = true;
                        }
                    }
                }
            }

            if (alunoExistente && materiaExistente)
            {
                // Ambos o aluno e a matéria existem, então podemos associá-los
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    string commandText = String.Format("INSERT INTO aluno_materia(matricula_aluno,codigo_materia) "
                            + "values('{0}','{1}')", matricula, codigo);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Aluno Matriculado com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparTextbox();
            }

            else
            {
                // Exibe uma mensagem de erro se o aluno ou a matéria não existirem
                MessageBox.Show("Número de matrícula do aluno ou código da matéria inválido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limparTextbox();
        }

        private void bt_deletmat_Click(object sender, EventArgs e)
        {
            string matricula = tb_ident.Text;
            string codigo = tb_mat.Text;

            bool alunoExistente = false;
            bool materiaExistente = false;

            string conexao = new ConexaoString().ConnString();
            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();
                string queryAluno = $"SELECT 1 FROM aluno_materia WHERE matricula_aluno = '{matricula}'";
                using (NpgsqlCommand cmdAluno = new NpgsqlCommand(queryAluno, con))
                {
                    using (NpgsqlDataReader reader = cmdAluno.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            alunoExistente = true;
                        }
                    }
                }
            }

            // Verifica se o código da matéria existe na tabela materia
            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open();
                string queryMateria = $"SELECT 1 FROM aluno_materia WHERE codigo_materia = '{codigo}'";
                using (NpgsqlCommand cmdMateria = new NpgsqlCommand(queryMateria, con))
                {
                    using (NpgsqlDataReader reader = cmdMateria.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            materiaExistente = true;
                        }
                    }
                }
            }

            if (alunoExistente && materiaExistente)
            {
                // Ambos o aluno e a matéria existem, então podemos associá-los
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    string commandText = String.Format("DELETE FROM aluno_materia WHERE codigo_materia = '{0}'", codigo);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("\"Matrícula Excluida com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                // Exibe uma mensagem de erro se o aluno ou a matéria não existirem
                MessageBox.Show("Número de matrícula do aluno ou código da matéria inválido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            limparTextbox();
        }
    }



}
