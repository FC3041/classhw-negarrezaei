namespace L2._8;

class Program
{
    public static int compute_sum(int n)
    {
        int sum = 0;
        for(int i=0; i< n+1; i++)
            sum = sum + i;

        return sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("N  compute_sum(N)");
        Console.WriteLine("------------------");
        for(int i=9; i>0; i--)
            Console.WriteLine(i + "  " + compute_sum(i));
    }
}
