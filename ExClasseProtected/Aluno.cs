using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasseProtected
{
    internal class Aluno : Pessoa
    {
        private string matricula;

        public Aluno(string nome, int idade, string matricula) : base(nome, idade)
        {
            this.matricula = matricula;
        }
        public void MostraInfo()
        {
            Console.WriteLine("Nome: {0}\t Idade: {1}\t Matricula: {2}\t\n", nome, idade, matricula);
        }
    }
}
