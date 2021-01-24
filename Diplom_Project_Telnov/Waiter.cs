using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Project_Telnov
{
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ordersList.Visible = true;
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

        private void table1Panel_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void table2Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void table1Panel_Click(object sender, EventArgs e)
        {
            string waiter = DB.Name_user;
            Table.TableWaiter = DB.Name_user;
            int table1val = 1;
            Table.TableTable = table1val.ToString();
            object timer = DateTime.Now;
            Table.TableTimer = timer.ToString();

            table1.Text = waiter;
            timer1.Text = timer.ToString();
            

            try
            {
                InputForm infor = new InputForm();
                infor.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            guest1.Text = Table.TableGuest;
        }

        private void table2Panel_Click(object sender, EventArgs e)
        {
            string waiter = DB.Name_user;
            Table.TableWaiter = DB.Name_user;
            int table1val = 2;
            Table.TableTable = table1val.ToString();
            object timer = DateTime.Now;
            Table.TableTimer = timer.ToString();

            table1.Text = waiter;
            timer1.Text = timer.ToString();


            try
            {
                InputForm infor = new InputForm();
                infor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            guest1.Text = Table.TableGuest;
        }

        private void table3Panel_Click(object sender, EventArgs e)
        {
            string waiter = DB.Name_user;
            Table.TableWaiter = DB.Name_user;
            int table1val = 3;
            Table.TableTable = table1val.ToString();
            object timer = DateTime.Now;
            Table.TableTimer = timer.ToString();

            table1.Text = waiter;
            timer1.Text = timer.ToString();


            try
            {
                InputForm infor = new InputForm();
                infor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            guest1.Text = Table.TableGuest;
        }

        private void table4Panel_Click(object sender, EventArgs e)
        {
            string waiter = DB.Name_user;
            Table.TableWaiter = DB.Name_user;
            int table1val = 1;
            Table.TableTable = table1val.ToString();
            object timer = DateTime.Now;
            Table.TableTimer = timer.ToString();

            table1.Text = waiter;
            timer1.Text = timer.ToString();


            try
            {
                InputForm infor = new InputForm();
                infor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            guest1.Text = Table.TableGuest;
        }

        private void table5Panel_Click(object sender, EventArgs e)
        {
            string waiter = DB.Name_user;
            Table.TableWaiter = DB.Name_user;
            int table1val = 1;
            Table.TableTable = table1val.ToString();
            object timer = DateTime.Now;
            Table.TableTimer = timer.ToString();

            table1.Text = waiter;
            timer1.Text = timer.ToString();


            try
            {
                InputForm infor = new InputForm();
                infor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            guest1.Text = Table.TableGuest;
        }

        private void stopList_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.getConnection();
            try
            {
                db.openConnection();
                string sql = "SELECT * FROM stoplist ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                stopdata.DataSource = ds.Tables[0];
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }


}
