using System;
namespace Part5;

class Program
{
    static string print_month(int monthNumber)
    {
        string month = "";
        if(monthNumber == 1)
            month = "January";

        else if (monthNumber == 2)
            month = "February";

        else if (monthNumber == 3)
            month = "March";
        
        else if (monthNumber == 4)
            month = "April";
        
        else if (monthNumber == 5)
            month = "May";
        
        else if (monthNumber == 6)
            month = "June";
        
        else if (monthNumber == 7)
            month = "July";
        
        else if (monthNumber == 8)
            month = "August";
        
        else if (monthNumber == 9)
            month = "September";
        
        else if (monthNumber == 10)
            month = "October";
        
        else if (monthNumber == 11)
            month = "November";
        
        else if (monthNumber == 12)
            month = "December";
        
        
        return month;
    }

    static void Main(string[] args)
    {
        for(int i=1; i<13; i++)
        {
            Console.Write(i + " ");
            Console.WriteLine(print_month(i));
        }
    }
}
