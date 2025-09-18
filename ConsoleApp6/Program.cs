using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class aaaa
    {
        class Program
        {
            static void Main(string[] args)
            {
                Cachorro c = new Cachorro();
                c.Falar();

                Gato g = new Gato();
                g.Falar();
            }

            public class Animal
            {
                public virtual void Falar()
                {
                    Console.WriteLine("Um animal pode emitir um som!");
                }
            }
            public class Cachorro : Animal
            {
                public override void Falar()
                {
                    Console.WriteLine("O cachorro faz au au au!");
                }
            }

            public class Gato : Animal
            {
                public override void Falar()
                {
                    Console.WriteLine("o gato faz miau");
                }

            }

        }
    }
}
