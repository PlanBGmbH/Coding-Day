using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace Get_the_experience_Pascal_Lässig
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sentence is inputed and will be saved into "inputSentence"
            string inputSentence;
            Console.Write("Please input a sentence: ");
            inputSentence = Console.ReadLine();
            // Sentence is printed to the console

            // Whitespaces are counted and printed to the Console
            int countWhitespaces = inputSentence.Count(Char.IsWhiteSpace);
            Console.WriteLine($"There are { countWhitespaces } whitespaces");

            // Character will be saved into the variable
            string inputLetter;
            Console.Write("Please insert a Character you want to remove: ");
            inputLetter = Console.ReadLine();

            if (inputSentence.Contains(inputLetter))
            {   
                // Char will be removed
                inputSentence = inputSentence.Replace(inputLetter, "");
                // Sentence is printed
                Console.WriteLine($"The Sentence is: { inputSentence }");
            }
            else
            {
                Console.WriteLine("Theres no such character");
            }
            
            // Word will be saved into the variable
            string inputWord;
            Console.Write("Please input a word: ");
            inputWord = Console.ReadLine();
            // Length of the word will be analyzed
            int numberOfChars = inputWord.Length;
            // Length is printed to console
            Console.WriteLine($"The Word contains { numberOfChars } character");

            string decryptLetter;
            Console.Write("Input a letter with which you want to decrypt your word: ");
            decryptLetter = Console.ReadLine();
            // Decryptes the word with the input letter
            for (int i = 0; i < numberOfChars; i++)
            {
                string decryptedWord = inputWord.Replace(inputWord, decryptLetter);
                Console.Write($"{ decryptedWord }");
            }

            Console.WriteLine("\nAlgorithmus wird geladen.....");
            Thread.Sleep(800);
            Console.Clear();
            // Verschlüsselungsmenü
            Console.WriteLine("####################");
            Console.WriteLine("Verschlüsselungsmenü");
            Console.WriteLine("####################");
            Console.WriteLine("\nBitte den zu verschlüsselnden Text eingeben: ");
            string textEingabe;
            textEingabe = Console.ReadLine().ToUpper();

            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string ausgabe = String.Empty;

            Console.Write("Um wie viele Zeichen wollen Sie das Alphabet verschieben? ");
            int decrypt;
            decrypt = Convert.ToInt32(Console.ReadLine());

            foreach (var c in textEingabe)
            {
                if (alphabet.Contains(c))
                {
                    int indexOfCharacter = alphabet.IndexOf(c);
                    int newIndex = indexOfCharacter + decrypt;
                    if (newIndex > alphabet.Length - 1)
                    {
                        newIndex = newIndex - alphabet.Length - 1;
                    }
                    string newCharacter = alphabet[newIndex].ToString();
                    ausgabe += newCharacter;
                }
            }

            Console.WriteLine("\nWird verschlüsselt.....");
            Thread.Sleep(800);
            Console.WriteLine("\nVerschlüsselter Text:\n" + ausgabe);  // Verschlüsselter Text wird ausgegeben

            Console.ReadLine();
        }
    }
}
