namespace Part5;

class Program
{
    public static int fibonacci(int n)
    {
        if(n==1 || n==2)
            return 1;
        
        else
        {
            int number1 = 1;
            int number2 = 1;
            int number = number1 + number2;
            for(int i=4; i<n+1; i++)
            {
                number1 = number2;
                number2 = number;
                number = number1 + number2;
            }
            return number;
        }
    }

    static void Main(string[] args)
    {
        for(int j=1; j<=20; j++)
            Console.WriteLine(fibonacci(j));
    }
}
