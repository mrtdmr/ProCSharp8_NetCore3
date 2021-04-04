using System;

namespace _3._1_FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //RectMultidimensionalArray();
            //JaggedMultidimensionalArray();
            SystemArrayFunctionality();
        }
        static void SimpleArrays()
        {
            int[] myInts = new int[3];
            string[] booksOnDotNet = new string[100];
            string[] stringArray = new string[] { "one", "two", "three" };
            bool[] boolArray = { false, true, true };
            int[] intArray = { 1, 4, 2, 6, 2 };
            var a = new[] { 1, 100, 23, 34 };
            var b = new[] { "one", "two", "three" };
            object[] myObjectArray = { 1, "one", false, true, 43.5, "Adam" };
        }
        static void RectMultidimensionalArray()
        {
            int[,] myMatrix = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void JaggedMultidimensionalArray()
        {
            int[][] myJagArray = new int[5][];
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void SystemArrayFunctionality()
        {
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
            for (int i = 1; i < gothicBands.Length; i++)
            {
                Index idx = ^i;
                Console.WriteLine(gothicBands[idx]+", ");
            }
            Range r = 0..3;
            foreach (var item in gothicBands[r])
            {
                Console.WriteLine(item+", ");
            }
        }
    }
}
