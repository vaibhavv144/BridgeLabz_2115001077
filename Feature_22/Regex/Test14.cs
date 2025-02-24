using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Test14
{
static void FindRepeatingWord(string text)
{
string pattern = @"\b(\w+)\s+\1\b"; // Regexto match consecutive repeated words
MatchCollection matches = Regex.Matches(text,
pattern, RegexOptions.IgnoreCase);
foreach (Match match in matches)
{
Console.WriteLine(match.Groups[1].Value);
// Print only the repeated word
}
} 
public static void Print()
{
string input = "This is is a repeated repeated word test.";
Console.WriteLine("Repeating Words:");
FindRepeatingWord(input);
}
}

