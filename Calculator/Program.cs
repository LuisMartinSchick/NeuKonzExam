
Console.WriteLine("Welcome to the calculator - please enter your first number:");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Now the second number:");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Now the action:");
string? action = Console.ReadLine();
double result = 0;
switch (action)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        result = num1 / num2;
        break;
    default:  
        Console.WriteLine("Wrong action! Try again");  
        break;
}
Console.WriteLine("The result is: ", result );
