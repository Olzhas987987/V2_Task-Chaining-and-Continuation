using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPL
{
    public static class Program
    {
        public static async Task Main()
        {
            Task<int[]> task1 = Task.Run(() => CreateRandomArray(10));
            
            Task<int[]> task2 = task1.ContinueWith(t => MultiplyArray(t.Result, GenerateRandomNumber()));

            Task<int[]> task3 = task2.ContinueWith(t => SortArray(t.Result));

            Task task4 = task3.ContinueWith(t => CalculateAverage(t.Result));

            Console.ReadLine();
        }
        public static int[] CreateRandomArray(int length)
        {
            var rnd = new Random();
            var arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("Original array: " + string.Join(", ", arr));
            return arr;
        }
        public static int GenerateRandomNumber()
        {
            Random rnd = new Random();
            int mult = rnd.Next(1, 10);
            return mult;
        }

        public static int[] MultiplyArray(int[] arr, int mult) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= mult;
            }
            Console.WriteLine($"Multiplied array: " + string.Join(", ", arr));
            return arr;
        }

        public static int[] SortArray(int[] arr)

        {
            Array.Sort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
            return arr;
        }

        public static double CalculateAverage(int[] arr)
        {
            double average = (double)arr.Sum() / arr.Length;
            
            Console.WriteLine($"Average value: {average}");
            return average;
        }
    }
}