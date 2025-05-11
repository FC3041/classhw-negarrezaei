using System;
namespace Part7;

class Program
{
    public static float average_of_squares0(int n)
    {
        int Sum_of_squares = 0;
        int N = n;
        while(n >= 0)
        {
            n--;
            Sum_of_squares += (int)Math.Pow(n,2);
        }
        float average_of_squares = Sum_of_squares / N;
        return average_of_squares; 
    }

    static void Main(string[] args)
    {
        float result = average_of_squares0(5);
        Console.WriteLine(result);
    }
}
