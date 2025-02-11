namespace Part2;

class Program
{
    public static void print_left_triangle(int baseLength, char character)
    {
        if(character == '\0')
            character = '*';

        for(int i=1; i<baseLength+1; i++)
        {
            for(int j=1; j<i+1; j++)
                Console.Write(character);
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        print_left_triangle(20,'%');
    }
}
