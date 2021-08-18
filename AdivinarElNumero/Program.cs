using System;

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
            catch (Exception)
            {
                Console.WriteLine("Debe ingresar un numero!");
                return LeerNumero();
            }
        }
    }
}
