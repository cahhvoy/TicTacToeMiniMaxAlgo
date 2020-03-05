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
        public int playerXWins = 0;
        public int playerOWins = 0;
        public int playersDraw = 0;
        

        private void TictacToe_Load(object sender, EventArgs e)
        {
            // this is method a form calls during  loading
            //draw top line
                labelTopLine.AutoSize = false;
                labelTopLine.Text = "";
                labelTopLine.Height = 1;
                labelTopLine.Width = 380;
                labelTopLine.BorderStyle = BorderStyle.None;
                labelTopLine.BackColor = Color.DarkOliveGreen;

            //draw bottom line 
                label1.AutoSize = false;
                label1.Height = 1;
                label1.Width = 380;
                label1.BackColor = Color.Maroon;
                label1.BorderStyle = BorderStyle.None;

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
                if (CheckForAWin() == true)
                    {
                        if (button.Text == "X")
                            {
                                //CustomMsgBox msgBox = new CustomMsgBox();
                                //msgBox.ShowDialog();
                                //MessageBox.Show("Player X Wins");
                                playerXWins++;                        
                                labelXWinsVal.Text = playerXWins.ToString();
                                NewGame();
                            }
                        else
                            {
                                MessageBox.Show("Player O Wins");
                                playerOWins++;
                                labelOwinsVal.Text = playerOWins.ToString();
                                NewGame();                    
                            }
                    }
                if (CheckDraw() == true)
                    {
                        MessageBox.Show("Its A Draw");
                        playersDraw++;
                        labelDrawsVal.Text = playersDraw.ToString();                   
                        NewGame();
                   }
                //check if draw or win  every time a move is Made
                //if()
            
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

        bool CheckDraw()
        {
            if (turns == 9 && CheckForAWin()==false)
                {
                    return true;
                }
            else
                {
                    return false;
                }
        }

        bool CheckForAWin()
            {
              ///horizontal wins
                  if((A01.Text==A02.Text) && (A02.Text == A03.Text) && A01.Text !="")
                        {
                          return true;
                        }
                  else if((A11.Text==A12.Text) && (A12.Text == A13.Text) && A11.Text !="")
                        {
                          return true;
                        }
                  else if ((A21.Text == A22.Text) && (A22.Text == A23.Text) && A21.Text != "")
                        {
                            return true;
                        }
              ///vertical wins
                  else if((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                        {
                            return true;
                        }
                  else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                        {
                            return true;
                        }
                  else if((A03.Text == A13.Text) && (A13.Text == A23.Text) && A03.Text != "")
                        {
                            return true;
                        }
                   ///Diagonal wins
                  else if ((A01.Text == A12.Text) && (A12.Text == A23.Text) && A01.Text != "")
                        {
                            return true;
                        }
                  else if ((A03.Text == A12.Text) && (A12.Text == A21.Text) && A03.Text != "")
                        {
                            return true;
                        }
                  //else if ((A03.Text == A13.Text) && (A13.Text == A23.Text) && A03.Text != "")
                  //      {
                  //          return true;
                  //      }
                    else
                        {
                            return false;
                        }
                }
        private void buttonResetGame_Click(object sender, EventArgs e)
            {
                NewGame();
                
                labelXWinsVal.Text = "0";
                labelOwinsVal.Text = "0";
                labelDrawsVal.Text = "0";
                playerXWins = 0;
                playerOWins = 0;
                playersDraw = 0;
            }
    
    
    
    
    
    }
}
