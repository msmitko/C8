using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        Console.WriteLine("{0} to hexadecimal is {1}.",
            binary, Convert.ToInt32(binary, 2).ToString("X");
    }
}

