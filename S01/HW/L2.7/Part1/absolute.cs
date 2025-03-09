using System;
namespace Part1;

class Program
{
    public static int absolute(int x)
    {
        if(x >= 0)
            return x;
        return -x;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(absolute(-100));
        Console.WriteLine(absolute(-1));
        Console.WriteLine(absolute(0));
        Console.WriteLine(absolute(1));
        Console.WriteLine(absolute(1000));
    }
}
