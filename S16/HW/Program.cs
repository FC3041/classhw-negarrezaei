namespace HW;

class Program
{
    static void print_citizen(Citizen[] cs)
    {
        foreach(var c in cs)
            Console.WriteLine(c.ToString());
    }
    static void Main(string[] args)
    {
        Citizen k = new Citizen("Kane", "Dave", 1, true);
        Student s = new Student(
            "Zari", "Hedayati", 2, "Math", 403521, false);
        GradStudent gs = new GradStudent(
            "Pari", "Hedayati", 2, "Math", 403521, false,
            "Calculus", "Integral");

        Teacher t = new Teacher(
            "Mari", "Hedayati", 2, false, 20000000, 18, 494830
        );
        Citizen[] citizens = new Citizen[]{k, s, gs,t};
        print_citizen(citizens);


    }
}
