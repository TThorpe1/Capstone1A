using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1A
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            string userChoice = "y";
            Console.WriteLine("Welcome to the Pig Latin Translator!\n");
            while (userChoice.ToLower() == "y")
            { ////user input


                Console.WriteLine("Enter a word to be translated");
                userinput = Console.ReadLine();

                // check if word contains a number
                bool containsNumber = false;
                for (int i = 0; i < userinput.Length; i++)
                {
                    if (Char.IsDigit(userinput[i]))


                    {
                        Console.Write("Input cannot be a number! Re-enter input again. ");
                        containsNumber = true;
                        continue;
                    }
                }
                //repeat process if contains number

                if (containsNumber) continue;

                //change all characters to lower case

                userinput = userinput.ToLower();


                //check if first character is a vowel
                int index = "aeiou".IndexOf(userinput[0]);

                bool vowel = false;
                if (index >= 0)
                //if index is greater or equal to 0, change vowel bool to true
                {
                    vowel = true;
                }
                //if first character is a vowel, add way to the end and display results
                if (vowel == true)
                {
                    userinput = userinput + "way";
                }
                // otherwise, if first letter is a consonant, find where first vowel occurs
                else
                {

                    int i;
                    for (i = 0; i < userinput.Length; i++)
                    {
                        index = "aeiou".IndexOf(userinput[i]);

                        if (index >= 0)
                        {
                            break;
                        }

                    }
                    // perform manipulation and display results
                    userinput = userinput.Substring(i) + userinput.Substring(0, i) + "ay";
                }
                Console.WriteLine(userinput);
                Console.WriteLine("Do you want to translate another word? (y/n)");
                userChoice = Console.ReadLine();


            }





        }
    }
}
