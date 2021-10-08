using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciodois
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 2
            Console.WriteLine("Digite tres numeros quaisquer: ");
            double primeiroNumeroDigitado = Convert.ToDouble(Console.ReadLine());
            double segundoNumeroDigitado = Convert.ToDouble(Console.ReadLine());
            double terceiroNumeroDigitado = Convert.ToDouble(Console.ReadLine());

            double calculoMedia = (primeiroNumeroDigitado + segundoNumeroDigitado + terceiroNumeroDigitado) / 3;
            Console.WriteLine("A media dos numeros digitados eh: " + calculoMedia);

            Console.ReadLine();
        }
    }
}
