using System;
namespace Assign1_601
{
    class Program
    {
        static void Main(String[] args) {
            // Initialize variables
            int amount_601 = 0;
            int balance_601 = 0;
            int pennies_601 = 0;
            int nickels_601 = 0;
            int dimes_601 = 0;
            int quarters_601 = 0;
            // Prompt the user for input
            Console.WriteLine("Enter the cost of an item (less than a dollar): ");
            // Convert the user input to an integer and store it in the amount variable.
            // If the conversion fails, an error message is sent
            if (Int32.TryParse(Console.ReadLine(), out amount_601))
            {
                // Check if the input in in the range between 0 and 99
                if(amount_601 > 99 || amount_601 < 0){
                    //  Print an error message if the input is out of range and return
                    Console.WriteLine("The amount is out of range. Please enter a number between 0 and 99.");
                    return;
                }
                // Calculate the balance from a dollar
                balance_601 = 100 - amount_601;
                // Calculate the maximum number of quarters in the balance
                while (balance_601 / 25 > 0){
                    // If the balance still has some quarters, increment the number of quarters and decrement
                    // the balance
                    quarters_601 += 1;
                    balance_601 -= 25;
                }
                // Calculate the number of dimes in the balance
                while (balance_601 / 10 > 0){
                    // If the balance still has some dimes, increment the number of dimes and decrement
                    // the balance
                    dimes_601 += 1;
                    balance_601 -= 10;
                }
                // Calculate the number of nickels in the balance
                while (balance_601 / 5 > 0){
                    // If the balance still has some nickels, increment the number of nickels and decrement
                    // the balance
                    nickels_601 += 1;
                    balance_601 -= 5;
                }
                // Calculate the number of pennies in the balance
                while (balance_601 / 1 > 0){
                    // If the balance still has some pennies, increment the number of pennies and decrement
                    // the balance
                    pennies_601 += 1;
                    balance_601 -= 1;
                }
                // Display the results to the user
                Console.WriteLine($"The balance of {100 - amount_601} is given as follows:");
                Console.WriteLine($"Quarters: {quarters_601}");
                Console.WriteLine($"Dimes: {dimes_601}");
                Console.WriteLine($"Nickels: {nickels_601}");
                Console.WriteLine($"Pennies: {pennies_601}");        
            }else{
                // If the number enetered is not valid, print an error message
                    Console.WriteLine("The input is not a valid number.");
            }
        }
    }
}