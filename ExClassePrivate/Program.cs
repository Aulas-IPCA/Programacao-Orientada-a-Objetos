using System.Runtime.CompilerServices;

namespace ExClassePrivate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa person1 = new Pessoa("Thiago", 22);
            Pessoa person2 = new Pessoa("Isabela", 20);

            person1.MostraNome();
            person1.MostraIdade();
            person2.MostraNome();
            person2.MostraIdade();
        }
    }
}