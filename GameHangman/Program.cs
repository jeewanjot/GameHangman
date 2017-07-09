using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHangman
{
    class Program
    {
        private static bool isFound = false;
        private static int lives;
        private static char selectedCharacter; 
        private static string selectedWord;
        private static int asciiValue;
        private static bool[] usedLetters;
        
        static void Main(string[] args)
        {
            Correct();
            wordLetter();
            askLetter();
            


            int lives = 5;
            string[] words = { "sky", "apple", "cloud", "is", "am" };

            bool[] usedLetters = new bool[26]; //if found is true
            int asciiValue = 0; //Can be between 0 to 25


            //Find Random Word
            Random rnd = new Random();
            selectedWord = words[rnd.Next(0, words.Length)];

            while (true)
            {
                Console.Clear();
                //Draw HangMan
                Console.WriteLine("Lives " + lives);

                if (lives == 0)
                {
                    DrawLives0();
                }
                else if (lives == 1)
                {
                    DrawLives1();
                }
                else if (lives == 2)
                {
                    DrawLives2();
                }


               

                    //DRAW MY Hidden Word
                    for (int i = 0; i < selectedWord.Length; i++)
                    {
                        char l = selectedWord[i];
                        asciiValue = l - 'a';
                        if (usedLetters[asciiValue] == true)
                        {
                            Console.Write(l + " ");
                        }
                        else
                        {
                            Console.Write("_ ");
                        }



                    }

                    Console.WriteLine();



                }

                Console.ReadKey();
            
        }

        public static void askLetter()
        {

            //ASK FOR A LETTER
            Console.Write("Input A Letter: ");
            char selectedCharacter = Convert.ToChar(Console.ReadLine());
            asciiValue = selectedCharacter - 'a';   //Get Value between 0 to 25
            usedLetters[asciiValue] = true;

        }
        public static void wordLetter()
        {
            //CHECK IF LETTER IN WORD
            bool isFound = false;
            for (int position = 0; position < selectedWord.Length; position++)
            {
                if (selectedCharacter == selectedWord[position])
                {
                    isFound = true;
                }
            }

        }

        public static void Correct()
        {
            
            //IF CORRECT OR NOT
            if (isFound == false)
            {
                lives--;
            }

        }

        public static void DrawLives0()
        {
            Console.WriteLine("___________  ");
            Console.WriteLine("|         |  ");
            Console.WriteLine("|         0  ");
            Console.WriteLine("|        /|\\ ");
            Console.WriteLine("|        / \\ ");
            Console.WriteLine("|            ");
            Console.WriteLine("|            ");

        }

        public static void DrawLives1()
        {
            Console.WriteLine("___________  ");
            Console.WriteLine("|         |  ");
            Console.WriteLine("|         0  ");
            Console.WriteLine("|        /|\\ ");
            Console.WriteLine("|          ");
            Console.WriteLine("|            ");
            Console.WriteLine("|            ");

        }

        public static void DrawLives2()
        {
            Console.WriteLine("___________  ");
            Console.WriteLine("|         |  ");
            Console.WriteLine("|         0  ");
            Console.WriteLine("|         | ");
            Console.WriteLine("|          ");
            Console.WriteLine("|            ");
            Console.WriteLine("|            ");

        }


    }
}
