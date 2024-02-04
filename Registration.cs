using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace TelephoneStation
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.ActiveControl = Label;
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            DataBase dataBases = new DataBase();
            var Fio = NameTextBox.Text;
            var Phone = PhoneTextBox.Text;
            var Login = LoginTextBox.Text;
            var Password = PasswordTextBox.Text;
            try
            {
            string querystring = $"insert into Client(Name_Client, Login_Client, Telephone_Client, Password_Client) values ('{Fio}','{Login}','{Phone}','{Password}')";

            SqlCommand command = new SqlCommand(querystring, dataBases.getConnection());
            dataBases.openConnection();
            
                if (command.ExecuteNonQuery() != 1)
                {
                    if (NameTextBox.Text == "Name_Client")
                        NameTextBox.BorderColor = Color.Red;
                    if (PhoneTextBox.Text == "Telephone_Client")
                        PhoneTextBox.BorderColor = Color.Red;
                    if (LoginTextBox.Text == "Login_Client")
                        LoginTextBox.BorderColor = Color.Red;
                    if (PasswordTextBox.Text == "Password_Client")
                        PasswordTextBox.BorderColor = Color.Red;
                    panelInfo.Visible = true;
                    labelMessenge.ForeColor = Color.Red;
                    labelMessenge.Text = "Есть пустые поля";
                }
                else
                {
                    DataBank.FioReg = NameTextBox.Text;
                    MessageBox.Show("Аккаунт был создан, поздравляю!");
                    Login login = new Login();
                    this.Hide();
                    login.ShowDialog();
                }
            }
            catch
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Пользователь с таким UserName уже зарегестрирован";
                dataBases.closeConnection();
            }
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Ваше ФИО")
            {
                NameTextBox.Text = "";
                NameTextBox.ForeColor = Color.Black;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameTextBox.Text = "Ваше ФИО";
                NameTextBox.ForeColor = Color.Black;
            }
        }

        private void PhoneTextBox_Enter(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text == "Номер телефона")
            {
                PhoneTextBox.Text = "";
                PhoneTextBox.ForeColor = Color.Black;
            }
        }

        private void PhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text == "")
            {
                PhoneTextBox.Text = "Номер телефона";
                PhoneTextBox.ForeColor = Color.Black;
            }
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Логин")
            {
                LoginTextBox.Text = "";
                LoginTextBox.ForeColor = Color.Black;
            }
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
            {
                LoginTextBox.Text = "Логин";
                LoginTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Пароль")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Пароль";
                PasswordTextBox.ForeColor = Color.Black;
            }
        }
    }
}
