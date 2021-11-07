using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioquatorze
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 14
            Console.WriteLine("Digite o valor de x: ");
            double valorX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de y: ");
            double valorY = Convert.ToDouble(Console.ReadLine());

            if (valorX < valorY)
            {
                double valorAoQuadradoX = Math.Pow(valorX, 2.0);
                Console.WriteLine("O valor de x eh: " + valorX + ", elevado ao quadradro fica " + valorAoQuadradoX);
            }else if (valorY < valorX)
            {
                double valorAoQuadradoY = Math.Pow(valorY, 2.0);
                Console.WriteLine("O valor de y eh: " + valorY + ", elevado ao quadradro fica " + valorAoQuadradoY);
            }

            if (valorX > valorY)
            {
                double valorRaizQuadradaX = Math.Sqrt(valorX);
                Console.WriteLine("O valor de x eh: " + valorX + ", sua raiz quadrada eh " + valorRaizQuadradaX);
            }
            else if (valorY > valorX)
            {
                double valorRaizQuadradaY = Math.Sqrt(valorY);
                Console.WriteLine("O valor de y eh: " + valorY + ", sua raiz quadrada eh " + valorRaizQuadradaY);
            }

            Console.ReadLine();
        }
    }
}
