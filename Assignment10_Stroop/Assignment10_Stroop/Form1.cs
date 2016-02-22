using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Jacob Stroop
CIS 353 - Assignment 10
2/21/16

    I think most of this code would be
    better off in another class where
    the event handlers are left only to call
    the appropriate external class methods,
    but there's no more time for refactoring
    tonight. :)
*/

namespace Assignment10_Stroop
{
    public partial class GuessANumber : Form
    {
        // class fields
        public int[] Numbers { get; set; }
        public int ArrayPosition { get; set; }
        public int CorrectGuessCount { get; set; }
        public int IncorrectGuessCount { get; set; }

        // derived field for easier reading
        public int CorrectNumber
        {
            get { return Numbers[ArrayPosition]; }
        }

        public GuessANumber()
        {
            Numbers = new int[100]; // instantiate array
            FillRandomNumberArray(); // populate array with random numbers
            ArrayPosition = 0; // set array index to 0
            CorrectGuessCount = 0; // set correct guess count to 0
            IncorrectGuessCount = 0; // set incorrect guess count to 0
            InitializeComponent(); // initialize form
        }

        // method fills numbers array with random numbers
        private void FillRandomNumberArray()
        {
            Random random = new Random();

            for(int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = random.Next(0, 101);
            }
        }

        // Guess Button event handler
        private void guessBtn_Click(object sender, EventArgs e)
        {
            int guess; // int variable for user guess

            // try to parse input, assigns value of zero if not sucessful
            int.TryParse(playerGuessTxt.Text, out guess);

            // if player guess is out of range, or if
            // input was unable to be parsed (0),
            // alert user and return from method
            if (guess < 1 || guess > 100)
            {
                correctNumberLbl.Text = LabelTexts.InvalidGuess;
                return;
            }

            guessBtn.Enabled = false; // diable guess button
            nextGuessBtn.Enabled = true; // enable next guess button

            // if guess is correct
            if (guess == CorrectNumber)
            {
                statusLbl.Text = LabelTexts.Win; // set label to alert of win
                CorrectGuessCount ++; // update running count of wins
                correctCountLbl.Text = Convert.ToString(CorrectGuessCount); // update label to reflect wins
            }
            // if guess is incorrect
            else
            {
                statusLbl.Text = LabelTexts.Lose; // set label to alert of loss
                IncorrectGuessCount++; // update running count of losses
                incorrectCountLbl.Text = Convert.ToString(IncorrectGuessCount); // update label to reflect losses
            }

            // display correct number in label
            correctNumberLbl.Text = String.Format("{0} {1}", LabelTexts.CorrectNumber, this.CorrectNumber);

            // disable hint label
            hintLbl.Enabled = false;

        }

        // Next Guess button event handler
        private void nextGuessBtn_Click(object sender, EventArgs e)
        {
            // if the array possition is at the end of the array,
            // repopulate array with random numbers, otherwise
            // increment array index to next position
            if (ArrayPosition == Numbers.Length - 1)
            {
                FillRandomNumberArray();
                ArrayPosition = 0;
            }
            else
            {
                ArrayPosition++; // increment array index
            }

            guessBtn.Enabled = true; // diable guess button
            nextGuessBtn.Enabled = false; // enable next guess button
            statusLbl.Text = LabelTexts.StatusDefault; // reset status label
            hintLbl.Text = ""; // reset hint label text
            playerGuessTxt.Text = "";
            correctNumberLbl.Text = LabelTexts.CorrectNumberDefault;
            hintLbl.Enabled = true; // enable hint label

            Console.WriteLine("Correct Number:" + CorrectNumber);
        }

        // event handler for hint label mouse hover
        private void hintPromptLbl_MouseHover(object sender, EventArgs e)
        {
            int hintNumber;

            // set hint number based on range of correct number
            if (CorrectNumber > 3 && CorrectNumber < 96)
            {
                hintNumber = CorrectNumber + 3;
            }
            else
            {
                hintNumber = CorrectNumber - 1;
            }

            // set hint label text to display hint
            hintLbl.Text = String.Format("{0} {1}.", LabelTexts.Hint, hintNumber);
        }

        // exit button event handler closes application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }

    // I'm not sure if there ended up being any benefit to refactoring
    // label texts out of the form class, but it works and I think it
    // keeps the rest of the code a bit more clean
    struct LabelTexts
    {
        public const string StatusDefault = "Guess A Number!";
        public const string CorrectNumberDefault = "Guess a number between 1 and 100";
        public const string Win = "Yes, You Win!";
        public const string Lose = "Sorry, You Lose!";
        public const string InvalidGuess = "Invalid Entry. Please Try Again.";
        public const string CorrectNumber = "The correct number was";
        public const string Hint = "The number is not";
    }
}
