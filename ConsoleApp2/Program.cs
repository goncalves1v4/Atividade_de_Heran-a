using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passaro passaro = new Passaro() {Voar=true, Penas=true };
            passaro.FAve();
        }
        public class Animal
        {
            public bool Voar;

            public void funcao()
            {
                Console.WriteLine("o animal pode voar");
            }
        }
        public class  Passaro:Animal
        {
            public bool Penas;

            public void FAve()
            {
                Console.WriteLine($"o animal tem {Penas} e pode {Voar} ");
            }
        }      
    }
}
