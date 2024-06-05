using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int valor1=50,valor2=0;
            
            float valor3=30.50F,valor4;
            Console.WriteLine("El valor de la variable 1 es: "+valor1);
            Console.WriteLine("El valor de la variable 2 es: "+valor2);
            valor2 = (int)valor3;
            valor4 = valor1;

            Console.WriteLine("El valor de la variable 1 es: " + valor2);
            Console.WriteLine("El valor de la variable 2 es: " + valor4);
            
            String cadena="894";
            int numero;
            numero = Convert.ToInt32(cadena);
            Console.WriteLine("El valor de la variable 1 es: " + (numero+1));

            Console.ReadKey();
        }
    }
}
