using System;
namespace Part8;

class Program
{
    public static float average_of_squares1(int n)
    {
        int Sum_of_squares = 0;
        int N = n;
        while(n > 0)
        {
            Sum_of_squares += (int)Math.Pow(n,2);
            n--;
        }
        float average_of_squares = (float)Sum_of_squares / N;
        return average_of_squares; 
    }

    static void Main(string[] args)
    {
        float result = average_of_squares1(4);
        Console.WriteLine(result);
    }
}
