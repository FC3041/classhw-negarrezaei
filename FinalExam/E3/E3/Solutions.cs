using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace E3;
 //Q0
public class Animal
{
    public virtual string MakeSound() => "Some generic animal sound";
}
public class Dog : Animal
{
    public override string MakeSound() => "Woof";
}

//Q1
public class MyPointType1
{
    public int X;
    public int Y;
}
public struct MyPointType2
{
    public int X;
    public int Y;
}

///
public class Comparer<T> : IComparable<T>
{
    public T A;
    public T B;
    public Comparer(T a, T b)
    {
        this.A = a;
        this.B = b;
    }

    // public T GetLarger()
    // {
            
    // }

    public int CompareTo(T? other)
    {
        if (other is null)
            return 1;
        return this.CompareTo(other);
    }
}
public class Product
{
    public string Name;
    public int Price;
}

//Q3
public class ResourceManager : IDisposable
{
    public bool IsDisposed;
    public ResourceManager()
    {
        IsDisposed = false;
    }
    public void Dispose()
    {
        // throw new NotImplementedException();
        IsDisposed = true;
    }
}

//Q4
public class LinqProblems
{
    public static IEnumerable<int> FilterAndDouble(List<int> numbers)
    {
        var result =
            numbers.Where(x => (x > 5) && (x % 2 == 0))
                    .Select(x => x * 2);
        return result;
    }

    // public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> sales)
    // {
    //     return sales.GroupBy(x => x.Category)
    //                 // .ToDictionary(x => ( x.Key,  x.Select(l => l.Amount).Sum))
    //                 // .Select(x => (key: x.Key, amount: x.Select(l => l.Amount).Sum))
    // }
}

public class Sale
{
    public string Category;
    public int Amount;
}

//Q6
public class Money : IEquatable<Money>
{
    public int Amount;
    public string Y;
    public Money(int a, string b)
    {
        this.Amount = a;
        this.Y = b;
    }

    public bool Equals(Money other)
    {
        return this.Amount.Equals(other.Amount) && this.Y.Equals(other.Y);
    }

    public static Money operator +(Money m1, Money m2) => new Money(m1.Amount + m2.Amount, m1.Y);
    public static bool operator ==(Money m1, Money m2) => m1.Equals(m2);
    public static bool operator !=(Money m1, Money m2) => !(m1 == m2);

}

//Q7
public class DelegateProblems
{
    public delegate T func<T>(T a);
    public static T ProcessString<T>(T input, func<T> myfunc)
    {
        return myfunc(input);
    }

    public static string ToUpper(string x) => x.ToUpper();
    public static string ToLower(string x) => x.ToLower();
}

//Q8
public class LambdaProblems
{
    public static Func<string, int> GetStringLengthCalculator()
       => (string x) => x.Length;

}


///
public class Publisher
{

}
public class Subscriber
{
    public Publisher publisher;
    public Subscriber(Publisher p)
    {
        this.publisher = p;
    }
}

// public class Closures
// {



//     public static Func<int> CreateCounter()
//     {
//         return ;
//     }


// }


//Q12
public class SafeCounter
{
    public object obj = new object();
    public int Count;
    public int Increment()
    {
        lock (obj)
        {
            Count++;
        }
        return Count;
    }
}

//Q13
public class DataService
{
    public async Task<string> FetchDataAsync(string s)
    {
        int number = 10_000_000;
        Task t = Task.Delay(number);
        // t.Wait();
        return $"Data for {s}";
    }
}