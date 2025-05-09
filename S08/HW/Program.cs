namespace HW;

class Program
{

    public static void reverse1(string s, out string str)
    {
        str = "";
        foreach (char c in s)
        {
            str = c + str;
        }
    }

    public static void reverse2(string s, out string str)
    {
        str = "";
        string word = "";
        foreach (char c in s)
        {
            if(c != ' ')
                word = word + c;

            else
            {
                str = " " + word + str;
                word = "";
            }    
        }
        if(! string.IsNullOrEmpty(word))
            str = word + str;
    }

    static void Main(string[] args)
    {
        string s = "Hello World  like  class";
        string str1;
        reverse1(s, out str1);
        System.Console.WriteLine($"'{str1}'");

        string str2;
        reverse2(s, out str2);
        System.Console.WriteLine($"'{str2}'");
    }
}
