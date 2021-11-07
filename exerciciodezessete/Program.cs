using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciodezessete
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 16           
           for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite um numero");
                double n = Convert.ToDouble(Console.ReadLine());
                double calcQuadrado = Math.Pow(n, 2.0);
                Console.WriteLine(calcQuadrado);
            }
            
            Console.ReadLine();
        }
    }
}
