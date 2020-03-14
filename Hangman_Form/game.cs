using System;
using System.IO; 
using System.Windows.Forms;
using System.Threading;

namespace Hangman_Form
{
    public partial class game : Form
    {
        string Word { get; set; }
        string[] LettersInWord { get; set; }
        public void printGuesses()
        {
            //Write an underscore for every letter that is not correctly guessed
            foreach(string item in LettersInWord)
            {
                lblCurrentGuess.Text += "_";
            }
        }
        public game(string word, string[] lettersInWord)
        {
            InitializeComponent();
            Word = word;
            LettersInWord = lettersInWord;
            lblCurrentGuess.Text = "";
            printGuesses();
        }
    }
}
