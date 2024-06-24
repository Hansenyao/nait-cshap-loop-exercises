/*
 * CPSC1012 - Loop Exercise: Write a program that takes as input the number of days in a month 
 * and the day of the week on which the first of the month occurs. 
 *
 * The program should produce a display of the calendar for that month in standard form. 
 * For example, if there are 30 days in the month and the first day of the month is Wednesday, 
 * the input would be 30 and Wed, and the output should be similar to the following:
 *
 * Sun Mon Tue Wed Thu Fri Sat 
 *             1   2   3   4
 * 5   6   7   8   9   10  11 
 * 12  13  14  15  16  17  18 
 * 19  20  21  22  23  24  25 
 * 26  27  28  29  30
 *
 * Student: Hansen Yao
 * 
 * Date: June 17, 2024
 * 
 */

namespace WeekDaysInMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Days = 0;
            int StartIndex = -1;
            string StartWeekDay;
            string[] Week = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            try
            {
                // Get how many days in this month
                Console.Write("Please enter how many days in the month [28,31]: ");
                Days = int.Parse(Console.ReadLine() ?? "0");
                if (Days < 28 || Days > 31)
                {
                    Console.WriteLine("The days number is wrong!");
                    return;
                }

                // Get the starting week day
                Console.Write("Please enter which week day starts from (Likes 'Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri' or 'Sat'): ");
                StartWeekDay = Console.ReadLine() ?? "";
                for (int i = 0; i < Week.Length; i++)
                {
                    if (Week[i] == StartWeekDay)
                    {
                        StartIndex = i;
                        break;
                    }
                }
                if (StartIndex == -1)
                {
                    Console.WriteLine("The starting week day is wrong!");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }

            // Print week days
            Console.WriteLine("\nThe calendar is below:");
            for (int i = 0; i < Week.Length; i++)
            {
                Console.Write(Week[i] + "\t");
            }

            // Print the spaces for the first week 
            Console.WriteLine("");
            for (int i = 0; i < StartIndex; i++)
            {
                Console.Write("\t");
            }

            // Print each day in the right week day
            for (int i = 1; i <= Days; i++)
            {
                int Index = (i + StartIndex) % Week.Length;
                if (Index != 0)
                {
                    Console.Write(i + "\t");
                }
                else
                {
                    Console.Write(i + "\n");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
