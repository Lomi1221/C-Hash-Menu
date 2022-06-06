using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public class losowanie: uzupełnianie
    {
        static string[] translations = { "assets - majątek", "assign - przydzielać", 
            "assigning - przypisywanie", "awareness - świadomość", 
            "booleans - wartości logiczne", "character - postać", 
            "conscious - świadomy", "consider - rozważać", "const - stały", "constantly - stale",
            "convinced - przekonany" };





       public static void MyMethod()
        {
            while (true)
            {
                try
                {

                    Random random = new Random();
                    int number = random.Next(0, 10);

                    Console.WriteLine(number);
                    Console.WriteLine(translations[number]);
                    Console.ReadLine();
                }
                catch (Exception ex)

                {

                    Console.WriteLine(ex.Message);
                }
            }

        }
       
    }
    }

