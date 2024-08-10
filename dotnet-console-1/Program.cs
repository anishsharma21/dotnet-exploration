namespace csharp_console_v2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(StartsWithUpper("Hello"));
        Console.WriteLine(StartsWithUpper("hello"));
    }

    static bool StartsWithUpper(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;
        char ch = str[0];
        return char.IsUpper(ch);
    }
}
