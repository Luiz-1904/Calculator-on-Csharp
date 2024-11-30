using System;

class MathOperation
{

    static private bool isRunning = true;
    static void Main(string[] args)
    {
        while (isRunning)
        {
            Interface();
        }
        Console.WriteLine("END");
        Console.WriteLine("Thanks for coming by");
        Console.WriteLine("----------------------------------");
    }

    static void Interface()
    {
        Console.WriteLine("Hello, Welcome to the calculator");
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine();

        var num1 = validNumber("Choose the first number: ");
        Console.WriteLine();

        var num2 = validNumber("Choose the second number: ");
        Console.WriteLine();

        Console.Write("Choose an operator (+ - / *): ");
        var op = Console.ReadLine();
        Console.WriteLine();

        Console.Write(Operation(num1, num2, op));
        Console.WriteLine();
        Console.WriteLine("----------------------------------");

        Console.Write("Do another calculation? (Y/N): ");
        string answer = Console.ReadLine();
        answer = answer.ToUpper();
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        switch (answer)
        {
            case "Y":
                Console.Clear();
                return;
            case "N":
                isRunning = false;
                return;
        }
    }

    static int validNumber(string message)
    {

        int number;
        bool isValid;

        do
        {
            Console.Write(message);
            var input = Console.ReadLine();
            isValid = int.TryParse(input, out number);
            if (!isValid)
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        } while (!isValid);

        return number;
    }


    static int Operation(int num1, int num2, string op)
    {
        switch (op)
        {
            case "-":
                return num1 - num2;

            case "+":
                return num1 + num2;

            case "/":
                return num1 / num2;

            case "*":
                return num1 * num2;

            default: throw new ArgumentException("Invalid Operator");
        }
    }
}