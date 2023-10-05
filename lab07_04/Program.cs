using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineas;
            Console.Write("Ingrese el número de lineas: ");
            lineas = int.Parse(Console.ReadLine()); 
             for (int i = 0; i < lineas; i++)
            {
                int numero;
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine()); 
                for (int  j = 0; j < numero; j++)
                {
                    for (int r = 0; r < numero*2; r++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
             Console.ReadKey();
        }
    }
}
