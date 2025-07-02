namespace Tema_1iulie_structuri
{
    public enum Status { FullTime, PartTime, Intern, Student }

    public struct Persoana
    {
        public string FirstName;
        public string? MiddleName;
        public string? LastName;
        public bool CurrentlyEmployed;
        public double WagePerYear;
        public uint ContractHoursPerWeek;
        public DateOnly DateOfHire;
        public DateOnly? DateOfLeave;
        public double YearsWorked;
        public double Age;
        public Status StatusAngajat;

        public void readData()
        {
            Console.Write("First name: ");
            FirstName = Console.ReadLine();

            Console.Write("Middle name: ");
            MiddleName = Console.ReadLine();

            Console.Write("Last name: ");
            LastName = Console.ReadLine();

            Console.Write("Are you currently employed? (true/false): ");
            while (!bool.TryParse(Console.ReadLine(), out CurrentlyEmployed))
            {
                Console.Write("Invalid input. Enter true or false:");
            }

            Console.Write("Date of hiring(MM DD YYYY): ");
            while (!DateOnly.TryParse(Console.ReadLine(), out DateOfHire))
            {
                Console.Write("Invalid date. Try again:");
            }

            if (!CurrentlyEmployed)
            {
                Console.Write("Date of leaving(MM DD YYYY): ");
                DateOnly dateOfLeave;
                while (!DateOnly.TryParse(Console.ReadLine(), out dateOfLeave))
                {
                    Console.Write("Invalid date. Try again:");
                }
                DateOfLeave = dateOfLeave;

                YearsWorked = (DateOfLeave.Value.DayNumber - DateOfHire.DayNumber) / 365.0;
            }
            else
            {
                Console.Write("Enter how many years you have worked so far: ");
                while (!double.TryParse(Console.ReadLine(), out YearsWorked))
                {
                    Console.Write("Invalid input. Try again:");
                }
            }

            Console.Write("Your age: ");
            while (!double.TryParse(Console.ReadLine(), out Age))
            {
                Console.Write("Invalid input. Try again:");
            }

            Console.Write("Annual salary (wagePerYear): ");
            while (!double.TryParse(Console.ReadLine(), out WagePerYear))
            {
                Console.Write("Invalid input. Try again:");
            }

            Console.Write("Contract hours per week: ");
            while (!uint.TryParse(Console.ReadLine(), out ContractHoursPerWeek))
            {
                Console.Write("Invalid input. Try again:");
            }

            Console.Write("Enter your status (FullTime, PartTime, Intern, Student): ");
            while (!Enum.TryParse(Console.ReadLine(), true, out StatusAngajat))
            {
                Console.Write("Invalid status. Try again (FullTime, PartTime, Intern, Student):");
            }
        }

        public double PaymentPerHour()
        {
            const double weeksPerYear = 52;
            double totalHoursPerYear = ContractHoursPerWeek * weeksPerYear;
            return WagePerYear / totalHoursPerYear;
        }

        public double TotalEarned()
        {
            return WagePerYear * YearsWorked;
        }

        public double WorkPercentage()
        {
            if (Age == 0) return 0;
            return (YearsWorked / Age) * 100;
        }

        public void printData()
        {
            Console.WriteLine($"\n=== Employee data ===");
            Console.WriteLine($"Full name: {FirstName} {MiddleName} {LastName}");
            Console.WriteLine($"Employee: {(CurrentlyEmployed ? "Da" : "Nu")}");
            Console.WriteLine($"Date of hiring: {DateOfHire}");

            if (DateOfLeave.HasValue)
                Console.WriteLine($"Date of leaving: {DateOfLeave.Value}");

            Console.WriteLine($"Status: {StatusAngajat}");
            Console.WriteLine($"Years worked: {YearsWorked:F1}");
            Console.WriteLine($"Wage per year: {WagePerYear:F2} lei");
            Console.WriteLine($"Payment per hour: {PaymentPerHour():F2} lei");
            Console.WriteLine($"Total earned {TotalEarned():F2} lei");
            Console.WriteLine($"Work percentage: {WorkPercentage():F2}%");
        }

        public void increaseWage()
        {
            Console.Write("Is the raise small, medium or big?: ");
            readRaise:
            string raise = Console.ReadLine();
            switch (raise)
            {
                case "small":
                    {
                        WagePerYear = 1.05 * WagePerYear;
                        Console.WriteLine("The wage was raised by 5% !");
                        break;
                    }
                case "medium":
                    {
                        WagePerYear = 1.1 * WagePerYear;
                        Console.WriteLine("The wage was raised by 10% !");
                        break;
                    }
                case "big":
                    {
                        WagePerYear = 1.15 * WagePerYear;
                        Console.WriteLine("The wage was raised by 15% !");
                        break;
                    }
                default: Console.WriteLine("Please write \"small\", \"big\" or \"medium\"!"); goto readRaise;
            }
        }
        public void call()
        {
            readData();
            Console.Write("Would you like to raise this person's wage? (anything other than a \"yes\" will be taken as a no): ");
            string answer = Console.ReadLine();
            if (answer == "yes")
                increaseWage();
            Console.Write("Would you like to fire the employee?: ");
            answer = Console.ReadLine();
            if(answer=="yes" ||  answer=="NO!")
            {
                CurrentlyEmployed = false;
                DateOfLeave = DateOnly.FromDateTime(DateTime.Now);
            }
            printData();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Would you like to generate a new employee? (anything other than a \"yes\" will be taken as a no): ");
            string answer2= Console.ReadLine();
            while(answer2=="yes")
            {
                Persoana p=new Persoana();
                p.call();
                Console.Write("Would you like to generate a new employee? (anything other than a \"yes\" will be taken as a no): ");
                answer2 = Console.ReadLine();
            }
        }
    }
}