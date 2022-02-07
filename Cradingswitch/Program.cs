using System;

namespace Cradingswitch
{
    class Program
    {
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
            //kasutan Switchi;

            Console.WriteLine("Sisesta oma tulemus");
            char UserResult = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (UserResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea.");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav.");
                    break;
                case 'E':
                    Console.WriteLine("Kasin.");
                    break;
                default:
                    Console.WriteLine("Vale väärtus");
                    break;

            }
        }
    }
}
