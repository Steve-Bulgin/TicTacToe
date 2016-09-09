
/* SBulginAssignment2.cs
 * Purpose: To build a Tic Tac Toe game using images from resources
 * 
 * Revision History
 *      Steven Bulgin, 2014.09.25: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBulginAssignment2
{
    public partial class TicTacToeForm : Form
    {
        //Variables
        string[,] wins = new string[3, 3]; //holds wins [cols, rows]
        int turnCount;
        bool turner = true; //Flips turns from x to o. x= true o = false
        char xo; // Puts an x or o into wins
        

        //My functions 

        /// <summary>
        /// Checks whether the game has been won
        /// </summary>
        private void winTester()
        {
            //Local Const
            const int WIN = 3;
            //Local variable
            bool winningGame = false;
            
            for (int i = 0; i < WIN; i++)
            {
                //columns
                if ((wins[i, 0] != null) && (wins[i, 0] == wins[i, 1]) && (wins[i, 1] == wins[i, 2]))
                {
                    MessageBox.Show(char.ToUpper(xo) + " Wins!");
                    winningGame = true;
                    finishDialog();
                }
                //rows
                else if ((wins[0, i] != null) && (wins[0, i] == wins[1, i]) && (wins[1, i] == wins[2, i]))
                {
                    MessageBox.Show(char.ToUpper(xo) + " Wins!");
                    winningGame = true;
                    finishDialog();
                }

            }

            if ((wins[0, 0] != null) && (wins[0, 0] == wins[1, 1]) && (wins[1, 1] == wins[2, 2]))
            {
                MessageBox.Show(char.ToUpper(xo) + " Wins!");
                winningGame = true;
                finishDialog();

            }
            else if ((wins[0, 2] != null) && (wins[0, 2] == wins[1, 1]) && (wins[1, 1] == wins[2, 0]))
            {
                MessageBox.Show(char.ToUpper(xo) + " Wins!");
                winningGame = true;
                finishDialog();
            }


            if ((turnCount == 9) && (winningGame == false))
            {
                MessageBox.Show("The game is a draw");
                finishDialog();
            }           
        }

        /// <summary>
        /// If a game has been completed prompts user to choose whether to play another game
        /// </summary>
        private void finishDialog()
        {
            DialogResult result = MessageBox.Show("Would you like to play another game?", 
                "Game Over!", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.No:
                    {
                        this.Close();
                        break;
                    }
                case DialogResult.Yes:
                    {
                        resetter();
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// Resets game to starting state
        /// </summary>
        private void resetter()
        {
            for (int i = 0; i < wins.GetLength(0); i++)
            {
                for (int j = 0; j < wins.GetLength(1); j++)
                {
                    wins[i, j] = null; 
                }
            }

            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                lbl.Image = null;
                lbl.Enabled = true;
            }

            turner = true;
            turnCount = 0;
        }

        //My Functions End

        /// <summary>
        /// Constructor for Tic Tac Toe Form
        /// </summary>
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for all squares on board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string labelName = lbl.Name.ToString();
            int col = -1;
            int row = -1;

            if (turner)
            {
                xo = 'x';
                lbl.Image = Properties.Resources.gameX;
            }
            else
            {
                xo = 'o';
                lbl.Image = Properties.Resources.gameO;
            }

            foreach (char c in labelName)
            {
                if (char.IsNumber(c))
                {
                    if (col < 0)
                    {
                        col = int.Parse(c.ToString());
                    }
                    else
                    {
                        row = int.Parse(c.ToString());
                    }
                }
            }

            wins[col, row] += xo;            
            turner = !turner;
            lbl.Enabled = false;
            turnCount++;
            winTester();
        }	
    }
}
