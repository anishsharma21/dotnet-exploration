namespace csharp_console_v2;

// ReSharper disable once ClassNeverInstantiated.Global
class Program
{
    static async Task Main(string[] args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }
        
        Console.WriteLine(StartsWithUpper("Hello"));
        Console.WriteLine(StartsWithUpper("hello"));
        double returnedNum = await ReturnNumber(5);
        Console.WriteLine(returnedNum);
    }

    private static bool StartsWithUpper(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;
        char ch = str[0];
        return char.IsUpper(ch);
    }

    private static async Task<double> ReturnNumber(int numerator)
    {
        const int divisor = 4;
        await Task.Delay(2000);
        return (double)numerator / divisor;
    }

}
