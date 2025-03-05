// Express Shipping Rate Calculator
// Author: David Kim
// Last Updated: March 2024
using System;

namespace PackageDelivery
{
    class RateCalculator
    {
        static void Main(string[] args)
        {
            // Print welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            try
            {
                // Get weight input from user with validation
                Console.WriteLine("Please enter the package weight:");
                if (!double.TryParse(Console.ReadLine(), out double weightInput))
                {
                    Console.WriteLine("Invalid weight input. Please enter a numeric value.");
                    return;
                }

                // Check weight restrictions
                if (weightInput > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    return;
                }

                // Get package measurements with validation
                Console.WriteLine("Please enter the package width:");
                if (!double.TryParse(Console.ReadLine(), out double widthInput))
                {
                    Console.WriteLine("Invalid width input. Please enter a numeric value.");
                    return;
                }

                Console.WriteLine("Please enter the package height:");
                if (!double.TryParse(Console.ReadLine(), out double heightInput))
                {
                    Console.WriteLine("Invalid height input. Please enter a numeric value.");
                    return;
                }

                Console.WriteLine("Please enter the package length:");
                if (!double.TryParse(Console.ReadLine(), out double lengthInput))
                {
                    Console.WriteLine("Invalid length input. Please enter a numeric value.");
                    return;
                }

                // Calculate total dimensions
                double sizeTotal = widthInput + heightInput + lengthInput;

                // Verify size limits
                if (sizeTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return;
                }

                // Calculate shipping price
                // Price = (width * height * length * weight) / 100
                double shippingPrice = (widthInput * heightInput * lengthInput * weightInput) / 100;

                // Show shipping cost to user
                Console.WriteLine($"Your estimated total for shipping this package is: ${shippingPrice:F2}");
                Console.WriteLine("Thank you!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
} 