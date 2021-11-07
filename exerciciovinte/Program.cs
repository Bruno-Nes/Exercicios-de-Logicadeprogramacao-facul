using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciovinte
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 20
            Console.WriteLine("Digite um numero para determinar ate onde vai a senquencia: ");
            double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= n; i++)// a variavel do limite esta sendo usada aqui
            {
                double calcSequenica = Math.Pow(i, 2.0);
                Console.WriteLine(calcSequenica);
            }
            Console.ReadLine();
        }
    }
}
