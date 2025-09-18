using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_OVERRIDE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engenheiro engenheiro = new Engenheiro();
            engenheiro.Trabalhar();

            Professor professor = new Professor();
            professor.Trabalhar();
        }

        public class funcionario
        {
            public virtual void Trabalhar()
            {
                Console.WriteLine("o funconario esta trabalhando");
            }

        }
        public class Engenheiro : funcionario
        { 
           public override  void Trabalhar()
            {
                Console.WriteLine(" o engenheiro constroi");
            }
        }
        public class Professor : funcionario
        {
            public override void Trabalhar()
            {
                Console.WriteLine(" o professor da aula");
            }
        }
    }
}
