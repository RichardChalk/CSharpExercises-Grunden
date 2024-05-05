using System;
//Test

namespace Övningsuppgifter_1___Grunden
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fortsatt = true;
            while (fortsatt)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~~        Välj en övning att köra:        ~~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("");
                Console.WriteLine(" 1: Adderar två heltal: ");
                Console.WriteLine(" 2: Adderar 3 heltal och dubblar resultatet: ");
                Console.WriteLine(" 3: Frågar efter användarens namn: ");
                Console.WriteLine(" 4: Arean av en triangel: ");
                Console.WriteLine(" 5: Tre nummer från användare: ");
                Console.WriteLine(" 6: Beräknar medeltalet: ");
                Console.WriteLine(" 7: Matte med tre tal: ");
                Console.WriteLine(" 8: Tre bokstäver: ");
                Console.WriteLine(" 9: Tal byter value: ");
                Console.WriteLine("10: Multiplikationstabell: ");
                Console.WriteLine("11: Alla operatorer: ");
                Console.WriteLine("12: Tre strängar: ");
                Console.WriteLine("13: Temperatur i Celcius: ");
                Console.WriteLine("14: Skriv PI: \n");
                Console.Write("Mitt val (Skriv 1-14): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                    Övningar1.Add2();
                else if (choice == 2)
                    Övningar1.Add3();
                else if (choice == 3)
                    Övningar1.NamnInput();
                else if (choice == 4)
                    Övningar1.TriArea();
                else if (choice == 5)
                    Övningar1.MultTre();
                else if (choice == 6)
                    Övningar1.Medel();
                else if (choice == 7)
                    Övningar1.MatteParentes();
                else if (choice == 8)
                    Övningar1.TreBokstaver();
                else if (choice == 9)
                    Övningar1.BytValue();
                else if (choice == 10)
                    Övningar1.MultiTabell();
                else if (choice == 11)
                    Övningar1.AllOperators();
                else if (choice == 12)
                    Övningar1.TreStrings();
                else if (choice == 13)
                    Övningar1.Temperatur();
                else if (choice == 14)
                    Övningar1.SkrivPi();

                Console.WriteLine("Vill du köra en till? (j/n)");
                string svar = Console.ReadLine();
                if (svar != "j" && svar != "J")
                    fortsatt = false;
                Console.Clear();
            }
            

        }
    }
}
