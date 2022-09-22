using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Ratespiel
{ class program
    { static void Main(string[] args)
        {
            int randomCeiling;
        start:


            Console.ForegroundColor = ConsoleColor.Yellow;
            
            
                int Anzahlversüche = 0;
                bool istrichtiggeraten = false;
                Random zufall = new Random();

                int zufallsZahl = zufall.Next(1, 101);


                Console.WriteLine("Willkommen beim Zahlenratespiel! ");
                Console.Write("Geben sie ihren Namen ein: ");
                string name = (Console.ReadLine());
            

            while(!istrichtiggeraten)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(name + " bitte geben sie eine Zahl zwishen 1 - 100 ein: ");
                int raten = Convert.ToInt32(Console.ReadLine());

                if (raten > zufallsZahl)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deine Zahl ist grösser als die Geheimzahl.");
                }
                else if (raten < zufallsZahl)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Deine Zahl ist kleiner als die Geheimzahl. ");

                }
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("richitg! ");
                    istrichtiggeraten = true;
                }
                
                Anzahlversüche = Anzahlversüche +1;


            }
            
            {
                Anzahlversüche = Anzahlversüche + 1;
                Console.WriteLine("Sie haben " + Anzahlversüche + " Versuche gebraucht. ");

                Console.WriteLine("Glückwunsch " + name + " sie habee das Spiel gewonnen! ");

                Console.ReadKey();
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Möchten sie  nochmal spielen? [Ja;Nein] ");
                string nochmalspielen = Console.ReadLine();
                
        


            if (nochmalspielen == "Ja" )
            {
                goto start;
            } 
            if (nochmalspielen == "Nein")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. ");
            }

            

        }
 
        static void Level2(string[] args)
        {
            start2:

            int anzahlversüche = 0;
            bool istrichtiggeraten = false;
            Random zufall = new Random();
            int zufallszahl = zufall.Next(1, 101);

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Wilkommen bei Level 2 vom Zahlenratespiel! " +
                "Sie haben eine begrenzte Anzahl an Versüchen! ");
            
        }
            

    }
}
