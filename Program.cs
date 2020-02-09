using System;

namespace SummativeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] arr2 = { 999, -60, -77, 14, 160, 301 };
            int[] arr3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130,
                           140, 150, 160, 170, 180, 190, 200, -99 };

            Console.WriteLine(sumOfArray(arr1));
            Console.WriteLine(sumOfArray(arr2));
            Console.WriteLine(sumOfArray(arr3));

        }

        public static int sumOfArray( int[] array)
        {
            int sum = 0;
            foreach(int x in array)
            {
                sum += x;
            }

            return sum;
        }
    }
}
