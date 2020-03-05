using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_Toe
{
    public partial class TictacToe : Form
    {
        public TictacToe()
        {
            InitializeComponent();
        }

        public int currPlayer = 2;
        public int turns = 0; //Counting Turns
        
        //Counting wins for both Players and Draws
        public int playerX = 0;
        public int playerY = 0;
        public int playerDraw = 0;
        

        private void TictacToe_Load(object sender, EventArgs e)
        {
            // this is method a form calls during  loading

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (currPlayer % 2 == 0)
                {
                    button.Text = "X";
                    currPlayer++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    currPlayer++;
                    turns++;
                }
            }

        }

        private void buttonMouseHover(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // add a confirmation dialog box if clicked yes cobnfirm exit from the app 
            this.Close();
        }

        void NewGame()
        {
            currPlayer = 2;
            turns = 0;
            foreach( Control button in groupBoxGameBtns.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
                    button.Text = "";
                }
            }

        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        bool checkDraw()
        {
            if (turns == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
