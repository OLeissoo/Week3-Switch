using System;

namespace GradingIF
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

            //KASUTAME IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character - salvestab ainult 1 sümboli
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin");
            } 
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Vale väärtus.");
            }
        }
    }
}
