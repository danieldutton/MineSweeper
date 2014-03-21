namespace Swinesweeper.Presentation
{
    partial class GameMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMode));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._btnConfirm = new System.Windows.Forms.Button();
            this._panelRadioBtns = new System.Windows.Forms.Panel();
            this._radioBtnAdvanced = new System.Windows.Forms.RadioButton();
            this._radioBtnNormal = new System.Windows.Forms.RadioButton();
            this._radioBtnBeginner = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._panelRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // _btnConfirm
            // 
            this._btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this._btnConfirm.Location = new System.Drawing.Point(118, 205);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(68, 23);
            this._btnConfirm.TabIndex = 11;
            this._btnConfirm.Text = "Ok";
            this._btnConfirm.UseVisualStyleBackColor = false;
            this._btnConfirm.Click += new System.EventHandler(this.SelectGameMode_Click);
            // 
            // _panelRadioBtns
            // 
            this._panelRadioBtns.BackColor = System.Drawing.Color.Transparent;
            this._panelRadioBtns.Controls.Add(this._radioBtnAdvanced);
            this._panelRadioBtns.Controls.Add(this._radioBtnNormal);
            this._panelRadioBtns.Controls.Add(this._radioBtnBeginner);
            this._panelRadioBtns.Location = new System.Drawing.Point(118, 134);
            this._panelRadioBtns.Name = "_panelRadioBtns";
            this._panelRadioBtns.Size = new System.Drawing.Size(68, 68);
            this._panelRadioBtns.TabIndex = 10;
            // 
            // _radioBtnAdvanced
            // 
            this._radioBtnAdvanced.AutoSize = true;
            this._radioBtnAdvanced.Location = new System.Drawing.Point(13, 50);
            this._radioBtnAdvanced.Name = "_radioBtnAdvanced";
            this._radioBtnAdvanced.Size = new System.Drawing.Size(14, 13);
            this._radioBtnAdvanced.TabIndex = 0;
            this._radioBtnAdvanced.TabStop = true;
            this._radioBtnAdvanced.Tag = "Advanced";
            this._radioBtnAdvanced.UseVisualStyleBackColor = true;
            // 
            // _radioBtnNormal
            // 
            this._radioBtnNormal.AutoSize = true;
            this._radioBtnNormal.Location = new System.Drawing.Point(13, 27);
            this._radioBtnNormal.Name = "_radioBtnNormal";
            this._radioBtnNormal.Size = new System.Drawing.Size(14, 13);
            this._radioBtnNormal.TabIndex = 0;
            this._radioBtnNormal.TabStop = true;
            this._radioBtnNormal.Tag = "Normal";
            this._radioBtnNormal.UseVisualStyleBackColor = true;
            // 
            // _radioBtnBeginner
            // 
            this._radioBtnBeginner.AutoSize = true;
            this._radioBtnBeginner.Location = new System.Drawing.Point(13, 1);
            this._radioBtnBeginner.Name = "_radioBtnBeginner";
            this._radioBtnBeginner.Size = new System.Drawing.Size(14, 13);
            this._radioBtnBeginner.TabIndex = 0;
            this._radioBtnBeginner.TabStop = true;
            this._radioBtnBeginner.Tag = "Beginner";
            this._radioBtnBeginner.UseVisualStyleBackColor = true;
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(394, 233);
            this.Controls.Add(this._btnConfirm);
            this.Controls.Add(this._panelRadioBtns);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameMode";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameMode_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._panelRadioBtns.ResumeLayout(false);
            this._panelRadioBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _btnConfirm;
        private System.Windows.Forms.Panel _panelRadioBtns;
        private System.Windows.Forms.RadioButton _radioBtnAdvanced;
        private System.Windows.Forms.RadioButton _radioBtnNormal;
        private System.Windows.Forms.RadioButton _radioBtnBeginner;

    }
}