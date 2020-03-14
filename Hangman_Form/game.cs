using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Hangman_Form
{
    public partial class game : Form
    {
        static string Word { get; set; }
        static string[] LettersInWord { get; set; }
        public void printGuesses()
        {
            for(int i = 0; i < LettersInWord.Length; i++)
            {
                if (LettersInWord[i] != " ")
                {
                    lblCurrentGuess.Text += "_";
                }
                else if (LettersInWord[i] == " ")
                {
                    lblCurrentGuess.Text += " ";
                }
            }
        }
        private static int guessAmount = 10; //Declares how many guesses the player has in total
        string[] allGuesses = new string[guessAmount];
        public game(string word, string[] lettersInWord)
        {
            InitializeComponent();
            Word = word;
            LettersInWord = lettersInWord;
            lblCurrentGuess.Text = "";
            lblGuesses.Text = "Guesses: " + guessAmount.ToString();

            printGuesses();
            Console.WriteLine("The word is: {0}", Word);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtPlayerInput.Text;
            if (guessAmount > 0) //If the player still has guesses left
            {
                if (guess.Length > 1 && guess != Word)
                {
                    MessageBox.Show("Please enter a valid guess\n1.) Single letters\n2.) Correct word as a whole");
                }
                else
                {
                    if(txtPlayerInput.Text == Word)//If the player guesses the word in one try
                    {
                        lblCurrentGuess.Text = "";
                        foreach(string letter in LettersInWord)
                        {
                            lblCurrentGuess.Text += letter;
                        }
                        MessageBox.Show("You guessed the word!");
                        Environment.Exit(1);
                    }
                    Console.WriteLine("Guess: {0}\nvalid guess\n~~~~~~~~~~~~~", guess);
                    guessAmount--;
                }
                lblGuesses.Text = "Guesses: " + guessAmount.ToString();
            }
            else //The player is all out of guesses
            {
                MessageBox.Show("You are out of guesses\nThe Word was: " + Word);
                Environment.Exit(1);
            }
        }
    }
}
