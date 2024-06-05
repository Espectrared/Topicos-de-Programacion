using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int opc, factorial=1;
            Console.WriteLine("ingresa un numero entre 1 y 8");
            opc=int.Parse(Console.ReadLine());
            switch(opc)
            {
                case 1:
                    {
                       for(int i = 2;i<=opc;i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }break;
                    case 2:
                    {
                        for (int i = 2; i <= opc; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }
                    break;
                    case 3:
                    {
                        for (int i = 2; i <= opc; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }break;
                    case 4:
                    {
                        for (int i = 2; i <= opc; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }break;
                    case 5:
                    {
                        for (int i = 2; i <= opc; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }
                    break;
                    case 6:
                    {
                        for (int i = 2; i <= opc; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }break;
                case 7:
                    {
                        for (int i = 2; i <= opc; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }break;
                case 8:
                    {
                        for (int i = 2; i <= opc; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                    }
                    break;
                default: Console.WriteLine("Opcion invalida"); break;

            }
            */
            /*
             int opc, num1, num2;
             Console.WriteLine("Ingresa una opcion \n 1)Suma\n 2)Resta\n 3)Multiplicacion\n 4)Resta");
             opc=Int32.Parse(Console.ReadLine());
             switch(opc)
             {
                 case 1:
                     {
                         Console.WriteLine("Ingresa numero 1");
                         num1 = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("Ingresa el numero 2");
                         num2 = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("La suma del primer numero con el segundo es" + (num1+num2));
                     }break;
                 case 2:
                     {

                         Console.WriteLine("Ingresa numero 1");
                         num1 = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("Ingresa el numero 2");
                         num2 = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("La resta  del primer numero con el segundo es" + (num1 +-num2));
                     }
                     break;
                     case 3:
                     {

                         Console.WriteLine("Ingresa numero 1");
                         num1 = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("Ingresa el numero 2");
                         num2 = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("La multiplicacion del primer numero con el segundo es" + (num1 * num2));
                     }break;
                     case 4:
                     {

                         Console.WriteLine("Ingresa numero 1");
                         num1 = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("Ingresa el numero 2");
                         num2 = Int32.Parse(Console.ReadLine());
                         Console.WriteLine("La multiplicacion del primer numero con el segundo es" + (num2 / num1));
                     }break;
                 default: Console.WriteLine("Invalido");break;
             }
             */
            int opc,num1;
            Console.WriteLine("Ingreso el numero");
            opc= Int32.Parse(Console.ReadLine());
            

            switch(opc)
            {
                    case int n when(opc<20):
                    {
                        Console.WriteLine("es menor que 20");
                    }break;
                case int n when (opc ==20):
                    {
                        Console.WriteLine("es igual 20");
                    }
                    break;
                case int n when (opc > 20):
                    {
                        Console.WriteLine("es mayor que 20");
                    }
                    break;
            }
            Console.ReadKey();
        }
          
        }
    }

