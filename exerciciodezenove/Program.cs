using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciodezenove
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 19
            double n;
            double soma = 0;

            for (int i = 0; i <= 99; i++)
            {

                n = i + 1;
                Console.WriteLine(n);
                soma = soma + Math.Pow(n, 2.0);

            }
            Console.WriteLine(soma);

            Console.ReadLine();
        }
    }
}
