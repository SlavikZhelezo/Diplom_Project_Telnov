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
        }

        private void bar_Click(object sender, EventArgs e)
        {
            cuisine.Visible = false;
            bar.Visible = false;
            Strong.Visible = true;
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
            double summ = 0;
                    try
                    {
                        for (int i = 0; i < orderdata.RowCount - 1; i++)
                        {
                            summ += Convert.ToDouble(orderdata.Rows[i].Cells[3].Value);
                        }
                MessageBox.Show(summ.ToString());                   }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
            }
    }
}
