namespace BankApp
{
    class ATMapp
    {

        static void Main(string[] args)
        {
            static void Linespace(string[] args)
            {
                Console.WriteLine();
            }
            double balance = 1000.00;
            int korrektPIN = 1337;


            Console.WriteLine("Velkommen til denne ATM");
            Console.Write("Indtast dit navn: ");
            string brugerNavn = Console.ReadLine();
            Linespace(args);

            while (true)
            {

                Console.WriteLine("Indtast din PIN: ");
                int indtastetPIN = int.Parse(Console.ReadLine());




                if (indtastetPIN == korrektPIN)
                {
                    Console.Clear();
                    break;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Forkert kode, prøv igen: ");
                    continue;
                }

            }
            while (true)
            {
                Console.WriteLine("Velkommen, " + brugerNavn);
                Linespace(args);
                Linespace(args);
                Console.WriteLine("1. Check din saldo");
                Console.WriteLine("2. Hæv penge");
                Console.WriteLine("3. Indsæt penge");
                Console.WriteLine("4. Exit");

                int valg = int.Parse(Console.ReadLine());

                if (valg == 1)
                {
                    Linespace(args);
                    Console.WriteLine("Din saldo er: " + balance + " Kr.");
                    Linespace(args);
                }

                if (valg == 2)
                {
                    Console.Clear();
                    Linespace(args);
                    Console.WriteLine("Hvor mange penge vil du hæve?");
                    Console.Write("Kr: ");
                    double hævPenge = double.Parse(Console.ReadLine());

                    if (hævPenge > 0 && hævPenge <= balance)
                    {
                        balance -= hævPenge;
                        Console.WriteLine("Udbetaler: " + hævPenge + " Kr.");
                        Linespace(args);
                        Console.WriteLine("Din nye saldo: " + balance + " Kr.");
                    }

                    else
                    {
                        Console.WriteLine("Det kan åbenbart ikke lade sig gøre? Har du penge nok eller skriver du bare noget fjol?");
                    }
                }

                if (valg == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Hvor mange penge vil du indsætte?");
                    Console.Write("Kr: ");
                    double indsætPenge = double.Parse(Console.ReadLine());

                    if (indsætPenge > 0)
                    {
                        balance += indsætPenge;
                        Console.WriteLine("Du har indsat: " + indsætPenge + " Kr.");
                        Console.WriteLine();
                        Console.WriteLine("Din nye saldo: " + balance + " Kr.");
                    }

                    else
                    {
                        Console.WriteLine("Det ser ikke ud til at virke? Prøv igen");
                    }
                }

                if (valg == 4)
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}

