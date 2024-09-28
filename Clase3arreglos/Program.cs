using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Clase3arreglos
{
    internal class Program
    {
        static float total = 0;              // global 
        static float num1 = 0, num2 = 0;     // variable locales
        // los metodos utilizan la palabra reservada void
        static void Main(string[] args)
        {

            menu();

            Console.Read();

        }

        static void menu()
        {
            int opcion = 0;

            try
            {
                do
                {
                    Console.WriteLine("********** menu *************");
                    Console.WriteLine("1- Agregar Articulo");
                    Console.WriteLine("2- Facturacion");
                    Console.WriteLine("3- Salir");
                    Console.WriteLine("*****************************");
                    Console.WriteLine("digite una opcion");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: AgregarArticulos(); break;
                        case 2: Facturar(); break;
                        case 3: break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            break;
                    }

                } while (opcion != 3); // false

            }
            catch (Exception)
            {

                Console.WriteLine(" opcion invalidad");
            }
            
        }

        static void AgregarArticulos() { }
        static void Facturar() { }
        static void cicloFor()
        {

            int acumulador = 0;
            int mayor = 0;
            for (int casa = 10; casa >= 1; casa--)
            {
                if (casa > mayor)
                {
                    mayor = casa;
                }
                Console.WriteLine(casa);
                acumulador = casa + acumulador;
            }
            Console.WriteLine(mayor);
            Console.WriteLine(acumulador / 10);
            Console.WriteLine(acumulador);
        }

        static void cicloWhile()
        {
            num1 = 0;

            while (num1 <= 10)
            {
                Console.WriteLine(num1);
                num1++;
            }

        }
        static void condicionIF()
        {
            num1 = 1; num2 = 1;
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} es mayor");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} es menor");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }

        }

        static string Diasemana(string dia)  // parametro 
        {
            int numero = 0;
            switch (dia)
            {
                case "Lunes": numero = 1; break;
                case "Martes": numero = 2; break;
                case "Miercoles": numero = 3; break;
                case "Jueves": numero = 4; break;
            }

            return numero.ToString();

        }
        static void SolicitaDatos()
        {
            Console.WriteLine("Digite un numero:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite un numero:");
            num2 = float.Parse(Console.ReadLine());
        }

        static void suma(float v1, float v2)
        {
            total = v1 + v2;
            Console.WriteLine("La suma es de:" + Program.total);
        }

        static void resta()
        {
            total = num1 - num2;
            Console.WriteLine("La resta es de:" + total);
        }

        // las funciones no usan el void, usan un tipo de dato, return  devuelven un valor

        static float multiplicar()
        {
            SolicitaDatos();
            total = num1 * num2;
            Console.WriteLine(total);
            return total;
        }

    }
}
