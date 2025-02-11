using System;
namespace Part6;

class Program
{
    public static void quadradic(float A, float B, float C)
    {
        float Delta = (float)(Math.Pow(B,2) - 4*A*C);
        if(Delta > 0)
        {
            float x1 = (float)((-B + Math.Sqrt(Delta)) / (2 * A));
            float x2 = (float)((-B - Math.Sqrt(Delta)) / (2 * A));
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if(Delta == 0)
        {
            float x = (float)((-B + Math.Sqrt(Delta)) / (2 * A));
            Console.WriteLine("x = " + x);
        }
        else
            Console.WriteLine("None");
    }
    static void Main(string[] args)
    {
        quadradic(1,2,3);
        quadradic(1,-4,3);
    }
}
