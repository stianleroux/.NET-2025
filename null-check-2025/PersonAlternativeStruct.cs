namespace NullCheck;

//no heap allocations
public record struct PersonAlternativeStruct(string Name, string Surname, int? Age);