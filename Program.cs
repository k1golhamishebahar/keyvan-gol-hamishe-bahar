﻿using System;
namespace fibonacci
{
    class program
    {
        public static int fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

            }
            return a;
        }
        
        static void Main()
        {
            for (int i = 0; i < 15; i++)
            {
             Console.WriteLine(fibonacci(i));
            }
            Console.WriteLine();
        }

    }
}



















      




















    