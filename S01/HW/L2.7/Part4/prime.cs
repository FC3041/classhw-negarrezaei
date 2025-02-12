using System;
namespace Part4;

class Program
{
    public static bool is_divisible(int a, int b)
    {
        return a%b == 0;
    }

    public static bool is_prime(int N)
    {
        if(N == 1)
            return false;

        for(int i=2; i<N; i++)
            if(is_divisible(N,i))
                return false;
        
        return true;
    }

    static void Main(string[] args)
    {
        for(int j=1; j<100; j++)
            if(is_prime(j))
                Console.WriteLine(j);
    }
}
