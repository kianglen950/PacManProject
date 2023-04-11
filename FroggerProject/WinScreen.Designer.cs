namespace FroggerProject
{
    partial class WinScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.winLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.exitButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.Font = new System.Drawing.Font("Goudy Stout", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Yellow;
            this.winLabel.Location = new System.Drawing.Point(3, 75);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(594, 210);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "Game Over! You Win! Play Again?";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Black;
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.Color.Olive;
            this.playAgainButton.Location = new System.Drawing.Point(98, 194);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(410, 102);
            this.playAgainButton.TabIndex = 1;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // exitButton3
            // 
            this.exitButton3.BackColor = System.Drawing.Color.Black;
            this.exitButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton3.ForeColor = System.Drawing.Color.Olive;
            this.exitButton3.Location = new System.Drawing.Point(98, 355);
            this.exitButton3.Name = "exitButton3";
            this.exitButton3.Size = new System.Drawing.Size(410, 102);
            this.exitButton3.TabIndex = 2;
            this.exitButton3.Text = "Exit";
            this.exitButton3.UseVisualStyleBackColor = false;
            this.exitButton3.Click += new System.EventHandler(this.exitButton3_Click);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.exitButton3);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.winLabel);
            this.Name = "WinScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button exitButton3;
    }
}
