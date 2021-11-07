using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciodezoito
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 18
            int n;
            int soma = 0;

            for (int i = 0; i <= 99; i++)
            {
                
                n = i + 1;
                Console.WriteLine(n);
                soma = soma + n;               
                             
            }
            Console.WriteLine(soma);

            Console.ReadLine();
        }
    }
}
