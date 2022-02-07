using System;

namespace CradingIF
{
    class Program
    {
        public static object A { get; private set; }

        static void Main(string[] args)
        {
            //Programm küsib mis hinde kasutaja sai;
            //kui kasutaja sai A, konsool kuvab "suurepärane";
            //kui tulemus on B, konsool kuvab "väga hea";
            //kui tulemus on C, konsool kuvab "hea";
            //kui tulemus on D, konsool kuvab "rahuldav";
            //kui ksautaja sai E, konsool kuvab "kasin";
            //kui kasutaja sai F, konsool kuvab "puudulik";
            //kui midagi muud, konsool kuvab "vale väärtus";
            //kasutan IF;

            Console.WriteLine("Sisesta oma tulemus");
            char UserResult = Convert.ToChar(Console.ReadLine().ToUpper());
            if(UserResult == 'A')
            {
                Console.WriteLine("Suurepärane!"); 
            }
            else if (UserResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (UserResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (UserResult == 'D')
            {
                Console.WriteLine("Rahuldav.");
            }
            else if (UserResult == 'E')
            {
                Console.WriteLine("Kasin.");
            }
            else if (UserResult == 'F')
            {
                Console.WriteLine("Puudulik.");
            }
            else
            {
                Console.WriteLine("Vale väärtus.");
            }
        }
    }
}
