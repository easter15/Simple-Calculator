using System.Runtime.CompilerServices;


do
{


    double num1 = 0;
    double num2 = 0;
    double result = 0;
    string symbol = "";

    Console.WriteLine("*****************\n");
    Console.WriteLine("Simple Calculator");
    Console.WriteLine("\n*****************\n");

    Console.Write("Please enter your first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\nPlease enter a mathematical symbol: ");
    Console.WriteLine("\t+ Add");
    Console.WriteLine("\t- Subtract");
    Console.WriteLine("\t* Multiply");
    Console.WriteLine("\t/ Divide");
    symbol = Console.ReadLine();

    Console.Write("\nPlease enter your second number: ");
    num2 = Convert.ToDouble(Console.ReadLine());


    switch (symbol)
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"\nYour result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"\nYour result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"\nYour result: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"\nYour result: {num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("That was not a valid option");
            break;
    }
    Console.Write("Woud you like to do another calculation? (Y = Yes, N = No): ");

} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("\nThank you for using my calculator.");
