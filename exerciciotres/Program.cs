using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciotres
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 3
            double Fahrenheit;

            Console.WriteLine("Qual a temperatura em grau Celsius? ");
            double grauCelcius = Convert.ToDouble(Console.ReadLine());

            Fahrenheit = 9 * grauCelcius / 5 + 32;
            Console.WriteLine("A conversao de Celsius para Fahrenheit eh: " + Fahrenheit);

            Console.ReadLine();
        }
    }
}
