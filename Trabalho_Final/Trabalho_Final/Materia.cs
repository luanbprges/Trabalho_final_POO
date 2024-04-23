using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final
{
    internal class Materia
    {
        /* Atributos */
        string nome;
        string codigo;

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        /* Métodos */
        public Materia(string _nome, string _codigo) 
        {
            nome = _nome;
            codigo = _codigo;
        }
    }
}
