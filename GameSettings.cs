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
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        private void GameSettings_Load(object sender, EventArgs e)
            {
                labelGameTitleLine.AutoSize = false;
                labelGameTitleLine.Text = "";
                labelGameTitleLine.Height = 1;
                labelGameTitleLine.Width = 165;
                labelGameTitleLine.BorderStyle = BorderStyle.None;
                labelGameTitleLine.BackColor = Color.DarkOrange;
           
                labelCpuDivider.AutoSize = false;
                labelCpuDivider.Text = "";
                labelCpuDivider.Height = 1;
                labelCpuDivider.Width = 225;
                labelCpuDivider.BorderStyle = BorderStyle.None;
                labelCpuDivider.BackColor = Color.DimGray;

                labelPlayerDivider.AutoSize = false;
                labelPlayerDivider.Text = "";
                labelPlayerDivider.Height = 1;
                labelPlayerDivider.Width = 225;
                labelPlayerDivider.BorderStyle = BorderStyle.None;
                labelCpuDivider.BackColor = Color.DimGray;
            
            
               int selected = TictacToe.CpuLevel;
                 if (selected == 1)
                    {
                        radioButtonRandom.Checked = true;
                    }
                 else if (selected == 2)
                    {
                        radioButtonSmartLvl1.Checked = true;
                    }


        }



        private void label1_Click(object sender, EventArgs e)
        {
            //apply settings then Close



            this.Close();

        }

        private void radioButtonRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRandom.Checked == true)
                {
                    TictacToe.CpuLevel = 1;
                    TictacToe.CpuLevelStr = "Random Moves";
                }
        }

        private void radioButtonSmartLvl1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSmartLvl1.Checked == true)
                {
                    TictacToe.CpuLevel = 2;
                    TictacToe.CpuLevelStr = "Smart Cpu {1}";
                }
        }
    }
}
