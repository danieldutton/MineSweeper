namespace Swinesweeper.Presentation
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this._panelGrid = new System.Windows.Forms.Panel();
            this._lblTime = new System.Windows.Forms.Label();
            this._lblTimeValue = new System.Windows.Forms.Label();
            this._panelTimer = new System.Windows.Forms.Panel();
            this._panelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelGrid
            // 
            this._panelGrid.AutoSize = true;
            this._panelGrid.Location = new System.Drawing.Point(12, 37);
            this._panelGrid.Name = "_panelGrid";
            this._panelGrid.Size = new System.Drawing.Size(314, 319);
            this._panelGrid.TabIndex = 1;
            // 
            // _lblTime
            // 
            this._lblTime.AutoSize = true;
            this._lblTime.Location = new System.Drawing.Point(3, 3);
            this._lblTime.Name = "_lblTime";
            this._lblTime.Size = new System.Drawing.Size(30, 13);
            this._lblTime.TabIndex = 2;
            this._lblTime.Text = "Time";
            // 
            // _lblTimeValue
            // 
            this._lblTimeValue.AutoSize = true;
            this._lblTimeValue.Location = new System.Drawing.Point(40, 3);
            this._lblTimeValue.Name = "_lblTimeValue";
            this._lblTimeValue.Size = new System.Drawing.Size(13, 13);
            this._lblTimeValue.TabIndex = 3;
            this._lblTimeValue.Text = "0";
            // 
            // _panelTimer
            // 
            this._panelTimer.Controls.Add(this._lblTime);
            this._panelTimer.Controls.Add(this._lblTimeValue);
            this._panelTimer.Location = new System.Drawing.Point(12, 9);
            this._panelTimer.Name = "_panelTimer";
            this._panelTimer.Size = new System.Drawing.Size(314, 24);
            this._panelTimer.TabIndex = 6;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 365);
            this.Controls.Add(this._panelTimer);
            this.Controls.Add(this._panelGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoard";
            this.Text = "Swine Sweeper";
            this._panelTimer.ResumeLayout(false);
            this._panelTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelGrid;
        private System.Windows.Forms.Label _lblTime;
        private System.Windows.Forms.Label _lblTimeValue;
        private System.Windows.Forms.Panel _panelTimer;

    }
}

