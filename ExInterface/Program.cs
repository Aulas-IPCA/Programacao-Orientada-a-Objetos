namespace ExInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutenticação autenticacao = new AutenticacaoServico();

            bool autenticado = autenticacao.LogIn("123", "123");

            if(autenticado)
            {
                Console.WriteLine("Utilizador autenticado com sucesso");
                autenticacao.LogOut();
            }

            else
            {
                Console.WriteLine("Falha na autenticação.");
            }
        }
    }
}