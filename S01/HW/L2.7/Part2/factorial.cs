using System;
namespace Part2;

class Program
{
    public static ulong Factorial(int n)
    {
        ulong number = 1;
        for(int i=1; i<n+1; i++)
            number *= (ulong)i;
        return number;
    }

    static void Main(string[] args)
    {
        for(int j=1; j<21; j++)
            Console.WriteLine(j + "! = " + Factorial(j));
    }
}
