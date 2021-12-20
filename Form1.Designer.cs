
namespace HangmanApp
{
    partial class Hangman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.drawingArea = new System.Windows.Forms.Panel();
            this.letterPanel = new System.Windows.Forms.Panel();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.labelGuessWord = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.labelGuessLetter = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.progressBarScore = new System.Windows.Forms.ProgressBar();
            this.labelLongest = new System.Windows.Forms.Label();
            this.txtLongest = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelWinRate = new System.Windows.Forms.Label();
            this.txtWinRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Location = new System.Drawing.Point(25, 27);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(159, 322);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingArea_Paint);
            // 
            // letterPanel
            // 
            this.letterPanel.Location = new System.Drawing.Point(211, 49);
            this.letterPanel.Name = "letterPanel";
            this.letterPanel.Size = new System.Drawing.Size(141, 300);
            this.letterPanel.TabIndex = 1;
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrompt.ForeColor = System.Drawing.Color.White;
            this.labelPrompt.Location = new System.Drawing.Point(140, 396);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(100, 24);
            this.labelPrompt.TabIndex = 2;
            this.labelPrompt.Text = "prompt";
            // 
            // labelGuessWord
            // 
            this.labelGuessWord.AutoSize = true;
            this.labelGuessWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGuessWord.ForeColor = System.Drawing.Color.White;
            this.labelGuessWord.Location = new System.Drawing.Point(211, 359);
            this.labelGuessWord.Name = "labelGuessWord";
            this.labelGuessWord.Size = new System.Drawing.Size(94, 15);
            this.labelGuessWord.TabIndex = 3;
            this.labelGuessWord.Text = "Guess the word";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(307, 355);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 23);
            this.txtGuess.TabIndex = 4;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGuess.FlatAppearance.BorderSize = 0;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.Location = new System.Drawing.Point(413, 355);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.wordGuess);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.BackColor = System.Drawing.Color.DarkRed;
            this.btnGiveUp.FlatAppearance.BorderSize = 0;
            this.btnGiveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveUp.ForeColor = System.Drawing.Color.White;
            this.btnGiveUp.Location = new System.Drawing.Point(494, 355);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(75, 23);
            this.btnGiveUp.TabIndex = 6;
            this.btnGiveUp.Text = "Give up";
            this.btnGiveUp.UseVisualStyleBackColor = false;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // labelGuessLetter
            // 
            this.labelGuessLetter.AutoSize = true;
            this.labelGuessLetter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGuessLetter.ForeColor = System.Drawing.Color.White;
            this.labelGuessLetter.Location = new System.Drawing.Point(210, 27);
            this.labelGuessLetter.Name = "labelGuessLetter";
            this.labelGuessLetter.Size = new System.Drawing.Size(84, 15);
            this.labelGuessLetter.TabIndex = 7;
            this.labelGuessLetter.Text = "Guess a letter";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.White;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAgain.Location = new System.Drawing.Point(246, 396);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHighScore.ForeColor = System.Drawing.Color.White;
            this.labelHighScore.Location = new System.Drawing.Point(631, 49);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(68, 15);
            this.labelHighScore.TabIndex = 10;
            this.labelHighScore.Text = "Highest (0)";
            // 
            // progressBarScore
            // 
            this.progressBarScore.ForeColor = System.Drawing.Color.DarkGreen;
            this.progressBarScore.Location = new System.Drawing.Point(529, 49);
            this.progressBarScore.Maximum = 0;
            this.progressBarScore.Name = "progressBarScore";
            this.progressBarScore.Size = new System.Drawing.Size(100, 15);
            this.progressBarScore.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarScore.TabIndex = 13;
            // 
            // labelLongest
            // 
            this.labelLongest.AutoSize = true;
            this.labelLongest.BackColor = System.Drawing.Color.Black;
            this.labelLongest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLongest.ForeColor = System.Drawing.Color.White;
            this.labelLongest.Location = new System.Drawing.Point(438, 73);
            this.labelLongest.Name = "labelLongest";
            this.labelLongest.Size = new System.Drawing.Size(88, 15);
            this.labelLongest.TabIndex = 16;
            this.labelLongest.Text = "Longest guess:";
            // 
            // txtLongest
            // 
            this.txtLongest.BackColor = System.Drawing.Color.Black;
            this.txtLongest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLongest.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLongest.ForeColor = System.Drawing.Color.White;
            this.txtLongest.Location = new System.Drawing.Point(529, 73);
            this.txtLongest.Name = "txtLongest";
            this.txtLongest.ReadOnly = true;
            this.txtLongest.Size = new System.Drawing.Size(100, 16);
            this.txtLongest.TabIndex = 17;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(469, 49);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(57, 15);
            this.labelScore.TabIndex = 18;
            this.labelScore.Text = "Score (0)";
            // 
            // labelWinRate
            // 
            this.labelWinRate.AutoSize = true;
            this.labelWinRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWinRate.ForeColor = System.Drawing.Color.White;
            this.labelWinRate.Location = new System.Drawing.Point(447, 99);
            this.labelWinRate.Name = "labelWinRate";
            this.labelWinRate.Size = new System.Drawing.Size(79, 15);
            this.labelWinRate.TabIndex = 19;
            this.labelWinRate.Text = "Success rate:";
            // 
            // txtWinRate
            // 
            this.txtWinRate.BackColor = System.Drawing.Color.Black;
            this.txtWinRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWinRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtWinRate.ForeColor = System.Drawing.Color.White;
            this.txtWinRate.Location = new System.Drawing.Point(529, 98);
            this.txtWinRate.Name = "txtWinRate";
            this.txtWinRate.ReadOnly = true;
            this.txtWinRate.Size = new System.Drawing.Size(100, 16);
            this.txtWinRate.TabIndex = 20;
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.txtWinRate);
            this.Controls.Add(this.labelWinRate);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.txtLongest);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.labelGuessLetter);
            this.Controls.Add(this.labelLongest);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.labelGuessWord);
            this.Controls.Add(this.progressBarScore);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.letterPanel);
            this.Controls.Add(this.drawingArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingArea;
        private System.Windows.Forms.Label labelGuessLetter;
        private System.Windows.Forms.Panel letterPanel;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Label labelGuessWord;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.ProgressBar progressBarScore;
        private System.Windows.Forms.Label labelLongest;
        private System.Windows.Forms.TextBox txtLongest;
        private System.Windows.Forms.Label labelWinRate;
        private System.Windows.Forms.TextBox txtWinRate;
    }
}

