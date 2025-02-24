using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal class Test10
{
static bool IsValidIPv4(string ipAddress)
{
string pattern =
@"\b((25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\b";
return Regex.IsMatch(ipAddress, pattern);
} 
public static void Print()
{
string[] testIPs = { "192.168.1.1",
"255.255.255.255", "256.100.50.25", "192.168.1",
"10.0.300.1" };
foreach (string ip in testIPs)
{
Console.WriteLine($"{ip}:{(IsValidIPv4(ip) ? "Valid" : "Invalid")}");
}
}
}


