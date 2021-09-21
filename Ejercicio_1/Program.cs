using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1: ");

            Console.WriteLine("Ingrese el numero entero 1: ");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero entero 2: ");
            int num2=int.Parse(Console.ReadLine());
           
                //Si son iguales muestro el cuadrado del número.
                if (num1 == num2)
                {
                    Console.WriteLine("El primer numero elevado al cuadrado es " + (num1 * num1));
                    Console.WriteLine("El segundo numero elevado al cuadrado es " + (num2 * num2));
                }
                //Si el primero es divisible por el segundo, los resto, de lo contrario muestro solo el resto
                if (num1 != 0)
                {
                    Console.WriteLine("La resta de los dos numeros es: " + (num1 - num2));
                }
                else if((num1 % num2) > 3)
                {
                Console.WriteLine("El resto es mayor a 3");
                
                }
                else
                {
                Console.WriteLine("El resto de los dos numeros es: " + (num1 % num2));
                }

           
            Console.ReadKey();
        }
    }
}
