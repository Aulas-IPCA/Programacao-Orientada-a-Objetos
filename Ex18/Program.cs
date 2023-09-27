namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2500;
            double num2 = 0.78876;

            Console.WriteLine("Decimal " + num1.ToString("D"));
            Console.WriteLine("Scientific " + num2.ToString("E"));
            Console.WriteLine("Fixed point " + num2.ToString("F2"));
            Console.WriteLine("General " + num1.ToString("G"));
            Console.WriteLine("Round Trip " + num2.ToString("R"));
            Console.WriteLine("Number " + num1.ToString("N"));
            Console.WriteLine("Percent " + (num2 * 100).ToString("P"));
            Console.WriteLine("Hexadecimal " + num1.ToString("X"));
        }
    }
}