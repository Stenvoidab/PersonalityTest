using System;

namespace Personality_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub kasutajal sisestada lemmik värv;
            //Kui kasutaja sisestab punane, konsool kuvab "Oled romantiline!";
            //kui kasutaja sisestab sinine, konsool kuvab "Oled töökas!";
            //kui kasutaja sisestab roheline, konsool kuvab "Oled loodusesõber!";
            //Kui kasutaja sisestab midagi muud, konsool kuvab "Oled {UserColor } ükssarvik!";

            Console.WriteLine("Sisesta enda lemmikvärv.");
            string UserColor = Console.ReadLine();
            if (UserColor == "punane")
            {
                Console.WriteLine("Oled romantiline!");
            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("Oled töökas!");
            }
            else if (UserColor == "roheline")
            {
                Console.WriteLine("Oled loodusesõber!");
            }
            else 
            { 
                Console.WriteLine("Oled " + UserColor + " ükssarvik!"); 
            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
