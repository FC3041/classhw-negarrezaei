using System;
namespace Part1;

class Program
{
    public static bool is_leap_year(int year)
    {
        if((year % 400 == 0) || ((year % 4 == 0)&&(year % 100 != 0)))
            return true;
        
        else
            return false; 
    }

    static void Main(string[] args)
    {
        int[] years = [1792,1796,1800,1804,1900,1904,2000,2004];
        int count = 8;
        for(int i=0; i<count; i++)
        {
            if(is_leap_year(years[i]))
                Console.WriteLine(years[i] + "  True");
            else
                Console.WriteLine(years[i] + "  False");
        }
    }
}
