using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculator Pero Hindi Simple");

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose operation (+, -, *, /, ^): ");
        string op = Console.ReadLine();

        int result = 0;

        if (op == "+")
            result = num1 + num2;
        else if (op == "-")
            result = num1 - num2;
        else
            Console.WriteLine("Invalid operator.");

        Console.WriteLine("Result: " + result);
    }
}
