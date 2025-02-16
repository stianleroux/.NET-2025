string[] data = ["John", "Jane"];
string[] allData = [.. data, .. data, "Charlie"];

Console.WriteLine(string.Join(", ", allData));