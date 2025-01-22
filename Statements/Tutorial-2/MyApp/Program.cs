using System;

class Program
{
    static void Main()
    {
        // 1. C# if-else Example
        Console.WriteLine("----- if-else Example -----");
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine(); // Read input as a string
        if (int.TryParse(input, out int num)) // Check if input can be converted to an integer
        {
            if (num > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }

        // 2. C# switch Example
        Console.WriteLine("\n----- switch Example -----");
        Console.Write("Enter a day of the week (1-7): ");
        string? input2 = Console.ReadLine();
        if (int.TryParse(input2, out int day))
        {
            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Invalid day!"); break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number between 1 and 7.");
        }

        // 3. C# for Loop Example
        Console.WriteLine("\n----- for loop Example -----");
        Console.Write("Enter a number to print squares (1 to N): ");
        string? nInput = Console.ReadLine();
        if (int.TryParse(nInput, out int n))
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Square of {i} is {i * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }

        // 4. C# while Loop Example
        Console.WriteLine("\n----- while loop Example -----");
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine($"Current count is {count}");
            count++;
        }

        // 5. C# do-while Loop Example
        Console.WriteLine("\n----- do-while loop Example -----");
        int number = 0;
        do
        {
            Console.WriteLine($"Number is {number}");
            number++;
        } while (number < 3);

        // 6. C# break Example
        Console.WriteLine("\n----- break Example -----");
        Console.Write("Enter the range for the loop: ");
        string? nbreak = Console.ReadLine();
        if (int.TryParse(nbreak, out int z))
        {
            for (int i = 0; i < z; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Breaking out of the loop at i = " + i);
                    break; // Exit loop when i equals 5
                }
                Console.WriteLine(i);
            }
        }

        // 7. C# continue Example
        Console.WriteLine("\n----- continue Example -----");
        Console.Write("Enter the range for the loop: ");
        string? nInput3 = Console.ReadLine();
        if (int.TryParse(nInput3, out int a))
        {
            for (int i = 0; i < a; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Skipping i = " + i);
                    continue; // Skip iteration when i equals 5
                }
                Console.WriteLine(i);
            }
        }

        // 8. C# goto Example
        Console.WriteLine("\n----- goto Example -----");
        int x = 0;
        startLoop:
        Console.WriteLine($"x is {x}");
        x++;
        if (x < 3)
        {
            goto startLoop; // Go back to startLoop label until x equals 3
        }

        // 9. C# Comments Example
        Console.WriteLine("\n----- Comments Example -----");
        // Single-line comment example
        /*
         * Multi-line comment example.
         * Explains a block of code or logic in detail.
         */
        Console.WriteLine("This program demonstrates all basic control statements in C#.");
    }
}
