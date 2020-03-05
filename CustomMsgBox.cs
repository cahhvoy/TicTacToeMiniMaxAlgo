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
    public partial class CustomMsgBox : Form
    {
        public CustomMsgBox()
        {
            InitializeComponent();
        }

        private void CustomMsgBox_Load(object sender, EventArgs e)
            {
              //converting a label into a divider line 
                labelTopLine.AutoSize = false;
                labelTopLine.Text="";
                labelTopLine.Height = 1;
                labelTopLine.Width = 370;
                labelTopLine.BorderStyle = BorderStyle.None;
                labelTopLine.BackColor = Color.Orange;

            labelBotLine.AutoSize = false;
            labelBotLine.Text = "";
            labelBotLine.Height = 1;
            labelBotLine.Width = 300;
            labelBotLine.BorderStyle = BorderStyle.None;
            labelBotLine.BackColor = Color.Orange;
        }

       

        private void buttonClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
