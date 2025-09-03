using System;
namespace Part7;

class Program
{
    public static bool is_leap_year(int year)
    {
        if((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))){
            return true;
        }
        return false;
    }
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

    public static int days_in_month_part7(int year , int monthnumber)
    {
        if(is_leap_year(year)){
            if(monthnumber == 2){
                int number_of_days = 29;
                return number_of_days;
            }
        }
    return days_in_month(monthnumber);
    }


    static void Main(string[] args)
    {
        Console.WriteLine(days_in_month_part7(2000,2));
        Console.WriteLine(days_in_month_part7(2002,10));
    }
}
