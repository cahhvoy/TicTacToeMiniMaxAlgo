namespace Tic_tac_Toe
{
    partial class CustomMsgBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCustomMsgBox = new System.Windows.Forms.Panel();
            this.labelBotLine = new System.Windows.Forms.Label();
            this.labelTopLine = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWinner = new System.Windows.Forms.Label();
            this.panelCustomMsgBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCustomMsgBox
            // 
            this.panelCustomMsgBox.BackColor = System.Drawing.SystemColors.Control;
            this.panelCustomMsgBox.Controls.Add(this.labelWinner);
            this.panelCustomMsgBox.Controls.Add(this.label1);
            this.panelCustomMsgBox.Controls.Add(this.labelClose);
            this.panelCustomMsgBox.Controls.Add(this.labelBotLine);
            this.panelCustomMsgBox.Controls.Add(this.labelTopLine);
            this.panelCustomMsgBox.Location = new System.Drawing.Point(1, 1);
            this.panelCustomMsgBox.Name = "panelCustomMsgBox";
            this.panelCustomMsgBox.Size = new System.Drawing.Size(448, 268);
            this.panelCustomMsgBox.TabIndex = 0;
            // 
            // labelBotLine
            // 
            this.labelBotLine.AutoSize = true;
            this.labelBotLine.Location = new System.Drawing.Point(86, 211);
            this.labelBotLine.Name = "labelBotLine";
            this.labelBotLine.Size = new System.Drawing.Size(65, 28);
            this.labelBotLine.TabIndex = 5;
            this.labelBotLine.Text = "label1";
            // 
            // labelTopLine
            // 
            this.labelTopLine.AutoSize = true;
            this.labelTopLine.Location = new System.Drawing.Point(33, 24);
            this.labelTopLine.Name = "labelTopLine";
            this.labelTopLine.Size = new System.Drawing.Size(65, 28);
            this.labelTopLine.TabIndex = 3;
            this.labelTopLine.Text = "label1";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Tw Cen MT", 20F, System.Drawing.FontStyle.Bold);
            this.labelClose.ForeColor = System.Drawing.Color.Green;
            this.labelClose.Location = new System.Drawing.Point(195, 232);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(58, 31);
            this.labelClose.TabIndex = 6;
            this.labelClose.Text = "O.K";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.label1.Location = new System.Drawing.Point(73, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Winner  :  ";
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Font = new System.Drawing.Font("Tw Cen MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelWinner.Location = new System.Drawing.Point(192, 74);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(85, 31);
            this.labelWinner.TabIndex = 8;
            this.labelWinner.Text = "label1";
            // 
            // CustomMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(450, 270);
            this.Controls.Add(this.panelCustomMsgBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CustomMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMsgBox";
            this.Load += new System.EventHandler(this.CustomMsgBox_Load);
            this.panelCustomMsgBox.ResumeLayout(false);
            this.panelCustomMsgBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCustomMsgBox;
        private System.Windows.Forms.Label labelBotLine;
        private System.Windows.Forms.Label labelTopLine;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Label label1;
    }
}