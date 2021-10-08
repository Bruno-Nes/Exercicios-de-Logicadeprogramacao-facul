using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioonze
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 12
            Console.WriteLine("Digite tres numeros diferentes: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            int valorB = Convert.ToInt32(Console.ReadLine());
            int valorC = Convert.ToInt32(Console.ReadLine());

            if (valorA != valorB && valorA != valorC && valorB != valorC)
            {

                if (valorA > valorB && valorA > valorC)
                {
                    Console.WriteLine(valorA);
                    if (valorB > valorC)
                    {
                        Console.WriteLine(valorB);
                        Console.WriteLine(valorC);
                    }
                    else if (valorC > valorB)
                    {
                        Console.WriteLine(valorC);
                        Console.WriteLine(valorB);
                    }


                }
                else if (valorB > valorA && valorB > valorC)
                {
                    Console.WriteLine(valorB);
                    if (valorA > valorC)
                    {
                        Console.WriteLine(valorA);
                        Console.WriteLine(valorC);
                    }
                    else if (valorC > valorA)
                    {
                        Console.WriteLine(valorC);
                        Console.WriteLine(valorA);
                    }
                }
                else
                {
                    Console.WriteLine(valorC);
                    if (valorA > valorB)
                    {
                        Console.WriteLine(valorA);
                        Console.WriteLine(valorB);
                    }
                    else if (valorB > valorA)
                    {
                        Console.WriteLine(valorB);
                        Console.WriteLine(valorA);
                    }

                }
            }
            else
            {
                Console.WriteLine("Existem valores semelhantes. Por favor digite valores diferentes entre si!");
            }

            Console.ReadLine();
        }
    }
}