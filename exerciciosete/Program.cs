using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosete
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 7
            Console.WriteLine("Digite dois numeros: ");

            int numeroUm = Convert.ToInt32(Console.ReadLine());
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            int sum = numeroUm + numeroDois;

            if (sum > 10)
            {
                Console.WriteLine("O resultado da soma dos dois numeros digitados eh maior que 10");
            }else
            {
                Console.WriteLine("O valor da soma dos numeros digitados eh igual ou menor que 10");
            }

            Console.ReadLine();
        }
    }
}
