namespace HW;

class Program
{
    static void Main(string[] args)
    {
        IVehicle[] vehicles = new IVehicle[]
        {
            new Motorcycle(2,3,2),
            new Bicycle(1,2,1),
            new Bus(5,10,24)
        };

        double Area_Sum = 0;
        int Capacity_Sum = 0;
        foreach (var item in vehicles)
        {
            Area_Sum += item.Area();
            Capacity_Sum += item.Capacity();
        }
        System.Console.WriteLine($"Area_Sum: {Area_Sum}, Capacity_Sum: {Capacity_Sum}");
    }
}
