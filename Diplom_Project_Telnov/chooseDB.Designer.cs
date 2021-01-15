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
            this.DB_Bakunina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DB_Bakunina.Location = new System.Drawing.Point(52, 15);
            this.DB_Bakunina.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DB_Bakunina.Name = "DB_Bakunina";
            this.DB_Bakunina.Size = new System.Drawing.Size(114, 29);
            this.DB_Bakunina.TabIndex = 0;
            this.DB_Bakunina.TabStop = true;
            this.DB_Bakunina.Text = "Бакунина";
            this.DB_Bakunina.UseVisualStyleBackColor = true;
            // 
            // DB_Konushennaya
            // 
            this.DB_Konushennaya.AutoSize = true;
            this.DB_Konushennaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DB_Konushennaya.Location = new System.Drawing.Point(52, 74);
            this.DB_Konushennaya.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DB_Konushennaya.Name = "DB_Konushennaya";
            this.DB_Konushennaya.Size = new System.Drawing.Size(149, 29);
            this.DB_Konushennaya.TabIndex = 1;
            this.DB_Konushennaya.TabStop = true;
            this.DB_Konushennaya.Text = "Конюшенная";
            this.DB_Konushennaya.UseVisualStyleBackColor = true;
            // 
            // DB_Sadovaya
            // 
            this.DB_Sadovaya.AutoSize = true;
            this.DB_Sadovaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DB_Sadovaya.Location = new System.Drawing.Point(52, 127);
            this.DB_Sadovaya.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DB_Sadovaya.Name = "DB_Sadovaya";
            this.DB_Sadovaya.Size = new System.Drawing.Size(107, 29);
            this.DB_Sadovaya.TabIndex = 2;
            this.DB_Sadovaya.TabStop = true;
            this.DB_Sadovaya.Text = "Садовая";
            this.DB_Sadovaya.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Gray;
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(14, 183);
            this.nextButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(255, 66);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // chooseDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(274, 262);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.DB_Sadovaya);
            this.Controls.Add(this.DB_Konushennaya);
            this.Controls.Add(this.DB_Bakunina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "chooseDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chooseDB";
            this.Load += new System.EventHandler(this.chooseDB_Load);
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