﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Project_Telnov
{
    public partial class ZavHoz : Form
    {
        public ZavHoz()
        {
            InitializeComponent();
            product_number.Visible = true;
            prodNumbBox.Visible = true;
            nameOfProduct.Visible = true;
            prodNameBox.Visible = true;
            codeOfProducts.Visible = true;
            code.Visible = true;
            unitOfMeasure.Visible = true;
            unit.Visible = true;
            quantityOfProducts.Visible = true;
            quantityOfProd.Visible = true;
            addLine.Visible = true;
            dataGridView1.Visible = true;
            deleteOrder.Visible = true;
            deleteSelected.Visible = true;
            saveOrder.Visible = true;
            costBox.Visible = true;
            costProducts.Visible = true;
            userPanel.Visible = false;
        }

        private void orderProducts_Click(object sender, EventArgs e)
        {
            product_number.Visible = true;
            prodNumbBox.Visible = true;
            nameOfProduct.Visible = true;
            prodNameBox.Visible = true;
            codeOfProducts.Visible = true;
            code.Visible = true;
            unitOfMeasure.Visible = true;
            unit.Visible = true;
            quantityOfProducts.Visible = true;
            quantityOfProd.Visible = true;
            addLine.Visible = true;
            dataGridView1.Visible = true;
            deleteOrder.Visible = true;
            deleteSelected.Visible = true;
            saveOrder.Visible = true;
            codeOfProduct.Visible = false;
            unitmeasure.Visible = false;
            providerID.Visible = true;
            comboBox1.Visible = true;
            unitmeasure.Visible = false;
            costBox.Visible = true;
            costProducts.Visible = true;
            addToStorage.Visible = false;
            getAlcoButton.Visible = false;
            userPanel.Visible = false;
        }

        private void addLine_Click(object sender, EventArgs e)
        {
            int prodNumber = 1;
            string nameprod = prodNameBox.Text;
            string cod = "114";
            string unit = "kg";
            string quant = quantityOfProd.Text;

            dataGridView1.Rows.Add(prodNumber.ToString(), nameprod, cod, unit, quant);
            prodNumber++;
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void deleteSelected_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            if (index == 0 || index == dataGridView1.RowCount)
                MessageBox.Show("Выберите поле для удаления!");
            else
                dataGridView1.Rows.RemoveAt(index);
        }

        private void saveOrder_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*.txt";
            Stream myStream;
            if (save.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = save.OpenFile()) != null)
                {
                    StreamWriter writer = new StreamWriter(myStream);
                    try 
                    { 
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            }
                            writer.WriteLine();
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        writer.Close();
                    }
                    myStream.Close();
                }
            }
        }

        private void getProduct_Click(object sender, EventArgs e)
        {
            product_number.Visible = false;
            prodNumbBox.Visible = false;
            nameOfProduct.Visible = true;
            prodNameBox.Visible = true;
            codeOfProducts.Visible = true;
            code.Visible = false;
            unitOfMeasure.Visible = true;
            unit.Visible = false;
            quantityOfProducts.Visible = true;
            quantityOfProd.Visible = true;
            addLine.Visible = true;
            dataGridView1.Visible = true;
            deleteOrder.Visible = true;
            deleteSelected.Visible = true;
            saveOrder.Visible = true;
            codeOfProduct.Visible = true;
            unitmeasure.Visible = true;
            deleteSelected.Visible = false;
            providerID.Visible = false;
            comboBox1.Visible = false;
            costBox.Visible = false;
            costProducts.Visible = false;
            addToStorage.Visible = true;
            getAlcoButton.Visible = false;
            userPanel.Visible = false;
        }

        private void addToStorage_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string nameprod = prodNameBox.Text;
            string code = codeOfProduct.Text;
            string unit = unitmeasure.Text;
            string quant = quantityOfProd.Text;
            
            string quantprod = "";

            using (MySqlCommand command = new MySqlCommand("SELECT `quantity` FROM `storageproducts` WHERE name_prod=@nameprod;", db.getConnection()))
            {
                command.Parameters.AddWithValue("@nameprod", nameprod);
                db.openConnection();


                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    quantprod = Convert.ToString(reader["quantity"]);
                    MessageBox.Show(quantprod);
                }
                db.closeConnection();

                if (nameprod == "" || code == "" || unit == "" || quant == "" || idprov == "")
                    MessageBox.Show("Заполните все поля!");
                else if (nameprod != "" || code != "" || unit != "" || quant != "" || idprov != "")
                    try
                    {
                        MessageBox.Show(quantprod);
                        quant = quant + quantprod;
                        MessageBox.Show(quant);
                        MySqlCommand cmd = new MySqlCommand("call add_to_storage(" + code + ",'" + nameprod + "'," + quant + ",'" + unit + "'); ", db.getConnection());
                        MessageBox.Show(cmd.ToString());
                        db.openConnection();

                        if (cmd.ExecuteNonQuery() == 1)
                            MessageBox.Show("Товар добавлен в остатки");
                        else
                            MessageBox.Show("Ошибка при добавлении остатков");

                        db.closeConnection();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
            }
            MessageBox.Show(quantprod);
            
        }

                string idprov;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idprov = comboBox1.SelectedIndex.ToString();
            if (idprov == "0")
                idprov = "001";
            else if (idprov == "1")
                idprov = "002";
            else if (idprov == "2")
                idprov = "003";
            else if (idprov == "3")
                idprov = "004";
            else if (idprov == "4")
                idprov = "005;";
        }

        private void getAlco_Click(object sender, EventArgs e)
        {
            product_number.Visible = false;
            prodNumbBox.Visible = false;
            nameOfProduct.Visible = true;
            prodNameBox.Visible = true;
            codeOfProducts.Visible = true;
            code.Visible = false;
            unitOfMeasure.Visible = true;
            unit.Visible = false;
            quantityOfProducts.Visible = true;
            quantityOfProd.Visible = true;
            addLine.Visible = false;
            dataGridView1.Visible = true;
            deleteOrder.Visible = true;
            deleteSelected.Visible = true;
            saveOrder.Visible = true;
            codeOfProduct.Visible = true;
            unitmeasure.Visible = true;
            deleteSelected.Visible = false;
            providerID.Visible = false;
            comboBox1.Visible = false;
            costBox.Visible = false;
            costProducts.Visible = false;
            addToStorage.Visible = false;
            userPanel.Visible = false;
            getAlcoButton.Visible = true;
        }

        private void getAlcoButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string nameprod = prodNameBox.Text;
            string code = codeOfProduct.Text;
            string unit = unitmeasure.Text;
            string quant = quantityOfProd.Text;

            string quantprod = "";

            using (MySqlCommand command = new MySqlCommand("SELECT `quantity` FROM `storageproducts` WHERE name_prod=@nameprod;", db.getConnection()))
            {
                command.Parameters.AddWithValue("@nameprod", nameprod);
                db.openConnection();


                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    quantprod = Convert.ToString(reader["quantity"]);
                    MessageBox.Show(quantprod);
                }
                db.closeConnection();

                if (nameprod == "" || code == "" || unit == "" || quant == "" || idprov == "")
                    MessageBox.Show("Заполните все поля!");
                else if (nameprod != "" || code != "" || unit != "" || quant != "" || idprov != "")
                    try
                    {
                        MessageBox.Show(quantprod);
                        quant = quant + quantprod;
                        MessageBox.Show(quant);
                        MySqlCommand cmd = new MySqlCommand("call add_to_storage(" + code + ",'" + nameprod + "'," + quant + ",'" + unit + "'); ", db.getConnection());
                        MessageBox.Show(cmd.ToString());
                        db.openConnection();

                        if (cmd.ExecuteNonQuery() == 1)
                            MessageBox.Show("Товар добавлен в остатки");
                        else
                            MessageBox.Show("Ошибка при добавлении остатков");

                        db.closeConnection();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
            }
            MessageBox.Show(quantprod);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AutorizationForm autor = new AutorizationForm();
            autor.Show();
            this.Hide();
        }

        private void offButtonP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void offButtonL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            product_number.Visible = false;
            prodNumbBox.Visible = false;
            nameOfProduct.Visible = false;
            prodNameBox.Visible = false;
            codeOfProducts.Visible = false;
            code.Visible = false;
            unitOfMeasure.Visible = false;
            unit.Visible = false;
            quantityOfProducts.Visible = false;
            quantityOfProd.Visible = false;
            addLine.Visible = false;
            dataGridView1.Visible = false;
            deleteOrder.Visible = false;
            deleteSelected.Visible = false;
            saveOrder.Visible = false;
            codeOfProduct.Visible = false;
            unitmeasure.Visible = false;
            providerID.Visible = false;
            comboBox1.Visible = false;
            unitmeasure.Visible = false;
            costBox.Visible = false;
            costProducts.Visible = false;
            addToStorage.Visible = false;
            getAlcoButton.Visible = false;

            userPanel.Visible = true;

            DB db = new DB();

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            userFeildBox.Visible = true;
            userField.Visible = true;
            passwordUserField.Visible = true;
            passwordFieldBox.Visible = true;
            idUserField.Visible = false;
            idFieldBox.Visible = false;
            rulesUser.Visible = true;
            rulesUserCombo.Visible = true;
            deleteUserButton.Visible = false;
            editUserButton.Visible = false;
            addUserButton.Visible = true;
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            userFeildBox.Visible = true;
            userField.Visible = true;
            passwordUserField.Visible = false;
            passwordFieldBox.Visible = false;
            idUserField.Visible = true;
            idFieldBox.Visible = true;
            rulesUser.Visible = false;
            rulesUserCombo.Visible = false;
            deleteUserButton.Visible = true;
            editUserButton.Visible = false;
            addUserButton.Visible = false;
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            userFeildBox.Visible = true;
            userField.Visible = true;
            passwordUserField.Visible = false;
            passwordFieldBox.Visible = false;
            idUserField.Visible = false;
            idFieldBox.Visible = false;
            rulesUser.Visible = true;
            rulesUserCombo.Visible = true;
            deleteUserButton.Visible = false;
            editUserButton.Visible = true;
            addUserButton.Visible = false;
        }
    }
}