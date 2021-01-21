using MySql.Data.MySqlClient;
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
            nameOfProduct.Visible = true;
            prodNameBox.Visible = true;
            codeOfProducts.Visible = true;
            code.Visible = true;
            unitOfMeasure.Visible = true;
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
            getAlcoButton.Visible = false;
            addToStorage.Visible = false;
            unitmeasure.Visible = false;
            if (DB.SimpleString == "ZavHoz")
            {
                usersButton.Visible = false;
                guestsbd.Visible = false;
                staffButton.Visible = false;
            }
            guestPanel.Visible = false;
            comment.Visible = true;
            commentText.Visible = true;
        }

        private void orderProducts_Click(object sender, EventArgs e)
        {
            nameOfProduct.Visible = true;
            prodNameBox.Visible = true;
            codeOfProducts.Visible = true;
            code.Visible = true;
            unitOfMeasure.Visible = false;
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
            if (DB.SimpleString == "ZavHoz")
            {
                usersButton.Visible = false;
                guestsbd.Visible = false;
            }
            guestPanel.Visible = false;
            comment.Visible = true;
            commentText.Visible = true;
        }

        int line = 1;

        private void addLine_Click(object sender, EventArgs e)
        {
            
            string nameprod = prodNameBox.Text;
            string quant = quantityOfProd.Text;
            string comm = commentText.Text;

            dataGridView1.Rows.Add(line.ToString(), nameprod, quant, idprov,  comm);
            line++;
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
            nameOfProduct.Visible = true;
            prodNameBox.Visible = true;
            codeOfProducts.Visible = true;
            code.Visible = false;
            unitOfMeasure.Visible = true;
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
            addToStorage.Visible = true;
            getAlcoButton.Visible = false;
            userPanel.Visible = false;
            if (DB.SimpleString == "ZavHoz")
            {
                usersButton.Visible = false;
                guestsbd.Visible = false;
            }
            comment.Visible = false;
            commentText.Visible = false;
            guestPanel.Visible = false;
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
            nameOfProduct.Visible = true;
            prodNameBox.Visible = true;
            codeOfProducts.Visible = true;
            code.Visible = false;
            unitOfMeasure.Visible = true;
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
            if (DB.SimpleString == "ZavHoz")
            {
                usersButton.Visible = false;
                guestsbd.Visible = false;
            }
            comment.Visible = false;
            commentText.Visible = false;
            guestPanel.Visible = false;
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
            nameOfProduct.Visible = false;
            prodNameBox.Visible = false;
            codeOfProducts.Visible = false;
            code.Visible = false;
            unitOfMeasure.Visible = false;
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
            guestPanel.Visible = false;
            comment.Visible = false;
            commentText.Visible = false;

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

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string us = userFeildBox.Text;
            string id = idFieldBox.Text;

            try
            {
                MySqlCommand cmd = new MySqlCommand(" Delete from user where (user = '" + us + "' or iduser = '" + id + "')", db.getConnection());

                db.openConnection();

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные удалены");
                else
                    MessageBox.Show("Ошибка при удалении данных");

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string us = userFeildBox.Text;
            string pas = passwordFieldBox.Text;

            try
            {

                MySqlCommand cmd = new MySqlCommand("call sha1_password('" + us + "', '" + pas + "', '" + ruleB + "')", db.getConnection());

                db.openConnection();

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Пользователь добавлен");
                else
                    MessageBox.Show("Ошибка при добавлении пользователя");

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string us = userFeildBox.Text;
            string id = idFieldBox.Text;

            try
            {
                MySqlCommand cmd = new MySqlCommand(" call update_user('" + us + "', '" + id + "'," + ruleB + ")", db.getConnection());

                db.openConnection();

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные изменены");
                else
                    MessageBox.Show("Ошибка при изменении данных");

                db.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }    
        }

        string ruleB;
        private void rulesUserCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ruleB = rulesUserCombo.SelectedIndex.ToString();
            if (ruleB == "0")
                ruleB = "Director";
            else if (ruleB == "1")
                ruleB = "Administrator";
            else if (ruleB == "2")
                ruleB = "Waiter";
            else if (ruleB == "3")
                ruleB = "ZavHoz";
        }

        private void guestsbd_Click(object sender, EventArgs e)
        {
            nameOfProduct.Visible = false;
            prodNameBox.Visible = false;
            codeOfProducts.Visible = false;
            code.Visible = false;
            unitOfMeasure.Visible = false;
            quantityOfProducts.Visible = false;
            quantityOfProd.Visible = false;
            addLine.Visible = false;
            dataGridView1.Visible = false;
            deleteOrder.Visible = false;
            deleteSelected.Visible = false;
            saveOrder.Visible = false;
            costBox.Visible = false;
            costProducts.Visible = false;
            userPanel.Visible = false;
            getAlcoButton.Visible = false;
            addToStorage.Visible = false;
            unitmeasure.Visible = false;
            guestsbd.Visible = true;
            comment.Visible = false;
            commentText.Visible = false;
            providerID.Visible = false;
            comboBox1.Visible = false;
            codeOfProduct.Visible = false;
            guestPanel.Visible = true;
            Поиск.Visible = true;
            deleteLine.Visible = true;
            searchField.Visible = true;
            nameSearch.Visible = true;
            summSearch.Visible = true;
            phoneSearch.Visible = true;
            idSearch.Visible = true;
            toSumm.Visible = false;

            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=client_database;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM guests ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                guestdata.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void guestdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        string findLine;
        private void nameSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (nameSearch.Checked == true)
            {
                findLine = "name_guest";
                toSumm.Visible = false;
            }
        }

        private void summSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (summSearch.Checked == true)
            {
                findLine = "Summ";
                toSumm.Visible = true;
            }
        }

        private void idSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (idSearch.Checked == true)
            {
                findLine = "id_guest";
                toSumm.Visible = false;
            }
        }

        private void phoneSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneSearch.Checked == true)
            {
                findLine = "Phone_number";
                toSumm.Visible = false;
            }
        }

        private void deleteLine_Click(object sender, EventArgs e)
        {
            int index = guestdata.SelectedCells[0].RowIndex;
            if (index == 0 || index == guestdata.RowCount)
                MessageBox.Show("Выберите поле для удаления!");
            else
                guestdata.Rows.RemoveAt(index);
        }

        private void Поиск_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=client_database;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM guests  WHERE `"+ findLine +"` = '"+ searchField.Text +"'";
                MessageBox.Show(sql);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                guestdata.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            nameOfProduct.Visible = false;
            prodNameBox.Visible = false;
            codeOfProducts.Visible = false;
            code.Visible = false;
            unitOfMeasure.Visible = false;
            quantityOfProducts.Visible = false;
            quantityOfProd.Visible = false;
            addLine.Visible = false;
            dataGridView1.Visible = false;
            deleteOrder.Visible = false;
            deleteSelected.Visible = false;
            saveOrder.Visible = false;
            costBox.Visible = false;
            costProducts.Visible = false;
            userPanel.Visible = false;
            getAlcoButton.Visible = false;
            addToStorage.Visible = false;
            unitmeasure.Visible = false;
            guestsbd.Visible = true;
            comment.Visible = false;
            commentText.Visible = false;
            providerID.Visible = false;
            comboBox1.Visible = false;
            codeOfProduct.Visible = false;
            guestPanel.Visible = true;
            Поиск.Visible = false;
            deleteLine.Visible = false;
            searchField.Visible = false;
            nameSearch.Visible = false;
            summSearch.Visible = false;
            phoneSearch.Visible = false;
            idSearch.Visible = false;
            toSumm.Visible = false;

            DB db = new DB();
            db.getConnection();
            try
            {
                db.openConnection();
                string sql = "SELECT * FROM staff ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                guestdata.DataSource = ds.Tables[0];
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}