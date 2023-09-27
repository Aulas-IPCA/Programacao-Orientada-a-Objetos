namespace Aulas_2
{
    internal class ex15
    {
        enum notas
        {
            E = 0,
            D = 8,
            C = 10,
            B = 14,
            A = 17
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Distinção >={0} ({1})", (int)notas.A, notas.A);
            Console.WriteLine("Aprovados >={0} ({1}, {2}, {3})", (int)notas.C, notas.C, notas.C, notas.C);
            Console.WriteLine("Oral entre {0} e {1} ({2})", (int)notas.D, (int)notas.C, (int)notas.C);
            Console.WriteLine("Reprovados <{0} ({1})", (int)notas.D, notas.D);
        }
    }
}