using System;
namespace Part3;

class Program
{
    public static ulong factorial(int n)
    {
        ulong number = 1;
        while(n>0)
        {
            number *= (ulong)n;
            n--;
        }
        return number;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(factorial(10));
    }
}
