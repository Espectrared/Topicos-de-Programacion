using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1
            float[] vector=new float[100];
            float promedio=0;
            int num;
            Console.WriteLine("Cuantas calificaciones vas a capturar?");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                do
                {
                    Console.WriteLine("Dame la calificacion {0}", i + 1);
                    vector[i] = float.Parse(Console.ReadLine());
                } while (vector[i] < 0);
                promedio += vector[i];
            }
            Console.WriteLine("El promedio es: {0}", promedio / num);

            */
            /*
             //Ejercicio 2
            int valorI, valorF;
            do {
                Console.WriteLine("Dame el valor inicial");
                valorI = int.Parse(Console.ReadLine());
                Console.WriteLine("Dame el valor final");
                valorF = int.Parse(Console.ReadLine());
            } while (valorI > valorF);
            for (int i = valorI; i <= valorF; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("los numeros pares son "+i);
                }
            }
            */

            /*
             int valorI, valorF;
            do {
                Console.WriteLine("Dame el valor inicial");
                valorI = int.Parse(Console.ReadLine());
                Console.WriteLine("Dame el valor final");
                valorF = int.Parse(Console.ReadLine());
            } while (valorI > valorF);
            for (int i = valorI; i <= valorF; i++)
            {
                if (i % 2 == 0)
                {

                }
            else
            {
                Console.WriteLine("los numeros impares son "+i);
            }
            }

            }*/

            //Ejercicio 4 
            /*
            int saldo=0;
            int retiro;
            int deposito;
            int opcion;

            do
            {
                Console.WriteLine("1.- Retiro");
                Console.WriteLine("2.- Deposito");
                Console.WriteLine("3.- Salir");
              
                Console.WriteLine("Dame una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dame el monto a retirar");
                        retiro = int.Parse(Console.ReadLine());
                        if (retiro > saldo)
                        {
                            Console.WriteLine("No tienes saldo suficiente");

                        }
                        else
                        {
                            saldo -= retiro;
              Console.WriteLine("Tu saldo es: " + saldo);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Dame el monto a depositar");
                        deposito = int.Parse(Console.ReadLine());
                        saldo += deposito;
              Console.WriteLine("Tu saldo es: " + saldo);
                        break;
                    case 3:
              Console.WriteLine("Adios");
                        Console.WriteLine("Tu saldo es: " + saldo);
                        break;
                    
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcion != 3);
            */
            /*
            int num1, num2;
            Console.WriteLine("Dame de la multiplicacion");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el multiplicador");
            num2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num2; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num1, i, (num1 * i));
            }*/
            double x = 1234.7;
            int a;
            // Cast double to int. a = (int)x;
            System.Console.WriteLine(a);
            Console.ReadKey();
}
}
}
