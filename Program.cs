namespace Pheasant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.StartNewGame();
            bool toContinue = true;
            do
            {
                Console.WriteLine("N - new game with same players, I - new players, Q - quit");
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (key)
                {
                    case 'N':
                        m.StartNewGame();
                        break;
                    case 'I':
                        m.SetPlayersForGame();
                        m.StartNewGame();
                        break;
                    case 'Q':
                        toContinue = false;
                        break;
                    default:
                        Console.WriteLine("Please insert only N, Q or I ");
                        break;
                }


            } while (toContinue) ;


        }
    }
}
