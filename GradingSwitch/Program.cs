using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt, mis hinde ta sai
            //Kui kasutaja sai "A", konsool kuvab "Suurepärane!";
            //Kui 'B', konsool kuvab "Väga hea!";
            //Kui 'C', "Hea!";
            //Kui 'D', "Rahuldav";
            //Kui 'E', "Kasin";
            //Kui 'F', "Puudulik".
            //Kui kasutaja sisetab midagi muud, kuva "Vale väärtus."

            //KASUTAME SWITCH

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character - salvestab ainult 1 sümboli
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Vale väärtus.");
                    break;
            }
        }
    }
}
