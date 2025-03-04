using System.Diagnostics.Metrics;
using System.Diagnostics;

// Welcome message for the VAT calculation program.
Console.WriteLine("Hello, Welcome to VAT included Amount Calculation!");
Thread.Sleep(2000); // Wait for 2 seconds.

// Ask the user to enter the product price.
Console.WriteLine("Enter the product price!");
string infoPrice = Console.ReadLine(); // Read the price input as a string.
double price = double.Parse(infoPrice); // Convert the price to a double.

// Ask the user to enter the VAT amount.
Console.WriteLine("Enter VAT amount!");
string infoVat = Console.ReadLine(); // Read the VAT input as a string.
double VAT = double.Parse(infoVat); // Convert the VAT to a double.

// Confirm that the inputs have been received.
Console.WriteLine("VAT and price information received! (The number you enter will be calculated as %)");
Thread.Sleep(2000); // Wait for 2 seconds.

// Calculate the total price including VAT.
double infoConclusion = price * VAT / 100; // VAT calculation formula.
Console.WriteLine("Your price including VAT: " + infoConclusion); // Display the result.