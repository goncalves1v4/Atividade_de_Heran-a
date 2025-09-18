using System;

namespace ATIVIDADE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Casa casa = new Casa();
            casa.EntrarCasa();

        }

        public class Casa
        {
            public Porta porta;
            public void EntrarCasa()
            {
                porta = new Porta();
                porta.Abrir();
            }
        }

        public class Porta
        {
            public void Abrir()
            {
                Console.WriteLine("a porta foi aberta ");
            }
        }











        
    }
}


    







        

