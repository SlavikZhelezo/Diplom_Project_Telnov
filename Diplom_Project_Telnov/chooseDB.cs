using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Diplom_Project_Telnov
{
    public partial class chooseDB : Form
    {
        public chooseDB()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (DB_Bakunina.Checked)
            {

                MySqlConnection connection_bak = new MySqlConnection("server=localhost;user=root;password=Semenovski3Polk13;database=ohooligans_bakunina;port=3306");

            }

            else if (DB_Konushennaya.Checked)
            {

                MySqlConnection connection_kon = new MySqlConnection("server=localhost;user=root;password=Semenovski3Polk13;database=ohooligans_konushennaya;port=3306");

            }

            else if (DB_Sadovaya.Checked)
            {
                MySqlConnection connection_sad = new MySqlConnection("server=localhost;user=root;password=Semenovski3Polk13;database=ohooligans_sadovaya;port=3306");
            }
            this.Hide();
            AutorizationForm AutoForm = new AutorizationForm();
            AutoForm.Show();
        }
    }
}
