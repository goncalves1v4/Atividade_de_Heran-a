using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class aaa
    {
        class Program
        {
            static void Main(string[] args)
            {
                Turma turma = new Turma();
                Aluno aluno = new Aluno();

                turma.aluno = aluno;
                turma.nomeTurma = "2A";

                aluno.nome = "Maria";
                aluno.sobrenome = "Eduarda";
                aluno.idade = 18;

                turma.ExibirTurma();
            }
            public class Turma
            {
                public Aluno aluno;
                public string nomeTurma;

                public void ExibirTurma()
                {
                    Console.WriteLine($"Turma: {nomeTurma} - Aluno: {aluno.nome} {aluno.sobrenome} {aluno.idade} anos");
                }
            }
            public class Aluno
            {
                public string nome;
                public string sobrenome;
                public int idade;
            }
        }
    }
}
