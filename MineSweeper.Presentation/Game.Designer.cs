namespace MineSweeper.Presentation
{
    partial class Game
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
            this._panelGrid = new System.Windows.Forms.Panel();
            this._lblTime = new System.Windows.Forms.Label();
            this._lblTimeValue = new System.Windows.Forms.Label();
            this._lblFlags = new System.Windows.Forms.Label();
            this._lblFlagsValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelGrid
            // 
            this._panelGrid.AutoSize = true;
            this._panelGrid.Location = new System.Drawing.Point(12, 27);
            this._panelGrid.Name = "_panelGrid";
            this._panelGrid.Size = new System.Drawing.Size(314, 329);
            this._panelGrid.TabIndex = 1;
            // 
            // _lblTime
            // 
            this._lblTime.AutoSize = true;
            this._lblTime.Location = new System.Drawing.Point(3, 14);
            this._lblTime.Name = "_lblTime";
            this._lblTime.Size = new System.Drawing.Size(30, 13);
            this._lblTime.TabIndex = 2;
            this._lblTime.Text = "Time";
            // 
            // _lblTimeValue
            // 
            this._lblTimeValue.AutoSize = true;
            this._lblTimeValue.Location = new System.Drawing.Point(40, 14);
            this._lblTimeValue.Name = "_lblTimeValue";
            this._lblTimeValue.Size = new System.Drawing.Size(13, 13);
            this._lblTimeValue.TabIndex = 3;
            this._lblTimeValue.Text = "0";
            // 
            // _lblFlags
            // 
            this._lblFlags.AutoSize = true;
            this._lblFlags.Location = new System.Drawing.Point(230, 14);
            this._lblFlags.Name = "_lblFlags";
            this._lblFlags.Size = new System.Drawing.Size(35, 13);
            this._lblFlags.TabIndex = 4;
            this._lblFlags.Text = "label1";
            // 
            // _lblFlagsValue
            // 
            this._lblFlagsValue.AutoSize = true;
            this._lblFlagsValue.Location = new System.Drawing.Point(272, 14);
            this._lblFlagsValue.Name = "_lblFlagsValue";
            this._lblFlagsValue.Size = new System.Drawing.Size(13, 13);
            this._lblFlagsValue.TabIndex = 5;
            this._lblFlagsValue.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._lblTime);
            this.panel2.Controls.Add(this._lblFlagsValue);
            this.panel2.Controls.Add(this._lblTimeValue);
            this.panel2.Controls.Add(this._lblFlags);
            this.panel2.Location = new System.Drawing.Point(12, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 31);
            this.panel2.TabIndex = 6;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this._panelGrid);
            this.MaximumSize = new System.Drawing.Size(359, 436);
            this.Name = "Game";
            this.Text = "Swine Sweeper";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelGrid;
        private System.Windows.Forms.Label _lblTime;
        private System.Windows.Forms.Label _lblTimeValue;
        private System.Windows.Forms.Label _lblFlags;
        private System.Windows.Forms.Label _lblFlagsValue;
        private System.Windows.Forms.Panel panel2;

    }
}

