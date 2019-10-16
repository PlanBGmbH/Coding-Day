using System;
using System.Linq;

namespace GetTheExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string satz;
                string buchstabe;
                string wort;
                string gesperrt;

                Console.WriteLine("Bitte geben sie einen Satz ein:)");
                satz = Console.ReadLine();
                int countSpaces = satz.Count(char.IsWhiteSpace);
                Console.WriteLine("Es sind {0} Leerzeichen in deinem Satz", countSpaces);

                Console.WriteLine("Bitte geben sie einen Buchstaben ein:)");
                buchstabe = Console.ReadLine();
                satz = satz.Replace(buchstabe, "");
                Console.WriteLine(satz);

                Console.WriteLine("Bitte geben sie einen Wort ein:)");
                wort = Console.ReadLine();
                int anzahlBuchstaben = wort.Length;
                Console.WriteLine(anzahlBuchstaben);

                Console.WriteLine("Bitte geben sie einen Buchstaben ein um das Wort zu verschlüsseln:)");
                gesperrt = Console.ReadLine();

                for (int i = 0; i < anzahlBuchstaben; i++)
                {
                    string wort2 = wort.Replace(wort, gesperrt);
                    Console.Write(wort2);
                }



                Console.Write("\nGeben Sie das Passwort ein: ");
                string inputText = Console.ReadLine();
                Console.Write("Um wie viele Stellen soll verschoben werden: ");
                string inputStellen = Console.ReadLine();

                int stellen = int.Parse(inputStellen) % 26; //Parse konvertiert Zeichenfolgendarstellungen einer Zahl in einem angegebenen Stil und Format
            
                string output = Chiffre(inputText, stellen);
                                                            

                Console.WriteLine("Ergebnis: {0}", output);
            
            
            Console.ReadKey();
            Console.Clear();
        }
        public static string Chiffre(string input, int stellen)
        {
            string output = string.Empty;
            
            foreach (char c in input)
            {
                char x = (char)(c + stellen);
                output += x.ToString();
            }

            return output; 

        }
    }
}
