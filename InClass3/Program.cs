using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 90;
            Console.WriteLine(x);

            // Selection Statements
            // if, if...else, if...else if...else, switch
            // <, <=, >, >=, ==, !=
            if (x < 50)
            {
                Console.WriteLine("x is greater than 50");
            }
            else if (x < 100)
            {
                Console.WriteLine("x is less than 100");
            }
            else
            {
                Console.WriteLine("x is not greater than 50");
            }

            // Example - Output a letter grade based on a numeric grade
            Console.Write("Enter a grade (as an integer):");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade > 89)
            {
                Console.WriteLine("You received an A");
            }
            else if (grade > 79)
            {
                Console.WriteLine("You received a B");
            }
            else if (grade > 69)
            {
                Console.WriteLine("You received a C");
            }
            else if (grade > 59)
            {
                Console.WriteLine("You received a D");
            }
            else
            {
                Console.WriteLine("You received an F");
            }

            // Combining conditions with logical operators
            bool attendanceMet = true;

            if ((grade > 69) && attendanceMet)
            {
                Console.WriteLine("You passed the class!");
            }

            // switch statement example - output day of the week
            int day = 12;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            // Going from selection to repetition
            int i = 1;
            if (i < 10)
            {
                Console.WriteLine("i is less than 10");
            }

            while (i < 3)
            {
                Console.WriteLine("i is less than 10");
                i++;
            }

        }
    }
}
