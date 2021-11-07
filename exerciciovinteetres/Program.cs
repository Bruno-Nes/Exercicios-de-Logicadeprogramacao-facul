using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciovinteetres
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 23
            Console.WriteLine("Digite seu nome: ");
            string nomeDigitado = Console.ReadLine();
            fazerCabecalho(nomeDigitado);

            Console.ReadLine();
        }

        static void fazerCabecalho(string nome)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("UFMG – Universidade Federal de Minas Gerais");
            Console.WriteLine("ICEx – Instituto de Ciências Exatas");
            Console.WriteLine("Disciplina de Programação de Computadores");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("============================================");
        }
    }
}
