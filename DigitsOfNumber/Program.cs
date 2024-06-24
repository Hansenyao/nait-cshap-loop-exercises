/*
 * CPSC1012 - Loop Exercise: Write a program that reads in a value N and then prints
 * its digits in a column, starting with the last digit. 
 *
 * E.g. if N = 3456, then the program should print the following:
 * 6
 * 5
 * 4 
 * 3
 *
 * Student: Hansen Yao
 * 
 * Date: June 15, 2024
 * 
 */

namespace DigitsOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal N = 0.0m;

            // Get the number from inputing
            Console.Write("Please enter a number: ");
            try
            {
                N = decimal.Parse(Console.ReadLine() ?? "0");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Print digits of the inputed number starting from the last digit
            string InputNumber = Convert.ToString(N);
            for (int i = InputNumber.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(InputNumber[i]);
            }
        }
    }
}
