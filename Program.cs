using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catDog
{
    internal class Program
    {
        static bool catDog(string input)
        {
            int catCount = 0;
            int dogCount = 0;

            for (int i = 0; i < input.Length -2; i++)
            {
                if (input.Substring(i, 3) == "cat")
                {
                    catCount++;
                }
                else if (input.Substring(i, 3) == "dog")
                {
                    dogCount++;
                }
            }

            return catCount == dogCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            bool result = catDog(input);

            if (result)
            {
                Console.WriteLine("The number of 'cat' and 'dog' occurrences is the same.");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("The number of 'cat' and dog' occurrences isn't the same.");
                Console.ReadLine();
            }
        }
    }
}
