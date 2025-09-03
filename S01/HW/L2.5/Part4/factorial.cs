namespace Part4;

class Program
{
    public static ulong factorial(int n)
    {
        ulong number = 1;
        while(n>0)
        {
            number *= (ulong)n;
            n--;
        }
        return number;
    }

    static void Main(string[] args)
    {
        for(int i=1; i<21; i++)
        {
            ulong result = factorial(i);
            Console.WriteLine(i + "! = " + result);
        }
    }
}
