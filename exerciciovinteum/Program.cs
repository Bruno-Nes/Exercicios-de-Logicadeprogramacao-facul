using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciovinteum
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 21
            Console.WriteLine("Informe um numero para definir o termino do programa: ");
            int valorInformado = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= valorInformado; i++) 
            {
                int n = i + 3;//logica tirada do codigo do Felipe Torres
                Console.Write(i + ", " + n + ", " + n + ", ");
            }
            Console.ReadLine();
        }
    }
}
