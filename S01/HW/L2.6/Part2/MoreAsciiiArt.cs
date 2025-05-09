using System;
namespace Part2;

class Program
{
    public static void print_left_triangle(int n)
    {
        for(int i=1; i<n+1; i++)
        {
            if(i%2 == 1)
                for(int j=0; j<i; j++)
                    Console.Write("%");

            else
                for(int k=0; k<i; k++)
                    Console.Write("*");
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        print_left_triangle(10);
    }
}
