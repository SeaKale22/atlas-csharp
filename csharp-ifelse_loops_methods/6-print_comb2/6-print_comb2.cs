﻿using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = i + 1; j <= 9; j++)
                {
                    if (i != j)
                    {
                        Console.Write($"{i}{j}");
                        if (i == 8 && j == 9)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
        }
    }
}
