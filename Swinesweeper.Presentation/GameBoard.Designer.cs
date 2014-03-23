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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._panelTimer = new System.Windows.Forms.Panel();
            this._lblFlags = new System.Windows.Forms.Label();
            this._lblFlagCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._panelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelGrid
            // 
            this._panelGrid.AutoSize = true;
            this._panelGrid.Location = new System.Drawing.Point(12, 116);
            this._panelGrid.Name = "_panelGrid";
            this._panelGrid.Size = new System.Drawing.Size(314, 319);
            this._panelGrid.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 89);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // _panelTimer
            // 
            this._panelTimer.Controls.Add(this._lblFlags);
            this._panelTimer.Controls.Add(this._lblFlagCount);
            this._panelTimer.Location = new System.Drawing.Point(12, 91);
            this._panelTimer.Name = "_panelTimer";
            this._panelTimer.Size = new System.Drawing.Size(314, 24);
            this._panelTimer.TabIndex = 8;
            // 
            // _lblFlags
            // 
            this._lblFlags.AutoSize = true;
            this._lblFlags.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFlags.ForeColor = System.Drawing.Color.Maroon;
            this._lblFlags.Location = new System.Drawing.Point(-1, 3);
            this._lblFlags.Name = "_lblFlags";
            this._lblFlags.Size = new System.Drawing.Size(41, 16);
            this._lblFlags.TabIndex = 2;
            this._lblFlags.Text = "Flags:";
            // 
            // _lblFlagCount
            // 
            this._lblFlagCount.AutoSize = true;
            this._lblFlagCount.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFlagCount.ForeColor = System.Drawing.Color.Maroon;
            this._lblFlagCount.Location = new System.Drawing.Point(36, 3);
            this._lblFlagCount.Name = "_lblFlagCount";
            this._lblFlagCount.Size = new System.Drawing.Size(14, 16);
            this._lblFlagCount.TabIndex = 3;
            this._lblFlagCount.Text = "0";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 448);
            this.Controls.Add(this._panelTimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._panelGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoard";
            this.Text = "Swine Sweeper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._panelTimer.ResumeLayout(false);
            this._panelTimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel _panelTimer;
        private System.Windows.Forms.Label _lblFlags;
        private System.Windows.Forms.Label _lblFlagCount;

    }
}

