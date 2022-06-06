using System;
namespace MyWorld
{
    public class MainClass: losowanie
    {

        


        public static void Main(string[] args)
            {
                Console.WriteLine("Co chcesz zrobić?");
                Console.ReadLine();
                Console.WriteLine("A: Zagrać w grę");
                Console.WriteLine("B: Pouczyć się");
                Console.WriteLine("C: Przetłumaczyć coś");
                Console.WriteLine("Wpisz A,B lub C jako swój wybór");

                string choice = Console.ReadLine();

            if (choice == "A")
            {
                Console.WriteLine("Dostępne gry:");
                Console.WriteLine("1. Ruletka - kolory");
                Console.WriteLine("2. BlackJack");
                Console.WriteLine("3. Zgadywanie liczb");
                Console.WriteLine("Wpisz 1,2 lub 3 jako swój wybór");

                int choice1 = (Convert.ToInt32(Console.ReadLine()));

                if (choice1 == 1)
                {
                    Ruletkaa();



    }
                else if (choice1 == 2)

                {
                    blackjackk();
                    
                }
            }
            else if (choice == "B")
            {
                Console.WriteLine("Dostępne opcje:");
                Console.WriteLine("1. Losowanie");
                Console.WriteLine("2. Uzupełnianie");
                Console.WriteLine("Wpisz 1 lub 2 jako swój wybór");


                int choice2 = (Convert.ToInt32(Console.ReadLine()));
                {
                    if (choice2 == 1)
                    {




                        MyMethod();



                    }

                    else if (choice2 == 2)
                    {
                        Uzupełnianie();
                    }


                }
            }
            else if (choice == "C")
            {
                Console.WriteLine("Dostępne tłumaczenia:");
                Console.WriteLine("1. Angielski -> Polski");
                Console.WriteLine("2. Polski -> Angielski");
                Console.WriteLine("3. Hiszpański -> Polski");
                Console.WriteLine("4. Polski -> Hiszpański");
                Console.WriteLine("Wpisz 1,2,3 lub 4 jako swój wybór");

            }
            }

       
    }
    }
