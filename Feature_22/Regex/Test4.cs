using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Test4
{
static void ExtractEmails(string text)
{
string pattern =
@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";
MatchCollection matches = Regex.Matches(text,
pattern);
foreach (Match match in matches)
{
Console.WriteLine(match.Value);
}
}
public static void Print()
{
string sampleText = "Contact us atsupport@example.com and info@company.org for more details.";
ExtractEmails(sampleText);
}
}

