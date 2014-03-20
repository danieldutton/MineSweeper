namespace MSweeper.Presentation
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
            this._panelRadioBtns = new System.Windows.Forms.Panel();
            this._radioBtnAdvanced = new System.Windows.Forms.RadioButton();
            this._radioBtnNormal = new System.Windows.Forms.RadioButton();
            this._radioBtnBeginner = new System.Windows.Forms.RadioButton();
            this._btnConfirm = new System.Windows.Forms.Button();
            this._panelRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelRadioBtns
            // 
            this._panelRadioBtns.BackColor = System.Drawing.Color.Transparent;
            this._panelRadioBtns.Controls.Add(this._radioBtnAdvanced);
            this._panelRadioBtns.Controls.Add(this._radioBtnNormal);
            this._panelRadioBtns.Controls.Add(this._radioBtnBeginner);
            this._panelRadioBtns.Location = new System.Drawing.Point(92, 12);
            this._panelRadioBtns.Name = "_panelRadioBtns";
            this._panelRadioBtns.Size = new System.Drawing.Size(68, 108);
            this._panelRadioBtns.TabIndex = 7;
            // 
            // _radioBtnAdvanced
            // 
            this._radioBtnAdvanced.AutoSize = true;
            this._radioBtnAdvanced.Location = new System.Drawing.Point(13, 87);
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
            this._radioBtnNormal.Location = new System.Drawing.Point(13, 52);
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
            this._radioBtnBeginner.Location = new System.Drawing.Point(13, 14);
            this._radioBtnBeginner.Name = "_radioBtnBeginner";
            this._radioBtnBeginner.Size = new System.Drawing.Size(14, 13);
            this._radioBtnBeginner.TabIndex = 0;
            this._radioBtnBeginner.TabStop = true;
            this._radioBtnBeginner.Tag = "Beginner";
            this._radioBtnBeginner.UseVisualStyleBackColor = true;
            // 
            // _btnConfirm
            // 
            this._btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this._btnConfirm.Location = new System.Drawing.Point(92, 126);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(68, 23);
            this._btnConfirm.TabIndex = 8;
            this._btnConfirm.Text = "Ok";
            this._btnConfirm.UseVisualStyleBackColor = false;
            this._btnConfirm.Click += new System.EventHandler(this.SelectGameMode_Click);
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(188, 162);
            this.Controls.Add(this._btnConfirm);
            this.Controls.Add(this._panelRadioBtns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameMode";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameMode_FormClosing);
            this._panelRadioBtns.ResumeLayout(false);
            this._panelRadioBtns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelRadioBtns;
        private System.Windows.Forms.RadioButton _radioBtnAdvanced;
        private System.Windows.Forms.RadioButton _radioBtnNormal;
        private System.Windows.Forms.RadioButton _radioBtnBeginner;
        private System.Windows.Forms.Button _btnConfirm;
    }
}