using _61_Records_For_Immutable_Lightweight_Data_Models;

Person p1 = new Person("Alice", 30);

// p1.Age = 31; // This line will cause a compilation error because records are immutable by default. You cannot change the value of Age after the record has been created.

Person p2 = p1 with { Age = 31 }; // This creates a new Person record with the updated Age, while keeping the original record unchanged.

Console.WriteLine("Original Person: " + p1);
Console.WriteLine("Updated Person: " + p2);