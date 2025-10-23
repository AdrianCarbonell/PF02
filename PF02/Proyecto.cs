using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF02
{
    public class Proyecto
    {

        
            static void Main(string[] args)
            {
                Console.WriteLine(CalcularFactorial(5));
            }

            public static long CalcularFactorial(int n)
            {
            if (n < 0)
            {
                Console.WriteLine("Número negativo, devolviendo -1");
                return -1;
            }

            if (n == 0)
            {
                Console.WriteLine("Factorial de 0 es 1");
                return 1;
            }

            if (n == 1)
            {
                Console.WriteLine("Factorial de 1 es 1");
                return 1;
            }

            long factorial = 1;
            long temp = 1;
            int contador = 1;

            while (contador <= n)
            {
                if (contador % 2 == 0)
                {
                    temp = contador; 
                }
                else
                {
                    temp = contador;
                }

                factorial = factorial * temp;

                Console.WriteLine($"Multiplicando {temp}, factorial ahora es {factorial}");

                contador++;
            }

            if (factorial < 0)
            {
                factorial = 1; 
            }

            return factorial;
        }
        
    }
}
