using System;

namespace AdivinarElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(0, 101);
            int userNumber;

            Console.WriteLine("Adivine el numero!");

            do
            {
                userNumber = Int32.Parse(Console.ReadLine());

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
    }
}
