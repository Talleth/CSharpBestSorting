using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] pArguments)
        {
            // Initialize arrays to test
            int[] arrayofNumbers    = new int[9] { 100, 45, 33, 55, 356, 11, 1000, 999, 987 };
            int[] arrayToSort1      = new int[9];
            int[] arrayToSort2      = new int[9];

            double bubbleSeconds;
            double insertSeconds;

            DateTime bubbleStart;
            DateTime bubbleEnd;
            DateTime insertStart;
            DateTime insertEnd;

            arrayofNumbers.CopyTo(arrayToSort1, 0);
            arrayofNumbers.CopyTo(arrayToSort2, 0);

            // Execute and time first sort
            bubbleStart = DateTime.Now;
            Program.BubbleSort(arrayToSort1, arrayToSort1.Length);
            bubbleEnd = DateTime.Now;

            // Execute and time second sort
            insertStart = DateTime.Now;
            Program.InsertionSort(arrayToSort2);
            insertEnd = DateTime.Now;

            bubbleSeconds = (bubbleEnd - bubbleStart).TotalMilliseconds;
            insertSeconds = (insertEnd - insertStart).TotalMilliseconds;

            // Print out results
            Console.WriteLine("Time Calculations:");
            Console.WriteLine();
            Console.WriteLine("Bubblesort Start: " + bubbleStart.ToString("MM/dd/yyyy HH:mm:ss.FFF"));
            Console.WriteLine("Bubblesort End: " + bubbleEnd.ToString("MM/dd/yyyy HH:mm:ss.FFF"));
            Console.WriteLine();
            Console.WriteLine("Time: " + bubbleSeconds + " milliseconds.");
            Console.WriteLine();
            Console.WriteLine("Insertsort Start: " + insertStart.ToString("MM/dd/yyyy HH:mm:ss.FFF"));
            Console.WriteLine("Insertsort End: " + insertEnd.ToString("MM/dd/yyyy HH:mm:ss.FFF"));
            Console.WriteLine();
            Console.WriteLine("Time: " + insertSeconds + " milliseconds.");
            Console.WriteLine();

            if (bubbleSeconds > insertSeconds)
                Console.WriteLine("Insertsort is faster.");
            else
                Console.WriteLine("Bubblesort is faster.");
        }

        public static int[] BubbleSort(int[] arrayToSort, int arrayLength)
        {
            // Iterate full array
            for (int i = 0; i < arrayLength - 1; i++)
            {
                // Iterate backwards until the spot is found
                for (int j = 0; j < arrayLength - i - 1; j++)
                {
                    // When spot is found swap
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        int tempNumber = arrayToSort[j];

                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = tempNumber;
                    }
                }
            }

            return arrayToSort;
        }

        public static int[] InsertionSort(int[] arrayToSort)
        {
            // Iterate full array
            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                // Iterate until spot is found
                for (int j = i + 1; j > 0; j--)
                {
                    if (arrayToSort[j - 1] > arrayToSort[j])
                    {
                        // Insert value to array
                        int temp = arrayToSort[j - 1];
                        arrayToSort[j - 1] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                }
            }
            return arrayToSort;
        }
    }
}
