using System;

namespace CodingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gebe einen Satz ein");
            //Satz wird eingegeben
            Console.ForegroundColor = ConsoleColor.Blue;
            string Satz = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ihr Satz lautet: "+ Satz);
            Console.ForegroundColor = ConsoleColor.Gray;
            //Leerzeichen werden deklariert
            char leer = ' ';
            //Counter für die leerzeichen
            int leercounter = 0;
            //Leerzeichen werden gezählt
            for (int i = 0; i < Satz.Length; i++)
            {
                if (Satz[i] == leer)
                {
                    //counter geht hoch
                    leercounter++;
                }
            }
            //Löscht einen Buchstaben der wahl aus dem Satz
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Und ihr Text enthält: " + leercounter + " Leerzeichen.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Bitte geben sie einen Buchstaben ein");
            Console.ForegroundColor = ConsoleColor.Blue;
            string Buchstabe = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Sie haben den Buchstabe " + Buchstabe + " gewählt");
            Console.WriteLine("");
            string eingabe2 = Satz.Replace(Buchstabe, "");
            Console.WriteLine("Zum weitermachen klicken");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ihr neuer Satz lautet nun: " + eingabe2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Zum weitermachen klicken");
            Console.ReadKey();
            Console.Clear();

            //Zeigt die Länge des eingegebenen satzes ein 
            Console.WriteLine("Geben sie nun ein Wort ihrer Wahl ein");
            Console.ForegroundColor = ConsoleColor.Blue;
            string Wort = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            int Länge = Wort.Length;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ihr Wort hat: " + Länge + " Buchstaben");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Zum weitermachen klicken");
            Console.ReadKey();
            Console.Clear();
            //Wort wird durch einen Buchstaben ersetzt
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ihr Wort: " + Wort);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Geben sie nun bitte einen Buchstaben ein um ihr Wort zu verschlüsseln");
            Console.WriteLine("");
            string WortBuchstabe = Console.ReadLine();
            string WortinX = Wort.Replace(Wort, WortBuchstabe);
            Console.Clear();
            Console.WriteLine("Ihr Wort lautet nun:");
            Console.WriteLine("");
            for (int i = 0; i < Wort.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(WortinX);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("");
            Console.WriteLine("Zum Beenden des Programms drücken sie eine beliebige Taste");
            Console.ReadKey();
        }
    }
}
