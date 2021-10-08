using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioquatro
{
    static class Constante 
    {
        public const double porcentPrimeiraPessoa = 0.30;
        public const double porcentSegundaPessoa = 0.38;
        public const double porcentTerceiraPessoa = 0.32;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 4
            Console.WriteLine("Qual a quantia a ser dividida? ");
            double quantiaDolaresTotais = Convert.ToDouble(Console.ReadLine());

            double quantiaPrimeiraPessoa = Constante.porcentPrimeiraPessoa * quantiaDolaresTotais;
            double quantiaSegundaPessoa = Constante.porcentSegundaPessoa * quantiaDolaresTotais;
            double quantiaTerceiraPessoa = Constante.porcentTerceiraPessoa * quantiaDolaresTotais;

            Console.WriteLine("A quantia em dolares que a primeira pessoa vai receber eh: " + quantiaPrimeiraPessoa);
            Console.WriteLine("A quantia em dolares que a segunda pessoa vai receber eh: " + quantiaSegundaPessoa);
            Console.WriteLine("A quantia em dolares que a terceira pessoa vai receber eh: " + quantiaTerceiraPessoa);

            Console.ReadLine();
        }
    }
}
