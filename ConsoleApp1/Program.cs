using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro { QtdPorta = 4, Volante = true, QtdVidro = 4, AnoFab = 2025, Comb = "gasolina", Preco = 400000, Cor = "AZUL", Modelo = "aaaa", Marca = "FERRARI" };
            carro.Funcao2();



        }
        public class veiculo
        {
            public int QtdRoda;
            public double PtcMotor;

            public void Funcao()
            {
                Console.WriteLine($"quantidade de roda: {QtdRoda} , potencia do motor: {PtcMotor}");
            }



        }
        public class Carro :veiculo
        {
            public int QtdPorta;
            public bool Volante;
            public int QtdVidro;
            public int AnoFab;
            public string Comb;
            public double Preco;
            public string Cor;
            public string Modelo;
            public string Marca;

            public void Funcao2()
            { 
                Console.WriteLine ($" quantidade de porta: {QtdPorta}\n possui volante: {Volante}\n quantidade de vidros: {QtdVidro}\n ano de fabricação: {AnoFab}\n combustivel: {Comb}\n preço: {Preco}\n cor: {Cor}\n Modelo: {Modelo}\n marca: {Marca}\n");
            }
        }
    }
}
