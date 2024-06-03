using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Matematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Entrada;
            do
            {
                Console.WriteLine("Escriba la opcion que desea realizar segun lo que se muestra a continuacion: ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. División");
                Console.WriteLine("4. Potencia");
                Console.WriteLine("5. Area triangulo");
                Console.WriteLine("6. Area cuadrado");
                Console.WriteLine("7. Salir");

                Entrada = Console.ReadLine().ToLower();

                switch (Entrada)
                {
                    case "suma":
                        Suma();
                        break;
                    case "resta":
                        Resta();
                        break;
                    case "division":
                        Division();
                        break;
                    case "potencia":
                        Potencia();
                        break;
                    case "areatriangulo":
                        AreaTriangulo();
                        break;
                    case "areacuadrado":
                        AreaCuadrado();
                        break;
                    case "salir":
                        Console.WriteLine("Estamos saliendo del programa..");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;

                }
                Console.WriteLine();
            } while (Entrada != "salir");
        }
        static void Suma()
        {
            Console.WriteLine("Ingrese un numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 + num2;
            Console.WriteLine("La suma es: " + resultado);
        }
        static void Resta()
        {
            Console.WriteLine("Ingrese un numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 - num2;
            Console.WriteLine("La resta es: " + resultado);
        }
        static void Division()
        {
            Console.WriteLine("Ingrese un numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 / num2;
            Console.WriteLine("La division es: " + resultado);
        }
        static void Potencia()
        {
            Console.WriteLine("Ingrese el numero que va ser la base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero que va ser el exponente: ");
            double exponente = Convert.ToDouble(Console.ReadLine());
            double resultado = Math.Pow(baseNum, exponente);
            Console.WriteLine("La potencia es: " + resultado);

        }
        static void AreaTriangulo()
        {
            Console.WriteLine("Ingrese la base del triangulo: ");
            double baseTria = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double area = (baseTria * altura) / 2;
            Console.WriteLine("El area es: " +  area);

        }
        static void AreaCuadrado()
        {
            Console.WriteLine("Ingrese el lado para el cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            double area = lado * lado;
            Console.WriteLine("El area es: " + area);
        }
    }
}
