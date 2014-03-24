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
            this._lblResultsText = new System.Windows.Forms.Label();
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
            // _lblResultsText
            // 
            this._lblResultsText.AutoSize = true;
            this._lblResultsText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblResultsText.ForeColor = System.Drawing.Color.Maroon;
            this._lblResultsText.Location = new System.Drawing.Point(12, 13);
            this._lblResultsText.Name = "_lblResultsText";
            this._lblResultsText.Size = new System.Drawing.Size(11, 13);
            this._lblResultsText.TabIndex = 2;
            this._lblResultsText.Text = "-";
            // 
            // GameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 77);
            this.Controls.Add(this._lblResultsText);
            this.Controls.Add(this._btnPlayAgain);
            this.Controls.Add(this._btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(208, 115);
            this.MinimumSize = new System.Drawing.Size(208, 115);
            this.Name = "GameResult";
            this.Text = "Results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameResult_FormClosing);
            this.Load += new System.EventHandler(this.GameResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Button _btnPlayAgain;
        private System.Windows.Forms.Label _lblResultsText;
    }
}