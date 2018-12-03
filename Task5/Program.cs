using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine();
        Console.WriteLine("{0} to decimal is {1}.",
            binary, Convert.ToInt64(binary, 2));
    }
}

