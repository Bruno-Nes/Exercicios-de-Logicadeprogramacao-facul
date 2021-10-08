using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciocinco
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 5
            Console.WriteLine("Quantos quilos de latao voce quer fazer? ");
            double quilosLatao = Convert.ToDouble(Console.ReadLine());

            double quantiCobre = quilosLatao * 7;
            double quantiZinco = quilosLatao * 3;

            Console.WriteLine("Para fazer " + quilosLatao +" quilos de latao, sera necessario " + quantiCobre + " pecas de cobre " + quantiZinco + 
                " pecas de zinco");

            Console.ReadLine();

        }
    }
}
