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
            this.saveButtonP = new System.Windows.Forms.Panel();
            this.saveButtonL = new System.Windows.Forms.Label();
            this.cancelButtonP = new System.Windows.Forms.Panel();
            this.cancelButtonL = new System.Windows.Forms.Label();
            this.createOrder = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.reservButton = new System.Windows.Forms.Button();
            this.stopListButton = new System.Windows.Forms.Button();
            this.showOrder = new System.Windows.Forms.Button();
            this.ordersList = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.offButtonL)).BeginInit();
            this.offButtonP.SuspendLayout();
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
            this.offButtonP.Paint += new System.Windows.Forms.PaintEventHandler(this.offButtonP_Paint);
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
            // createOrder
            // 
            this.createOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.createOrder.Location = new System.Drawing.Point(12, 13);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(200, 100);
            this.createOrder.TabIndex = 13;
            this.createOrder.Text = "Создание заказа";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.editButton.Location = new System.Drawing.Point(14, 140);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(200, 100);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Редактирование заказа";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // reservButton
            // 
            this.reservButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.reservButton.Location = new System.Drawing.Point(12, 264);
            this.reservButton.Name = "reservButton";
            this.reservButton.Size = new System.Drawing.Size(200, 100);
            this.reservButton.TabIndex = 15;
            this.reservButton.Text = "Резервирование";
            this.reservButton.UseVisualStyleBackColor = true;
            // 
            // stopListButton
            // 
            this.stopListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.stopListButton.Location = new System.Drawing.Point(14, 397);
            this.stopListButton.Name = "stopListButton";
            this.stopListButton.Size = new System.Drawing.Size(200, 100);
            this.stopListButton.TabIndex = 16;
            this.stopListButton.Text = "Ограниченные блюда";
            this.stopListButton.UseVisualStyleBackColor = true;
            // 
            // showOrder
            // 
            this.showOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.showOrder.Location = new System.Drawing.Point(248, 551);
            this.showOrder.Name = "showOrder";
            this.showOrder.Size = new System.Drawing.Size(203, 64);
            this.showOrder.TabIndex = 17;
            this.showOrder.Text = "Показать заказы";
            this.showOrder.UseVisualStyleBackColor = true;
            this.showOrder.Click += new System.EventHandler(this.test_Click);
            // 
            // ordersList
            // 
            this.ordersList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ordersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ordersList.Location = new System.Drawing.Point(248, 13);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(1051, 532);
            this.ordersList.TabIndex = 18;
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 626);
            this.Controls.Add(this.ordersList);
            this.Controls.Add(this.showOrder);
            this.Controls.Add(this.stopListButton);
            this.Controls.Add(this.reservButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.cancelButtonP);
            this.Controls.Add(this.saveButtonP);
            this.Controls.Add(this.offButtonP);
            this.Controls.Add(this.exitButton);
            this.Name = "Waiter";
            this.Text = "Waiter";
            ((System.ComponentModel.ISupportInitialize)(this.offButtonL)).EndInit();
            this.offButtonP.ResumeLayout(false);
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
        private System.Windows.Forms.Panel saveButtonP;
        private System.Windows.Forms.Label saveButtonL;
        private System.Windows.Forms.Panel cancelButtonP;
        private System.Windows.Forms.Label cancelButtonL;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button reservButton;
        private System.Windows.Forms.Button stopListButton;
        private System.Windows.Forms.Button showOrder;
        private System.Windows.Forms.FlowLayoutPanel ordersList;
    }
}