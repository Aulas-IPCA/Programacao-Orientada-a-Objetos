namespace ExHerança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Filipe", 29, "123456", "POO");

            a.Apresentar();
            Console.WriteLine("Matrícula: {0}", a.Matricula);

            a.Estudar();
        }
    }
}