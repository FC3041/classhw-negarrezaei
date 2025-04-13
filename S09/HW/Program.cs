namespace HW;

class Program
{
    public static void Register(string[] x)
    {
        Student s = new Student(
            x[1],
            x[2],
            int.Parse(x[3]),
            int.Parse(x[4]),
            int.Parse(x[5]));
        
        File.AppendAllLines("Register_Students.csv",new string[]{s.ToString()});

    }
    public static void Print_List()
    {
        string[] lines =  File.ReadAllLines("Register_Students.csv");
        foreach(var line in lines)
            Console.WriteLine(line);

    }


    static void Main(string[] args)
    {
        if(args[0] == "register")
            Register(args);
        if(args[0] == "list")
            Print_List();
    }
}
