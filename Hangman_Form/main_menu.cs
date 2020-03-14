using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Hangman_Form
{
    /*
     * Easy (3-4 characters)
     * Medium (5-6 characters)
     * Hard (7+ characters)
     */

      //Allow for universal calling to files instead of local =
    public partial class Hangman : Form
    {
        string file_path;
        string word;
        public Hangman()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            file_path = @"C:\Users\Simon\Documents\GitHub\WinForm_Hangman\Hangman_Form\Easy_Words.txt";
            openGameForm();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            file_path = @"C:\Users\Simon\Documents\GitHub\WinForm_Hangman\Hangman_Form\Medium_Words.txt";
            openGameForm();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            file_path = @"C:\Users\Simon\Documents\GitHub\WinForm_Hangman\Hangman_Form\Hard_Words.txt";
            openGameForm();
        }

        public void ChooseRandomWord()
        {
            Random random = new Random();
            string[] textInArray = File.ReadAllLines(file_path);
            word = textInArray[random.Next(0, textInArray.Length - 1)];
        }
        private void openGameForm()
        {
            ChooseRandomWord();
            game Game_Form = new game(word, lettersInTheWord(word));
            this.Hide();
            Game_Form.Location = new Point(this.Location.X, this.Location.Y);
            Game_Form.Show();
        }
        private string[] lettersInTheWord(string word)
        {
            string[] arr = new string[word.Length];
            for(int i = 0; i < word.Length - 1; i++)
            {
                arr[i] = word[i].ToString();
            }
            return arr;
        }
    }
}
