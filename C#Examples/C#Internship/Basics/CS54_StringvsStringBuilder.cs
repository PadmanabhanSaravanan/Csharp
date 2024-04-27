using System;
using System.Text;

class CS54_StringvsStringBuilder
{
    void Main()
    {
        // Using System.String
        string result = "";
        for (int i = 0; i < 10000; i++)
        {
            result += "value" + i.ToString() + " ";
        }
        Console.WriteLine("Using System.String:");
        Console.WriteLine("Concatenated string length: " + result.Length);

        // Using System.Text.StringBuilder
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append("value");
            sb.Append(i.ToString());
            sb.Append(" ");
        }
        string sbResult = sb.ToString();
        Console.WriteLine("Using System.Text.StringBuilder:");
        Console.WriteLine("Concatenated string length: " + sbResult.Length);
    }
}