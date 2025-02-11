namespace Part1;

class Program
{
    public static void temperature(float F)
    {
        float C = (F - 32) * 5/9;
        Console.WriteLine("{0:0.00}",F);
        Console.WriteLine("{0:0.00}",C);
    }

    static void Main(string[] args)
    {
        temperature(50.8f);
    }
}
