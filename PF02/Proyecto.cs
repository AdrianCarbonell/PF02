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
                return -1;

            if (n == 0)
                return 1;

            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static bool EsContrasenyaValida(string contrasenya)
        {
            
            if (string.IsNullOrEmpty(contrasenya))
                return false;

           
            if (contrasenya.Length < 8)
                return false;

            if (!contrasenya.Contains('#'))
                return false;

            return true;
        }


    }
}
