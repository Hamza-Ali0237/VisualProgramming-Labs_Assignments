namespace HangmanGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.lblGuessLeft = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.txtGuessBox = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.picGuess = new System.Windows.Forms.PictureBox();
            this.txtGuessed = new System.Windows.Forms.TextBox();
            this.txtGuessesLeft = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(53, 100);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(83, 15);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess a Letter!";
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Location = new System.Drawing.Point(45, 146);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(92, 15);
            this.lblGuessed.TabIndex = 1;
            this.lblGuessed.Text = "Guessed Letters:";
            // 
            // lblGuessLeft
            // 
            this.lblGuessLeft.AutoSize = true;
            this.lblGuessLeft.Location = new System.Drawing.Point(53, 188);
            this.lblGuessLeft.Name = "lblGuessLeft";
            this.lblGuessLeft.Size = new System.Drawing.Size(75, 15);
            this.lblGuessLeft.TabIndex = 2;
            this.lblGuessLeft.Text = "Guesses Left:";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(172, 233);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(107, 15);
            this.lblRandom.TabIndex = 3;
            this.lblRandom.Text = "_ _ l _ _ _ _ _ a _ _ _ _";
            // 
            // txtGuessBox
            // 
            this.txtGuessBox.Location = new System.Drawing.Point(97, 284);
            this.txtGuessBox.MaxLength = 1;
            this.txtGuessBox.Name = "txtGuessBox";
            this.txtGuessBox.Size = new System.Drawing.Size(31, 23);
            this.txtGuessBox.TabIndex = 4;
            this.txtGuessBox.TextChanged += new System.EventHandler(this.txtGuessBox_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(172, 284);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(107, 23);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Guess Letter!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // picGuess
            // 
            this.picGuess.Image = global::HangmanGame.Properties.Resources.hangman0;
            this.picGuess.Location = new System.Drawing.Point(371, 100);
            this.picGuess.Name = "picGuess";
            this.picGuess.Size = new System.Drawing.Size(166, 148);
            this.picGuess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGuess.TabIndex = 6;
            this.picGuess.TabStop = false;
            this.picGuess.Click += new System.EventHandler(this.picGuess_Click);
            // 
            // txtGuessed
            // 
            this.txtGuessed.Location = new System.Drawing.Point(159, 143);
            this.txtGuessed.Name = "txtGuessed";
            this.txtGuessed.ReadOnly = true;
            this.txtGuessed.Size = new System.Drawing.Size(100, 23);
            this.txtGuessed.TabIndex = 7;
            // 
            // txtGuessesLeft
            // 
            this.txtGuessesLeft.Location = new System.Drawing.Point(159, 185);
            this.txtGuessesLeft.Name = "txtGuessesLeft";
            this.txtGuessesLeft.ReadOnly = true;
            this.txtGuessesLeft.Size = new System.Drawing.Size(100, 23);
            this.txtGuessesLeft.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.txtGuessesLeft);
            this.Controls.Add(this.txtGuessed);
            this.Controls.Add(this.picGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuessBox);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.lblGuessLeft);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.lblGuess);
            this.Name = "Form1";
            this.Text = "HangMan";
            ((System.ComponentModel.ISupportInitialize)(this.picGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGuess;
        private Label lblGuessed;
        private Label lblGuessLeft;
        private Label lblRandom;
        private TextBox txtGuessBox;
        private Button btnGuess;
        private PictureBox picGuess;
        private TextBox txtGuessed;
        private TextBox txtGuessesLeft;
    }
}