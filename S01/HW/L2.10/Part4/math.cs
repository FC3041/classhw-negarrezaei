using System;
namespace Part4;

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
    public static double Abs(double x)
    {
        if(x >= 0)
            return x;
        return -x; 
    }
    public static double Sin(int x, double precision)
    {
        double rad = x * (3.1415 / 180);
        int n = 0;
        double sinx = 0.0;
        double a = (Math.Pow(-1,n) * Math.Pow(rad,(2*n + 1))) / factorial(2*n +1);
        while (Abs(a) > precision)
        {
            sinx += a;
            n++;
            a = (Math.Pow(-1,n) * Math.Pow(rad,(2*n + 1))) / factorial(2*n +1);
        }
        return sinx;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Sin(45 , 0.0001));
        Console.WriteLine(Sin(90 , 0.001));
        Console.WriteLine(Sin(0 , 0.0001));
    }
}
