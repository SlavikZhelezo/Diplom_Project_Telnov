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
            saveButtonP.Visible = false;
            cancelButtonP.Visible = false;
            ordersList.Visible = false;
            testPanel.Visible = false;
        }

        
        private void exitButton_Click(object sender, EventArgs e)
        {
            AutorizationForm autor = new AutorizationForm();
            autor.Show();
            this.Hide();
        }

        private void test_Click(object sender, EventArgs e)
        {
            ordersList.Visible = true;
            testPanel.Visible = true;
        }
    }

    //Создать объект со следующими свойствами: номер стола, количество гостей, 
    //время создания заказа, сумма  заказа, официант


    class table
    {
        public int number_of_table;
        public int quantity_guest;
        public object time = DateTime.Now.ToString("yyyy.MM.dd  h:mm:ss");
        public double amount_table;
        public string waiter;
    }
}
