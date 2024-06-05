using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int cal1, cal2, cal3, cal4, cal5;
            float promedio;
            
                Console.WriteLine("Ingrese la calificacion 1");
            cal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la calificacion 2");
            cal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la calificacion 3");
            cal3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la calificacion 4");
            cal4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la calificacion 5");
            cal5 = Convert.ToInt32(Console.ReadLine());
            promedio = (cal1 + cal2 + cal3 + cal4 + cal5) / 5;
            Console.WriteLine("El promedio es: " + promedio);
            if (promedio >= 6)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
            Console.ReadKey();
           
             
             //Ejercicio 2
             int edad;
            char gemero;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su genero (H/M)");
            gemero = Convert.ToChar(Console.ReadLine());
            if(edad>=18 && edad<=30 && gemero == 'H')
            {
                Console.WriteLine("Si lo es ");
            }
            else
            {
                Console.WriteLine("No lo es");
            }
          Console.ReadKey();
            
            // Ejercicio 3
            int par;
            Console.WriteLine("Ingrese un numero");
            par = Convert.ToInt32(Console.ReadLine());
            if (par % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadKey();
           
             // Ejercicio 4
            int num1, num2, num3;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El numero mayor es: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El numero mayor es: " + num2);
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + num3);
            }
            Console.ReadKey();  
            
            float numero;
            Console.WriteLine("Ingrese un numero");
            numero = float.Parse(Console.ReadLine());
            Console.WriteLine("El valor absoluto es " + Math.Abs(numero));
            Console.WriteLine("El cuadrado es " + Math.Pow(numero, 2));
            Console.WriteLine("La raiz cuadrada es " + Math.Sqrt(numero));
            Console.WriteLine("El seno es " + Math.Sin(numero));
            Console.WriteLine("El coseno es " + Math.Cos(numero));
            Console.WriteLine("El redondeo es "+ Math.Round(numero));
            Console.WriteLine("El trunco es " + Math.Truncate(numero));
            Console.ReadKey();

        }
    }
}
