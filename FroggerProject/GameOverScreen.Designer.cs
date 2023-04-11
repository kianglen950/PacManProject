namespace FroggerProject
{
    partial class GameOverScreen
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
            this.loseLabel = new System.Windows.Forms.Label();
            this.redoButton = new System.Windows.Forms.Button();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loseLabel
            // 
            this.loseLabel.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseLabel.ForeColor = System.Drawing.Color.Yellow;
            this.loseLabel.Location = new System.Drawing.Point(3, 92);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(581, 253);
            this.loseLabel.TabIndex = 0;
            this.loseLabel.Text = "Game Over! You Lose Try Again?";
            this.loseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // redoButton
            // 
            this.redoButton.BackColor = System.Drawing.Color.Black;
            this.redoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redoButton.ForeColor = System.Drawing.Color.Yellow;
            this.redoButton.Location = new System.Drawing.Point(105, 225);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(420, 107);
            this.redoButton.TabIndex = 1;
            this.redoButton.Text = "Play Again";
            this.redoButton.UseVisualStyleBackColor = false;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // exitButton2
            // 
            this.exitButton2.BackColor = System.Drawing.Color.Black;
            this.exitButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton2.ForeColor = System.Drawing.Color.Yellow;
            this.exitButton2.Location = new System.Drawing.Point(105, 399);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(420, 107);
            this.exitButton2.TabIndex = 2;
            this.exitButton2.Text = "Exit";
            this.exitButton2.UseVisualStyleBackColor = false;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.exitButton2);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.loseLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loseLabel;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button exitButton2;
    }
}
