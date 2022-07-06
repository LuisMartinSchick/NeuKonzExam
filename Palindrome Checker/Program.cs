Console.WriteLine("Please input your name:");
string? name = Console.ReadLine();
name = RemoveWhitespace(name);
name = name.ToLower();
string reversedName = Reverse(name);
if (name.Equals(reversedName))
{
    Console.WriteLine("Name is a palindrome");
}
else
{
    Console.WriteLine("Name is not a palindrome");
}


static string? RemoveWhitespace(string? str)
{
    return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
}

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}