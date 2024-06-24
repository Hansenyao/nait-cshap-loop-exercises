/*
 * CPSC1012 - Loop Exercise: Write a program that could be used to play a simple game. 
 *
 * The program should first generate a random number between 1 and 100 (research how to create random numbers in your programming language). 
 * Once this number has been generated, the program should ask the user to guess the generated number. 
 * After each incorrect guess, the program should tell the user whether the guess was too low or too high and ask for another guess. 
 * This should continue until the user has found the correct number. 
 * The program should then print the number of guesses that the user needed to determine the number.
 * 
 * Student: Hansen Yao
 * 
 * Date: June 22, 2024
 * 
 */

namespace RandomNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TryTimes = 0;
            int RandomNuber = new Random().Next(0, 100);

            do
            {
                Console.Write("Please enter your answer [0, 100]: ");
                int Answer = int.Parse(Console.ReadLine() ?? "0");
                if (Answer == RandomNuber)
                {
                    Console.WriteLine("Congradulation! You get the right answer by {0} times.", TryTimes);
                    break;
                }
                else if (Answer < RandomNuber)
                {
                    Console.WriteLine("Sorry, your answer is too low! Try it again!");
                }
                else
                {
                    Console.WriteLine("Sorry, your answer is too high! Try it again!");
                }
                TryTimes ++;
            } while (true);
        }
    }
}
