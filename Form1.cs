using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace HangmanApp
{
    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
        }

        List<string> words = new List<string>();
        string word, prompt;
        int wrongGuesses, score, highScore, roundsWon, roundsPlayed = 0;
        string longestWord = "";

        private void Hangman_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../../../assets/words.txt");

            words = sr.ReadToEnd().Split("\r\n").ToList();
            sr.Close();
            generatePrompt();

            // generate letter picker
            int width = letterPanel.Width / 4;
            int height = letterPanel.Height / 7;
            for (int i = 0; i < 26; i++)
            {
                Button btnLetter = new Button();
                btnLetter.SetBounds(i % 4 * width, i / 4 * height, width - 5, height - 5);
                btnLetter.FlatStyle = FlatStyle.Flat;
                btnLetter.FlatAppearance.BorderSize = 0;
                btnLetter.BackColor = Color.White;
                btnLetter.Text = $"&{ (char)('a' + i) }";
                btnLetter.Click += new System.EventHandler(letterGuess);

                letterPanel.Controls.Add(btnLetter);
            }
        }

        void generatePrompt()
        {
            Random r = new Random();
            word = words[r.Next(0, words.Count)];

            prompt = "";
            for (int i = 0; i < word.Length; i++) prompt += "_ ";
            labelPrompt.Text = prompt;
        }

        void disableLetterBtn(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(180, 255, 255, 255);
        }

        void letterGuess(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            disableLetterBtn(btn);

            char letter = btn.Text[1];
            if (word.Contains(letter))
            {
                string prevPrompt = prompt;
                prompt = "";
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter) prompt += letter + " ";
                    else prompt += prevPrompt[i * 2] + " ";
                }
                if (!prompt.Contains('_')) endGame(true);
            }
            else
            {
                wrongGuesses++;
                drawingArea.Invalidate();
            }

            labelPrompt.Text = prompt;
        }

        private void wordGuess(object sender, EventArgs e)
        {
            if (txtGuess.Text.ToLower() == word) endGame(true);
            else
            {
                wrongGuesses++;
                drawingArea.Invalidate();
            }
            labelPrompt.Focus();
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            wrongGuesses = 6; // way to indicate the game is over
            drawingArea.Invalidate();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            words.Remove(word);
            generatePrompt();

            foreach (Button btn in letterPanel.Controls)
            {
                btn.Enabled = true;
                btn.BackColor = Color.White;
            }

            txtGuess.Text = "";
            txtGuess.ReadOnly = false;
            btnGuess.Enabled = true;
            btnGiveUp.Enabled = true;
            btnPlayAgain.Visible = false;
            labelPrompt.ForeColor = Color.White;

            wrongGuesses = 0;
            drawingArea.Invalidate();

            labelPrompt.Focus();
        }

        void endGame(bool won)
        {
            prompt = "";
            for (int i = 0; i < word.Length; i++) prompt += word[i] + " ";
            labelPrompt.Text = prompt;
            labelPrompt.ForeColor = won ? Color.DarkGreen : Color.DarkRed;

            score = won ? score + word.Length : 0;

            labelScore.Text = $"Score ({score})";
            labelScore.Location = new Point(
                progressBarScore.Location.X - labelScore.Width, labelScore.Location.Y);

            try
            {
                progressBarScore.Value = score;
            }
            catch
            {
                progressBarScore.Maximum = score;
                progressBarScore.Value = score;
            }

            if (score > highScore)
            {
                highScore = score;
                labelHighScore.Text = $"Highest ({highScore})";
                progressBarScore.Maximum = highScore;
            }

            if (won && word.Length > longestWord.Length)
            {
                longestWord = word;
                txtLongest.Text = $"{longestWord} ({longestWord.Length})";
            }

            if (won) roundsWon++;
            roundsPlayed++;
            txtWinRate.Text = $"{Math.Round((float)roundsWon / (float)roundsPlayed * 100)}%";

            foreach (Button btn in letterPanel.Controls) disableLetterBtn(btn);

            txtGuess.Text = "";
            txtGuess.ReadOnly = true;
            btnGuess.Enabled = false;
            btnGiveUp.Enabled = false;
            btnPlayAgain.Visible = true;
            btnPlayAgain.Location = new Point(labelPrompt.Location.X +
                labelPrompt.Width + 10, labelPrompt.Location.Y);
            btnPlayAgain.Focus();
        }

        private void drawingArea_Paint(object sender, PaintEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("../../../assets/drawSound.wav");
            sp.Play();

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen p = new Pen(Color.White, 2);

            g.DrawLine(p, new Point(0, 292), new Point(120, 292));
            g.DrawLine(p, new Point(30, 292), new Point(30, 50));
            g.DrawLine(p, new Point(30, 50), new Point(120, 50));
            g.DrawLine(p, new Point(120, 50), new Point(120, 80));

            p = new Pen(Color.Orange, 3);

            if (wrongGuesses > 0) g.DrawEllipse(p, 100, 80, 40, 40);
            if (wrongGuesses > 1) g.DrawLine(p, new Point(120, 120), new Point(120, 200));
            if (wrongGuesses > 2) g.DrawLine(p, new Point(120, 140), new Point(150, 170));
            if (wrongGuesses > 3) g.DrawLine(p, new Point(120, 140), new Point(90, 170));
            if (wrongGuesses > 4) g.DrawLine(p, new Point(120, 200), new Point(150, 230));
            if (wrongGuesses > 5)
            {
                g.DrawLine(p, new Point(120, 200), new Point(90, 230));
                endGame(false);
            }
        }
    }
}