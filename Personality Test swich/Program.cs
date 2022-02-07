using System;

namespace Personality_Test_swich
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

            Console.WriteLine("Sisesta enda lemmikvärv");
            string UserColor = Console.ReadLine().ToLower();
            switch (UserColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline!");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas!");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber");
                    break;
                default:
                    Console.WriteLine($"Oled {UserColor } ükssarvik");
                    break;
            }
            Console.WriteLine("Kena päeva!");
            
        }
    }
}
