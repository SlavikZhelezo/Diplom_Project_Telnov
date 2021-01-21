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
            waiterActual.Text = "Сергей Миронов";
        }

        private void agree_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            object timeactual = DateTime.Now;
            string table = tableBox.Text;
            string guest = guestBox.Text;
            string waiter = "Сергей Миронов";


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Waiter wait = new Waiter();
            wait.Show();
            this.Hide();
        }
    }
}
