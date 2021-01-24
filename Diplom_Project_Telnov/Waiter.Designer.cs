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
            this.ordersList = new System.Windows.Forms.FlowLayoutPanel();
            this.table1Panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Label();
            this.table1 = new System.Windows.Forms.Label();
            this.waiterLabel1 = new System.Windows.Forms.Label();
            this.guest1 = new System.Windows.Forms.Label();
            this.table2Panel = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Label();
            this.table2 = new System.Windows.Forms.Label();
            this.guest2 = new System.Windows.Forms.Label();
            this.waiter2 = new System.Windows.Forms.Label();
            this.table3Panel = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Label();
            this.table3 = new System.Windows.Forms.Label();
            this.waiter3 = new System.Windows.Forms.Label();
            this.guest3 = new System.Windows.Forms.Label();
            this.table4Panel = new System.Windows.Forms.Panel();
            this.timer4 = new System.Windows.Forms.Label();
            this.table4 = new System.Windows.Forms.Label();
            this.guest4 = new System.Windows.Forms.Label();
            this.waiter4 = new System.Windows.Forms.Label();
            this.table5Panel = new System.Windows.Forms.Panel();
            this.timer5 = new System.Windows.Forms.Label();
            this.table5 = new System.Windows.Forms.Label();
            this.waiter5 = new System.Windows.Forms.Label();
            this.guest5 = new System.Windows.Forms.Label();
            this.stopList = new System.Windows.Forms.Button();
            this.stopdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.offButtonL)).BeginInit();
            this.offButtonP.SuspendLayout();
            this.ordersList.SuspendLayout();
            this.table1Panel.SuspendLayout();
            this.table2Panel.SuspendLayout();
            this.table3Panel.SuspendLayout();
            this.table4Panel.SuspendLayout();
            this.table5Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopdata)).BeginInit();
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
            // ordersList
            // 
            this.ordersList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ordersList.Controls.Add(this.table1Panel);
            this.ordersList.Controls.Add(this.table2Panel);
            this.ordersList.Controls.Add(this.table3Panel);
            this.ordersList.Controls.Add(this.table4Panel);
            this.ordersList.Controls.Add(this.table5Panel);
            this.ordersList.Controls.Add(this.stopdata);
            this.ordersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ordersList.Location = new System.Drawing.Point(248, 13);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(1051, 504);
            this.ordersList.TabIndex = 18;
            // 
            // table1Panel
            // 
            this.table1Panel.Controls.Add(this.timer1);
            this.table1Panel.Controls.Add(this.table1);
            this.table1Panel.Controls.Add(this.waiterLabel1);
            this.table1Panel.Controls.Add(this.guest1);
            this.table1Panel.Location = new System.Drawing.Point(3, 3);
            this.table1Panel.Name = "table1Panel";
            this.table1Panel.Size = new System.Drawing.Size(200, 100);
            this.table1Panel.TabIndex = 0;
            this.table1Panel.Click += new System.EventHandler(this.table1Panel_Click);
            this.table1Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.table1Panel_Paint);
            // 
            // timer1
            // 
            this.timer1.AutoSize = true;
            this.timer1.Location = new System.Drawing.Point(112, 58);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(65, 22);
            this.timer1.TabIndex = 0;
            this.timer1.Text = "Время";
            // 
            // table1
            // 
            this.table1.AutoSize = true;
            this.table1.Location = new System.Drawing.Point(18, 16);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(66, 22);
            this.table1.TabIndex = 3;
            this.table1.Text = "Стол 1";
            // 
            // waiterLabel1
            // 
            this.waiterLabel1.AutoSize = true;
            this.waiterLabel1.Location = new System.Drawing.Point(18, 58);
            this.waiterLabel1.Name = "waiterLabel1";
            this.waiterLabel1.Size = new System.Drawing.Size(97, 22);
            this.waiterLabel1.TabIndex = 2;
            this.waiterLabel1.Text = "Официант";
            // 
            // guest1
            // 
            this.guest1.AutoSize = true;
            this.guest1.Location = new System.Drawing.Point(112, 16);
            this.guest1.Name = "guest1";
            this.guest1.Size = new System.Drawing.Size(20, 22);
            this.guest1.TabIndex = 1;
            this.guest1.Text = "0";
            // 
            // table2Panel
            // 
            this.table2Panel.Controls.Add(this.timer2);
            this.table2Panel.Controls.Add(this.table2);
            this.table2Panel.Controls.Add(this.guest2);
            this.table2Panel.Controls.Add(this.waiter2);
            this.table2Panel.Location = new System.Drawing.Point(209, 3);
            this.table2Panel.Name = "table2Panel";
            this.table2Panel.Size = new System.Drawing.Size(200, 100);
            this.table2Panel.TabIndex = 1;
            this.table2Panel.Click += new System.EventHandler(this.table2Panel_Click);
            this.table2Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.table2Panel_Paint);
            // 
            // timer2
            // 
            this.timer2.AutoSize = true;
            this.timer2.Location = new System.Drawing.Point(107, 58);
            this.timer2.Name = "timer2";
            this.timer2.Size = new System.Drawing.Size(65, 22);
            this.timer2.TabIndex = 4;
            this.timer2.Text = "Время";
            // 
            // table2
            // 
            this.table2.AutoSize = true;
            this.table2.Location = new System.Drawing.Point(13, 16);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(66, 22);
            this.table2.TabIndex = 7;
            this.table2.Text = "Стол 2";
            // 
            // guest2
            // 
            this.guest2.AutoSize = true;
            this.guest2.Location = new System.Drawing.Point(107, 16);
            this.guest2.Name = "guest2";
            this.guest2.Size = new System.Drawing.Size(20, 22);
            this.guest2.TabIndex = 5;
            this.guest2.Text = "0";
            // 
            // waiter2
            // 
            this.waiter2.AutoSize = true;
            this.waiter2.Location = new System.Drawing.Point(13, 58);
            this.waiter2.Name = "waiter2";
            this.waiter2.Size = new System.Drawing.Size(97, 22);
            this.waiter2.TabIndex = 6;
            this.waiter2.Text = "Официант";
            // 
            // table3Panel
            // 
            this.table3Panel.Controls.Add(this.timer3);
            this.table3Panel.Controls.Add(this.table3);
            this.table3Panel.Controls.Add(this.waiter3);
            this.table3Panel.Controls.Add(this.guest3);
            this.table3Panel.Location = new System.Drawing.Point(415, 3);
            this.table3Panel.Name = "table3Panel";
            this.table3Panel.Size = new System.Drawing.Size(200, 100);
            this.table3Panel.TabIndex = 2;
            this.table3Panel.Click += new System.EventHandler(this.table3Panel_Click);
            // 
            // timer3
            // 
            this.timer3.AutoSize = true;
            this.timer3.Location = new System.Drawing.Point(115, 58);
            this.timer3.Name = "timer3";
            this.timer3.Size = new System.Drawing.Size(65, 22);
            this.timer3.TabIndex = 8;
            this.timer3.Text = "Время";
            // 
            // table3
            // 
            this.table3.AutoSize = true;
            this.table3.Location = new System.Drawing.Point(21, 16);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(66, 22);
            this.table3.TabIndex = 11;
            this.table3.Text = "Стол 3";
            // 
            // waiter3
            // 
            this.waiter3.AutoSize = true;
            this.waiter3.Location = new System.Drawing.Point(21, 58);
            this.waiter3.Name = "waiter3";
            this.waiter3.Size = new System.Drawing.Size(97, 22);
            this.waiter3.TabIndex = 10;
            this.waiter3.Text = "Официант";
            // 
            // guest3
            // 
            this.guest3.AutoSize = true;
            this.guest3.Location = new System.Drawing.Point(115, 16);
            this.guest3.Name = "guest3";
            this.guest3.Size = new System.Drawing.Size(20, 22);
            this.guest3.TabIndex = 9;
            this.guest3.Text = "0";
            // 
            // table4Panel
            // 
            this.table4Panel.Controls.Add(this.timer4);
            this.table4Panel.Controls.Add(this.table4);
            this.table4Panel.Controls.Add(this.guest4);
            this.table4Panel.Controls.Add(this.waiter4);
            this.table4Panel.Location = new System.Drawing.Point(621, 3);
            this.table4Panel.Name = "table4Panel";
            this.table4Panel.Size = new System.Drawing.Size(200, 100);
            this.table4Panel.TabIndex = 3;
            this.table4Panel.Click += new System.EventHandler(this.table4Panel_Click);
            // 
            // timer4
            // 
            this.timer4.AutoSize = true;
            this.timer4.Location = new System.Drawing.Point(103, 58);
            this.timer4.Name = "timer4";
            this.timer4.Size = new System.Drawing.Size(65, 22);
            this.timer4.TabIndex = 12;
            this.timer4.Text = "Время";
            // 
            // table4
            // 
            this.table4.AutoSize = true;
            this.table4.Location = new System.Drawing.Point(9, 16);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(66, 22);
            this.table4.TabIndex = 15;
            this.table4.Text = "Стол 4";
            // 
            // guest4
            // 
            this.guest4.AutoSize = true;
            this.guest4.Location = new System.Drawing.Point(103, 16);
            this.guest4.Name = "guest4";
            this.guest4.Size = new System.Drawing.Size(20, 22);
            this.guest4.TabIndex = 13;
            this.guest4.Text = "0";
            // 
            // waiter4
            // 
            this.waiter4.AutoSize = true;
            this.waiter4.Location = new System.Drawing.Point(9, 58);
            this.waiter4.Name = "waiter4";
            this.waiter4.Size = new System.Drawing.Size(97, 22);
            this.waiter4.TabIndex = 14;
            this.waiter4.Text = "Официант";
            // 
            // table5Panel
            // 
            this.table5Panel.Controls.Add(this.timer5);
            this.table5Panel.Controls.Add(this.table5);
            this.table5Panel.Controls.Add(this.waiter5);
            this.table5Panel.Controls.Add(this.guest5);
            this.table5Panel.Location = new System.Drawing.Point(827, 3);
            this.table5Panel.Name = "table5Panel";
            this.table5Panel.Size = new System.Drawing.Size(200, 100);
            this.table5Panel.TabIndex = 4;
            this.table5Panel.Click += new System.EventHandler(this.table5Panel_Click);
            // 
            // timer5
            // 
            this.timer5.AutoSize = true;
            this.timer5.Location = new System.Drawing.Point(109, 58);
            this.timer5.Name = "timer5";
            this.timer5.Size = new System.Drawing.Size(65, 22);
            this.timer5.TabIndex = 16;
            this.timer5.Text = "Время";
            // 
            // table5
            // 
            this.table5.AutoSize = true;
            this.table5.Location = new System.Drawing.Point(15, 16);
            this.table5.Name = "table5";
            this.table5.Size = new System.Drawing.Size(66, 22);
            this.table5.TabIndex = 19;
            this.table5.Text = "Стол 5";
            // 
            // waiter5
            // 
            this.waiter5.AutoSize = true;
            this.waiter5.Location = new System.Drawing.Point(15, 58);
            this.waiter5.Name = "waiter5";
            this.waiter5.Size = new System.Drawing.Size(97, 22);
            this.waiter5.TabIndex = 18;
            this.waiter5.Text = "Официант";
            // 
            // guest5
            // 
            this.guest5.AutoSize = true;
            this.guest5.Location = new System.Drawing.Point(109, 16);
            this.guest5.Name = "guest5";
            this.guest5.Size = new System.Drawing.Size(20, 22);
            this.guest5.TabIndex = 17;
            this.guest5.Text = "0";
            // 
            // stopList
            // 
            this.stopList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.stopList.Location = new System.Drawing.Point(13, 16);
            this.stopList.Name = "stopList";
            this.stopList.Size = new System.Drawing.Size(216, 62);
            this.stopList.TabIndex = 19;
            this.stopList.Text = "Ограниченные блюда";
            this.stopList.UseVisualStyleBackColor = true;
            this.stopList.Click += new System.EventHandler(this.stopList_Click);
            // 
            // stopdata
            // 
            this.stopdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stopdata.Location = new System.Drawing.Point(3, 109);
            this.stopdata.Name = "stopdata";
            this.stopdata.Size = new System.Drawing.Size(584, 351);
            this.stopdata.TabIndex = 4;
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 626);
            this.Controls.Add(this.stopList);
            this.Controls.Add(this.ordersList);
            this.Controls.Add(this.offButtonP);
            this.Controls.Add(this.exitButton);
            this.Name = "Waiter";
            this.Text = "Waiter";
            ((System.ComponentModel.ISupportInitialize)(this.offButtonL)).EndInit();
            this.offButtonP.ResumeLayout(false);
            this.ordersList.ResumeLayout(false);
            this.table1Panel.ResumeLayout(false);
            this.table1Panel.PerformLayout();
            this.table2Panel.ResumeLayout(false);
            this.table2Panel.PerformLayout();
            this.table3Panel.ResumeLayout(false);
            this.table3Panel.PerformLayout();
            this.table4Panel.ResumeLayout(false);
            this.table4Panel.PerformLayout();
            this.table5Panel.ResumeLayout(false);
            this.table5Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.PictureBox offButtonL;
        private System.Windows.Forms.Panel offButtonP;
        private System.Windows.Forms.FlowLayoutPanel ordersList;
        private System.Windows.Forms.Panel table1Panel;
        private System.Windows.Forms.Label timer1;
        private System.Windows.Forms.Label table1;
        private System.Windows.Forms.Label waiterLabel1;
        private System.Windows.Forms.Label guest1;
        private System.Windows.Forms.Panel table2Panel;
        private System.Windows.Forms.Label timer2;
        private System.Windows.Forms.Label table2;
        private System.Windows.Forms.Label guest2;
        private System.Windows.Forms.Label waiter2;
        private System.Windows.Forms.Panel table3Panel;
        private System.Windows.Forms.Label timer3;
        private System.Windows.Forms.Label table3;
        private System.Windows.Forms.Label waiter3;
        private System.Windows.Forms.Label guest3;
        private System.Windows.Forms.Panel table4Panel;
        private System.Windows.Forms.Label timer4;
        private System.Windows.Forms.Label table4;
        private System.Windows.Forms.Label guest4;
        private System.Windows.Forms.Label waiter4;
        private System.Windows.Forms.Panel table5Panel;
        private System.Windows.Forms.Label timer5;
        private System.Windows.Forms.Label table5;
        private System.Windows.Forms.Label waiter5;
        private System.Windows.Forms.Label guest5;
        private System.Windows.Forms.Button stopList;
        private System.Windows.Forms.DataGridView stopdata;
    }
}