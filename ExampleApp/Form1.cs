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
using System.Security.Cryptography;

namespace ExampleApp
{
    public partial class Form1 : Form
    {
        public int doktor_id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Vnesi_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username1.Text))
                MessageBox.Show("Внесете корисничко име");
            else if (string.IsNullOrWhiteSpace(password.Text))
                MessageBox.Show("Внесете лозинка");
            else
            {                
                SHA1 sha = new SHA1CryptoServiceProvider();
                var hash = sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password.Text));
                string pass = BitConverter.ToString(hash);
                pass = pass.Replace("-", "");
                string upit = " select * from proba_apteka.doktori where username_d = '" + username1.Text + "' and password_d = '" + pass + "'";

                DBConnect connection = new DBConnect();
                connection.openConnection();
                int id = connection.Login(upit);
                if (id != 0)
                {
                    LoginInfo.doktor_id = id;
                    this.Hide();
                    pacient p = new pacient();
                    p.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Невалидна комбинација.Обидете се пак!");
                }
            }
        }

        private void promeniPassword_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label3.Visible = true;
            username2.Visible = true;
            starPassword.Visible = true;
            novPassword.Visible = true;
            novPassword2.Visible = true;
            button3.Visible = true;
            this.Size = new Size(581, 496);
        }

        private void aptekar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Aptekar();
            f.ShowDialog();
        }


    }
}
