namespace L2._3;

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
        for(int i=0; i<6; i++)
            Console.WriteLine(" +*******+ ");
    }
    public static void Line()
    {
        Console.WriteLine(" +-------+ ");
    }


    static void Main(string[] args)
    {
        Head();
        for(int j=0; j<4; j++)
        {
            Line();
            Body();
        }
        Line();
        Head();
    }
}
