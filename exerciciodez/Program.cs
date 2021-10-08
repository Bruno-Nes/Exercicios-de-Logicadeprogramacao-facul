using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciodez
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 10
            Console.WriteLine("Digite um numero: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado >= 0)
            {
                double raiz = Math.Sqrt(numeroDigitado);
                Console.WriteLine("A a raiz quadrada do numero " + numeroDigitado + " eh " + raiz);
            }else 
            {
                Console.WriteLine("O quadrado do numero eh: " + Math.Pow(numeroDigitado , 2.0));
            }

            Console.ReadLine();
        }
    }
}
