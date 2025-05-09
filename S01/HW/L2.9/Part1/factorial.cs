using System.Diagnostics;
namespace Part1;

class Program
{
    public static ulong Factorial(int n)
    {
        Debug.Assert(n >= 0);

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
        Console.WriteLine(Factorial(5));
    }
}
