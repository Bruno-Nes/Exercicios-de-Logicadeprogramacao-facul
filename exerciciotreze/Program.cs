using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciotreze
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 13
            Console.WriteLine("Digite um valor: ");
            int valorDigitado = Convert.ToInt32(Console.ReadLine());

            switch (valorDigitado)
            {
                case 5:
                    Console.WriteLine("O numero digitado eh igual a 5");
                    break; 
                case 200:
                    Console.WriteLine("O numero digitado eh igual a 200");
                    break;
                case 400:
                    Console.WriteLine("O numero digitado eh igual a 400");
                    break;
                default:
                    if (valorDigitado > 500  && valorDigitado < 1000)
                    {
                        Console.WriteLine("O numero " + valorDigitado + " esta entre 500 e 1000");
                    }else
                    {
                        Console.WriteLine("O numero nao atende a nenhum dos criterios anteriores");
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
