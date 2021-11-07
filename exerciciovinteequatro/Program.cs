using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciovinteequatro
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 24
            Console.WriteLine("Informe um caracter, para saber se pertence ao alfabeto: ");
            char caracter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(questao24(caracter));
        }

        static int questao24(char caracter)
        {
            int codigo = Convert.ToInt32(caracter);
            if ((codigo >= 65 && codigo <= 90) || (codigo >= 97 && codigo <= 122))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
