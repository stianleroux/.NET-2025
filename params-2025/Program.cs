namespace Params;

public class Program
{
    public static void OldPrintNumbers(params int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public static void PrintNumbers(params List<int> numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    // Usage
    public static void Main(string[] args)
        => PrintNumbers([1, 2, 3, 4, 5]);
}

/*
Old version: You had to use int[] (an array) with params.
New version (C# 13+): You can directly pass a List<int> using params.
*/ 