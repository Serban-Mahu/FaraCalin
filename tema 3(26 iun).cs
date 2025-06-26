string firstName, familyName;
string? middleName;
uint contractHourPerWeek,weeksWorked;
uint age;
bool currentlyEmployed=false;
double wagePerYear, payment, total,percent;
double computePayment(uint hours,double wage)
{
    return wage/(52 * hours);
}
double computeTotal(uint weeks, double wage)
{
    return (wage / 52) * weeks;
}
double computePercentage(uint hours, uint weeks, uint age)
{
    return (double)(weeks * hours)/ (double)(age * 8780);
}
void readAndCompute()
{
    Console.Write("First name: ");
    firstName=Console.ReadLine();
    Console.Write("Middle name: ");
    middleName =Console.ReadLine();
    Console.Write("Last name: ");
    familyName =Console.ReadLine();
    Console.Write("Number of hours per week: ");
    contractHourPerWeek = uint.Parse(Console.ReadLine());
    Console.Write("Is the person employed?(1 for yes, 0 for no): ");
    string employment=(Console.ReadLine());
    if(employment=="1")
        currentlyEmployed=true;
    Console.Write("Annual wage: ");
    wagePerYear = double.Parse(Console.ReadLine());
    Console.Write("Number of weeks worked: ");
    weeksWorked= uint.Parse(Console.ReadLine());
    if (currentlyEmployed)
    {
        Console.Write("Age: ");
        age = uint.Parse(Console.ReadLine());
        percent = computePercentage(contractHourPerWeek, weeksWorked, age);
    }
    else percent = 1;
        payment = computePayment(contractHourPerWeek, wagePerYear);
    total=computeTotal(weeksWorked, wagePerYear);
}
readAndCompute();
if (middleName != "")
    Console.WriteLine($"The payment per hour of {firstName} {middleName} {familyName} is {payment:C2}, the total amount of money earned is {total:C2} and the percentage of work out of age is {percent:P2}.");
else
    Console.WriteLine($"The payment per hour of {firstName} {familyName} is {payment:C2}, the total amount of money earned is {total:C2} and the percentage of work out of age is {percent:P2}.");
