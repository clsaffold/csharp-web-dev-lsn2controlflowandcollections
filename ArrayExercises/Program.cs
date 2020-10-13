using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 1, 1, 2, 3, 5, 8 };

            //list each integer in the array integers in order
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
            }
            
            //another way to list each integer in array in order on separate lines
            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }
            
            //list only the odd integers in array
            for (int i = 0; i < integers.Length; i++)
                if (integers[i] % 2 !=0)
                {
                    Console.WriteLine(integers[i]);
                }
        }
    }
}
