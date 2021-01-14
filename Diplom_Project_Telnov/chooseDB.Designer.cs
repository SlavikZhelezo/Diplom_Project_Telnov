namespace Diplom_Project_Telnov
{
    partial class chooseDB
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
            this.DB_Bakunina = new System.Windows.Forms.RadioButton();
            this.DB_Konushennaya = new System.Windows.Forms.RadioButton();
            this.DB_Sadovaya = new System.Windows.Forms.RadioButton();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DB_Bakunina
            // 
            this.DB_Bakunina.AutoSize = true;
            this.DB_Bakunina.Location = new System.Drawing.Point(72, 38);
            this.DB_Bakunina.Name = "DB_Bakunina";
            this.DB_Bakunina.Size = new System.Drawing.Size(73, 17);
            this.DB_Bakunina.TabIndex = 0;
            this.DB_Bakunina.TabStop = true;
            this.DB_Bakunina.Text = "Бакунина";
            this.DB_Bakunina.UseVisualStyleBackColor = true;
            // 
            // DB_Konushennaya
            // 
            this.DB_Konushennaya.AutoSize = true;
            this.DB_Konushennaya.Location = new System.Drawing.Point(72, 76);
            this.DB_Konushennaya.Name = "DB_Konushennaya";
            this.DB_Konushennaya.Size = new System.Drawing.Size(90, 17);
            this.DB_Konushennaya.TabIndex = 1;
            this.DB_Konushennaya.TabStop = true;
            this.DB_Konushennaya.Text = "Конюшенная";
            this.DB_Konushennaya.UseVisualStyleBackColor = true;
            // 
            // DB_Sadovaya
            // 
            this.DB_Sadovaya.AutoSize = true;
            this.DB_Sadovaya.Location = new System.Drawing.Point(72, 111);
            this.DB_Sadovaya.Name = "DB_Sadovaya";
            this.DB_Sadovaya.Size = new System.Drawing.Size(68, 17);
            this.DB_Sadovaya.TabIndex = 2;
            this.DB_Sadovaya.TabStop = true;
            this.DB_Sadovaya.Text = "Садовая";
            this.DB_Sadovaya.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Gray;
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(49, 147);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(153, 43);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // chooseDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(240, 215);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.DB_Sadovaya);
            this.Controls.Add(this.DB_Konushennaya);
            this.Controls.Add(this.DB_Bakunina);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "chooseDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chooseDB";
            this.Enter += new System.EventHandler(this.nextButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DB_Bakunina;
        private System.Windows.Forms.RadioButton DB_Konushennaya;
        private System.Windows.Forms.RadioButton DB_Sadovaya;
        private System.Windows.Forms.Button nextButton;
    }
}