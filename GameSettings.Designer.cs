namespace Tic_tac_Toe
{
    partial class GameSettings
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
            this.panelBotColor = new System.Windows.Forms.Panel();
            this.labelGameTitleLine = new System.Windows.Forms.Label();
            this.labelGameSettingsTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotColor
            // 
            this.panelBotColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotColor.BackColor = System.Drawing.SystemColors.Control;
            this.panelBotColor.Controls.Add(this.label1);
            this.panelBotColor.Controls.Add(this.labelGameTitleLine);
            this.panelBotColor.Controls.Add(this.labelGameSettingsTitle);
            this.panelBotColor.Location = new System.Drawing.Point(1, 1);
            this.panelBotColor.Name = "panelBotColor";
            this.panelBotColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelBotColor.Size = new System.Drawing.Size(248, 428);
            this.panelBotColor.TabIndex = 0;
            // 
            // labelGameTitleLine
            // 
            this.labelGameTitleLine.AutoSize = true;
            this.labelGameTitleLine.Location = new System.Drawing.Point(48, 31);
            this.labelGameTitleLine.Name = "labelGameTitleLine";
            this.labelGameTitleLine.Size = new System.Drawing.Size(46, 17);
            this.labelGameTitleLine.TabIndex = 5;
            this.labelGameTitleLine.Text = "label1";
            // 
            // labelGameSettingsTitle
            // 
            this.labelGameSettingsTitle.AutoSize = true;
            this.labelGameSettingsTitle.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameSettingsTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelGameSettingsTitle.Location = new System.Drawing.Point(66, 5);
            this.labelGameSettingsTitle.Name = "labelGameSettingsTitle";
            this.labelGameSettingsTitle.Size = new System.Drawing.Size(132, 23);
            this.labelGameSettingsTitle.TabIndex = 4;
            this.labelGameSettingsTitle.Text = "Game Settings";
            this.labelGameSettingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(91, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Save";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(250, 430);
            this.Controls.Add(this.panelBotColor);
            this.Font = new System.Drawing.Font("Tw Cen MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameSettings";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            this.panelBotColor.ResumeLayout(false);
            this.panelBotColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotColor;
        private System.Windows.Forms.Label labelGameTitleLine;
        private System.Windows.Forms.Label labelGameSettingsTitle;
        private System.Windows.Forms.Label label1;
    }
}