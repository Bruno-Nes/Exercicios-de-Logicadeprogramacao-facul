﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicovintedois
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 22
            Console.WriteLine("Informe o numero de um mes: ");
            int mesDigitado = Convert.ToInt32(Console.ReadLine());
            qualMes(mesDigitado);
        }

        static void qualMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
                default:
                    Console.WriteLine("O mes digitado eh invalido, digite de novo");
                    break;
            }
        }
    }
}