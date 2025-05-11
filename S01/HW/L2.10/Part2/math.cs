using System;
namespace Part2;

class Program
{
    public static int Power(int a, int b)
    {
        int power = 1;
        for(int i =0; i<b; i++)
            power *= a;
    
        return power;
    }
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
    public static double exp(int x, double precision)
    {
        int n = 1;
        int y = Power(x,n);
        double a = 1.0/factorial(n);
        double e = 1.0;
        while (a > precision)
        {
            y = Power(x,n);
            a = (double)y/factorial(n);
            n++;
            e += a;
        }
        return e; 
    }

    static void Main(string[] args)
    {
        Console.WriteLine(exp(1,0.000001));
        Console.WriteLine(exp(2,0.000001));
    }
}
