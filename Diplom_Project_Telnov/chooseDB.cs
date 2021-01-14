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

        DB db = new DB();

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (DB_Bakunina.Checked)
            {

                string connection_bak = "server=localhost;user=root;password=Semenovski3Polk13;database=ohooligans_bakunina;port=3306";
                DB.choosePub = connection_bak;
                MessageBox.Show(connection_bak);
            }

            else if (DB_Konushennaya.Checked)
            {

                string connection_kon = "server=localhost;user=root;password=Semenovski3Polk13;database=ohooligans_konushennaya;port=3306";
                DB.choosePub = connection_kon;
                MessageBox.Show(connection_kon);
            }

            else if (DB_Sadovaya.Checked)
            {
                string connection_sad = "server=localhost;user=root;password=Semenovski3Polk13;database=ohooligans_sadovaya;port=3306";
                DB.choosePub = connection_sad;
                MessageBox.Show(connection_sad);
            }
            
            AutorizationForm AutoForm = new AutorizationForm();
            AutoForm.Show();
            this.Hide();
        }

        private void chooseDB_Load(object sender, EventArgs e)
        {

        }
    }
}
