using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 4");

            List<int> numbers = new List<int>();

            int Number = -1;
            do            
            {
                Console.Write("Enter a number (0 to quit): ");
                
                string Response = Console.ReadLine();
                Number = int.Parse(Response);
                
                numbers.Add(Number);


            }while (Number != 0);
        
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Part 2: Compute the average
            float average = sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Part 3: Find the max
            // There are several ways to do this, such as sorting the list
            
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    // if this number is greater than the max, we have found the new max!
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");

        
        }

        
    }
}
