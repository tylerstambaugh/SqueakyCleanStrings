using System;
using System.Text;



Console.WriteLine(Identifier.Clean("😀😀😀"));
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder(identifier);
        sb.Replace(' ', '_');
        string cleanControlChar = sb.ToString();
        StringBuilder rs = new StringBuilder();

        for (int i = 0; i < sb.Length; i++)
        {
            //Console.WriteLine((short)char.Parse(cleanControlChar.Substring(i, 1)));

            if (char.IsControl(sb[i]))
            {
                rs.Append("CTRL");
            }
            else if (sb[i] == '-')
            {
                rs.Append(sb[i + 1].ToString().ToUpper());
                i++;
            }
            else if (!(((short)(sb[i]) >= 945) && ((short)(sb[i]) <= 970)) 
                && (Char.IsLetter(sb[i]) || sb[i].ToString() == "_"))
            {
                rs.Append(sb[i]);
            }
        }
        return rs.ToString();
    }

    public static string ReplaceControlCharacters(string stringToClean)
    {
        StringBuilder sb = new StringBuilder(stringToClean);
        StringBuilder returnString = new StringBuilder();

        return returnString.ToString();


        
    }

    public static string ConvertKebabCaseToCamelCase(string stringToConvert)
    {
        StringBuilder sb = new StringBuilder(stringToConvert);

        StringBuilder returnString = new StringBuilder();

        return returnString.ToString();
    }
}
