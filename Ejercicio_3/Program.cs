using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercio 3");
            int[] bolsasDeMascotas = new int[10];
            string[] sabor = new string[3] { "carne", "vegetales", "pollo" };


            for (int i = 0; i < bolsasDeMascotas.Length; i++)
            {
                Console.WriteLine("Ingrese los kilos de cada bolsa");
                int kilos = int.Parse(Console.ReadLine());
                if (kilos > 0 && kilos < 500)
                {
                    bolsasDeMascotas[i] = kilos;
                }

            }


            //El promedio de los kilos totales.
            double sumatoria = 0;
            int contador = 0;
            for (int i = 0; i < bolsasDeMascotas.Length; i++)
            {
                sumatoria += bolsasDeMascotas[i];
                contador++;

                double promedio = sumatoria / contador;
            }

            //La bolsa más liviana y su sabor
            for (int i = 0; i < bolsasDeMascotas.Length; i++)
            {
                int minimo = int.MinValue;
                if (bolsasDeMascotas[i] == minimo)
                {
                    int bolsaLiviana = bolsasDeMascotas[i];
                    Console.WriteLine("La bolsa mas liviana es: "+bolsaLiviana);
                }
            }
            //La cantidad de bolsas sabor carne y el promedio de kilos de sabor carne
            for (int i = 0; i < sabor.Length; i++)
            {
                //int sum = 0;
                int cont = 0;
                if (sabor[i] == "carne")
                {
                    cont++;    
                
                   Console.WriteLine("La cantidad de bolsas de carne es " + cont);
                }
            }
            Console.ReadKey();
        }
    }
}
