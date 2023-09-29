using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3
{
    internal class Aviao
    {
        //Atributos da classe
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Altitude { get; set; }
        public string Marca { get; set; }

        //Construtor
        public Aviao(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
            Velocidade = 0;
            Altitude = 0;
        }

        //Procedimentos
        public void Acelerar(int aumentarVelocidade)
        {
            Velocidade += aumentarVelocidade;
            Console.WriteLine("O avião {0} {1} acelerou para {2} km/h", Marca, Modelo, Velocidade);
        }

        public void Reduzir(int reduzirVelocidade)
        {
            Velocidade -= reduzirVelocidade;
            Console.WriteLine("O avião {0} {1} reduziu para {2} km/h", Marca, Modelo, Velocidade);
        }

        public void Subir(int aumentarAltitude)
        {
            Altitude += aumentarAltitude;
            Console.WriteLine("O avião {0} {1} subiu para {2} metros de altitude", Marca, Modelo, Altitude);
        }

        public void Descer(int reduzirAltitude)
        {
            Altitude -= reduzirAltitude;
            Console.WriteLine("O avião {0} {1} desceu para {2} metros de altitude", Marca, Modelo, Altitude);
        }

    }
}
