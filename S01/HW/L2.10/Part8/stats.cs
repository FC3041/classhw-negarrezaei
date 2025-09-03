using System;
namespace Part8;

class Program
{
    public static float The_average(float[] n, int count)
    {
        float sum = 0;
        for(int i=0; i<count; i++)
            sum += n[i];
        
        return sum/count;
    }

    public static float The_minimum(float[] n, int count)
    {
        float min = n[0];
        for(int i=1; i<count; i++)
        {
            if(n[i] <= min)
                min = n[i];
        }
        return min;
    }

    public static float The_maximum(float[] n, int count)
    {
        float max = n[0];
        for(int i=1; i<count; i++)
        {
            if(n[i] >= max)
                max = n[i];
        }
        return max;
    }

    static void Main(string[] args)
    {
        bool x = true;
        float[] number = new float[30];
        int i=0;
        while(x == true)
        {
            Console.Write("");
            string n = Console.ReadLine();

            if(float.TryParse(n , out float num))
            {
                if(num == -1.0f)
                    x = false;

                else
                {
                    number[i] = num;
                    i++;
                }
            }
        }
        int The_number_of_entries = i;
        
        Console.WriteLine("The number of entries: " + The_number_of_entries);
    
        Console.WriteLine("The average: " + The_average(number,The_number_of_entries));
        Console.WriteLine("The minimum: " + The_minimum(number,The_number_of_entries));
        Console.WriteLine("The maximum: " + The_maximum(number,The_number_of_entries));
    }
}
