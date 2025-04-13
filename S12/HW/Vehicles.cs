public interface IVehicle
{
    public int Capacity();
    public double Area();
}

class Motorcycle: IVehicle
{
    public double L;
    public double W;
    public int Capacity;
    public Motorcycle(double l, double w, int capacity)
    {
        this.L = l;
        this.W = w;
        this.Capacity = capacity;
    }

    public double Area()
    {
        return L*W;
    }

    int IVehicle.Capacity()
    {
        return this.Capacity;
    }
}

class Bicycle: IVehicle
{
    public double L;
    public double W;
    public int Capacity;
    public Bicycle(double l, double w, int capacity)
    {
        this.L = l;
        this.W = w;
        this.Capacity = capacity;
    }

    public double Area()
    {
        return L*W;
    }

    int IVehicle.Capacity()
    {
        return this.Capacity;
    }
}

class Bus: IVehicle
{
    public double L;
    public double W;
    public int Capacity;
    public Bus(double l, double w, int capacity)
    {
        this.L = l;
        this.W = w;
        this.Capacity = capacity;
    }

    public double Area()
    {
        return L*W;
    }

    int IVehicle.Capacity()
    {
        return this.Capacity;
    }
}
