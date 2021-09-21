using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            string[] continente = new string[5] { "America", "Asia", "Europa", "Africa", "Oceania" };
            string[] formaDePago = new string[6] { "Debito", "Credito", "Efectivo", "Mercado Pago", "Cheque", "Leliq" };

            double precioDia = 100;
            
            bool validacionCnt = Ejercicio_2.Program.ValidacionContinentes(continente);
            bool validacionPg = Ejercicio_2.Program.ValidacionFormaDePago(formaDePago);

            if (validacionCnt && validacionPg)
            {
                for (int i = 0; i < continente.Length; i++)
                {
                    for (int j = 0; j < formaDePago.Length; j++)
                    {
                        if (i.Equals("America"))
                        {
                            double respuesta = precioDia - (precioDia * 0.15);
                            if (j.Equals("Debito"))
                            {
                                double respuesta2 = precioDia - (precioDia * 0.25);
                            }
                        }
                        if (i.Equals("Africa") || i.Equals("Oceania"))
                        {
                            double respuesta = precioDia - (precioDia * 0.30);
                            if (j.Equals("Mercado Pago") || j.Equals("Efectivo"))
                            {
                                double respuesta2 = precioDia - (precioDia * 0.45);
                            }
                        }
                        if (i.Equals("Europa"))
                        {
                            double respuesta = precioDia - (precioDia * 0.20);
                            if (j.Equals("Debito"))
                            {
                                double respuesta2 = precioDia - (precioDia * 0.35);
                            }
                            else if (j.Equals("Mercado Pago"))
                            {
                                double respuesta3 = precioDia - (precioDia * 0.30);
                            }
                            else
                            {
                                double respuesta4 = precioDia - (precioDia * 0.25);
                            }

                        }
                        else if (j.Equals("Cheque"))
                        {
                            double respuesta = precioDia + (precioDia * 0.15);
                        }
                    }
                }
            }
            


                 
             Console.ReadKey();
        }

        //punto a
        static bool ValidacionContinentes(string[] continente)
        {
            bool valido = false;
            for (int i = 0; i < continente.Length; i++)
            {
                if (i.Equals("America") || i.Equals("Asia") || i.Equals("Europa") || i.Equals("Africa") || i.Equals("Oceania"))
                {
                    valido = true;
                }
            }
            return valido;
        }

        static bool ValidacionFormaDePago(string[] formaDePago)
        {
            bool validacion = false;
            for (int i = 0; i < formaDePago.Length; i++)
            {
                if (i.Equals("Debito") || i.Equals("Credito") || i.Equals("Efectivo") || i.Equals("Mercado Pago") || i.Equals("Cheque") || i.Equals("Leliq")) ;
                {
                    validacion = true;
                }
            }
            return validacion;
        }

    }
}
