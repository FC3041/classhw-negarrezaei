using System;
namespace Part3B;

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



    public static bool near(int x)
    {
        if((exp2(x , 0.00001) >= 0.99999 * exp(x , 0.00001)) && (exp2(x , 0.00001) <= 1.00001 * exp(x , 0.00001)))
            return true;
        return false;
    }
    static void Main(string[] args)
    {
        if(near(2))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}
