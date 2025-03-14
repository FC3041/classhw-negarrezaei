using System;
namespace Part3;

class Program
{
    public static void print_cone(int baseSize)
    {
        int space = baseSize/2;
        for(int i=0; i<space; i++)
            Console.Write(" ");
        Console.WriteLine("^");

        for(int j=1; j<space+1; j++)
        {
            for(int k=space-j; k>0; k--)
                Console.Write(" ");
            for(int x=1; x<j+1; x++)
                Console.Write("/");

            Console.Write("|");
            for(int y=1; y<j+1; y++)
                Console.Write("\\");

            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        print_cone(7);
    }
}
