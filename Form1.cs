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
 * Enrique Sanchezmurillo
 * CST-150
 * Activity 11
 * 06 AUG 2022
 */
namespace Activity_11
{
    public partial class Form1 : Form
    {
        /*
         * Here I have declared static variables that I am going to use 
         * in my method, they are accessable by all methods in this class.
         */ 
        static int rollsCounted = 0;
        static Boolean snakeEyes;
        //I had to create one instance of random becase I kept getting the same #
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        //Event handler for the Roll Dice Button
        private void RollDiceButton_Click(object sender, EventArgs e)
        {
            //Declare face for both dice
            int diceFaceOne;
            int diceFaceTwo;
            //Here we invoke both methods to get the face value
                diceFaceOne = RollDiceOne();
                diceFaceTwo = RollDiceTwo();
            //Here we set the label to display the face values
            Dice1Label.Text = diceFaceOne.ToString();
            Dice2Label.Text = diceFaceTwo.ToString();
            //Here invoke our method to check for snake eyes.
                snakeEyes = checkSnakeEyes(diceFaceOne, diceFaceTwo);
            //Increments the rolls counter so we can display the quantity later
                rollsCounted++;
            //Below we have an if statement to handle the snake eyes being true.
            if (snakeEyes)
            {
                //We display how many rolls it took and also reset the values
                MessageBox.Show("It took you " + rollsCounted + " rolls to get snake eyes!");
                rollsCounted = 0;
                snakeEyes = false;
            }
        }
        //Method to create the Dice One Face value
        public int RollDiceOne()  {
            int diceFaceOne = random.Next(1,6);
            return diceFaceOne;
        }
        //Creates Dice Two Face Value
        public int RollDiceTwo() {
            int diceFaceTwo = random.Next(1,6);
            return diceFaceTwo;
        }
        //Checks to see if the snake eyes event is true and changes the boolean value
        public Boolean checkSnakeEyes(int diceFaceOne, int diceFaceTwo)
        {
            if (diceFaceOne == 1 && diceFaceTwo == 1)
            {
                return true;
            }
            else return false;
        }
        //Exit Button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

 }

