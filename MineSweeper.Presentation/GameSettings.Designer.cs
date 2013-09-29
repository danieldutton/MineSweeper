namespace MineSweeper.Presentation
{
    partial class GameSettings
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
            this._lblBeginner = new System.Windows.Forms.Label();
            this._lblNormal = new System.Windows.Forms.Label();
            this._lblAdvanced = new System.Windows.Forms.Label();
            this._panelGameModeLabels = new System.Windows.Forms.Panel();
            this._panelCheckBoxes = new System.Windows.Forms.Panel();
            this._radioBtnAdvanced = new System.Windows.Forms.RadioButton();
            this._radioBtnNormal = new System.Windows.Forms.RadioButton();
            this._radioBtnBeginner = new System.Windows.Forms.RadioButton();
            this._btnConfirm = new System.Windows.Forms.Button();
            this._panelGameModeLabels.SuspendLayout();
            this._panelCheckBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblBeginner
            // 
            this._lblBeginner.AutoSize = true;
            this._lblBeginner.Location = new System.Drawing.Point(3, 4);
            this._lblBeginner.Name = "_lblBeginner";
            this._lblBeginner.Size = new System.Drawing.Size(49, 13);
            this._lblBeginner.TabIndex = 0;
            this._lblBeginner.Text = "Beginner";
            // 
            // _lblNormal
            // 
            this._lblNormal.AutoSize = true;
            this._lblNormal.Location = new System.Drawing.Point(3, 37);
            this._lblNormal.Name = "_lblNormal";
            this._lblNormal.Size = new System.Drawing.Size(40, 13);
            this._lblNormal.TabIndex = 1;
            this._lblNormal.Text = "Normal";
            // 
            // _lblAdvanced
            // 
            this._lblAdvanced.AutoSize = true;
            this._lblAdvanced.Location = new System.Drawing.Point(3, 67);
            this._lblAdvanced.Name = "_lblAdvanced";
            this._lblAdvanced.Size = new System.Drawing.Size(56, 13);
            this._lblAdvanced.TabIndex = 2;
            this._lblAdvanced.Text = "Advanced";
            // 
            // _panelGameModeLabels
            // 
            this._panelGameModeLabels.Controls.Add(this._lblBeginner);
            this._panelGameModeLabels.Controls.Add(this._lblAdvanced);
            this._panelGameModeLabels.Controls.Add(this._lblNormal);
            this._panelGameModeLabels.Location = new System.Drawing.Point(13, 9);
            this._panelGameModeLabels.Name = "_panelGameModeLabels";
            this._panelGameModeLabels.Size = new System.Drawing.Size(88, 85);
            this._panelGameModeLabels.TabIndex = 3;
            // 
            // _panelCheckBoxes
            // 
            this._panelCheckBoxes.Controls.Add(this._radioBtnAdvanced);
            this._panelCheckBoxes.Controls.Add(this._radioBtnNormal);
            this._panelCheckBoxes.Controls.Add(this._radioBtnBeginner);
            this._panelCheckBoxes.Location = new System.Drawing.Point(153, 9);
            this._panelCheckBoxes.Name = "_panelCheckBoxes";
            this._panelCheckBoxes.Size = new System.Drawing.Size(38, 85);
            this._panelCheckBoxes.TabIndex = 4;
            // 
            // _radioBtnAdvanced
            // 
            this._radioBtnAdvanced.AutoSize = true;
            this._radioBtnAdvanced.Location = new System.Drawing.Point(3, 67);
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
            this._radioBtnNormal.Location = new System.Drawing.Point(3, 37);
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
            this._radioBtnBeginner.Location = new System.Drawing.Point(3, 4);
            this._radioBtnBeginner.Name = "_radioBtnBeginner";
            this._radioBtnBeginner.Size = new System.Drawing.Size(14, 13);
            this._radioBtnBeginner.TabIndex = 0;
            this._radioBtnBeginner.TabStop = true;
            this._radioBtnBeginner.Tag = "Beginner";
            this._radioBtnBeginner.UseVisualStyleBackColor = true;
            // 
            // _btnConfirm
            // 
            this._btnConfirm.Location = new System.Drawing.Point(116, 100);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(75, 23);
            this._btnConfirm.TabIndex = 5;
            this._btnConfirm.Text = "Ok";
            this._btnConfirm.UseVisualStyleBackColor = true;
            this._btnConfirm.Click += new System.EventHandler(this.ConfirmGameSettings_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 132);
            this.Controls.Add(this._btnConfirm);
            this.Controls.Add(this._panelCheckBoxes);
            this.Controls.Add(this._panelGameModeLabels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(219, 170);
            this.Name = "GameSettings";
            this.Text = "Options";
            this._panelGameModeLabels.ResumeLayout(false);
            this._panelGameModeLabels.PerformLayout();
            this._panelCheckBoxes.ResumeLayout(false);
            this._panelCheckBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lblBeginner;
        private System.Windows.Forms.Label _lblNormal;
        private System.Windows.Forms.Label _lblAdvanced;
        private System.Windows.Forms.Panel _panelGameModeLabels;
        private System.Windows.Forms.Panel _panelCheckBoxes;
        private System.Windows.Forms.Button _btnConfirm;
        private System.Windows.Forms.RadioButton _radioBtnAdvanced;
        private System.Windows.Forms.RadioButton _radioBtnNormal;
        private System.Windows.Forms.RadioButton _radioBtnBeginner;
    }
}