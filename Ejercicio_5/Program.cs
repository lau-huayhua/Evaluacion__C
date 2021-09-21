using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5");
            Console.WriteLine("Ingrese la cantidad de alumnos");
            int n = int.Parse(Console.ReadLine());
            string[] nombres = new string[n];
            int[] edades = new int[n];
            string[] sexo = new string[n];
            double[] notaFinal = new double[n];

            //carga de datos
            Console.WriteLine("Ingrese el nombre de los alumnos");
            nombres[n] = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de los alumnos");
            edades[n] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el genero nombre de los alumnos");
            sexo[n] = Console.ReadLine();
            Console.WriteLine("Ingrese la nota final de los alumnos");
            notaFinal[n] = double.Parse(Console.ReadLine());
            

        }

        //punto a
        static void PromedioDeVarones(string[] sexo, double[] notaFinal)
        {
            for (int i = 0; i < sexo.Length; i++)
            {
                int contador = 0;
                for (int j = 0; j < notaFinal.Length; j++)
                {

                    if (i.Equals("Masculino") && i > 6)
                    {
                        contador++;

                    }
                }

                Console.WriteLine("la cantidad de varones aprobados es: " + contador);
            }
        }
        //punto b
        static void PromedioMenoresDeEdad(int[] edad, double[] notaFinal)
        {
            for (int i = 0; i < edad.Length; i++)
            {
                int contador = 0;
                if (i < 18)
                {
                    contador++;
                }
                for (int j = 0; j < notaFinal.Length; j++)
                {
                    double promedio = notaFinal[i] / contador;
                    Console.WriteLine("El promedio de notas de los menores de edad es " + promedio);
                }

                
            }
        }
        //punto c
        static void PromedioDeAdolecentes(int[] edad, double[] notaFinal)
        {
            for (int i = 0; i < edad.Length; i++)
            {
                int contador = 0;
                if (i > 18 && i < 25)
                {
                    contador++;
                }
                for (int j = 0; j < notaFinal.Length; j++)
                {
                    double promedio = notaFinal[i] / contador;
                    Console.WriteLine("El promedio de notas de los adolescentes es "+ promedio);
                }
            }
            //punto d
            static void PromedioDeMayores(int[] edad, double[] notaFinal)
            {
                for (int i = 0; i < edad.Length; i++)
                {
                    int contador = 0;
                    if (i > 25)
                    {
                        contador++;
                    }
                    for (int j = 0; j < notaFinal.Length; j++)
                    {
                        double promedio = notaFinal[i] / contador;
                        Console.WriteLine("El promedio de notas de los mayores es " + promedio);
                    }
                }
            }
            //punto e
            static void PromedioPorSexo(string[] sexo, double[] notaFinal)
            {
                int contador = 0;
                for (int i = 0; i < sexo.Length; i++)
                {
                    contador++;
                    for (int j = 0; j < notaFinal.Length; j++)
                    {
                        double promedio = notaFinal[i] / contador;
                        Console.WriteLine("El promedio de notas por sexo es " + promedio);
                    }
                }

            }
        }
    }
}
