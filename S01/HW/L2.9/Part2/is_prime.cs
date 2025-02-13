using System.Diagnostics;
namespace Part2;

class Program
{
    public static bool is_divisible(int a, int b)
    {
        Debug.Assert(a >= 0);
        Debug.Assert(b > 0);
        return a%b == 0;
    }

    public static bool is_prime(int N){
        Debug.Assert(N > 0);

        if(N == 1){
            return false;
        }
        for(int x = 2; x<N; x++){
            if(is_divisible(N,x)){
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        for(int i = 1; i<100; i++)
            if(is_prime(i))
                Console.WriteLine(i);
    }
}
