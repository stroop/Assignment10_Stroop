namespace Assignment10_Stroop
{
    partial class GuessANumber
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
            this.guessBtn = new System.Windows.Forms.Button();
            this.nextGuessBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hintPromptLbl = new System.Windows.Forms.Label();
            this.hintLbl = new System.Windows.Forms.Label();
            this.incorrectLbl = new System.Windows.Forms.Label();
            this.correctLbl = new System.Windows.Forms.Label();
            this.playerGuessTxt = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.correctNumberLbl = new System.Windows.Forms.Label();
            this.correctCountLbl = new System.Windows.Forms.Label();
            this.incorrectCountLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessBtn
            // 
            this.guessBtn.Location = new System.Drawing.Point(28, 80);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(75, 23);
            this.guessBtn.TabIndex = 0;
            this.guessBtn.Text = "Guess";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // nextGuessBtn
            // 
            this.nextGuessBtn.Enabled = false;
            this.nextGuessBtn.Location = new System.Drawing.Point(28, 124);
            this.nextGuessBtn.Name = "nextGuessBtn";
            this.nextGuessBtn.Size = new System.Drawing.Size(75, 23);
            this.nextGuessBtn.TabIndex = 1;
            this.nextGuessBtn.Text = "Next Guess";
            this.nextGuessBtn.UseVisualStyleBackColor = true;
            this.nextGuessBtn.Click += new System.EventHandler(this.nextGuessBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(28, 221);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(183, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit Guess A Number";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hintPromptLbl
            // 
            this.hintPromptLbl.AutoSize = true;
            this.hintPromptLbl.Location = new System.Drawing.Point(25, 172);
            this.hintPromptLbl.Name = "hintPromptLbl";
            this.hintPromptLbl.Size = new System.Drawing.Size(186, 13);
            this.hintPromptLbl.TabIndex = 3;
            this.hintPromptLbl.Text = "Place your mouse over here for a hint!";
            this.hintPromptLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hintPromptLbl.MouseHover += new System.EventHandler(this.hintPromptLbl_MouseHover);
            // 
            // hintLbl
            // 
            this.hintLbl.Location = new System.Drawing.Point(25, 195);
            this.hintLbl.Name = "hintLbl";
            this.hintLbl.Size = new System.Drawing.Size(186, 13);
            this.hintLbl.TabIndex = 4;
            this.hintLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incorrectLbl
            // 
            this.incorrectLbl.AutoSize = true;
            this.incorrectLbl.Location = new System.Drawing.Point(133, 135);
            this.incorrectLbl.Name = "incorrectLbl";
            this.incorrectLbl.Size = new System.Drawing.Size(52, 13);
            this.incorrectLbl.TabIndex = 5;
            this.incorrectLbl.Text = "Incorrect:";
            // 
            // correctLbl
            // 
            this.correctLbl.AutoSize = true;
            this.correctLbl.Location = new System.Drawing.Point(133, 116);
            this.correctLbl.Name = "correctLbl";
            this.correctLbl.Size = new System.Drawing.Size(44, 13);
            this.correctLbl.TabIndex = 6;
            this.correctLbl.Text = "Correct:";
            // 
            // playerGuessTxt
            // 
            this.playerGuessTxt.Location = new System.Drawing.Point(136, 82);
            this.playerGuessTxt.Name = "playerGuessTxt";
            this.playerGuessTxt.Size = new System.Drawing.Size(75, 20);
            this.playerGuessTxt.TabIndex = 7;
            this.playerGuessTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusLbl
            // 
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(28, 18);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(183, 23);
            this.statusLbl.TabIndex = 8;
            this.statusLbl.Text = "Guess A Number!";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctNumberLbl
            // 
            this.correctNumberLbl.Location = new System.Drawing.Point(28, 45);
            this.correctNumberLbl.Name = "correctNumberLbl";
            this.correctNumberLbl.Size = new System.Drawing.Size(183, 23);
            this.correctNumberLbl.TabIndex = 9;
            this.correctNumberLbl.Text = "Guess a number between 1 and 100";
            this.correctNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctCountLbl
            // 
            this.correctCountLbl.AutoSize = true;
            this.correctCountLbl.Location = new System.Drawing.Point(198, 116);
            this.correctCountLbl.Name = "correctCountLbl";
            this.correctCountLbl.Size = new System.Drawing.Size(13, 13);
            this.correctCountLbl.TabIndex = 10;
            this.correctCountLbl.Text = "0";
            this.correctCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // incorrectCountLbl
            // 
            this.incorrectCountLbl.AutoSize = true;
            this.incorrectCountLbl.Location = new System.Drawing.Point(198, 135);
            this.incorrectCountLbl.Name = "incorrectCountLbl";
            this.incorrectCountLbl.Size = new System.Drawing.Size(13, 13);
            this.incorrectCountLbl.TabIndex = 11;
            this.incorrectCountLbl.Text = "0";
            this.incorrectCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GuessANumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 261);
            this.Controls.Add(this.incorrectCountLbl);
            this.Controls.Add(this.correctCountLbl);
            this.Controls.Add(this.correctNumberLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.playerGuessTxt);
            this.Controls.Add(this.correctLbl);
            this.Controls.Add(this.incorrectLbl);
            this.Controls.Add(this.hintLbl);
            this.Controls.Add(this.hintPromptLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.nextGuessBtn);
            this.Controls.Add(this.guessBtn);
            this.Name = "GuessANumber";
            this.Text = "Guess A Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Button nextGuessBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label hintPromptLbl;
        private System.Windows.Forms.Label hintLbl;
        private System.Windows.Forms.Label incorrectLbl;
        private System.Windows.Forms.Label correctLbl;
        private System.Windows.Forms.TextBox playerGuessTxt;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label correctNumberLbl;
        private System.Windows.Forms.Label correctCountLbl;
        private System.Windows.Forms.Label incorrectCountLbl;
    }
}

