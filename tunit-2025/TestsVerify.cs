﻿namespace TUnit;

public class TestsVerif
{
    [Test]
    [MethodDataSource(nameof(DataSource))]
    public Task MethodDataSource(int a, int b, int c)
    {
        Console.WriteLine("This one can accept arguments from a method");

        var result = a + b;

        return Verify(result);
    }

    public static IEnumerable<(int a, int b, int c)> DataSource()
    {
        yield return (1, 1, 2);
        yield return (2, 1, 3);
        yield return (3, 1, 4);
    }
}