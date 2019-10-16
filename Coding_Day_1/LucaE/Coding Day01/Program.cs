using System;

namespace Coding_Day
{
    using System;
    using System.Linq;

    class Program
    {

        static void Main(string[] args)
        {
            string userInput;
            string star = "*";


            Console.WriteLine("Bitte geben Sie einen Satz ein!");
            userInput = Console.ReadLine();

            // Zählt die Leerzeichen
            int countSpaces = userInput.Count(Char.IsWhiteSpace);
            Console.WriteLine("Es ist/sind {0} Leerzeichen in deinem Satz.", countSpaces);
            Console.WriteLine("");


            // Löscht den Buchstaben aus dem Satz
            Console.WriteLine("Bitte geben Sie einen Buchstaben ein!");
            string letter = Console.ReadLine();
            userInput = userInput.Replace(letter, "");
            Console.WriteLine(userInput);
            Console.WriteLine("");
            Console.WriteLine("==================");
            Console.WriteLine("Drücken Sie Enter");
            Console.WriteLine("==================");
            Console.ReadKey();
            Console.Clear();

            // Zählt die Buchstaben im Wort
            Console.WriteLine("Bitte geben Sie ein Wort ein!");
            string word = Console.ReadLine();
            int numberOfLetters = word.Length;
            Console.WriteLine("Ihr Wort hat {0} Buchstaben", numberOfLetters);
            Console.WriteLine("");

            // Wort wird mit Buchstaben Verschlüsselt
            Console.WriteLine("Nun werden wir ihr Wort verschlüsseln");
            Console.WriteLine("");
            Console.WriteLine("Wählen Sie ihre Verschlüsseslungs Art:");
            Console.WriteLine("[1] Standart Verschlüsselung (***-Verschlüsselung) [2] Buchstaben Verschlüsselung [3] Cesar Verschlüsselung");
            int input = Convert.ToInt32(Console.ReadLine());

            // 1. Verschlüsselungs Methode
            if (input == 1)
            {
                Console.WriteLine("Ihr verschlüsseltes Passwort lautet: ");
                for (int i = 0; i < numberOfLetters; i++)
                {
                    string word2 = word.Replace(word, star);
                    Console.Write(word2);
                }
                Console.ReadKey();
            }
            // 2. Verschlüsselungs Methode
            else if (input == 2)
            {
                Console.WriteLine("Geben Sie einen Buchstaben ein mit dem das Wort: --> {0} <---  verschlüsselt werden soll ", word);
                string letter2 = Console.ReadLine();

                Console.WriteLine("Ihr verschlüsseltes Passwort lautet:");
                for (int i = 0; i < numberOfLetters; i++)
                {
                    string word2 = word.Replace(word, letter2);
                    Console.Write(word2);
                }
                Console.ReadKey();

            }
            else if (input == 3)
            {


                Console.Write("Geben Sie den Text ein: ");
                string inputText = Console.ReadLine();
                Console.Write("Um wie viele Stellen soll verschoben werden: ");
                string inputStellen = Console.ReadLine();



                int stellen = int.Parse(inputStellen) % 26; //Parse konvertiert Zeichenfolgendarstellungen einer Zahl in einem angegebenen Stil und Format

                string output = Chiffre(inputText, stellen);




                Console.WriteLine("Ergebnis: {0}", output);


                Console.ReadKey();
                Console.Clear();
            }
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

