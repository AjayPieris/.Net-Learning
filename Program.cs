// Step 1: Ask for the name
Console.WriteLine("Hello! What is your name?");
string name = Console.ReadLine();

// Step 2: Ask for the age
Console.WriteLine($"Hi {name}, how old are you?");
string ageText = Console.ReadLine(); // We catch the text first

// Step 3: The Translator (Text -> Number)
int age = Convert.ToInt32(ageText);

// Step 4: The Logic (If Statement)
if (age >= 16)
{
    Console.WriteLine("You are old enough to drive a car!");
}
else
{
    // Let's do some math to see how many years are left
    int yearsLeft = 16 - age;
    Console.WriteLine($"Sorry, you have to wait {yearsLeft} more years.");
}