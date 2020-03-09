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
                labelGameTitleLine.Height = 2;
                labelGameTitleLine.Width = 165;
                labelGameTitleLine.BorderStyle = BorderStyle.None;
                labelGameTitleLine.BackColor = Color.DarkOrange;
            }

      

        private void label1_Click(object sender, EventArgs e)
        {
            //apply settings then Close

            this.Close();

        }
    }
}
