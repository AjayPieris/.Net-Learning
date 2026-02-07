/* While Loops 
int counter = 1; // 1. The Starting Point

while (counter <= 5) // 2. The Condition (Keep going while this is true)
{
    Console.WriteLine($"Number: {counter}"); // 3. The Action
    
    counter = counter + 1; // 4. The Step (Moving forward)
}

Console.WriteLine("Finished!");

string password = ""; // Start empty

// While the password is NOT "secret123"... keep asking!
while (password != "secret123")
{
    Console.Write("Enter the password: ");
    password = Console.ReadLine(); // Update the variable
    
    if (password != "secret123")
    {
         Console.WriteLine("Wrong! Try again.");
    }
}

Console.WriteLine("Access Granted!");
*/

/* Array 
// 1. Create the Array (The Carton)
string[] students = new string[3];

// 2. Fill the slots
students[0] = "John";
students[1] = "Sarah";
students[2] = "Mike";

// 3. Read from a slot
Console.WriteLine(students[2]);

string[] friends = { "Bob", "Alice", "Joe" }; // A shortcut to fill the array quickly

// Loop from 0 to 2
for (int i = 0; i < friends.Length; i++) 
{
    Console.WriteLine($"Hello, {friends[i]}!");
}
*/

