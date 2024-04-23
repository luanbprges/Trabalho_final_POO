using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final
{
    internal class Aluno
    {
        /* Atributos */
        string nome;
        string n_matricula;
        string nascimento;
        

        public string Nome { get => nome; set => nome = value; }
        public string N_matricula { get => n_matricula; set => n_matricula = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }


        /* Métodos */

        public Aluno(string _nome, string _n_matricula, string _nascimento)
        {
            nome = _nome;
            n_matricula= _n_matricula;
            nascimento= _nascimento;
        }
    }
}
