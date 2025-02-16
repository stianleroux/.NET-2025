using NullCheck;

var wrongPerson = new PersonWrong()
{
    Name = "John",
    Surname = null
};

Console.WriteLine();

//!= is equality operator overloading
//Expressiveness: != is a common operator, but it doesn't clearly communicate the intent to check if something is null.
if (wrongPerson.Surname != null)
{
    Console.WriteLine("Surname is null");
}
//is null is a pattern matching
//Expressiveness: is null clearly communicates the intent to check if something is null.
//Performance: Potentially faster when custom != operator overloading is involved.
//Safety: Avoids potential bugs when the != operator is overloaded to return true for null values.
//Modern C# 9.0 syntax: is null is a new pattern matching feature in C# 9.0.
if (wrongPerson.Surname is null)
{
    Console.WriteLine("Surname is null");
}

//No way to make sure that the Name property is set corrctly
Console.WriteLine(new PersonOld("John", "Doe"));
Console.WriteLine(new PersonOld("Doe", "John"));

Console.WriteLine(new PersonNew()
{
    Name = "John",
    Surname = null
});

Console.WriteLine(new PersonAlternative("John", "Doe", 25));
Console.WriteLine(new PersonAlternative("Doe", "John", 25));

//Better readability, avoid making mistakes
Console.WriteLine(new PersonAlternative(Name: "Doe", Surname: "John", Age: 25));

//no heap allocations
Console.WriteLine(new PersonAlternativeStruct(Name: "Doe", Surname: "John", Age: 25));

/*
Memory Allocation	    Stack (faster)	                Heap (slower)                   Heap (slower)
Copy Behavior	        By value (copies object)	    By reference (shared object)	By reference (shared object)
Immutability	        readonly for safety	            Supports with expressions	    Mutable by default
Inheritance	            ❌ No	                        ✅ Yes	                        ✅ Limited (no subclassing)
Polymorphism	        ❌ No	                        ✅ Yes	                        ✅ Yes (but sealed)
Nullability	            ❌ No (needs Nullable<T>)	    ✅ Yes	                        ✅ Yes
Performance (Small Data)✅ Best for <16 bytes	        ❌ More overhead	            ❌ More overhead
Serialization	        ⚠️ Limited (manual handling)    ✅ Easier	                    ✅ Easier

Struct	        ✅ For small, immutable data (<16 bytes) where performance matters (e.g., Point, Color).
Class	        ✅ For complex objects with inheritance or large sizes that need reference semantics.
Sealed Class	✅ When you want to prevent inheritance and gain faster execution with optimized method calls.
Record	        ✅ For immutable reference types that require value equality and ease of copying via with.
Sealed Record	✅ When you need a finalized, immutable data type with better performance and no extensibility.

✅ Sealed classes perform better than regular classes due to devirtualization—the compiler optimizes method calls by skipping virtual dispatch

Use records when you want data that cannot change (immutable) and you need value equality (where two objects with the same data are considered equal).
Use sealed classes for everything else, especially when you want to prevent other classes from inheriting and improve performance. Also Composition Over Inheritance
*/
