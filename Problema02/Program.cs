using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (Exception)
            {
                result = Convert.ToByte(num1 * num2 > 255 ? 255 : 0);
                Console.WriteLine($"{num1} x {num2} {(result == 255 ? ">" : "<")} {result}");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
