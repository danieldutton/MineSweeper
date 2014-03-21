namespace Swinesweeper.Presentation
{
    partial class GameResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameResult));
            this._btnExit = new System.Windows.Forms.Button();
            this._btnPlayAgain = new System.Windows.Forms.Button();
            this._lblYouWonText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(12, 45);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 0;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // _btnPlayAgain
            // 
            this._btnPlayAgain.Location = new System.Drawing.Point(93, 45);
            this._btnPlayAgain.Name = "_btnPlayAgain";
            this._btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this._btnPlayAgain.TabIndex = 1;
            this._btnPlayAgain.Text = "Play Again";
            this._btnPlayAgain.UseVisualStyleBackColor = true;
            this._btnPlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // _lblYouWonText
            // 
            this._lblYouWonText.AutoSize = true;
            this._lblYouWonText.Location = new System.Drawing.Point(12, 13);
            this._lblYouWonText.Name = "_lblYouWonText";
            this._lblYouWonText.Size = new System.Drawing.Size(126, 13);
            this._lblYouWonText.TabIndex = 2;
            this._lblYouWonText.Text = "Congratulations you won!";
            // 
            // GameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 77);
            this.Controls.Add(this._lblYouWonText);
            this.Controls.Add(this._btnPlayAgain);
            this.Controls.Add(this._btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameResult";
            this.Text = "GameWon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameResult_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnPlayAgain;
        private System.Windows.Forms.Label _lblYouWonText;
    }
}