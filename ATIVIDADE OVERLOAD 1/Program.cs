using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_OVERLOAD_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacoes op = new Operacoes();
           

            op.mult(1, 2);
            op.mult(1, 2, 3);
            op.mult(1, 2, 3, 4);




        }


        public class Operacoes
        {
            public void mult(int x, int y)
            {
                Console.WriteLine(x * y);
            }
            public void mult(int x, int y, int z)
            {
                Console.WriteLine(x * y * z);
            }
            public void mult(int x, int y, int z, int a)
            {
                Console.WriteLine(x * y * z * a);
            }
        }








    }
}
