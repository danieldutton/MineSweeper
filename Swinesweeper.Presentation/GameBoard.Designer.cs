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
            this._lblFlags = new System.Windows.Forms.Label();
            this._lblFlagCount = new System.Windows.Forms.Label();
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
            // _lblFlags
            // 
            this._lblFlags.AutoSize = true;
            this._lblFlags.Location = new System.Drawing.Point(3, 3);
            this._lblFlags.Name = "_lblFlags";
            this._lblFlags.Size = new System.Drawing.Size(35, 13);
            this._lblFlags.TabIndex = 2;
            this._lblFlags.Text = "Flags:";
            // 
            // _lblFlagCount
            // 
            this._lblFlagCount.AutoSize = true;
            this._lblFlagCount.Location = new System.Drawing.Point(40, 3);
            this._lblFlagCount.Name = "_lblFlagCount";
            this._lblFlagCount.Size = new System.Drawing.Size(13, 13);
            this._lblFlagCount.TabIndex = 3;
            this._lblFlagCount.Text = "0";
            // 
            // _panelTimer
            // 
            this._panelTimer.Controls.Add(this._lblFlags);
            this._panelTimer.Controls.Add(this._lblFlagCount);
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
        private System.Windows.Forms.Label _lblFlags;
        private System.Windows.Forms.Label _lblFlagCount;
        private System.Windows.Forms.Panel _panelTimer;

    }
}

