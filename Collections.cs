using System;
using System.Collections.Generic; // Needed for List<T>
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list to store guests
        List<string> guests = new List<string>();

        // Add guests
        guests.Add("Alice");
        guests.Add("Bob");
        guests.Add("Charlie");
        guests.Add("Diana");

        Console.WriteLine("Party Guest List:");
        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }

        // Show how many guests
        Console.WriteLine("\nTotal guests: " + guests.Count);

        // Remove a guest
        Console.WriteLine("\nOops! Bob can't come.");
        guests.Remove("Bob");

        // Show updated list
        Console.WriteLine("\nUpdated Party Guest List:");
        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }

        // Show updated count
        Console.WriteLine("\nTotal guests now: " + guests.Count);

        // Insert a new guest at a specific position
        Console.WriteLine("\nAdding Eve at the beginning.");
        guests.Insert(0, "Eve");

        Console.WriteLine("\nFinal Party Guest List:");
        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }

        // 1. Create the Dictionary
// Key = string (Name), Value = string (Phone Number)
Dictionary<string, string> phonebook = new Dictionary<string, string>();

// 2. Add items
phonebook.Add("Ajay", "123456");
phonebook.Add("Mom", "123457");

// 3. Look up a value (Lightning Fast!)
// We ask for "Mom", it gives us the number.
string momsNumber = phonebook["Mom"]; 
Console.WriteLine($"Mom's Number is: {momsNumber}");

// 4. Safety Check (Very Important)
// If you ask for "Dad" but he isn't in the list, the program crashes!
if (phonebook.ContainsKey("Dad"))
{
    Console.WriteLine(phonebook["Dad"]);
}
else
{
    Console.WriteLine("Dad is not in the phonebook.");
}

 List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // THE LINQ MAGIC
        // Read this as: "Go through 'numbers'. For each 'n', keep it WHERE n modulo 2 equals 0."
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Even Numbers:");
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        
    }
}

