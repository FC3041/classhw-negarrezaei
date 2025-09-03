using System;

namespace L2._2;

class Program
{
    public static void Head()
    {
        Console.WriteLine("     ^     ");
        Console.WriteLine("    /|\\    ");
        Console.WriteLine("   //|\\\\   ");
        Console.WriteLine("  ///|\\\\\\  ");
    }
    public static void Body()
    {
        Console.WriteLine(" +*******+ ");
        Console.WriteLine(" +*******+ ");
        Console.WriteLine(" +*******+ ");
        Console.WriteLine(" +*******+ ");
    }
    public static void Line()
    {
        Console.WriteLine(" +-------+ ");
    }


    static void Main(string[] args)
    {
        Head();
        Line();
        Body();
        Line();
        Body();
        Line();
        Head();
    }
}
