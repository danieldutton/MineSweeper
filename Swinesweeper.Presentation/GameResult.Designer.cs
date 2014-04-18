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
            this._lblTimeTaken = new System.Windows.Forms.Label();
            this._lblTimeTakenValue = new System.Windows.Forms.Label();
            this._lblBestTime = new System.Windows.Forms.Label();
            this._lblBestTimeValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(14, 87);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 0;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // _btnPlayAgain
            // 
            this._btnPlayAgain.Location = new System.Drawing.Point(95, 87);
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
            this._lblResultsText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblResultsText.ForeColor = System.Drawing.Color.Maroon;
            this._lblResultsText.Location = new System.Drawing.Point(12, 13);
            this._lblResultsText.Name = "_lblResultsText";
            this._lblResultsText.Size = new System.Drawing.Size(29, 14);
            this._lblResultsText.TabIndex = 2;
            this._lblResultsText.Text = "test";
            // 
            // _lblTimeTaken
            // 
            this._lblTimeTaken.AutoSize = true;
            this._lblTimeTaken.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTimeTaken.ForeColor = System.Drawing.Color.Maroon;
            this._lblTimeTaken.Location = new System.Drawing.Point(11, 36);
            this._lblTimeTaken.Name = "_lblTimeTaken";
            this._lblTimeTaken.Size = new System.Drawing.Size(76, 14);
            this._lblTimeTaken.TabIndex = 3;
            this._lblTimeTaken.Text = "Time Taken:";
            // 
            // _lblTimeTakenValue
            // 
            this._lblTimeTakenValue.AutoSize = true;
            this._lblTimeTakenValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTimeTakenValue.ForeColor = System.Drawing.Color.Maroon;
            this._lblTimeTakenValue.Location = new System.Drawing.Point(92, 36);
            this._lblTimeTakenValue.Name = "_lblTimeTakenValue";
            this._lblTimeTakenValue.Size = new System.Drawing.Size(28, 14);
            this._lblTimeTakenValue.TabIndex = 4;
            this._lblTimeTakenValue.Text = "N/A";
            // 
            // _lblBestTime
            // 
            this._lblBestTime.AutoSize = true;
            this._lblBestTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblBestTime.ForeColor = System.Drawing.Color.Maroon;
            this._lblBestTime.Location = new System.Drawing.Point(12, 59);
            this._lblBestTime.Name = "_lblBestTime";
            this._lblBestTime.Size = new System.Drawing.Size(66, 14);
            this._lblBestTime.TabIndex = 3;
            this._lblBestTime.Text = "Best Time:";
            // 
            // _lblBestTimeValue
            // 
            this._lblBestTimeValue.AutoSize = true;
            this._lblBestTimeValue.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblBestTimeValue.ForeColor = System.Drawing.Color.Maroon;
            this._lblBestTimeValue.Location = new System.Drawing.Point(92, 59);
            this._lblBestTimeValue.Name = "_lblBestTimeValue";
            this._lblBestTimeValue.Size = new System.Drawing.Size(28, 14);
            this._lblBestTimeValue.TabIndex = 4;
            this._lblBestTimeValue.Text = "N/A";
            // 
            // GameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 122);
            this.Controls.Add(this._lblBestTimeValue);
            this.Controls.Add(this._lblTimeTakenValue);
            this.Controls.Add(this._lblBestTime);
            this.Controls.Add(this._lblTimeTaken);
            this.Controls.Add(this._lblResultsText);
            this.Controls.Add(this._btnPlayAgain);
            this.Controls.Add(this._btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label _lblTimeTaken;
        private System.Windows.Forms.Label _lblTimeTakenValue;
        private System.Windows.Forms.Label _lblBestTime;
        private System.Windows.Forms.Label _lblBestTimeValue;
    }
}