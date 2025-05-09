using System;
namespace Part5;

class Program
{
    public static double square_root(double x, double precision)
    {
        double lowerBound = 0;
        double upperBound = x;;
        int iterations = 0;
        double mid = 0;
        while(upperBound - lowerBound > precision)
        {
            mid = (upperBound + lowerBound) / 2;
            if(Math.Pow(mid,2) > x)
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
        Console.WriteLine(square_root(2, 0.000001));
        Console.WriteLine(Math.Pow(2,0.5));
    }
}
