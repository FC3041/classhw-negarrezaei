using System;
namespace Part1;

class Program
{
    public static ulong factorial(int n)
    {
        if(n == 0)
            return 1;
        ulong number = 1;
        while(n > 0){
            number *= (ulong)n;
            n--;
        }
        return number;
    }

    public static double eulers_constant(double precision)
    {
        int n = 1;
        double a = 1.0/factorial(n);
        double e = 1.0;
        while (a > precision)
        {
            a = 1.0/factorial(n);
            n++;
            e += a;
        }
       
        return e; 
    }

    static void Main(string[] args)
    {
        Console.WriteLine(eulers_constant(0.0001));
    }
}
