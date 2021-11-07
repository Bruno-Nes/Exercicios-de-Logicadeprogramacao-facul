using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciovinteecinco
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 25
            Console.WriteLine("Informe dois valores e te direi qual eh o menor: ");
            int valorUm = Convert.ToInt32(Console.ReadLine());
            int valorDois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mostrarMenorValor(valorUm, valorDois));
            Console.ReadLine();
        }

        static int mostrarMenorValor(int num1, int num2)
        {
            if (num1 < num2)
            {
                Console.Write("O menor eh: ");
                return num1;
            }else
            {
                Console.Write("O menor eh: ");
                return num2;
            }//Essa logica eu peguei do codigo do Felipe Torres :)
        }
    }
}
