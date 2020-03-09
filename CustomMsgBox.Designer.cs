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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTopLine = new System.Windows.Forms.Label();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.panelCustomMsgBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCustomMsgBox
            // 
            this.panelCustomMsgBox.BackColor = System.Drawing.SystemColors.Control;
            this.panelCustomMsgBox.Controls.Add(this.labelBotLine);
            this.panelCustomMsgBox.Controls.Add(this.buttonClose);
            this.panelCustomMsgBox.Controls.Add(this.labelTopLine);
            this.panelCustomMsgBox.Location = new System.Drawing.Point(2, 2);
            this.panelCustomMsgBox.Name = "panelCustomMsgBox";
            this.panelCustomMsgBox.Size = new System.Drawing.Size(446, 259);
            this.panelCustomMsgBox.TabIndex = 0;
            // 
            // labelBotLine
            // 
            this.labelBotLine.AutoSize = true;
            this.labelBotLine.Location = new System.Drawing.Point(86, 158);
            this.labelBotLine.Name = "labelBotLine";
            this.labelBotLine.Size = new System.Drawing.Size(65, 28);
            this.labelBotLine.TabIndex = 5;
            this.labelBotLine.Text = "label1";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClose.Location = new System.Drawing.Point(187, 188);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(72, 34);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "O.K";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            // panelDivider
            // 
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelDivider.Location = new System.Drawing.Point(0, 260);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(450, 10);
            this.panelDivider.TabIndex = 6;
            // 
            // CustomMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 270);
            this.Controls.Add(this.panelDivider);
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
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTopLine;
        private System.Windows.Forms.Panel panelDivider;
    }
}