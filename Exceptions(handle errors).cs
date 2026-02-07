// Format Errors: If the user types "ABC" instead of a number.

// Math Errors: If the user tries to divide by zero.

// Unexpected Errors: Any other crash.

// Cleanup: It always runs the cleanup code at the end.


// Scenario 1: The Happy Path (Success)

// Input 1: 10

// Input 2: 2

// Result: It prints SUCCESS: 10 / 2 = 5 and then --- Calculation attempt finished ---.

// Scenario 2: The Math Error (Divide by Zero)

// Input 1: 10

// Input 2: 0

// Result: It jumps to the catch (DivideByZeroException) block.

// It prints: ERROR: You cannot divide by zero!

// It DOES NOT CRASH. The program stays alive and asks for the next number.

// Scenario 3: The Format Error (Invalid Input)

// Input 1: 10

// Input 2: Hello

// Result: It jumps to the catch (FormatException) block.

// It prints: ERROR: Please enter valid numbers only.

// Scenario 4: The Unexpected Error (Any Other Crash)

// Input 1: 10

// Input 2: (Imagine something really weird happens here, like a power surge)

// Result: It jumps to the catch (Exception) block, which is a catch-all for any errors we didn't specifically handle.

// It prints: An unexpected error occurred: (followed by the error message).


// using System;
// class Program  
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter the first number: ");
//         string input1 = Console.ReadLine();

//         Console.Write("Enter the second number: ");
//         string input2 = Console.ReadLine();

//         try
//         {
//             int num1 = int.Parse(input1);
//             int num2 = int.Parse(input2);

//             int result = num1 / num2;
//             Console.WriteLine($"SUCCESS: {num1} / {num2} = {result}");
//         }
//         catch (DivideByZeroException)
//         {
//             Console.WriteLine("ERROR: You cannot divide by zero!");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("ERROR: Please enter valid numbers only.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An unexpected error occurred: {ex.Message}");
//         }
//         finally
//         {
//             Console.WriteLine("--- Calculation attempt finished ---");
//         }
//     }
// }