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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        public class Safety
        {
            public static string Hash(string value)
            {
                var sha1 = System.Security.Cryptography.SHA1.Create();
                var inputBytes = Encoding.UTF8.GetBytes(value);
                var hash = sha1.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                for (var i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string Director = "Director";
            string Administrator = "Administrator";
            string Waiter = "Waiter";
            try
            {
                string LoginUser = loginField.Text;
                string Password = passwordField.Text;

                if (LoginUser == "" || Password == "")
                    MessageBox.Show("Заполните поля");
                if (LoginUser.Length < 2 || Password.Length < 2)
                    MessageBox.Show("Недостаточно символов. Не менее 5-ти символов");

                DB db = new DB();
                using (MySqlCommand command = new MySqlCommand("SELECT iduser, password, rules FROM user WHERE user=@Login;", db.getConnection()))
                {
                    command.Parameters.AddWithValue("@Login", LoginUser);
                    db.openConnection();


                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = Convert.ToString(reader["iduser"]);
                        string password = Convert.ToString(reader["password"]);
                        string rules = Convert.ToString(reader["rules"]);
                        //string hashedPassword = Safety.Hash(Password);
                        //password = password.ToUpper();//перевод пароля из БД в верхний регистр

                        DB.SimpleString = id;
                        
                        if (password != Password)
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                        else if (password == Password & rules == Director)
                        {
                            ZavHoz dirFORM = new ZavHoz();
                            dirFORM.Show();
                            this.Hide();
                        }
                        else if (password == Password & rules == Administrator)
                        {
                            Waiter admFORM = new Waiter();
                            admFORM.Show();
                            this.Hide();
                        }
                        else if (password == Password & rules == Waiter)
                        {
                            Waiter waitFORM = new Waiter();
                            MessageBox.Show(id);
                            waitFORM.Show();
                            this.Hide();
                        }
                        else if (password == Password & rules == "ZavHoz")
                        {
                            ZavHoz dirFORM = new ZavHoz();
                            dirFORM.Show();
                            this.Hide();
                        }
                    }
                    db.closeConnection();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Waiter wt = new Waiter();
            wt.Show();
            this.Hide();
        }
    }
    
}