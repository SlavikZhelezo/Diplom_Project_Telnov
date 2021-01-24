using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Diplom_Project_Telnov
{
    public partial class Create_order : Form
    {
        public Create_order()
        {
            InitializeComponent();
            menuPanel.Visible = true;
            beer.Visible = false;
            Strong.Visible = false;
            guinness.Visible = false;
            scottish.Visible = false;
            kilkenny.Visible = false;
            grimbblond.Visible = false;
            grimbdubel.Visible = false;
            blanch.Visible = false;
            cockpanel.Visible = false;
        }

        private void bar_Click(object sender, EventArgs e)
        {
            cuisine.Visible = false;
            bar.Visible = false;
            Strong.Visible = false;
            beer.Visible = true;
        }

        private void beer_Click_1(object sender, EventArgs e)
        {
            beer.Visible = false;
            Strong.Visible = false;
            guinness.Visible = true;
            scottish.Visible = true;
            kilkenny.Visible = true;
            grimbblond.Visible = true;
            grimbdubel.Visible = true;
            blanch.Visible = true;
        }

        private void Strong_Click(object sender, EventArgs e)
        {

        }
        int line;
        private void guinness_Click(object sender, EventArgs e)
        {
            string nameposit = "Гиннесс";
            string vol = "0.56";
            string cost = "300";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void scottish_Click(object sender, EventArgs e)
        {
            string nameposit = "Скоттиш Стаут";
            string vol = "0.56";
            string cost = "300";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void kilkenny_Click(object sender, EventArgs e)
        {
            string nameposit = "Килкенни";
            string vol = "0.56";
            string cost = "300";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void blanch_Click(object sender, EventArgs e)
        {
            string nameposit = "Бланш де Брюссель";
            string vol = "0.56";
            string cost = "300";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void grimbdubel_Click(object sender, EventArgs e)
        {
            string nameposit = "Гримберген Дюббель";
            string vol = "0.56";
            string cost = "300";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void grimbblond_Click(object sender, EventArgs e)
        {
            string nameposit = "Гримберген Блонд";
            string vol = "0.56";
            string cost = "300";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void save_order_Click(object sender, EventArgs e)
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
                        for (int i = 0; i < orderdata.RowCount - 1; i++)
                        {
                            for (int j = 0; j < orderdata.ColumnCount; j++)
                            {
                                writer.Write(orderdata.Rows[i].Cells[j].Value.ToString());
                            }
                            writer.WriteLine();
                        }
                    }
                    catch (Exception ex)
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

        private void cuisine_Click(object sender, EventArgs e)
        {
            cockpanel.Visible = true;
            cuisine.Visible = false;
            bar.Visible = false;
        }

        private void salad1_Click(object sender, EventArgs e)
        {
            string nameposit = "Салат с жареной говядиной";
            string vol = "0";
            string cost = "330";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void salad2_Click(object sender, EventArgs e)
        {
            string nameposit = "Салат Цезарь";
            string vol = "0";
            string cost = "350";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void irishlep_Click(object sender, EventArgs e)
        {
            string nameposit = "Лепешка с курицей";
            string vol = "0";
            string cost = "360";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void irishlep3_Click(object sender, EventArgs e)
        {
            string nameposit = "Лепешка с форелью";
            string vol = "0";
            string cost = "360";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void steikFM_Click(object sender, EventArgs e)
        {
            string nameposit = "Филе-Миньон";
            string vol = "0";
            string cost = "930";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void ribai_Click(object sender, EventArgs e)
        {
            string nameposit = "Рибай";
            string vol = "0";
            string cost = "1300";

            orderdata.Rows.Add(line.ToString(), nameposit, vol, cost);
            line++;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = true;
            beer.Visible = false;
            Strong.Visible = false;
            guinness.Visible = false;
            scottish.Visible = false;
            kilkenny.Visible = false;
            grimbblond.Visible = false;
            grimbdubel.Visible = false;
            blanch.Visible = false;
            cockpanel.Visible = false;
            cuisine.Visible = true;
            bar.Visible = true;
        }
    }
}
