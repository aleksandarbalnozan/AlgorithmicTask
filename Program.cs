using System;

namespace AlgorthimicTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 4, 4, 4, 5, 6, 6 };
            FindMostFrequent(array);
        }

        public static void FindMostFrequent(int[] arr)
        {

            int count;
            int temp = 0;
            int mostFrequent = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                count = 0;
                for (int j = 0; j < arr.Length; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > temp)
                {
                    temp = count;
                    mostFrequent = arr[i];
                }
            }
            Console.WriteLine(mostFrequent);
        }
    }
}