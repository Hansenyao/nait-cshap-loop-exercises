/*
 * CPSC1012 - Loop Exercise: Input a list of numbers from the user and then calculate 
 * and display the average age. 
 * 
 * Use the input of the number zero (i.e. 0) to stop prompting for numbers.
 * 
 * Student: Hansen Yao
 * 
 * Date: June 13, 2024
 * 
 */

namespace AvgOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            decimal InputNumber = 0.0m;
            decimal Sum = 0.0m;

            // Get inputing
            do
            {
                Console.Write("Please enter a number (end by 0):");
                try
                {
                    InputNumber = decimal.Parse(Console.ReadLine() ?? "0");
                    if (InputNumber != 0)
                    {
                        Sum += InputNumber;
                        Count++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return;
                }
            } while (InputNumber != 0);

            // Calculate average of inputed numbers
            decimal Avg = Sum / Count;
            Console.WriteLine("The average is: {0}", Avg);
        }
    }
}
