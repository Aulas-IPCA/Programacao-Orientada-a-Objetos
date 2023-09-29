using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Aula_3
{
    internal class Avião
    {
        static void Main(string[] args)
        {
            Aviao aviao = new Aviao("747", "Boeing");
            Aviao aviao1 = new Aviao("237", "GOL");

            aviao.Acelerar(500);
            aviao1.Acelerar(1000);
            aviao.Subir(10000);
            aviao1.Subir(50000);
            aviao.Descer(6000);
            aviao1.Descer(25000);
            aviao.Reduzir(400);
            aviao1.Reduzir(500);
        }
    }
}