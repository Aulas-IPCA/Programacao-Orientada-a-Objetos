using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterface
{
    internal interface IAutenticação
    {
        bool LogIn(string user, string password);
        void LogOut();
    }
}
