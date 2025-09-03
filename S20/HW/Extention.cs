using System.Text;

public static class EXT
{
    public static string Encoder(this string str)
    {
        StringBuilder Str = new StringBuilder(str);

        for (int i=0; i<Str.Length; i++)
        {
            int AsciiNumber = (int) str[i];

            if((AsciiNumber >= (int)'A' && AsciiNumber <= (int)'W')
                || (AsciiNumber >= (int)'a' && AsciiNumber <= (int)'w'))
                Str[i] = (char)(AsciiNumber + 3);

            else if(AsciiNumber == (int)'X' || AsciiNumber == (int)'Y' || AsciiNumber == (int)'Z'
                    || AsciiNumber == (int)'x' || AsciiNumber == (int)'y' || AsciiNumber == (int)'z')
                Str[i] = (char)(AsciiNumber - 23);
        }
        return Str.ToString();
    }

    public static string Decoder(this string str)
    {
        StringBuilder Str = new StringBuilder(str);

        for (int i=0; i<Str.Length; i++)
        {
            int AsciiNumber = (int) str[i];

            if((AsciiNumber >= (int)'D' && AsciiNumber <= (int)'Z')
                || (AsciiNumber >= (int)'d' && AsciiNumber <= (int)'z'))
                Str[i] = (char)(AsciiNumber - 3);

            else if(AsciiNumber == (int)'A' || AsciiNumber == (int)'B' || AsciiNumber == (int)'C'
                    || AsciiNumber == (int)'a' || AsciiNumber == (int)'b' || AsciiNumber == (int)'c')
                Str[i] = (char)(AsciiNumber + 23);
        }
        return Str.ToString();
    }
}