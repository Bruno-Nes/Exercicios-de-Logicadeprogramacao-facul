using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioseis
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 6
            Console.WriteLine("Digite um numero qualquer: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado > 20)
            {
                Console.WriteLine("O numero " + numeroDigitado + " eh maior que 20");
            }

            Console.ReadLine();
        }
    }
}
