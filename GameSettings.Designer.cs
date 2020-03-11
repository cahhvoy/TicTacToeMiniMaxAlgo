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
            this.labelSet = new System.Windows.Forms.Label();
            this.labelCpuDivider = new System.Windows.Forms.Label();
            this.panelCpuRadios = new System.Windows.Forms.Panel();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonSmartLvl1 = new System.Windows.Forms.RadioButton();
            this.panelBotColor.SuspendLayout();
            this.panelCpuRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotColor
            // 
            this.panelBotColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotColor.BackColor = System.Drawing.SystemColors.Control;
            this.panelBotColor.Controls.Add(this.panelCpuRadios);
            this.panelBotColor.Controls.Add(this.labelCpuDivider);
            this.panelBotColor.Controls.Add(this.labelSet);
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
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.labelSet.ForeColor = System.Drawing.Color.Maroon;
            this.labelSet.Location = new System.Drawing.Point(32, 61);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(63, 16);
            this.labelSet.TabIndex = 10;
            this.labelSet.Text = "CPU Level";
            // 
            // labelCpuDivider
            // 
            this.labelCpuDivider.AutoSize = true;
            this.labelCpuDivider.Location = new System.Drawing.Point(11, 148);
            this.labelCpuDivider.Name = "labelCpuDivider";
            this.labelCpuDivider.Size = new System.Drawing.Size(46, 17);
            this.labelCpuDivider.TabIndex = 11;
            this.labelCpuDivider.Text = "label1";
            // 
            // panelCpuRadios
            // 
            this.panelCpuRadios.Controls.Add(this.radioButtonRandom);
            this.panelCpuRadios.Controls.Add(this.radioButtonSmartLvl1);
            this.panelCpuRadios.Location = new System.Drawing.Point(8, 78);
            this.panelCpuRadios.Name = "panelCpuRadios";
            this.panelCpuRadios.Size = new System.Drawing.Size(234, 65);
            this.panelCpuRadios.TabIndex = 13;
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRandom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButtonRandom.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioButtonRandom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonRandom.Location = new System.Drawing.Point(48, 4);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonRandom.Size = new System.Drawing.Size(156, 25);
            this.radioButtonRandom.TabIndex = 11;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Random Moves    :";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.radioButtonRandom_CheckedChanged);
            // 
            // radioButtonSmartLvl1
            // 
            this.radioButtonSmartLvl1.AutoSize = true;
            this.radioButtonSmartLvl1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonSmartLvl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radioButtonSmartLvl1.ForeColor = System.Drawing.Color.DarkGreen;
            this.radioButtonSmartLvl1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonSmartLvl1.Location = new System.Drawing.Point(48, 36);
            this.radioButtonSmartLvl1.Name = "radioButtonSmartLvl1";
            this.radioButtonSmartLvl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonSmartLvl1.Size = new System.Drawing.Size(158, 25);
            this.radioButtonSmartLvl1.TabIndex = 10;
            this.radioButtonSmartLvl1.TabStop = true;
            this.radioButtonSmartLvl1.Text = "Smart  Level 1       :";
            this.radioButtonSmartLvl1.UseVisualStyleBackColor = true;
            this.radioButtonSmartLvl1.CheckedChanged += new System.EventHandler(this.radioButtonSmartLvl1_CheckedChanged);
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
            this.panelCpuRadios.ResumeLayout(false);
            this.panelCpuRadios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotColor;
        private System.Windows.Forms.Label labelGameTitleLine;
        private System.Windows.Forms.Label labelGameSettingsTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSet;
        private System.Windows.Forms.Label labelCpuDivider;
        private System.Windows.Forms.Panel panelCpuRadios;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonSmartLvl1;
    }
}