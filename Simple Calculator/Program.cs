// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

do
{

    double num1 = 0;
    double num2 = 0;
    double result = 0;



    Console.WriteLine("-----------------");
    Console.WriteLine("Simple Calculator");
    Console.WriteLine("-----------------");

    Console.Write("Enter your first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter your second number: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter one of the mathematical symbols: ");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Subtract");
    Console.WriteLine("\t* : Multiply");
    Console.WriteLine("\t/ : Divide");
  
    
    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("That was not a valid option");
                break;
    }
    Console.Write("Woud you like to do another calculation? (Y = Yes, N = No): ");

} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("\nThank you for using my calculator.");
 Console.ReadKey(); 