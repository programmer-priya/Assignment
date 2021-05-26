﻿using System;

namespace ArrayAssignment
{



    public class MinAndMax
    {
        public int Max(int[] array)
        {
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public int Min(int[] array)
        {
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static void Main(String [] args)
        {
            int[] myArray = { 23, 92, 56, 39, 93 };
            MinAndMax m = new MinAndMax();
            Console.WriteLine("Maximum value in the array is::" + m.Max(myArray));
            Console.WriteLine("Minimum value in the array is::" + m.Min(myArray));
        }
    }
}

