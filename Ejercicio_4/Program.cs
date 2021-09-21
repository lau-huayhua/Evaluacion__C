using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4");
            int n = int.Parse(Console.ReadLine());
            int[] vehiculos = new int[n];
            string[] color = new string[3];
            int contadorDeVehiculos = 0;

            for (int i = 0; i < vehiculos.Length; i++)
            {
                Console.WriteLine("Ingrese el precio del vehiculo");
                int precio = int.Parse(Console.ReadLine());
                if (precio > 0 && precio < 10000)
                {
                    vehiculos[i] = precio;
                    contadorDeVehiculos += vehiculos[i];
                }

            }

            Console.WriteLine("Ingrese el color del vehiculo");
            string colores = Console.ReadLine();
            int contadorColores = 0;
            for (int i = 0; i < color.Length; i++)
            {
                if (color.Equals("rojo") || color.Equals("verde") || color.Equals("amarillo"))
                {
                    color[i] = colores;
                    contadorColores++;
                }
            }
            //a. La cantidad de rojos
            int contadorRojos=0;
            for (int i = 0; i < color.Length; i++)
            {
                if (color.Equals("rojo"))
                {
                    contadorRojos++;
                }
                Console.WriteLine("La cantidad de rojos" + contadorRojos);
            }

           
            // b.La cantidad de rojos con precio mayor a 5000
            for (int i = 0; i < color.Length; i++)
            {
                int cont = 0;
                if (color.Equals("rojo"))
                {
                    for (int j = 0; j < vehiculos.Length; j++)
                    {
                        if (vehiculos[j] > 5000)
                        {
                            cont++;
                        }
                    }
                }
                Console.WriteLine("La cantidad de rojos con precio mayor a 5000" + cont);
            }

            //c.La cantidad de vehículos con precio inferior a 5000
            for (int j = 0; j < vehiculos.Length; j++)
            {
                int cont1 = 0;
                if (vehiculos[j] < 5000)
                {
                    cont1++;
                }
                Console.WriteLine("La cantidad de rojos con precio menor a 5000" + cont1);
            }
            // d.El promedio de todos los vehículos ingresados.
            int promedio = contadorDeVehiculos / n;
            Console.WriteLine("El promedio de precios de todos los vehiculos es: " + promedio);

            //e.El más caro y su color.
            int masCaro = int.MaxValue;
            for (int j = 0; j < vehiculos.Length; j++)
            { 
                if(vehiculos[j]>masCaro)
                {
                    masCaro = vehiculos[j];

                    Console.WriteLine("El vehiculo mas caro: "+ masCaro);
                }
            }


            
    }
    }
}
