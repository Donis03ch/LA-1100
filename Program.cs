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
                Console.Write(name + " bitte geben sie eine Zahl zwishen 1 - 100 ein: ");
                int raten = Convert.ToInt32(Console.ReadLine());
                if (raten > zufallsZahl)
                {
                    Console.WriteLine("Deine Zahl ist grösser als die Geheimzahl.");
                }
                else if (raten < zufallsZahl)
                {
                    Console.WriteLine("Deine Zahl ist kleiner als die Geheimzahl.");

                }
                else
                {
                    Console.WriteLine("Richtig!");
                    istrichtiggeraten = true;
                }
                
                Anzahlversüche = Anzahlversüche +1;


            }
            
            {
                Anzahlversüche = Anzahlversüche + 1;
                Console.WriteLine("Sie haben " + Anzahlversüche + " Versüche gebraucht. ");

                Console.WriteLine("Glückwunsch " + name + " sie haben das Spiel gewonnen! ");

                Console.ReadKey();
            }
            
                Console.WriteLine("Möchten sie nochmal spielen? ja (1) / nein (2) / next level (3) ");
                int nochmalspielen = Convert.ToInt32(Console.ReadLine());
                int ja = 1;
                int nein = 2;
        


            if (nochmalspielen == 1  )
            {
                goto start;
            } else
            {
                Environment.Exit(nochmalspielen);
            }
            


        }
 
        
            

    }
}
