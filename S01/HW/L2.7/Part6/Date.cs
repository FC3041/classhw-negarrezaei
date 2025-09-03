using System;
namespace Part6;

class Program
{
    public static int days_in_month(int monthNumber)
    {
        int number_of_days = 0;

        if(monthNumber == 1)
            number_of_days = 31;
        
        else if (monthNumber == 2)
            number_of_days = 28;
        
        else if (monthNumber == 3)
            number_of_days = 31;
        
        else if (monthNumber == 4)
            number_of_days = 30;
        
        else if (monthNumber == 5)
            number_of_days = 31;
        
        else if (monthNumber == 6)
            number_of_days = 30;
        
        else if (monthNumber == 7)
            number_of_days = 31;
        
        else if (monthNumber == 8)
            number_of_days = 31;
        
        else if (monthNumber == 9)
            number_of_days = 30;
        
        else if (monthNumber == 10)
            number_of_days = 31;
        
        else if (monthNumber == 11)
            number_of_days = 30;
        
        else if (monthNumber == 12)
            number_of_days = 31;
        

        return number_of_days;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(days_in_month(12));
    }
}
