using System;
namespace Part6;

class Program
{
    public static void compute_change(int cents)
    {
        cents = 100 - cents;
        int quarters = cents / 25;
        cents %= 25;
        Console.WriteLine(quarters + " quarters");

        int dime = cents / 10;
        cents %= 10;
        Console.WriteLine(dime + " dime");

        int nickel = cents / 5;
        cents %= 5;
        Console.WriteLine(nickel + " nickel");

        int pennies = cents;
        Console.WriteLine(pennies + " pennies");
    }

    static void Main(string[] args)
    {
        compute_change(8);
    }
}
