using System;

class Program
{
    static void Conversion(string value)
    {
        Console.WriteLine("{0} to decimal is {1}.",
            value, Convert.ToInt32(value, 16));
        Console.WriteLine("{0} to decimal is {1}.\n", value,
            Convert.ToString(Convert.ToInt32(value, 16), 2));
    }
    static void Main()
    {
        Conversion("2A3E");
        Conversion("FA");
        Conversion("FFFF");
        Conversion("5A0E9");
    }
}

