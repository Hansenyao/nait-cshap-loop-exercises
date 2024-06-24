/*
 * CPSC1012 - Loop Exercise: Find the sum of the squares of the integers from 1 to MySquare, 
 * where MySquare is input by the user. 
 * 
 * E.g. user enters 4 then return 1x1 + 2x2 + 3x3 + 4x4 = 30.
 * 
 * Student: Hansen Yao
 * 
 * Date: June 10, 2024
 * 
 */

namespace SumOfSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int InputNumber = 0;
            int Sum = 0;

            // Ask user to input the number
            Console.Write("Please enter an integer number (bewteen 1 and 100): ");
            try
            {
                InputNumber = int.Parse(Console.ReadLine() ?? "0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
            if (InputNumber <= 0 || InputNumber > 100) 
            {
                Console.WriteLine("The integer number should bewteen 1 and 100!");
                return;
            }

            // Loop from 1 to InputNumber, and sum these number's squares
            for (int i = 1; i <= InputNumber; i++) 
            {
                Sum += i * i;
            }
            Console.WriteLine("The sum is: {0}", Sum);
        }
    }
}
