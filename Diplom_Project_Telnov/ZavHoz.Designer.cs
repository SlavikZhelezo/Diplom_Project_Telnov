namespace Diplom_Project_Telnov
{
    partial class ZavHoz
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
            this.usersButton = new System.Windows.Forms.Label();
            this.offButtonP = new System.Windows.Forms.Panel();
            this.offButtonL = new System.Windows.Forms.PictureBox();
            this.getAlco = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.getProduct = new System.Windows.Forms.Label();
            this.orderProducts = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_of_measure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_of_products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_number = new System.Windows.Forms.Label();
            this.nameOfProduct = new System.Windows.Forms.Label();
            this.codeOfProducts = new System.Windows.Forms.Label();
            this.unitOfMeasure = new System.Windows.Forms.Label();
            this.quantityOfProducts = new System.Windows.Forms.Label();
            this.prodNumbBox = new System.Windows.Forms.TextBox();
            this.prodNameBox = new System.Windows.Forms.TextBox();
            this.quantityOfProd = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.addLine = new System.Windows.Forms.Button();
            this.saveOrder = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.codeOfProduct = new System.Windows.Forms.TextBox();
            this.unitmeasure = new System.Windows.Forms.TextBox();
            this.addToStorage = new System.Windows.Forms.Button();
            this.providerID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.costProducts = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.TextBox();
            this.getAlcoButton = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.rulesUserCombo = new System.Windows.Forms.ComboBox();
            this.rulesUser = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.passwordFieldBox = new System.Windows.Forms.TextBox();
            this.idUserField = new System.Windows.Forms.Label();
            this.editUser = new System.Windows.Forms.Label();
            this.deleteUser = new System.Windows.Forms.Label();
            this.addUser = new System.Windows.Forms.Label();
            this.idFieldBox = new System.Windows.Forms.TextBox();
            this.passwordUserField = new System.Windows.Forms.Label();
            this.userFeildBox = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.Label();
            this.editUserButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.offButtonP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offButtonL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuPanel.Controls.Add(this.usersButton);
            this.menuPanel.Controls.Add(this.offButtonP);
            this.menuPanel.Controls.Add(this.getAlco);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.getProduct);
            this.menuPanel.Controls.Add(this.orderProducts);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(224, 574);
            this.menuPanel.TabIndex = 0;
            // 
            // usersButton
            // 
            this.usersButton.AutoSize = true;
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.usersButton.Location = new System.Drawing.Point(29, 128);
            this.usersButton.MaximumSize = new System.Drawing.Size(170, 0);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(159, 44);
            this.usersButton.TabIndex = 26;
            this.usersButton.Text = "Управление пользоваателями";
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // offButtonP
            // 
            this.offButtonP.BackColor = System.Drawing.Color.Red;
            this.offButtonP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.offButtonP.Controls.Add(this.offButtonL);
            this.offButtonP.Location = new System.Drawing.Point(8, 485);
            this.offButtonP.Name = "offButtonP";
            this.offButtonP.Size = new System.Drawing.Size(78, 78);
            this.offButtonP.TabIndex = 25;
            this.offButtonP.Paint += new System.Windows.Forms.PaintEventHandler(this.offButtonP_Paint);
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
            this.offButtonL.Click += new System.EventHandler(this.offButtonL_Click);
            // 
            // getAlco
            // 
            this.getAlco.AutoSize = true;
            this.getAlco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.getAlco.Location = new System.Drawing.Point(29, 89);
            this.getAlco.Name = "getAlco";
            this.getAlco.Size = new System.Drawing.Size(147, 22);
            this.getAlco.TabIndex = 2;
            this.getAlco.Text = "Прием алкоголя";
            this.getAlco.Click += new System.EventHandler(this.getAlco_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.exitButton.Location = new System.Drawing.Point(130, 487);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 78);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getProduct
            // 
            this.getProduct.AutoSize = true;
            this.getProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.getProduct.Location = new System.Drawing.Point(29, 49);
            this.getProduct.Name = "getProduct";
            this.getProduct.Size = new System.Drawing.Size(129, 22);
            this.getProduct.TabIndex = 1;
            this.getProduct.Text = "Прием товара";
            this.getProduct.Click += new System.EventHandler(this.getProduct_Click);
            // 
            // orderProducts
            // 
            this.orderProducts.AutoSize = true;
            this.orderProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.orderProducts.Location = new System.Drawing.Point(29, 9);
            this.orderProducts.Name = "orderProducts";
            this.orderProducts.Size = new System.Drawing.Size(122, 22);
            this.orderProducts.TabIndex = 0;
            this.orderProducts.Text = "Заказ товара";
            this.orderProducts.Click += new System.EventHandler(this.orderProducts_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Name,
            this.code_product,
            this.unit_of_measure,
            this.quantity_of_products});
            this.dataGridView1.Location = new System.Drawing.Point(230, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Товар №";
            this.Column1.Name = "Column1";
            // 
            // Name
            // 
            this.Name.HeaderText = "Название товара";
            this.Name.Name = "Name";
            // 
            // code_product
            // 
            this.code_product.HeaderText = "Код продукта";
            this.code_product.Name = "code_product";
            // 
            // unit_of_measure
            // 
            this.unit_of_measure.HeaderText = "Единица измерения";
            this.unit_of_measure.Name = "unit_of_measure";
            // 
            // quantity_of_products
            // 
            this.quantity_of_products.HeaderText = "Количество";
            this.quantity_of_products.Name = "quantity_of_products";
            // 
            // product_number
            // 
            this.product_number.AutoSize = true;
            this.product_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.product_number.Location = new System.Drawing.Point(240, 17);
            this.product_number.Name = "product_number";
            this.product_number.Size = new System.Drawing.Size(98, 22);
            this.product_number.TabIndex = 2;
            this.product_number.Text = "Продукт№";
            // 
            // nameOfProduct
            // 
            this.nameOfProduct.AutoSize = true;
            this.nameOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameOfProduct.Location = new System.Drawing.Point(240, 52);
            this.nameOfProduct.Name = "nameOfProduct";
            this.nameOfProduct.Size = new System.Drawing.Size(174, 22);
            this.nameOfProduct.TabIndex = 3;
            this.nameOfProduct.Text = "Название продукта";
            // 
            // codeOfProducts
            // 
            this.codeOfProducts.AutoSize = true;
            this.codeOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.codeOfProducts.Location = new System.Drawing.Point(240, 87);
            this.codeOfProducts.Name = "codeOfProducts";
            this.codeOfProducts.Size = new System.Drawing.Size(125, 22);
            this.codeOfProducts.TabIndex = 4;
            this.codeOfProducts.Text = "Код продукта";
            // 
            // unitOfMeasure
            // 
            this.unitOfMeasure.AutoSize = true;
            this.unitOfMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.unitOfMeasure.Location = new System.Drawing.Point(704, 17);
            this.unitOfMeasure.Name = "unitOfMeasure";
            this.unitOfMeasure.Size = new System.Drawing.Size(181, 22);
            this.unitOfMeasure.TabIndex = 5;
            this.unitOfMeasure.Text = "Единица измерения";
            // 
            // quantityOfProducts
            // 
            this.quantityOfProducts.AutoSize = true;
            this.quantityOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.quantityOfProducts.Location = new System.Drawing.Point(776, 55);
            this.quantityOfProducts.Name = "quantityOfProducts";
            this.quantityOfProducts.Size = new System.Drawing.Size(109, 22);
            this.quantityOfProducts.TabIndex = 6;
            this.quantityOfProducts.Text = "Количество";
            // 
            // prodNumbBox
            // 
            this.prodNumbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.prodNumbBox.Location = new System.Drawing.Point(420, 14);
            this.prodNumbBox.Name = "prodNumbBox";
            this.prodNumbBox.Size = new System.Drawing.Size(40, 27);
            this.prodNumbBox.TabIndex = 7;
            // 
            // prodNameBox
            // 
            this.prodNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.prodNameBox.Location = new System.Drawing.Point(420, 49);
            this.prodNameBox.Name = "prodNameBox";
            this.prodNameBox.Size = new System.Drawing.Size(255, 27);
            this.prodNameBox.TabIndex = 8;
            // 
            // quantityOfProd
            // 
            this.quantityOfProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.quantityOfProd.Location = new System.Drawing.Point(891, 52);
            this.quantityOfProd.Name = "quantityOfProd";
            this.quantityOfProd.Size = new System.Drawing.Size(66, 27);
            this.quantityOfProd.TabIndex = 9;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.code.Location = new System.Drawing.Point(416, 87);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(43, 22);
            this.code.TabIndex = 10;
            this.code.Text = "Код";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.unit.Location = new System.Drawing.Point(891, 17);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(84, 22);
            this.unit.TabIndex = 11;
            this.unit.Text = "Единица";
            // 
            // addLine
            // 
            this.addLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.addLine.Location = new System.Drawing.Point(1041, 87);
            this.addLine.Name = "addLine";
            this.addLine.Size = new System.Drawing.Size(181, 47);
            this.addLine.TabIndex = 12;
            this.addLine.Text = "Добавить в заказ";
            this.addLine.UseVisualStyleBackColor = true;
            this.addLine.Click += new System.EventHandler(this.addLine_Click);
            // 
            // saveOrder
            // 
            this.saveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.saveOrder.Location = new System.Drawing.Point(1041, 461);
            this.saveOrder.Name = "saveOrder";
            this.saveOrder.Size = new System.Drawing.Size(181, 47);
            this.saveOrder.TabIndex = 13;
            this.saveOrder.Text = "Сохранить заказ";
            this.saveOrder.UseVisualStyleBackColor = true;
            this.saveOrder.Click += new System.EventHandler(this.saveOrder_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.deleteOrder.Location = new System.Drawing.Point(233, 461);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(181, 47);
            this.deleteOrder.TabIndex = 14;
            this.deleteOrder.Text = "Удалить заказ";
            this.deleteOrder.UseVisualStyleBackColor = true;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // deleteSelected
            // 
            this.deleteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.deleteSelected.Location = new System.Drawing.Point(470, 461);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(205, 47);
            this.deleteSelected.TabIndex = 15;
            this.deleteSelected.Text = "Удалить выбранное";
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // codeOfProduct
            // 
            this.codeOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.codeOfProduct.Location = new System.Drawing.Point(419, 84);
            this.codeOfProduct.Name = "codeOfProduct";
            this.codeOfProduct.Size = new System.Drawing.Size(152, 27);
            this.codeOfProduct.TabIndex = 16;
            // 
            // unitmeasure
            // 
            this.unitmeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.unitmeasure.Location = new System.Drawing.Point(891, 14);
            this.unitmeasure.Name = "unitmeasure";
            this.unitmeasure.Size = new System.Drawing.Size(40, 27);
            this.unitmeasure.TabIndex = 17;
            // 
            // addToStorage
            // 
            this.addToStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.addToStorage.Location = new System.Drawing.Point(989, 87);
            this.addToStorage.Name = "addToStorage";
            this.addToStorage.Size = new System.Drawing.Size(233, 47);
            this.addToStorage.TabIndex = 18;
            this.addToStorage.Text = "Добавить в остатки";
            this.addToStorage.UseVisualStyleBackColor = true;
            this.addToStorage.Click += new System.EventHandler(this.addToStorage_Click);
            // 
            // providerID
            // 
            this.providerID.AutoSize = true;
            this.providerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.providerID.Location = new System.Drawing.Point(240, 125);
            this.providerID.Name = "providerID";
            this.providerID.Size = new System.Drawing.Size(149, 22);
            this.providerID.TabIndex = 19;
            this.providerID.Text = "Код поставщика";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Карамбус",
            "Партнер",
            "НатурПродукт",
            "Юнтолово-Индастриз"});
            this.comboBox1.Location = new System.Drawing.Point(419, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // costProducts
            // 
            this.costProducts.AutoSize = true;
            this.costProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.costProducts.Location = new System.Drawing.Point(817, 89);
            this.costProducts.Name = "costProducts";
            this.costProducts.Size = new System.Drawing.Size(53, 22);
            this.costProducts.TabIndex = 21;
            this.costProducts.Text = "Цена";
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.costBox.Location = new System.Drawing.Point(891, 84);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(66, 27);
            this.costBox.TabIndex = 22;
            // 
            // getAlcoButton
            // 
            this.getAlcoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.getAlcoButton.Location = new System.Drawing.Point(989, 87);
            this.getAlcoButton.Name = "getAlcoButton";
            this.getAlcoButton.Size = new System.Drawing.Size(233, 47);
            this.getAlcoButton.TabIndex = 23;
            this.getAlcoButton.Text = "Добавить в остатки";
            this.getAlcoButton.UseVisualStyleBackColor = true;
            this.getAlcoButton.Click += new System.EventHandler(this.getAlcoButton_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.rulesUserCombo);
            this.userPanel.Controls.Add(this.rulesUser);
            this.userPanel.Controls.Add(this.deleteUserButton);
            this.userPanel.Controls.Add(this.addUserButton);
            this.userPanel.Controls.Add(this.passwordFieldBox);
            this.userPanel.Controls.Add(this.idUserField);
            this.userPanel.Controls.Add(this.editUser);
            this.userPanel.Controls.Add(this.deleteUser);
            this.userPanel.Controls.Add(this.addUser);
            this.userPanel.Controls.Add(this.idFieldBox);
            this.userPanel.Controls.Add(this.passwordUserField);
            this.userPanel.Controls.Add(this.userFeildBox);
            this.userPanel.Controls.Add(this.userField);
            this.userPanel.Controls.Add(this.editUserButton);
            this.userPanel.Location = new System.Drawing.Point(244, 13);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(996, 148);
            this.userPanel.TabIndex = 24;
            // 
            // rulesUserCombo
            // 
            this.rulesUserCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rulesUserCombo.FormattingEnabled = true;
            this.rulesUserCombo.Items.AddRange(new object[] {
            "Директор",
            "Администратор",
            "Официант",
            "Заведующий хозяйством"});
            this.rulesUserCombo.Location = new System.Drawing.Point(683, 6);
            this.rulesUserCombo.Name = "rulesUserCombo";
            this.rulesUserCombo.Size = new System.Drawing.Size(121, 28);
            this.rulesUserCombo.TabIndex = 13;
            // 
            // rulesUser
            // 
            this.rulesUser.AutoSize = true;
            this.rulesUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rulesUser.Location = new System.Drawing.Point(605, 7);
            this.rulesUser.Name = "rulesUser";
            this.rulesUser.Size = new System.Drawing.Size(51, 22);
            this.rulesUser.TabIndex = 12;
            this.rulesUser.Text = "Роль";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.deleteUserButton.Location = new System.Drawing.Point(822, 84);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(156, 48);
            this.deleteUserButton.TabIndex = 11;
            this.deleteUserButton.Text = "Удалить";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.addUserButton.Location = new System.Drawing.Point(822, 84);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(156, 48);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // passwordFieldBox
            // 
            this.passwordFieldBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.passwordFieldBox.Location = new System.Drawing.Point(451, 45);
            this.passwordFieldBox.Name = "passwordFieldBox";
            this.passwordFieldBox.Size = new System.Drawing.Size(103, 27);
            this.passwordFieldBox.TabIndex = 8;
            // 
            // idUserField
            // 
            this.idUserField.AutoSize = true;
            this.idUserField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idUserField.Location = new System.Drawing.Point(298, 87);
            this.idUserField.Name = "idUserField";
            this.idUserField.Size = new System.Drawing.Size(151, 22);
            this.idUserField.TabIndex = 7;
            this.idUserField.Text = "ID Пользователя";
            // 
            // editUser
            // 
            this.editUser.AutoSize = true;
            this.editUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.editUser.Location = new System.Drawing.Point(17, 99);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(92, 22);
            this.editUser.TabIndex = 6;
            this.editUser.Text = "Изменить";
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.AutoSize = true;
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.deleteUser.Location = new System.Drawing.Point(17, 61);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(80, 22);
            this.deleteUser.TabIndex = 5;
            this.deleteUser.Text = "Удалить";
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // addUser
            // 
            this.addUser.AutoSize = true;
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.addUser.Location = new System.Drawing.Point(17, 17);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(91, 22);
            this.addUser.TabIndex = 4;
            this.addUser.Text = "Добавить";
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // idFieldBox
            // 
            this.idFieldBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idFieldBox.Location = new System.Drawing.Point(451, 84);
            this.idFieldBox.Name = "idFieldBox";
            this.idFieldBox.Size = new System.Drawing.Size(103, 27);
            this.idFieldBox.TabIndex = 3;
            // 
            // passwordUserField
            // 
            this.passwordUserField.AutoSize = true;
            this.passwordUserField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.passwordUserField.Location = new System.Drawing.Point(298, 45);
            this.passwordUserField.Name = "passwordUserField";
            this.passwordUserField.Size = new System.Drawing.Size(72, 22);
            this.passwordUserField.TabIndex = 2;
            this.passwordUserField.Text = "Пароль";
            // 
            // userFeildBox
            // 
            this.userFeildBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.userFeildBox.Location = new System.Drawing.Point(451, 3);
            this.userFeildBox.Name = "userFeildBox";
            this.userFeildBox.Size = new System.Drawing.Size(103, 27);
            this.userFeildBox.TabIndex = 1;
            // 
            // userField
            // 
            this.userField.AutoSize = true;
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.userField.Location = new System.Drawing.Point(298, 7);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(128, 22);
            this.userField.TabIndex = 0;
            this.userField.Text = "Пользователь";
            // 
            // editUserButton
            // 
            this.editUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.editUserButton.Location = new System.Drawing.Point(822, 84);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(156, 48);
            this.editUserButton.TabIndex = 10;
            this.editUserButton.Text = "Изменить";
            this.editUserButton.UseVisualStyleBackColor = true;
            // 
            // ZavHoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 574);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.costProducts);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.providerID);
            this.Controls.Add(this.unitmeasure);
            this.Controls.Add(this.codeOfProduct);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.deleteOrder);
            this.Controls.Add(this.saveOrder);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.code);
            this.Controls.Add(this.quantityOfProd);
            this.Controls.Add(this.prodNameBox);
            this.Controls.Add(this.prodNumbBox);
            this.Controls.Add(this.quantityOfProducts);
            this.Controls.Add(this.unitOfMeasure);
            this.Controls.Add(this.codeOfProducts);
            this.Controls.Add(this.nameOfProduct);
            this.Controls.Add(this.product_number);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.addLine);
            this.Controls.Add(this.getAlcoButton);
            this.Controls.Add(this.addToStorage);
            this.Text = "ZavHoz";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.offButtonP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offButtonL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label orderProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_of_measure;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_of_products;
        private System.Windows.Forms.Label product_number;
        private System.Windows.Forms.Label nameOfProduct;
        private System.Windows.Forms.Label codeOfProducts;
        private System.Windows.Forms.Label unitOfMeasure;
        private System.Windows.Forms.Label quantityOfProducts;
        private System.Windows.Forms.TextBox prodNumbBox;
        private System.Windows.Forms.TextBox prodNameBox;
        private System.Windows.Forms.TextBox quantityOfProd;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.Button addLine;
        private System.Windows.Forms.Button saveOrder;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Label getProduct;
        private System.Windows.Forms.TextBox codeOfProduct;
        private System.Windows.Forms.TextBox unitmeasure;
        private System.Windows.Forms.Button addToStorage;
        private System.Windows.Forms.Label providerID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label costProducts;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label getAlco;
        private System.Windows.Forms.Button getAlcoButton;
        private System.Windows.Forms.Panel offButtonP;
        private System.Windows.Forms.PictureBox offButtonL;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label usersButton;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox passwordFieldBox;
        private System.Windows.Forms.Label idUserField;
        private System.Windows.Forms.Label editUser;
        private System.Windows.Forms.Label deleteUser;
        private System.Windows.Forms.Label addUser;
        private System.Windows.Forms.TextBox idFieldBox;
        private System.Windows.Forms.Label passwordUserField;
        private System.Windows.Forms.TextBox userFeildBox;
        private System.Windows.Forms.Label userField;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.ComboBox rulesUserCombo;
        private System.Windows.Forms.Label rulesUser;
    }
}