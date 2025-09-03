using System;
namespace Part6;

class Program
{
    public static double root(double x, int n, double precision)
    {
        double lowerBound = 0;
        double upperBound = x;;
        int iterations = 0;
        double mid = 0;
        while(upperBound - lowerBound > precision)
        {
            mid = (upperBound + lowerBound) / 2;
            if(Math.Pow(mid,n) > x)
                upperBound = mid;
            else
                lowerBound = mid;
            iterations++;
        }
        Console.WriteLine("iterations = "+ iterations);
        return mid;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(root(8,3, 0.000001));
        Console.WriteLine(Math.Pow(8,(double)1/3));
    }
}
