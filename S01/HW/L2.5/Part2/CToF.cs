using System;
namespace Part2;

class Program
{
    public static void temperature(float C)
    {
        float F = 9/5 * C + 32;
        Console.WriteLine("{0:0.00}",C);
        Console.WriteLine("{0:0.00}",F);
    }

    static void Main(string[] args)
    {
        temperature(80.5f);
    }
}
