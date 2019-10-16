using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string auswahl;
                Console.WriteLine("Bitte auswählen zwischen:\n1. Leerzeichen eines satzen einlesen und einen Buchstaben aus diesem entfernen\n2. Buchstaben eines Wortes einlesen und dieses Verschlüsseln\n3. ROT-13 verschlüsselung\n4. Exit");
                auswahl = Console.ReadLine();
                switch (auswahl)
                {
                    case "1":
                        sentence();
                        break;
                    case "2":
                        word();
                        break;
                    case "3":
                        rot();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        static void sentence()
        {
            Console.Clear();
            string eingabe;
            string ausgabe;
            string change;
            int counter = 0;
            Console.WriteLine("Bitte Satz eingeben");
            eingabe = Console.ReadLine();
            foreach (char character in eingabe)
            {
                var temp = character;
                if (temp == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter + "\n\nBitte den zu löschenden Buchstabe eingeben");
            change = Console.ReadLine();
            ausgabe = eingabe.Replace(change, "");
            Console.WriteLine(ausgabe);
            Console.ReadKey();
        }

        static void word()
        {
            Console.Clear();
            string eingabe;
            string ausgabe = "" ;
            string change;
            Console.WriteLine("Bitte Wort eingeben");
            eingabe = Console.ReadLine();
            Console.WriteLine(eingabe.Length + "\n\nBitte den Buchstabe zum Verschlüssln eingeben");
            change = Console.ReadLine();
            foreach (char character in eingabe)
            {
                ausgabe += eingabe.Replace(eingabe, change);
            }
            Console.WriteLine(ausgabe);
            Console.ReadKey();
        }
        static void rot()
        {
            Console.Clear();
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string ausgabe = "";
            string eingabe;
            char output;
            int counter = 0;
            Console.WriteLine("Bitte Satz eingeben");
            eingabe = Console.ReadLine().ToUpper();
            foreach (char character in eingabe)
            {
                foreach (char buchstabe in alpha)
                {
                    counter++;
                    if (buchstabe == character)
                    {
                        counter = counter + 12;
                        if (counter >= 26)
                        {
                            counter = counter - 26;
                        }
                        output = alpha[counter];
                        ausgabe = ausgabe + output;
                        counter = 0;
                    }
                }
                counter = 0;
            }
            Console.WriteLine(ausgabe);
            Console.ReadKey();
        }

        /*
        string changeInput;
        string word;
        string satz;
        string letterInput;
        string satzOutput = "";
        string wordOutput = "";
        char[] letter;
        char temp;
        char[] change;

        Console.WriteLine("Bitte einen Satz eingeben");
        satz = Console.ReadLine();
        int result1 = 0;
        int result2 = 0;
        foreach (char character1 in satz)
        {
            if(character1 == ' ')
            {
                result1++;
            }
        }
        Console.WriteLine("You have {0} empty spaces\n\nBuchstabe eingeben", result1);
        letterInput = Console.ReadLine();
        letter = letterInput.ToCharArray(0,1);
        foreach (char character1 in satz)
        {
            temp = character1;
            if (temp == letter[0])
            {
                temp = ' ';
            }
            satzOutput = satzOutput + temp;
        }
        Console.WriteLine(satzOutput+"\n\n Bitte Wort eingeben");
        word = Console.ReadLine();
        foreach (char character2 in word)
        {
            result2++;
        }
        Console.WriteLine("You have {0} charecters in you word\n\nBuchstabe eingeben zum Verschlüsseln", result2);
        changeInput = Console.ReadLine();
        change = changeInput.ToCharArray(0, 1);
        foreach (char character2 in word)
        {
            temp = change[0];
            wordOutput = wordOutput + temp;
        }
        Console.WriteLine(wordOutput);
        Console.ReadKey();*/

    }
}
