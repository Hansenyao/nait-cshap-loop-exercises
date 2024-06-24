/*
 * CPSC1012 - Loop Exercise: MathTutor
 * 
 * Student: Hansen Yao
 * 
 * Date: June 24, 2024
 * 
 */

using System.Diagnostics.Metrics;

namespace MathTutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int RandomNumber1 = 0;
            int RandomNumber2 = 0;
            decimal Answer = 0.0m;

            do
            {
                // Print menu
                Console.WriteLine("");
                Console.WriteLine("Math Tutor – Version 0.4");
                Console.WriteLine("------------------------");
                Console.WriteLine("a) Addition             ");
                Console.WriteLine("s) Subtraction          ");
                Console.WriteLine("m) Multiplication       ");
                Console.WriteLine("d) Division             ");
                Console.WriteLine("x) Exit Program         ");
                Console.WriteLine("Enter a letter for your choice:");

                // Generate random numbers
                RandomNumber1 = new Random().Next(1, 99);
                RandomNumber2 = new Random().Next(1, 99);

                // Menu choice
                string Choice = Console.ReadLine() ?? "";

                do
                {
                    switch (Choice)
                    {
                        case "a":
                            Console.WriteLine($"What is {RandomNumber1} + {RandomNumber2} = ?");
                            Answer = RandomNumber1 + RandomNumber2;
                            break;
                        case "s":
                            Console.WriteLine($"What is {RandomNumber1} - {RandomNumber2} = ?");
                            Answer = RandomNumber1 - RandomNumber2;
                            break;
                        case "m":
                            Console.WriteLine($"What is {RandomNumber1} x {RandomNumber2} = ?");
                            Answer = RandomNumber1 * RandomNumber2;
                            break;
                        case "d":
                            Console.WriteLine($"What is {RandomNumber1} / {RandomNumber2} = ?");
                            Answer = RandomNumber1 / RandomNumber2;
                            break;
                        case "x":
                            Console.WriteLine("\nEnd!");
                            return;
                        default:
                            Console.WriteLine("Incorrect choice!");
                            break;
                    }

                    // Get user inputing and check it
                    try
                    {
                        decimal Input = decimal.Parse(Console.ReadLine() ?? "0");
                        if (Input == Answer)
                        {
                            Console.WriteLine("Correct!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect! Would you like to try again (y/n)?");
                            string TryAgain = Console.ReadLine() ?? "n";
                            if (TryAgain == "n")
                            {
                                Console.WriteLine("The correct answer is {0}.", Answer);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("The inputing is wrong!");
                        break;
                    }
                } while (true);
            }while (true);
        }
    }
}
