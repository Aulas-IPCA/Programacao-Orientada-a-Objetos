using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClassePrivate
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        //Metodo publico para exibir um nome (acessa a um atributo privado)
        public void MostraNome()
        {
            Console.WriteLine("Nome: {0}", nome);
        }
        //Metodo publico para exibir uma idade
        public void MostraIdade()
        {
            Console.WriteLine("Idade: {0} anos", idade);
        }
    }
}
