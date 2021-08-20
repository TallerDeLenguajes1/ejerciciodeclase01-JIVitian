using System;

namespace Problema03
{

    class Program
    {
        static void Main(string[] args)
        {
            Auto Auto1 = CrearAutoFiat(2020);            
            MostrarAuto(Auto1);            

            Auto Auto2 = CrearAutoPeugeot();
            MostrarAuto(Auto2);
        }

        static Auto CrearAutoFiat(int? anio = null)
        {
            Auto auto = null;

            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Fiat"
                };
            }

            return auto;
        }

        static Auto CrearAutoPeugeot(int? anio = null)
        {
            Auto auto = null;
            
            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Peugeot"
                };
            }

            return auto;
        }

        static void MostrarAuto(Auto auto)
        {
            //try
            //{
            //    Console.WriteLine("{0} - {1}", auto.Modelo, auto.Anio);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("No se puede mostrar el auto especificado.");
            //}
            //Console.ReadLine();

            if (auto != null)
                Console.WriteLine("{0} - {1}", auto.Modelo, auto.Anio);
            else
                Console.WriteLine("El auto especificado no existe.");    
            Console.ReadLine();

            
        }
    }
}
