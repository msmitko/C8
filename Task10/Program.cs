﻿using System;

class Program
{
    static void Main()
    {
        int deci = 0;

        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        int length = binary.Length;
        int power = length - 1;

        for (int i = 0; i < length; i++)
        {
            deci += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
            power--;
        }

        Console.WriteLine("Result is {0}.", deci);
    }
}

