using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public class Ruletka: blackjack
    {

        public static void Ruletkaa()
        {


            

                string[] zakręceniakolory = { "zielony", "czerwony", "czarny" };
                int[] zakręcenialiczby = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
           
                try
                {



                    Random random = new Random();
                    int liczba = random.Next(0, 13);

                    Console.WriteLine(liczba);
                    if (liczba % 2 == 0)
                    {
                        Console.WriteLine("czarny" + liczba);
                    }
                    else if (liczba % 2 == 1)
                    {
                        Console.WriteLine("czerwony" + liczba);
                    }
                    else
                    {
                        Console.WriteLine("zielony" + liczba);
                    }
                    Console.WriteLine();

                }
                catch (Exception)
                {

                    throw;
                }




            
        }
    }
}
