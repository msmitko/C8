﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int deci = Int32.Parse(Console.ReadLine());
        Console.WriteLine("{0} to hexadecimal is {1}.",
            deci, deci.ToString("X"));
    }
}

