using System;
namespace Part7;

class Program
{
    public static bool Pythagorean_Triples(int a ,int b ,int c)
    {
        if(a*a + b*b == c*c)
            return true;
        return false;
    }

    static void Main(string[] args)
    {
        for(int i = 1; i<100; i++){
            for(int j = i+1; j<100; j++){
                for(int k = j+1; k<100; k++){
                    if(Pythagorean_Triples(i, j, k)){
                        Console.WriteLine("a = " + i + "    b = " + j + "    c = " + k);
                    }
                }
            }
        }
    }
}
