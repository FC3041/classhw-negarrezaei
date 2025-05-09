namespace Part3;

class Program
{
    public static void print_right_triangle(int baseLength, char character)
    {
        if(character == '\0')
            character = '*';

        for(int i=1; i<baseLength+1; i++)
        {
            for(int j = baseLength-i; j>0; j--) 
                Console.Write(" ");
            for(int k=1; k<i+1; k++)
                Console.Write(character);
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        print_right_triangle(20,'*');
    }
}
