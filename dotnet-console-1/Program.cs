namespace csharp_console_v2;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine(StartsWithUpper("Hello"));
        Console.WriteLine(StartsWithUpper("hello"));
        double returnedNum = await ReturnNumber(5);
        Console.WriteLine(returnedNum);
    }

    static bool StartsWithUpper(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;
        char ch = str[0];
        return char.IsUpper(ch);
    }

    static async Task<double> ReturnNumber(int numerator)
    {
        int divisor = 4;
        await Task.Delay(2000);
        return (double)numerator / divisor;
    }

}
