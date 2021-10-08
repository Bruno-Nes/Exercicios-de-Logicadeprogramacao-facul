using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciooite
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 8
            Console.WriteLine("Digite um numero: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado % 2 == 0)
            {
                Console.WriteLine("O numero digitado eh par");
            }else
            {
                Console.WriteLine("O numero digitado eh impar");
            }
            
            Console.ReadLine();
        }
    }
}
