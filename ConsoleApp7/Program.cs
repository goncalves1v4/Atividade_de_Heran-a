using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class aaaa
    {

        class Program
        {
            static void Main(string[] args)
            {
                Calculo calc = new Calculo();
                
                calc.Somar(10, 5);
                calc.Somar(10, 5, 2);
                calc.Somar(10, 5, 2, 10);
                

            }
            public class Calculo
            {
                public void Somar(int a, int b)
                {
                    Console.WriteLine(a + b);
                }
                public void Somar(int a, int b, int c)
                {
                    Console.WriteLine(a + b + c);
                }
                public void Somar(int a, int b, int c, int d)
                {
                    Console.WriteLine(a + b + c + d);
                }
            }
        }
    }    
}
