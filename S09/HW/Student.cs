public class Student
{
    public string? FirstName;
    public string? LastName;
    public int stdid;
    public int natid;
    public int credits;

    public Student(string fname, string lname, int stdid, int natid, int credits)
    {
        this.FirstName = fname;
        this.LastName = lname;
        this.stdid = stdid;
        this.natid = natid;
        this.credits = credits;
    }

    public override string ToString()
    {
        return $"{FirstName},{LastName},{stdid},{natid},{credits}";
    }
}