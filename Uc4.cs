﻿using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure_and_algorithm
{
    class Uc4
    {
        public static void Bubble()
        {
            int[] N = new int[] { 5, 2, 3, 1, 4 };
            int n = N.Length;
            //Console.WriteLine("Unsorted array "+N[i]);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (N[j] > N[j + 1])
                    {

                        int temp = N[j];
                        N[j] = N[j + 1];
                        N[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine("sorted array " + N[i]);

        }
    }
}
