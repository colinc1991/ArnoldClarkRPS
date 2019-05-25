namespace ArnoldClarkRPS
{
    partial class Form1
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
            this.listBoxPlayer = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPlayerTitle = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblOpponentScore = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblOpponentChoice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPlayer
            // 
            this.listBoxPlayer.FormattingEnabled = true;
            this.listBoxPlayer.ItemHeight = 17;
            this.listBoxPlayer.Items.AddRange(new object[] {
            "Rock",
            "Paper",
            "Scissors",
            "Lizard",
            "Spock"});
            this.listBoxPlayer.Location = new System.Drawing.Point(12, 50);
            this.listBoxPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxPlayer.Name = "listBoxPlayer";
            this.listBoxPlayer.Size = new System.Drawing.Size(139, 89);
            this.listBoxPlayer.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 147);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(139, 32);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lblPlayerTitle
            // 
            this.lblPlayerTitle.AutoSize = true;
            this.lblPlayerTitle.Location = new System.Drawing.Point(12, 14);
            this.lblPlayerTitle.Name = "lblPlayerTitle";
            this.lblPlayerTitle.Size = new System.Drawing.Size(133, 17);
            this.lblPlayerTitle.TabIndex = 2;
            this.lblPlayerTitle.Text = "Choose your gesture:";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(271, 14);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(93, 17);
            this.lblPlayerScore.TabIndex = 3;
            this.lblPlayerScore.Text = "Player score: 0";
            // 
            // lblOpponentScore
            // 
            this.lblOpponentScore.AutoSize = true;
            this.lblOpponentScore.Location = new System.Drawing.Point(271, 40);
            this.lblOpponentScore.Name = "lblOpponentScore";
            this.lblOpponentScore.Size = new System.Drawing.Size(117, 17);
            this.lblOpponentScore.TabIndex = 4;
            this.lblOpponentScore.Text = "Opponent score: 0";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(271, 175);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(93, 17);
            this.lblOutcome.TabIndex = 5;
            this.lblOutcome.Text = "Outcome label";
            // 
            // lblOpponentChoice
            // 
            this.lblOpponentChoice.AutoSize = true;
            this.lblOpponentChoice.Location = new System.Drawing.Point(271, 147);
            this.lblOpponentChoice.Name = "lblOpponentChoice";
            this.lblOpponentChoice.Size = new System.Drawing.Size(140, 17);
            this.lblOpponentChoice.TabIndex = 7;
            this.lblOpponentChoice.Text = "Opponent choice label";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 185);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 32);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 228);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblOpponentChoice);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblOpponentScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerTitle);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.listBoxPlayer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors Lizard Spock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblPlayerTitle;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblOpponentScore;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblOpponentChoice;
        private System.Windows.Forms.Button btnReset;
    }
}

