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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            waiterActual.Text = Table.TableWaiter;
        }

        private void agree_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            Table.TableGuest = guestBox.Text;

            if (Table.TableWaiter == "Александр Алексеев")
                Table.TableWaiter = "1";

            string tableident = Table.TableTable + " " + Table.TableTimer;
            try
            {
                MySqlCommand cmd = new MySqlCommand("call create_order('"+ DB.Name_user +"', '"+ tableident +"', "+ Table.TableTable +", "+ Table.TableGuest + " , '"+ Table.TableTimer +"', 0, 0)", db.getConn());

                db.openConn();

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Заказ создан");
                else
                    MessageBox.Show("Ошибка при создании заказа");

                db.closeConn();

                Create_order ord = new Create_order();
                ord.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Create_order ord = new Create_order();
            ord.Show();
            this.Hide();
        }
    }
}
