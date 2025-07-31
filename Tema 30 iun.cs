using System.Runtime;

Console.WriteLine("Operatiile posibile in calculator sunt urmatoarele: ");
Console.WriteLine("+: adunare");
Console.WriteLine("-: scadere");
Console.WriteLine("*: inmultire");
Console.WriteLine("/: impartire");
Console.WriteLine("^: ridicarea la o putere(exponentul poate fi doar nr natural)");
Console.WriteLine("MS: salvarea numarului curent in memorie");
Console.WriteLine("=: terminarea calculului");
Console.WriteLine("MR se poate folosi pentru substituirea unui nr cu ce e salvat in memorie, defaultul fiind 0");
Console.WriteLine("C se poate folosi pentru reinceperea calculului");
Console.WriteLine("Numerele si comenzile trebuie sa fie pe linii individuale.");
double binPow(double a, uint b)
{
    if (b == 0)
        return 1;
    if (b % 2 == 0)
        a = putere(a * a, b / 2);
    else a = a * putere(a * a, b / 2);
    return a;
}
double memorie = 0,x;
string comanda;
resetCalcul:
if (!double.TryParse(Console.ReadLine(), out x))
    Console.WriteLine("Nu ati introdus un numar.");
else
{
calcul:
    comanda = Console.ReadLine();
    switch (comanda)
    {
        case "+":
            {
                string z; double y;
            citire1:
                z = Console.ReadLine();
                if (z == "MR")
                    y = memorie;
                else
                if (!double.TryParse(z, out y))
                { Console.WriteLine("Nu ati introdus un numar."); goto citire1; }
                x = x + y;
                Console.WriteLine($"={x}");
                break;
            }
        case "-":
            {
                string z; double y;
            citire2:
                z = Console.ReadLine();
                if (z == "MR")
                    y = memorie;
                else
                if (!double.TryParse(z, out y))
                { Console.WriteLine("Nu ati introdus un numar."); goto citire2; }
                x = x - y;
                Console.WriteLine($"={x}");
                break;
            }
        case "*":
            {
                string z; double y;
            citire3:
                z = Console.ReadLine();
                if (z == "MR")
                    y = memorie;
                else
                if (!double.TryParse(z, out y))
                { Console.WriteLine("Nu ati introdus un numar."); goto citire3; }
                x = x * y;
                Console.WriteLine($"={x}");
                break;
            }
        case "/":
            {
                string z; double y;
            citire4:
                z = Console.ReadLine();
                if (z == "MR")
                    y = memorie;
                else
                if (!double.TryParse(z, out y))
                { Console.WriteLine("Nu ati introdus un numar."); goto citire4; }
                x = x / y;
                Console.WriteLine($"={x}");
                break;
            }
        case "^":
            {
                uint y;
            citire5:
                if (!uint.TryParse(Console.ReadLine(), out y))
                { Console.WriteLine("Nu ati introdus un numar natural."); goto citire5; }
                x = putere(x, y);
                Console.WriteLine($"={x}");
                break;
            }
        case "MS":
            {
                memorie = x;
                Console.WriteLine($"={x}");
                break;
            }
        case "=":
            {
                Console.WriteLine($"Rezultatul este {x}.");
                return;
            }
        case "C":
            {
                goto resetCalcul;
            }
        default: Console.WriteLine("Comanda invalida."); break;
    }
    goto calcul;
}
