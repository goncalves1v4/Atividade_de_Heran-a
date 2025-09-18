using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autor autor = new Autor();
            Livro livro = new Livro();
 
            livro.autor = autor;
            livro.Titulo = "cachorro";

            autor.Nome = "Carlos";
            autor.Nacionalidade = "Brasileiro";
            livro.ExibirAutor();

        }

        public class Autor
        {
            public string Nome;
            public string Nacionalidade;

           
        }
        public class Livro
        {
            public string Titulo;
            public Autor autor;

            public void ExibirAutor()
            {
                Console.WriteLine($"Livro {Titulo} autor {autor.Nome} nacionalidade {autor.Nacionalidade}");
            }
        }
    }
}
