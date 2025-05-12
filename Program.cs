using System;

namespace Shipping_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            // Prompt for package weight
            Console.WriteLine("Please enter the package weight:");
            string? weightInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(weightInput) || !int.TryParse(weightInput, out int weight))
            {
                // Handle invalid input
                Console.WriteLine("Invalid input for weight. Exiting.");
                return;
            }

            // Check if weight is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Prompt for package width
            Console.WriteLine("Please enter the package width:");
            string? widthInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(widthInput) || !int.TryParse(widthInput, out int width))
            {
                Console.WriteLine("Invalid input for width. Exiting.");
                return;
            }

            // Prompt for package height
            Console.WriteLine("Please enter the package height:");
            string? heightInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(heightInput) || !int.TryParse(heightInput, out int height))
            {
                Console.WriteLine("Invalid input for height. Exiting.");
                return;
            }

            // Prompt for package length
            Console.WriteLine("Please enter the package length:");
            string? lengthInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(lengthInput) || !int.TryParse(lengthInput, out int length))
            {
                Console.WriteLine("Invalid input for length. Exiting.");
                return;
            }

            // Check if total dimensions are too large
            int totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too large to be shipped via Package Express.");
                return;
            }

            // Calculate the quote
            decimal quote = (width * height * length * weight) / 100m;

            // Display the quote as a dollar amount
            Console.WriteLine($"\nYour estimated total for shipping this package is: ${quote:F2}\n");
            Console.WriteLine("Thank you!");
        }
    }
}
