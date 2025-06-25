// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a numeric value for a: ");
int a;
a = 34;
Console.WriteLine("a is now " + a);
Console.WriteLine("New value for a: ");
a=int.Parse(Console.ReadLine());
Console.WriteLine("a is now " + a);
Console.WriteLine("Test if a is an integer");
string? input = Console.ReadLine();
if (int.TryParse(input, out int number))
    Console.WriteLine("a is an integer");
else
    Console.WriteLine("a is not an integer");

Console.WriteLine("If a is an integer, these are its minimum and maximum values:");
Console.WriteLine("Min: " + int.MinValue);
Console.WriteLine("Max: " + int.MaxValue);

Console.WriteLine("Test if a is a number with decimals");
string? input2= Console.ReadLine();
if (double.TryParse(input2, out double number2))
    Console.WriteLine("a is a number with decimals");
else
    Console.WriteLine("a is not a number with decimals");

Console.WriteLine("If a is a double, these are its minimum and maximum values:");
Console.WriteLine("Min: " + double.MinValue);
Console.WriteLine("Max: " + double.MaxValue);

Console.WriteLine("Now, test if a is a character");
string? input3 = Console.ReadLine();
if (char.TryParse(input3, out char character))
    Console.WriteLine("a is a character");
else
    Console.WriteLine("a is not a character");

Console.WriteLine("If a is a character, these are its minimum and maximum values, in ASCII code:");
Console.WriteLine("Min: " + (int)char.MinValue);
Console.WriteLine("Max: " + (int)char.MaxValue);
