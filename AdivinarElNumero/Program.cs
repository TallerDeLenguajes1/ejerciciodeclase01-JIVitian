using System;
using System.IO;

namespace AdivinarElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(0, 101);
            int userNumber;

            Console.WriteLine("Adivina el numero!");

            do
            {
                userNumber = LeerNumero();

                if(userNumber < number)
                    Console.WriteLine("El numero es mas grande!");
                else if (userNumber > number)
                    Console.WriteLine("El numero es mas chico!");
                else
                {   
                    Console.WriteLine("Adivinaste el numero!");
                    break;
                }
            } while (true);
        }

        public static int LeerNumero()
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            // No controlé que tipo de exepción tira
            catch (Exception e)
            {
                GuardarLog(e);
                Console.WriteLine("Debe ingresar un numero!");
                return LeerNumero();
            }
        }

        // Guardo la información de la información en un archivo
        public static void GuardarLog(Exception e)
        {
            using (FileStream archivo = new FileStream("Log.txt", FileMode.OpenOrCreate))
            {
                StreamWriter strWrite = new StreamWriter(archivo);
                strWrite.WriteLine(e);
                strWrite.Close();
                strWrite.Dispose();
            }
        }
    }
}
