// See https://aka.ms/new-console-template for more information
int err1 = 1;
string err1type1 = "string", err1type2 = "int";
Console.WriteLine($"Error {err1}");
Console.WriteLine($"\"Error: Cannot implicitly convert type '{err1type1}' to '{err1type2}.\" This means that your variable is not compatible with the {err1type2} type. ");
int err2 = 2;
string err2var = "N";
Console.WriteLine($"Error {err2}");
Console.WriteLine($"\"The name '{err2var}' does not exist in the current context.\" This means that the variable {err2var} was not declared.");
int err3 = 3;
string err3type = "int";
Console.WriteLine($"Error {err3}");
Console.WriteLine($"\"Not all code paths return a value.\". This means that, for example, an {err3type} method does not return a {err3type} value in all cases,which it should.");
