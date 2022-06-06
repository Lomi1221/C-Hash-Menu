using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public class uzupełnianie: Ruletka

    {

        public const string dobraodpowiedź = "\nPoprawna odpowiedź. Brawo!!!";
        public const string złaodpowiedź = "\nNiestety się nie udało :(";
        public const string zapisane = dobraodpowiedź;

        static string[] words = { "assets", "assign",
            "assigning", "awareness",
            "booleans", "character",
            "conscious", "consider", "const", "constantly",
            "convinced" };

        static string[] solutions = { "majątek", "przydzielać", "przypisywanie",
            "świadomość", "wartości logiczne", "postać", "świadomy", "rozważać", "stały",
        "stale", "przekonany"};

        

        
        

        public static void Uzupełnianie()
        {
            while (true)
            {
                try
                {
                    Random random = new Random();
                    int number = random.Next(0, 10);

                    
                    Console.WriteLine(words[number]);
                 string odpowiedź = Console.ReadLine();
                    string dobra = solutions[number];

                    if (odpowiedź == dobra)
                    {
                        Console.WriteLine(dobraodpowiedź);

                       

                        Console.WriteLine("Następne słowo to:\n");


                        





                    }

                    else
                    {
                        Console.WriteLine(złaodpowiedź);
                        Console.WriteLine("Prawidłowa odpowiedź, to:\n");
                        Console.WriteLine(dobra);
                        Console.WriteLine("\nNastępne słowo to:\n");
                    }

                }
                catch (Exception ex)

                {

                    Console.WriteLine(ex.Message);
                }
                
            }

        }
    }
}
