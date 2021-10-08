using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadeexercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercicio 1
            Console.WriteLine("Digite um valor: ");
            int valorDigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O sucessor do numero digitado eh: " + (valorDigitado + 1));
            Console.WriteLine("O antecessor do numero digitado eh: " + (valorDigitado - 1));

            Console.ReadLine();
        }
    }
}
