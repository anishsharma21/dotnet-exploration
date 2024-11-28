using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

const int age = 25;

Console.WriteLine(age);

int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
Console.WriteLine(numbers[1]);

List<string> fruits = ["apple", "orange", "grape"];

foreach (var fruit in fruits)
{
    Console.WriteLine($"Fruit: {fruit}");
}

GreetUser("John", 4);
GetInput();
return;

void GreetUser(string name, int age)
{
    Console.WriteLine($"{name} is {age} years old!");
}

void GetInput()
{
    Console.Write("Number: ");
    var line = Console.ReadLine();
    Console.WriteLine($"Users value: {line}");
}