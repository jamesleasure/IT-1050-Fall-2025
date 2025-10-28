using System;

namespace Lesson2Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample Code from our Lesson 2 Class Meeting\n");

            // Define and assign values for pi
            int intPi = 22 / 7;
            float floatPi = 22f / 7f;
            double doublePi = 22.0 / 7.0;
            decimal decimalPi = 22m / 7m;

            // Output using string concatenation
            Console.WriteLine("int: " + intPi);
            Console.WriteLine("float: " + floatPi);

            // Output using string interpolation
            Console.WriteLine($"double: {doublePi}");
            Console.WriteLine($"decimal: {decimalPi}");

            Console.WriteLine("\n--- User Input Section ---");

            // Input a name
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            // Input a number
            Console.Write("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Output the entered number
            Console.WriteLine("You entered: " + userNumber);

            // Add 100 to the entered number and display the result
            int sum = userNumber + 100;
            Console.WriteLine($"Your number plus 100 is: {sum}");

            Console.WriteLine("\n--- Increment Operator Examples ---");

            int value = 5;
            Console.WriteLine($"Starting value: {value}");

            // Post-increment example
            Console.WriteLine($"Post-increment (value++): {value++}");
            Console.WriteLine($"Value after post-increment: {value}");

            // Reset and pre-increment example
            value = 5;
            Console.WriteLine($"\nPre-increment (++value): {++value}");
            Console.WriteLine($"Value after pre-increment: {value}");

            Console.WriteLine("\n--- Boolean Variable Examples ---");

            // Simple boolean assignment
            bool isLearningFun = true;
            Console.WriteLine($"isLearningFun: {isLearningFun}");

            // Comparison examples
            int a = 10;
            int b = 20;

            bool isLess = a < b;
            bool isGreaterOrEqual = a >= b;
            bool isNotEqual = a != b;
            bool isEqual = a == 10;

            // Output the results
            Console.WriteLine($"a < b: {isLess}");
            Console.WriteLine($"a >= b: {isGreaterOrEqual}");
            Console.WriteLine($"a != b: {isNotEqual}");
            Console.WriteLine($"a == 10: {isEqual}");
        }
    }
}
