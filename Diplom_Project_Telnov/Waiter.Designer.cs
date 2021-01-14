namespace Diplom_Project_Telnov
{
    partial class Waiter
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
            this.exitButton = new System.Windows.Forms.Label();
            this.offButtonL = new System.Windows.Forms.PictureBox();
            this.offButtonP = new System.Windows.Forms.Panel();
            this.stopListButtonP = new System.Windows.Forms.Panel();
            this.stopListButtonL = new System.Windows.Forms.Label();
            this.reservButtonP = new System.Windows.Forms.Panel();
            this.reservButtonL = new System.Windows.Forms.Label();
            this.createOrderP = new System.Windows.Forms.Panel();
            this.createOrderL = new System.Windows.Forms.Label();
            this.editOrderP = new System.Windows.Forms.Panel();
            this.editOrderL = new System.Windows.Forms.Label();
            this.saveButtonP = new System.Windows.Forms.Panel();
            this.saveButtonL = new System.Windows.Forms.Label();
            this.cancelButtonP = new System.Windows.Forms.Panel();
            this.cancelButtonL = new System.Windows.Forms.Label();
            this.ordersList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.offButtonL)).BeginInit();
            this.offButtonP.SuspendLayout();
            this.stopListButtonP.SuspendLayout();
            this.reservButtonP.SuspendLayout();
            this.createOrderP.SuspendLayout();
            this.editOrderP.SuspendLayout();
            this.saveButtonP.SuspendLayout();
            this.cancelButtonP.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.exitButton.Location = new System.Drawing.Point(134, 535);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 78);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // offButtonL
            // 
            this.offButtonL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.offButtonL.Image = global::Diplom_Project_Telnov.Properties.Resources.stop_button;
            this.offButtonL.Location = new System.Drawing.Point(4, 3);
            this.offButtonL.Name = "offButtonL";
            this.offButtonL.Size = new System.Drawing.Size(64, 66);
            this.offButtonL.TabIndex = 5;
            this.offButtonL.TabStop = false;
            // 
            // offButtonP
            // 
            this.offButtonP.BackColor = System.Drawing.Color.Red;
            this.offButtonP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.offButtonP.Controls.Add(this.offButtonL);
            this.offButtonP.Location = new System.Drawing.Point(12, 533);
            this.offButtonP.Name = "offButtonP";
            this.offButtonP.Size = new System.Drawing.Size(78, 78);
            this.offButtonP.TabIndex = 6;
            // 
            // stopListButtonP
            // 
            this.stopListButtonP.BackColor = System.Drawing.Color.LightGray;
            this.stopListButtonP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stopListButtonP.Controls.Add(this.stopListButtonL);
            this.stopListButtonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.stopListButtonP.Location = new System.Drawing.Point(12, 393);
            this.stopListButtonP.Name = "stopListButtonP";
            this.stopListButtonP.Size = new System.Drawing.Size(200, 100);
            this.stopListButtonP.TabIndex = 2;
            // 
            // stopListButtonL
            // 
            this.stopListButtonL.AutoSize = true;
            this.stopListButtonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.stopListButtonL.Location = new System.Drawing.Point(19, 24);
            this.stopListButtonL.MaximumSize = new System.Drawing.Size(190, 0);
            this.stopListButtonL.Name = "stopListButtonL";
            this.stopListButtonL.Size = new System.Drawing.Size(147, 50);
            this.stopListButtonL.TabIndex = 9;
            this.stopListButtonL.Text = "Ограниченные блюда";
            this.stopListButtonL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reservButtonP
            // 
            this.reservButtonP.BackColor = System.Drawing.Color.LightGray;
            this.reservButtonP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reservButtonP.Controls.Add(this.reservButtonL);
            this.reservButtonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.reservButtonP.Location = new System.Drawing.Point(12, 268);
            this.reservButtonP.Name = "reservButtonP";
            this.reservButtonP.Size = new System.Drawing.Size(200, 100);
            this.reservButtonP.TabIndex = 1;
            // 
            // reservButtonL
            // 
            this.reservButtonL.AutoSize = true;
            this.reservButtonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.reservButtonL.Location = new System.Drawing.Point(19, 38);
            this.reservButtonL.MaximumSize = new System.Drawing.Size(190, 0);
            this.reservButtonL.Name = "reservButtonL";
            this.reservButtonL.Size = new System.Drawing.Size(164, 25);
            this.reservButtonL.TabIndex = 8;
            this.reservButtonL.Text = "Резервирование";
            this.reservButtonL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createOrderP
            // 
            this.createOrderP.BackColor = System.Drawing.Color.LightGray;
            this.createOrderP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.createOrderP.Controls.Add(this.createOrderL);
            this.createOrderP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.createOrderP.Location = new System.Drawing.Point(12, 12);
            this.createOrderP.Name = "createOrderP";
            this.createOrderP.Size = new System.Drawing.Size(200, 100);
            this.createOrderP.TabIndex = 0;
            this.createOrderP.Paint += new System.Windows.Forms.PaintEventHandler(this.createOrderP_Paint);
            // 
            // createOrderL
            // 
            this.createOrderL.AutoSize = true;
            this.createOrderL.Location = new System.Drawing.Point(14, 35);
            this.createOrderL.Name = "createOrderL";
            this.createOrderL.Size = new System.Drawing.Size(169, 25);
            this.createOrderL.TabIndex = 7;
            this.createOrderL.Text = "Создание заказа";
            // 
            // editOrderP
            // 
            this.editOrderP.BackColor = System.Drawing.Color.LightGray;
            this.editOrderP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editOrderP.Controls.Add(this.editOrderL);
            this.editOrderP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editOrderP.Location = new System.Drawing.Point(12, 143);
            this.editOrderP.Name = "editOrderP";
            this.editOrderP.Size = new System.Drawing.Size(200, 100);
            this.editOrderP.TabIndex = 1;
            // 
            // editOrderL
            // 
            this.editOrderL.AutoSize = true;
            this.editOrderL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editOrderL.Location = new System.Drawing.Point(13, 25);
            this.editOrderL.MaximumSize = new System.Drawing.Size(190, 0);
            this.editOrderL.Name = "editOrderL";
            this.editOrderL.Size = new System.Drawing.Size(165, 50);
            this.editOrderL.TabIndex = 7;
            this.editOrderL.Text = "Редактирование заказа";
            this.editOrderL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButtonP
            // 
            this.saveButtonP.BackColor = System.Drawing.Color.LightGray;
            this.saveButtonP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saveButtonP.Controls.Add(this.saveButtonL);
            this.saveButtonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.saveButtonP.Location = new System.Drawing.Point(1171, 551);
            this.saveButtonP.Name = "saveButtonP";
            this.saveButtonP.Size = new System.Drawing.Size(128, 62);
            this.saveButtonP.TabIndex = 10;
            // 
            // saveButtonL
            // 
            this.saveButtonL.AutoSize = true;
            this.saveButtonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.saveButtonL.Location = new System.Drawing.Point(10, 15);
            this.saveButtonL.MaximumSize = new System.Drawing.Size(190, 0);
            this.saveButtonL.Name = "saveButtonL";
            this.saveButtonL.Size = new System.Drawing.Size(111, 25);
            this.saveButtonL.TabIndex = 9;
            this.saveButtonL.Text = "Сохранить";
            this.saveButtonL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButtonP
            // 
            this.cancelButtonP.BackColor = System.Drawing.Color.LightGray;
            this.cancelButtonP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cancelButtonP.Controls.Add(this.cancelButtonL);
            this.cancelButtonP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cancelButtonP.Location = new System.Drawing.Point(1037, 551);
            this.cancelButtonP.Name = "cancelButtonP";
            this.cancelButtonP.Size = new System.Drawing.Size(128, 62);
            this.cancelButtonP.TabIndex = 11;
            // 
            // cancelButtonL
            // 
            this.cancelButtonL.AutoSize = true;
            this.cancelButtonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cancelButtonL.Location = new System.Drawing.Point(20, 15);
            this.cancelButtonL.MaximumSize = new System.Drawing.Size(190, 0);
            this.cancelButtonL.Name = "cancelButtonL";
            this.cancelButtonL.Size = new System.Drawing.Size(88, 25);
            this.cancelButtonL.TabIndex = 9;
            this.cancelButtonL.Text = "Отмена";
            this.cancelButtonL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordersList
            // 
            this.ordersList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ordersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordersList.Location = new System.Drawing.Point(246, 12);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(1053, 522);
            this.ordersList.TabIndex = 12;
            this.ordersList.Visible = false;
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 626);
            this.Controls.Add(this.ordersList);
            this.Controls.Add(this.cancelButtonP);
            this.Controls.Add(this.saveButtonP);
            this.Controls.Add(this.offButtonP);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.stopListButtonP);
            this.Controls.Add(this.reservButtonP);
            this.Controls.Add(this.editOrderP);
            this.Controls.Add(this.createOrderP);
            this.Name = "Waiter";
            this.Text = "Waiter";
            ((System.ComponentModel.ISupportInitialize)(this.offButtonL)).EndInit();
            this.offButtonP.ResumeLayout(false);
            this.stopListButtonP.ResumeLayout(false);
            this.stopListButtonP.PerformLayout();
            this.reservButtonP.ResumeLayout(false);
            this.reservButtonP.PerformLayout();
            this.createOrderP.ResumeLayout(false);
            this.createOrderP.PerformLayout();
            this.editOrderP.ResumeLayout(false);
            this.editOrderP.PerformLayout();
            this.saveButtonP.ResumeLayout(false);
            this.saveButtonP.PerformLayout();
            this.cancelButtonP.ResumeLayout(false);
            this.cancelButtonP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.PictureBox offButtonL;
        private System.Windows.Forms.Panel offButtonP;
        private System.Windows.Forms.Panel stopListButtonP;
        private System.Windows.Forms.Label stopListButtonL;
        private System.Windows.Forms.Panel reservButtonP;
        private System.Windows.Forms.Label reservButtonL;
        private System.Windows.Forms.Panel createOrderP;
        private System.Windows.Forms.Label createOrderL;
        private System.Windows.Forms.Panel editOrderP;
        private System.Windows.Forms.Label editOrderL;
        private System.Windows.Forms.Panel saveButtonP;
        private System.Windows.Forms.Label saveButtonL;
        private System.Windows.Forms.Panel cancelButtonP;
        private System.Windows.Forms.Label cancelButtonL;
        private System.Windows.Forms.Panel ordersList;
    }
}