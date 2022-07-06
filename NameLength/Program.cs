Console.WriteLine("Please input your name:");
var name = Console.ReadLine();
name = RemoveWhitespace(name);
Console.WriteLine(name.Length);

static string RemoveWhitespace(string str)
{
    return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
}