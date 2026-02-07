// class BankAccount
// {
//     private int _balance; // The Safe

//     public int Balance // The Teller
//     {
//         // 1. READING (Get)
//         get 
//         { 
//             return _balance; // "Here is your balance, sir."
//         }

//         // 2. WRITING (Set)
//         set 
//         { 
//             // "value" is whatever number the user is trying to put in.
            
//             if (value < 0) 
//             {
//                 // PROTECT THE DATA!
//                 Console.WriteLine("Error: You cannot deposit negative money!");
//             }
//             else 
//             {
//                 // ACCEPT THE DATA
//                 _balance = value; 
//             }
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         BankAccount myAccount = new BankAccount();

//         // Try to set the balance to a negative number (This should be blocked!)
//         myAccount.Balance = -100; // Output: Error: You cannot deposit negative money!

//         // Set the balance to a positive number (This should work!)
//         myAccount.Balance = 500;

//         // Read the balance (This should show 500)
//         Console.WriteLine($"Your balance is: {myAccount.Balance}"); // Output: Your balance is: 500
//     }
// }