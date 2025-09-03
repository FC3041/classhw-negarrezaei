using System.Numerics;


public interface IVector<T> where T: INumber<T>
{
    T Magnitude {get;}
    Vector<T> Add(IVector<T> o);
    T X {get; set;}
    T Y {get; set;}
}

public class AngleVector<T> :
    IEquatable<Vector<int>>,
    IComparable<Vector<int>>
        // where T : INumber<T>
{
    public int X {get; set;}
    public int Y {get; set;}

    public AngleVector(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public double Angle(AngleVector<int> v) => Math.Acos((X*v.X + Y*v.Y)/(Math.Sqrt(X*X + Y*Y) + Math.Sqrt(v.X * v.X + v.Y * v.Y)));

    public int CompareTo(Vector<int> other)
    {
        throw new NotImplementedException();
    }

    public bool Equals(Vector<int> other)
    {
        throw new NotImplementedException();
    }
}


public class Vector<T>: 
    IEquatable<Vector<T>>, 
    IComparable<Vector<T>>,
    IVector<T>
        where T: INumber<T>
{
    public Vector(T x, T y)
    {
        this.X = x;
        this.Y = y;
    }
    public T X {get; set;}
    public T Y {get; set;}

    int IComparable<Vector<T>>.CompareTo(Vector<T> v) =>    
     this.Magnitude.CompareTo(v.Magnitude);

    public T Magnitude => X*X + Y*Y;
    public Vector<T> Add(IVector<T> v) => new Vector<T>(X + v.X, Y + v.Y);
    bool IEquatable<Vector<T>>.Equals(Vector<T> v)
    {
        if (null == v)
            return false;        
        return (v.X == this.X) && (v.Y == this.Y);
    }
    public override bool Equals(object obj)
    {        
        Vector<T> v = obj as Vector<T>;
        if (v != null)
            return Equals(v);
        return false;
    }

    public override int GetHashCode()
    {
        return this.X.GetHashCode() ^ this.Y.GetHashCode();
    }

}