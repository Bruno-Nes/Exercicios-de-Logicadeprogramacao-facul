using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicionove
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 9

            Console.WriteLine("Digite um numero: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado >= 1)
            {
                Console.WriteLine("O numero digitado eh POSITIVO");
            }else if (numeroDigitado <= -1)
            {
                Console.WriteLine("O numero digitado eh NEGATIVO");
            }else
            {
                Console.WriteLine("Numero NULO");
            }

            Console.ReadLine();
        }
    }
}
