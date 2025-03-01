using System;
namespace Part7;

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
    public static double Exp(double x, double precision)
    {
        int n = 1;
        int y = (int)Math.Pow(x,n);
        double a = 1.0/factorial(n);
        double e = 1.0;
        while (a > precision)
        {
            y = (int)Math.Pow(x,n);
            a = (double)y/factorial(n);
            n++;
            e += a;
        }
        return e;  
    }
    public static double ln(double x, double precision)
    {
        if(x <= 0){
            Console.WriteLine("not found");
            return -1;
        }
        else
        {
            double lowerBound = 0;
            double upperBound = x;
            double mid = 0;
            while(upperBound - lowerBound > precision)
            {
                mid = (upperBound + lowerBound) / 2;
                if(Exp(mid,precision) > x) 
                    upperBound = mid;
                else
                    lowerBound = mid;
            }
            return mid;
        }  
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ln(10 , 0.001));
        Console.WriteLine(ln(3 , 0.001));
    }
}
