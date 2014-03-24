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
            this.picBoxHeader = new System.Windows.Forms.PictureBox();
            this._btnConfirm = new System.Windows.Forms.Button();
            this._panelRadioBtns = new System.Windows.Forms.Panel();
            this._radioBtnAdvanced = new System.Windows.Forms.RadioButton();
            this._radioBtnNormal = new System.Windows.Forms.RadioButton();
            this._radioBtnBeginner = new System.Windows.Forms.RadioButton();
            this._lblBeginner = new System.Windows.Forms.Label();
            this._lblNormal = new System.Windows.Forms.Label();
            this._lblAdvanced = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHeader)).BeginInit();
            this._panelRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxHeader
            // 
            this.picBoxHeader.Image = ((System.Drawing.Image)(resources.GetObject("picBoxHeader.Image")));
            this.picBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.picBoxHeader.Name = "picBoxHeader";
            this.picBoxHeader.Size = new System.Drawing.Size(394, 114);
            this.picBoxHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxHeader.TabIndex = 9;
            this.picBoxHeader.TabStop = false;
            // 
            // _btnConfirm
            // 
            this._btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this._btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnConfirm.Location = new System.Drawing.Point(288, 1);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(68, 23);
            this._btnConfirm.TabIndex = 11;
            this._btnConfirm.Text = "Confirm";
            this._btnConfirm.UseVisualStyleBackColor = false;
            this._btnConfirm.Click += new System.EventHandler(this.SelectGameMode_Click);
            // 
            // _panelRadioBtns
            // 
            this._panelRadioBtns.BackColor = System.Drawing.Color.White;
            this._panelRadioBtns.Controls.Add(this._radioBtnAdvanced);
            this._panelRadioBtns.Controls.Add(this._radioBtnNormal);
            this._panelRadioBtns.Controls.Add(this._radioBtnBeginner);
            this._panelRadioBtns.Controls.Add(this._btnConfirm);
            this._panelRadioBtns.Location = new System.Drawing.Point(0, 115);
            this._panelRadioBtns.Name = "_panelRadioBtns";
            this._panelRadioBtns.Size = new System.Drawing.Size(359, 27);
            this._panelRadioBtns.TabIndex = 10;
            // 
            // _radioBtnAdvanced
            // 
            this._radioBtnAdvanced.AutoSize = true;
            this._radioBtnAdvanced.Location = new System.Drawing.Point(255, 7);
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
            this._radioBtnNormal.Location = new System.Drawing.Point(157, 7);
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
            this._radioBtnBeginner.Location = new System.Drawing.Point(72, 7);
            this._radioBtnBeginner.Name = "_radioBtnBeginner";
            this._radioBtnBeginner.Size = new System.Drawing.Size(14, 13);
            this._radioBtnBeginner.TabIndex = 0;
            this._radioBtnBeginner.TabStop = true;
            this._radioBtnBeginner.Tag = "Beginner";
            this._radioBtnBeginner.UseVisualStyleBackColor = true;
            // 
            // _lblBeginner
            // 
            this._lblBeginner.AutoSize = true;
            this._lblBeginner.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblBeginner.ForeColor = System.Drawing.Color.SaddleBrown;
            this._lblBeginner.Location = new System.Drawing.Point(3, 119);
            this._lblBeginner.Name = "_lblBeginner";
            this._lblBeginner.Size = new System.Drawing.Size(63, 18);
            this._lblBeginner.TabIndex = 13;
            this._lblBeginner.Text = "Beginner";
            // 
            // _lblNormal
            // 
            this._lblNormal.AutoSize = true;
            this._lblNormal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNormal.ForeColor = System.Drawing.Color.SaddleBrown;
            this._lblNormal.Location = new System.Drawing.Point(98, 119);
            this._lblNormal.Name = "_lblNormal";
            this._lblNormal.Size = new System.Drawing.Size(52, 18);
            this._lblNormal.TabIndex = 13;
            this._lblNormal.Text = "Normal";
            // 
            // _lblAdvanced
            // 
            this._lblAdvanced.AutoSize = true;
            this._lblAdvanced.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAdvanced.ForeColor = System.Drawing.Color.SaddleBrown;
            this._lblAdvanced.Location = new System.Drawing.Point(181, 119);
            this._lblAdvanced.Name = "_lblAdvanced";
            this._lblAdvanced.Size = new System.Drawing.Size(68, 18);
            this._lblAdvanced.TabIndex = 13;
            this._lblAdvanced.Text = "Advanced";
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 142);
            this.Controls.Add(this._lblAdvanced);
            this.Controls.Add(this._lblNormal);
            this.Controls.Add(this._lblBeginner);
            this.Controls.Add(this._panelRadioBtns);
            this.Controls.Add(this.picBoxHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(375, 180);
            this.MinimumSize = new System.Drawing.Size(375, 180);
            this.Name = "GameMode";
            this.Text = "Game Mode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameMode_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHeader)).EndInit();
            this._panelRadioBtns.ResumeLayout(false);
            this._panelRadioBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHeader;
        private System.Windows.Forms.Button _btnConfirm;
        private System.Windows.Forms.Panel _panelRadioBtns;
        private System.Windows.Forms.RadioButton _radioBtnAdvanced;
        private System.Windows.Forms.RadioButton _radioBtnNormal;
        private System.Windows.Forms.RadioButton _radioBtnBeginner;
        private System.Windows.Forms.Label _lblBeginner;
        private System.Windows.Forms.Label _lblNormal;
        private System.Windows.Forms.Label _lblAdvanced;

    }
}