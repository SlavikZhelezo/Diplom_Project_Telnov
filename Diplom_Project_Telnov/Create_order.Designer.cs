﻿namespace Diplom_Project_Telnov
{
    partial class Create_order
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.grimbblond = new System.Windows.Forms.Label();
            this.grimbdubel = new System.Windows.Forms.Label();
            this.blanch = new System.Windows.Forms.Label();
            this.kilkenny = new System.Windows.Forms.Label();
            this.scottish = new System.Windows.Forms.Label();
            this.guinness = new System.Windows.Forms.Label();
            this.Strong = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Label();
            this.beer = new System.Windows.Forms.Label();
            this.cockpanel = new System.Windows.Forms.Panel();
            this.ribai = new System.Windows.Forms.Label();
            this.steikFM = new System.Windows.Forms.Label();
            this.salad2 = new System.Windows.Forms.Label();
            this.irishlep3 = new System.Windows.Forms.Label();
            this.irishlep = new System.Windows.Forms.Label();
            this.salad1 = new System.Windows.Forms.Label();
            this.cuisine = new System.Windows.Forms.Label();
            this.orderdata = new System.Windows.Forms.DataGridView();
            this.number_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_posit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_order = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.cockpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdata)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.cockpanel);
            this.menuPanel.Controls.Add(this.grimbblond);
            this.menuPanel.Controls.Add(this.grimbdubel);
            this.menuPanel.Controls.Add(this.blanch);
            this.menuPanel.Controls.Add(this.kilkenny);
            this.menuPanel.Controls.Add(this.bar);
            this.menuPanel.Controls.Add(this.scottish);
            this.menuPanel.Controls.Add(this.Strong);
            this.menuPanel.Controls.Add(this.guinness);
            this.menuPanel.Controls.Add(this.cuisine);
            this.menuPanel.Controls.Add(this.beer);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(347, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // grimbblond
            // 
            this.grimbblond.AutoSize = true;
            this.grimbblond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.grimbblond.Location = new System.Drawing.Point(169, 239);
            this.grimbblond.MaximumSize = new System.Drawing.Size(170, 0);
            this.grimbblond.Name = "grimbblond";
            this.grimbblond.Size = new System.Drawing.Size(170, 62);
            this.grimbblond.TabIndex = 18;
            this.grimbblond.Text = "Гримберген Блонд";
            this.grimbblond.Click += new System.EventHandler(this.grimbblond_Click);
            // 
            // grimbdubel
            // 
            this.grimbdubel.AutoSize = true;
            this.grimbdubel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.grimbdubel.Location = new System.Drawing.Point(10, 239);
            this.grimbdubel.MaximumSize = new System.Drawing.Size(170, 0);
            this.grimbdubel.Name = "grimbdubel";
            this.grimbdubel.Size = new System.Drawing.Size(170, 62);
            this.grimbdubel.TabIndex = 17;
            this.grimbdubel.Text = "Гримберген Дубель";
            this.grimbdubel.Click += new System.EventHandler(this.grimbdubel_Click);
            // 
            // blanch
            // 
            this.blanch.AutoSize = true;
            this.blanch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.blanch.Location = new System.Drawing.Point(171, 163);
            this.blanch.MaximumSize = new System.Drawing.Size(170, 0);
            this.blanch.Name = "blanch";
            this.blanch.Size = new System.Drawing.Size(144, 62);
            this.blanch.TabIndex = 16;
            this.blanch.Text = "Бланш де Брюссель";
            this.blanch.Click += new System.EventHandler(this.blanch_Click);
            // 
            // kilkenny
            // 
            this.kilkenny.AutoSize = true;
            this.kilkenny.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.kilkenny.Location = new System.Drawing.Point(10, 163);
            this.kilkenny.Name = "kilkenny";
            this.kilkenny.Size = new System.Drawing.Size(136, 31);
            this.kilkenny.TabIndex = 15;
            this.kilkenny.Text = "Килкенни";
            this.kilkenny.Click += new System.EventHandler(this.kilkenny_Click);
            // 
            // scottish
            // 
            this.scottish.AutoSize = true;
            this.scottish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.scottish.Location = new System.Drawing.Point(174, 77);
            this.scottish.MaximumSize = new System.Drawing.Size(170, 0);
            this.scottish.Name = "scottish";
            this.scottish.Size = new System.Drawing.Size(131, 62);
            this.scottish.TabIndex = 14;
            this.scottish.Text = "Скоттиш Стаут";
            this.scottish.Click += new System.EventHandler(this.scottish_Click);
            // 
            // guinness
            // 
            this.guinness.AutoSize = true;
            this.guinness.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.guinness.Location = new System.Drawing.Point(10, 77);
            this.guinness.Name = "guinness";
            this.guinness.Size = new System.Drawing.Size(117, 31);
            this.guinness.TabIndex = 13;
            this.guinness.Text = "Гиннесс";
            this.guinness.Click += new System.EventHandler(this.guinness_Click);
            // 
            // Strong
            // 
            this.Strong.AutoSize = true;
            this.Strong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Strong.Location = new System.Drawing.Point(173, 7);
            this.Strong.Name = "Strong";
            this.Strong.Size = new System.Drawing.Size(152, 39);
            this.Strong.TabIndex = 12;
            this.Strong.Text = "Крепкое";
            this.Strong.Click += new System.EventHandler(this.Strong_Click);
            // 
            // bar
            // 
            this.bar.AutoSize = true;
            this.bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.bar.Location = new System.Drawing.Point(192, 26);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(77, 39);
            this.bar.TabIndex = 1;
            this.bar.Text = "Бар";
            this.bar.Click += new System.EventHandler(this.bar_Click);
            // 
            // beer
            // 
            this.beer.AutoSize = true;
            this.beer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.beer.Location = new System.Drawing.Point(26, 9);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(98, 39);
            this.beer.TabIndex = 11;
            this.beer.Text = "Пиво";
            this.beer.Click += new System.EventHandler(this.beer_Click_1);
            // 
            // cockpanel
            // 
            this.cockpanel.Controls.Add(this.ribai);
            this.cockpanel.Controls.Add(this.steikFM);
            this.cockpanel.Controls.Add(this.salad2);
            this.cockpanel.Controls.Add(this.irishlep3);
            this.cockpanel.Controls.Add(this.irishlep);
            this.cockpanel.Controls.Add(this.salad1);
            this.cockpanel.Location = new System.Drawing.Point(16, 12);
            this.cockpanel.Name = "cockpanel";
            this.cockpanel.Size = new System.Drawing.Size(323, 319);
            this.cockpanel.TabIndex = 19;
            // 
            // ribai
            // 
            this.ribai.AutoSize = true;
            this.ribai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ribai.Location = new System.Drawing.Point(168, 191);
            this.ribai.MaximumSize = new System.Drawing.Size(130, 0);
            this.ribai.Name = "ribai";
            this.ribai.Size = new System.Drawing.Size(62, 22);
            this.ribai.TabIndex = 5;
            this.ribai.Text = "Рибай";
            this.ribai.Click += new System.EventHandler(this.ribai_Click);
            // 
            // steikFM
            // 
            this.steikFM.AutoSize = true;
            this.steikFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.steikFM.Location = new System.Drawing.Point(168, 155);
            this.steikFM.MaximumSize = new System.Drawing.Size(130, 0);
            this.steikFM.Name = "steikFM";
            this.steikFM.Size = new System.Drawing.Size(124, 22);
            this.steikFM.TabIndex = 4;
            this.steikFM.Text = "Филе-Миньон";
            this.steikFM.Click += new System.EventHandler(this.steikFM_Click);
            // 
            // salad2
            // 
            this.salad2.AutoSize = true;
            this.salad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.salad2.Location = new System.Drawing.Point(24, 103);
            this.salad2.MaximumSize = new System.Drawing.Size(130, 0);
            this.salad2.Name = "salad2";
            this.salad2.Size = new System.Drawing.Size(123, 22);
            this.salad2.TabIndex = 3;
            this.salad2.Text = "салат Цезарь";
            this.salad2.Click += new System.EventHandler(this.salad2_Click);
            // 
            // irishlep3
            // 
            this.irishlep3.AutoSize = true;
            this.irishlep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.irishlep3.Location = new System.Drawing.Point(168, 93);
            this.irishlep3.MaximumSize = new System.Drawing.Size(130, 0);
            this.irishlep3.Name = "irishlep3";
            this.irishlep3.Size = new System.Drawing.Size(105, 44);
            this.irishlep3.TabIndex = 2;
            this.irishlep3.Text = "Лепешка с форелью";
            this.irishlep3.Click += new System.EventHandler(this.irishlep3_Click);
            // 
            // irishlep
            // 
            this.irishlep.AutoSize = true;
            this.irishlep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.irishlep.Location = new System.Drawing.Point(168, 20);
            this.irishlep.MaximumSize = new System.Drawing.Size(130, 0);
            this.irishlep.Name = "irishlep";
            this.irishlep.Size = new System.Drawing.Size(105, 44);
            this.irishlep.TabIndex = 1;
            this.irishlep.Text = "Лепешка с курицей";
            this.irishlep.Click += new System.EventHandler(this.irishlep_Click);
            // 
            // salad1
            // 
            this.salad1.AutoSize = true;
            this.salad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.salad1.Location = new System.Drawing.Point(24, 20);
            this.salad1.MaximumSize = new System.Drawing.Size(130, 0);
            this.salad1.Name = "salad1";
            this.salad1.Size = new System.Drawing.Size(98, 66);
            this.salad1.TabIndex = 0;
            this.salad1.Text = "Салат с жареной говядиной";
            this.salad1.Click += new System.EventHandler(this.salad1_Click);
            // 
            // cuisine
            // 
            this.cuisine.AutoSize = true;
            this.cuisine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cuisine.Location = new System.Drawing.Point(26, 26);
            this.cuisine.Name = "cuisine";
            this.cuisine.Size = new System.Drawing.Size(111, 39);
            this.cuisine.TabIndex = 0;
            this.cuisine.Text = "Кухня";
            this.cuisine.Click += new System.EventHandler(this.cuisine_Click);
            // 
            // orderdata
            // 
            this.orderdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_prod,
            this.Name_posit,
            this.volume,
            this.cost});
            this.orderdata.Location = new System.Drawing.Point(354, 0);
            this.orderdata.Name = "orderdata";
            this.orderdata.Size = new System.Drawing.Size(434, 301);
            this.orderdata.TabIndex = 1;
            // 
            // number_prod
            // 
            this.number_prod.HeaderText = "Номер блюда";
            this.number_prod.Name = "number_prod";
            // 
            // Name_posit
            // 
            this.Name_posit.HeaderText = "Название";
            this.Name_posit.Name = "Name_posit";
            // 
            // volume
            // 
            this.volume.HeaderText = "Количество";
            this.volume.Name = "volume";
            // 
            // cost
            // 
            this.cost.HeaderText = "Цена";
            this.cost.Name = "cost";
            // 
            // save_order
            // 
            this.save_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.save_order.Location = new System.Drawing.Point(620, 369);
            this.save_order.Name = "save_order";
            this.save_order.Size = new System.Drawing.Size(149, 51);
            this.save_order.TabIndex = 2;
            this.save_order.Text = "Сохранить";
            this.save_order.UseVisualStyleBackColor = true;
            this.save_order.Click += new System.EventHandler(this.save_order_Click);
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.menuButton.Location = new System.Drawing.Point(353, 369);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(149, 51);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Меню";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Create_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.save_order);
            this.Controls.Add(this.orderdata);
            this.Controls.Add(this.menuPanel);
            this.Name = "Create_order";
            this.Text = "Create_order";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.cockpanel.ResumeLayout(false);
            this.cockpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label bar;
        private System.Windows.Forms.Label cuisine;
        private System.Windows.Forms.Label grimbblond;
        private System.Windows.Forms.Label grimbdubel;
        private System.Windows.Forms.Label blanch;
        private System.Windows.Forms.Label kilkenny;
        private System.Windows.Forms.Label scottish;
        private System.Windows.Forms.Label guinness;
        private System.Windows.Forms.Label Strong;
        private System.Windows.Forms.Label beer;
        private System.Windows.Forms.DataGridView orderdata;
        private System.Windows.Forms.Button save_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_posit;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Panel cockpanel;
        private System.Windows.Forms.Label ribai;
        private System.Windows.Forms.Label steikFM;
        private System.Windows.Forms.Label salad2;
        private System.Windows.Forms.Label irishlep3;
        private System.Windows.Forms.Label irishlep;
        private System.Windows.Forms.Label salad1;
        private System.Windows.Forms.Button menuButton;
    }
}