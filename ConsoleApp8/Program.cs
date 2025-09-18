using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            COMPUTADOR c = new COMPUTADOR();
            c.ligarcomputador();
        }

        public class PROCESSADOR
        {
            public void INICIAR()
            {
                Console.WriteLine("Processador iniciado!");
            }
        }
        public class COMPUTADOR
        {
            public PROCESSADOR PROCESSADOR;
            public void ligarcomputador()
            {
                Console.WriteLine("ligando computadidor...");
                PROCESSADOR = new PROCESSADOR();
                PROCESSADOR.INICIAR();
            }

        }

    }
}
