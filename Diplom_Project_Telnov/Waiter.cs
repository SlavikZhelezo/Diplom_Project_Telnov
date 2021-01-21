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
            saveButtonP.Visible = false;
            cancelButtonP.Visible = false;
            ordersList.Visible = false;
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
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            InputForm input = new InputForm();
            input.Show();

            /*
            ordersList.Visible = true;
            
            FlowLayoutPanel table = new FlowLayoutPanel();
            Label number_table = new Label();
            Label quantity = new Label();
            Label amount = new Label();
            Label waiter = new Label();

            // Initialize the Panel control.
            table.Location = new Point();//создаем панель
            table.Size = new Size(264, 152);
            // Set the Borderstyle for the Panel to three-dimensional.
            table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // Initialize the Label and TextBox controls.

            number_table.Location = new Point();//создаем  текст с номером стола
            number_table.Text = "16";
            number_table.Size = new Size(104, 16);

            quantity.Location = new Point();//  текст с кол-вом человек
            quantity.Text = "2";
            quantity.Size = new Size();

            amount.Location = new Point();//текст с суммой
            amount.Text = "1435";
            amount.Size = new Size(104, 16);

            waiter.Location = new Point();//имя официанта
            waiter.Text = "Sergey";
            waiter.Size = new Size(104, 16);

            // Add the Panel control to the form.
            ordersList.Controls.Add(table);
            // Add the Label and TextBox controls to the Panel.
            table.Controls.Add(number_table);
            table.Controls.Add(quantity);
            table.Controls.Add(waiter);
            table.Controls.Add(amount);*/
        }

        private void offButtonP_Paint(object sender, PaintEventArgs e)
        {

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
