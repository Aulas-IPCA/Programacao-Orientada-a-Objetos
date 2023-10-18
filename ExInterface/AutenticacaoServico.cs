using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterface
{
    internal class AutenticacaoServico : IAutenticação
    {
        public bool LogIn(string usuario, string senha)
        {
            if (usuario == "123" && senha =="123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void LogOut()
        {
            Console.WriteLine("Logout.");
        }
    }
}
