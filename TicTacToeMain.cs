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
        public int playerCpuWins = 0;
        public int playersDraw = 0;

        public bool myTurn = true;
        //if true i play if false CPU plays

        public int CpuLevel = 2;
            //1 dumb =random moves
            //2 lil intelligent 
        

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
                    if (myTurn == true)
                        {
                            button.Text = "X";
                        }
                    else
                        {
                            button.Text = "O";
                        }
                    turns++;
                    myTurn = !myTurn;
                }
               
            //check if draw or win  every time a move is Made
                if (CheckForAWin() == true)
                        {
                            if (myTurn == false)
                                {
                                    MessageBox.Show("You Win");
                                    playerXWins++;                        
                                    labelHumanWinsVal.Text = playerXWins.ToString();
                                    NewGame();
                                }
                            else
                                {
                                    MessageBox.Show("Computer Wins");
                                    playerCpuWins++;
                                    labelCpuWinsVal.Text = playerCpuWins.ToString();
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


                if (myTurn == false)
                    {
                      CpuPlayer().PerformClick();
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
            myTurn = true;
            turns = 0;
            foreach( Control button in groupBoxGameBtns.Controls)
                {
                    if (button.GetType() == typeof(Button))
                        {
                            button.Text = "";
                        }
                }
            Highlight_Highest_Score();

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
                
                labelHumanWinsVal.Text = "0";
                labelCpuWinsVal.Text = "0";
                labelDrawsVal.Text = "0";
                playerXWins = 0;
                playerCpuWins = 0;
                playersDraw = 0;
            }
        
        //method for CPU to Try Win Block Or Defend
        public Button CpuTryWinOrDefend(string S)
        {
            Button btn = null;
            //horizontal checks
            //top line
            if (A01.Text == A02.Text && A02.Text == S && A03.Text == "")
                return A03;
            else if (A01.Text == A03.Text && A03.Text == S && A02.Text == "")
                return A02;
            else if (A02.Text == A03.Text && A03.Text == S && A01.Text == "")
                return A01;
            //2nd line
            else if (A11.Text == A12.Text && A12.Text == S && A13.Text == "")
                return A13;
            else if (A11.Text == A13.Text && A13.Text == S && A12.Text == "")
                return A12;
            else if (A12.Text == A13.Text && A13.Text == S && A11.Text == "")
                return A01;
            //3rd Line
            else if (A21.Text == A22.Text && A22.Text == S && A23.Text == "")
                return A23;
            else if (A21.Text == A23.Text && A23.Text == S && A22.Text == "")
                return A02;
            else if (A22.Text == A23.Text && A23.Text == S && A21.Text == "")
                return A21;
            //verical checks
            //1st Vert Line 
            else if (A01.Text == A11.Text && A11.Text == S && A21.Text == "")
                return A21;
            else if (A01.Text == A21.Text && A21.Text == S && A11.Text == "")
                return A11;
            else if (A11.Text == A21.Text && A21.Text == S && A01.Text == "")
                return A01;
            //2nd Vert' Line 
            else if (A02.Text == A12.Text && A12.Text == S && A22.Text == "")
                return A22;
            else if (A02.Text == A22.Text && A22.Text == S && A12.Text == "")
                return A12;
            else if (A12.Text == A22.Text && A22.Text == S && A02.Text == "")
                return A02;
            //3rd Vert' Line 
            else if (A03.Text == A13.Text && A13.Text == S && A23.Text == "")
                return A23;
            else if (A03.Text == A23.Text && A23.Text == S && A13.Text == "")
                return A13;
            else if (A13.Text == A23.Text && A23.Text == S && A03.Text == "")
                return A03;
            //Diagonal Checks
            //1st Diag' Line 
            else if (A01.Text == A12.Text && A12.Text == S && A23.Text == "")
                return A23;
            else if (A01.Text == A23.Text && A23.Text == S && A12.Text == "")
                return A12;
            else if (A12.Text == A23.Text && A23.Text == S && A01.Text == "")
                return A01;
            //2dn Diag' Line 
            else if (A03.Text == A12.Text && A12.Text == S && A21.Text == "")
                return A21;
            else if (A03.Text == A21.Text && A21.Text == S && A12.Text == "")
                return A12;
            else if (A23.Text == A12.Text && A12.Text == S && A03.Text == "")
                return A03;



            else
            return null;
        }
        
        //Method For Cpu to Make Random Move If No Move Provides a Win
        public Button CpuRandomMove()
            {
                Button b = null;
                     foreach( Control button in groupBoxGameBtns.Controls)
                        {
                            if (button.GetType() == typeof(Button))
                                {
                                    b = button as Button;
                                        if (b != null)
                                            {
                                                if (b.Text == "")
                                                    {
                                                        return b;
                                                    }
                                        }

                                }

                        }

            return b;
            }

        public Button CpuPlayer()
            {
                Button PcMove = null;
                if (CpuLevel == 2)
                    {
                        PcMove = CpuTryWinOrDefend("O");
                        if (PcMove != null)
                            {
                                return PcMove;
                            }
                        else
                        {
                            PcMove = CpuTryWinOrDefend("X");
                            if (PcMove != null)
                                {
                                    return PcMove;
                                }
                            else
                                {
                                    return CpuRandomMove();
                                }
                        }
                    }
                else
                    {
                        return CpuRandomMove();
                    }
            
            }

        void Highlight_Highest_Score()
            {            
                if (playerXWins != 0 || playerCpuWins != 0 || playersDraw != 0)
                    {
                        //string[] cntrls = {"labelHumanWins", "labelHumanWinsVal", "labelCpuwins", "labelCpuWinsVal", "labelDrawS", "labelDrawsVal"};
                        //foreach (var c in cntrls)
                        //    {                       
                        //    }

                        labelHumanWins.ForeColor = Color.Gray;
                        labelHumanWinsVal.ForeColor = Color.DarkGreen;
                        labelCpuwins.ForeColor = Color.Gray;
                        labelCpuWinsVal.ForeColor = Color.DarkGreen;
                        labelDrawS.ForeColor = Color.Gray;
                        labelDrawsVal.ForeColor = Color.DarkGreen;

                      if(playerXWins> playerCpuWins)
                        {
                            labelHumanWins.ForeColor = Color.Maroon;
                            labelHumanWinsVal.ForeColor = Color.Maroon;
                        }
                      else if (playerCpuWins>playerXWins)
                        {
                            labelCpuwins.ForeColor = Color.Maroon;
                            labelCpuWinsVal.ForeColor = Color.Maroon;
                        }
                      else  if (playersDraw > playerXWins && playersDraw > playerCpuWins)
                        {
                            labelDrawS.ForeColor = Color.Maroon;
                            labelDrawsVal.ForeColor = Color.Maroon;
                        }

            }
        }

        private void labelGameSettings_Click(object sender, EventArgs e)
        {
            // show pop up with different settings to Select
            GameSettings Settings = new GameSettings();
            Settings.ShowDialog();
        }
    }
}
