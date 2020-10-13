using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rorövovarorsospoproråkoketot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\tVar god skriv in ett ord: ");
            RobberLanguage();
            Console.ReadLine();
        }

        static void RobberLanguage()
        {  
            char[] vokal = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y' };        //Array of letters to change.
                                                                                                            
            string word = Console.ReadLine().ToLower();     //Input to lowercase so it's easier to work with.
            string translated = "";                                                 //Empty string to add to later
           
            foreach (char letter in word)                               //Loops through the word
            {                                                                       
                if(vokal.Contains(letter) == true)                  //Looks for letters from arry
                {
                    translated += letter + "o" + letter;            //If letter does match array, add said combo to new string
                }
                else
                {
                    translated += letter;                                   //If letter does not exist, add it to the new string w/o tampering.
                }                
            }

            //For fun, capitilize the first letter in the word. And writes it to console.
            Console.WriteLine(char.ToUpper(translated[0])  + translated.Substring(1) ); 
        }

    }

}
