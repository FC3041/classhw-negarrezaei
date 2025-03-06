using System;
namespace Part3A;

class Program
{
    public static float Abs(float x)
    {
        if(x >= 0)
            return x;
        return -x; 
    }
    public static bool near(float x, float y, double closeness)
    {
        float x1 = Abs(x);
        float y1 = Abs(y);
        if((y1 > (1 - closeness) * x1) && (y1 < (1 + closeness) * x1))
            return true;
        return false;
    }

    static void Main(string[] args)
    {
        if(near(102,102.1f, 0.001))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}
