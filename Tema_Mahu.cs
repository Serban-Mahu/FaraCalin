// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
double b;
b = 42.512;
Console.WriteLine(b);
Console.WriteLine("New b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Another b");
Console.WriteLine("Memorie utilizata:" +sizeof(double));
string? input = Console.ReadLine();
if (double.TryParse(input, out double number))
    Console.Write(number);
else
    Console.WriteLine("Bad input");
Console.WriteLine("Min: " +double.MinValue);
Console.WriteLine("Max: " +double.MaxValue);

float c;
c = 13.2f;
Console.WriteLine(c);
Console.WriteLine("New c");
c = float.Parse(Console.ReadLine());
Console.WriteLine("Another c");
Console.WriteLine("Memorie utilizata:" +sizeof(float));
string? inputfloat = Console.ReadLine();
if (float.TryParse(inputfloat, out float number2))
    Console.Write(number2);
else
    Console.WriteLine("Bad input");
Console.WriteLine("Min: " + Single.MinValue);
Console.WriteLine("Max: " + Single.MaxValue);


long i;
i = 78;
Console.WriteLine(i);
Console.WriteLine("New i");
i = long.Parse(Console.ReadLine());
Console.WriteLine("Another i");
Console.WriteLine("Memorie utilizata:" + sizeof(long));
string? inputlong = Console.ReadLine();
if (long.TryParse(inputlong, out long number3))
    Console.Write(number3);
else
    Console.WriteLine("Bad input");
Console.WriteLine("Min: " + Int64.MinValue);
Console.WriteLine("Max: " + Int64.MaxValue);


