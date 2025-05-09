namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Query 1
        Console.WriteLine("Query 1");
        
        var lines = File.ReadAllLines("data.csv")
                .Where(l => l.Contains("at birth"))
                .Where(l => l.Contains("Both"))
                .Where(l => l.ToLower().Contains("iran"))
                .Select(l => Data.Parse(l))
                .OrderBy(i => i.Value)
                .ToList();

            lines.ForEach(l => Console.WriteLine(l));
                

        Console.WriteLine();


        //Query 2
        Console.WriteLine("Query 2");
        //

        System.Console.WriteLine(lines[lines.Count - 1].Value - lines[0].Value);     
        //
        Console.WriteLine();


        //Query 3
        Console.WriteLine("Query 3");
        //
        var list = File.ReadAllLines("data.csv")
                        .Where(l => l.Contains("at birth"))
                        .Where(l => l.Contains("Both"))
                        .Select(l => Data.Parse(l))
                        .GroupBy(l => l.Country)
                        .Select(l =>
                        {
                            var MaxValue = l.MaxBy(v => v.Value);
                            var MinValue = l.MinBy(v => v.Value);
                            return (Country: l.Key, Year: MinValue.Year, MinValue: MinValue.Value, diff: MaxValue.Value - MinValue.Value);
                        })
                        .OrderBy(i => i.diff)
                        .Reverse()
                        .ToList();

            int x = 0;
            list.ForEach(l => 
            {
                x++;
                System.Console.WriteLine($"{x} {l}");
            });
            
        //
        Console.WriteLine();


        //Query 4
        Console.WriteLine("Query 4");
        //
        var data = File.ReadAllLines("data.csv")
                        .Where(l => l.Contains("at birth"))
                        .Select(l => Data.Parse(l));

        var list2 = data.Join(data,
                        (d1) => (d1.Country, d1.Year, d1.DataGender == DataGender.Female),
                        (d2) => (d2.Country, d2.Year, d2.DataGender == DataGender.Male),
                        (d1,d2) => (country: d1.Country, year: d1.Year, MValue: d2.Value, FValue: d1.Value, diff: Math.Abs(d2.Value - d1.Value))
                    )
                    .GroupBy(d => d.country)
                    .Select(d =>
                    {
                        var MaxDiff = d.MaxBy(x => x.diff);
                        return (country: d.Key, year: MaxDiff.year, MValue: MaxDiff.MValue, FValue: MaxDiff.FValue, diff: MaxDiff.diff);
                    })
                    .OrderBy(x => x.diff)
                    .Reverse()
                    .ToList();

        int y = 0;
        list2.ForEach(d =>
        {
            y++;
            System.Console.WriteLine($"{y} {d}");
        });
        //
        Console.WriteLine();

    }
}
