namespace NullCheck;

public sealed class PersonOld
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int? Age { get; set; }

    public PersonOld(string name)
        => this.Name = name;

    public PersonOld(string name, string surname)
        => (this.Name, this.Surname) = (name, surname);
}