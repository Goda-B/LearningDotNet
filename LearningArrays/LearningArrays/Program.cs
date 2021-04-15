// Work in the main function and complete the tasks:
//•	Create an array of string size 5. Fill array items with values.
//•	Print all words using loop.
//•	Create an int array size 20. Fill values from 0 till 20.
//•	Print numbers backwards.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Task - Words array

            string[] words;
            words = new string[5] { "House", "Door", "Window", "Table", "Chair" };

            Console.WriteLine("1 Task. Create an array of string size 5. Fill array items with values. Print all words using loop.");
            Console.WriteLine();
            Console.WriteLine("Words: ");
            Console.WriteLine();

            foreach (var item in words)
            {
                Console.WriteLine(item.ToString());
             }

            Console.WriteLine();
            Console.WriteLine();

            //2 Task - Numbers array

            int[] numbers = new int[20] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};

            Console.WriteLine("2 Task. Create an int array size 20. Fill values from 0 till 20. Print numbers backwards.");
            Console.WriteLine();
            Console.WriteLine("Numbers: ");
            Console.WriteLine();
            Array.ForEach(numbers, Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Numbers printed backwards: ");
            Console.WriteLine();
            Array.Reverse(numbers);
            Array.ForEach(numbers, Console.WriteLine);

            Console.ReadKey();
        }
    }
}
