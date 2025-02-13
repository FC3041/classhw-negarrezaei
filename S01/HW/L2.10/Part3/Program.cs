using System;
namespace Part3;

class Program
{
    public static double exp2(int x, double precision)
    {
        int N = 1;
        int n = 0;
        double a  = (double) Math.Pow(x,n)/N; 
        double e = 0.0;
        while(a > precision)
        {
            a  = (double) Math.Pow(x,n)/N;
            n++;
            N *= n;
            e += a;   
        }
        return e;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(exp2(1 , 0.000001));
        Console.WriteLine(exp2(2 , 0.000001));
    }
}
