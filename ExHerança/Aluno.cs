using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHerança
{
    internal class Aluno : Pessoa
    {
        //Atributos
        public string Matricula { get; set; }
        public string Curso { get; set; }

        //Construtor
        public Aluno(string nome, int idade, string matricula, string curso) : base(nome, idade)
        {
            Matricula = matricula;
            Curso = curso;
        }

        public void Estudar()
        {
            Console.WriteLine("O {0} está estudando a disciplina {1} e tem a matrícula {2}.", Nome, Curso, Matricula);
        }
    }
}
