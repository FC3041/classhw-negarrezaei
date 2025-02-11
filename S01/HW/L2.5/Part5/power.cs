using System;
namespace Part5;

class Program
{
    public static int power(int x, int y)
    {
        if(y<0){
            Console.WriteLine("y must be non-negative");
            return -1;
        }
        
            int number =1;
            while(y>0)
            {
                number *= x;
                y--;
            }
            return number; 
    }

    static void Main(string[] args)
    {
        int result = power(4,3);
        if(result != -1)
            Console.WriteLine(result);
    }
}
