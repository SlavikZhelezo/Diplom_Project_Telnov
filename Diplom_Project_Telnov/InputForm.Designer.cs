namespace Diplom_Project_Telnov
{
    partial class InputForm
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
            this.guest = new System.Windows.Forms.Label();
            this.guestBox = new System.Windows.Forms.TextBox();
            this.waiter = new System.Windows.Forms.Label();
            this.agree = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.waiterActual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guest
            // 
            this.guest.AutoSize = true;
            this.guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guest.Location = new System.Drawing.Point(42, 46);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(67, 22);
            this.guest.TabIndex = 1;
            this.guest.Text = "Гостей";
            // 
            // guestBox
            // 
            this.guestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guestBox.Location = new System.Drawing.Point(125, 43);
            this.guestBox.Name = "guestBox";
            this.guestBox.Size = new System.Drawing.Size(87, 27);
            this.guestBox.TabIndex = 3;
            // 
            // waiter
            // 
            this.waiter.AutoSize = true;
            this.waiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.waiter.Location = new System.Drawing.Point(12, 15);
            this.waiter.Name = "waiter";
            this.waiter.Size = new System.Drawing.Size(97, 22);
            this.waiter.TabIndex = 4;
            this.waiter.Text = "Официант";
            // 
            // agree
            // 
            this.agree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.agree.Location = new System.Drawing.Point(12, 93);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(123, 38);
            this.agree.TabIndex = 6;
            this.agree.Text = "Создать";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.Click += new System.EventHandler(this.agree_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cancel.Location = new System.Drawing.Point(151, 93);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(123, 38);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // waiterActual
            // 
            this.waiterActual.AutoSize = true;
            this.waiterActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.waiterActual.Location = new System.Drawing.Point(121, 15);
            this.waiterActual.Name = "waiterActual";
            this.waiterActual.Size = new System.Drawing.Size(97, 22);
            this.waiterActual.TabIndex = 8;
            this.waiterActual.Text = "Официант";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(111, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waiterActual);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.agree);
            this.Controls.Add(this.waiter);
            this.Controls.Add(this.guestBox);
            this.Controls.Add(this.guest);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label guest;
        private System.Windows.Forms.TextBox guestBox;
        private System.Windows.Forms.Label waiter;
        private System.Windows.Forms.Button agree;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label waiterActual;
        private System.Windows.Forms.Label label1;
    }
}