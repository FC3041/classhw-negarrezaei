using System;
namespace Part3;

class Program
{
    public static bool is_divisible(int a, int b)
    {
        return a%b == 0;
    }

    static void Main(string[] args)
    {
        if(is_divisible(28,9))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}
