using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneStation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = Label;
            Fio.Text = DataBank.FioReg;
        }
        private void BtnLog_Click(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text != "Telephone_Client" && LoginTextBox.Text != "Login_Client" && PasswordTextBox.Text != "Password_Client")
            {
                DataBase dataBases = new DataBase();
                var Phone = PhoneTextBox.Text;
                var Login = LoginTextBox.Text;
                var Password = PasswordTextBox.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select Id, Telephone_Client, Login_Client, Password_Client from Client where Login_Client ='{Login}' and Telephone_Client = '{Phone}' and Password_Client = '{Password}'";

                SqlCommand command = new SqlCommand(querystring, dataBases.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count != 1)
                {
                    ErrorPanel.Visible = true;
                    Messenge.ForeColor = Color.Red;
                    Messenge.Text = "Пользователь не найден";
                }
                else
                {
                    DataBank.FioReg = Fio.Text;
                    Main main = new Main();
                    main.ShowDialog();
                    this.Show();
                    this.Hide();
                }
            }
            else
            {
                if (PhoneTextBox.Text == "Telephone_Client")
                    PhoneTextBox.BorderColor = Color.Red;
                if (LoginTextBox.Text == "Login_Client")
                    LoginTextBox.BorderColor = Color.Red;
                if (PasswordTextBox.Text == "Password_Client")
                    PasswordTextBox.BorderColor = Color.Red;
                ErrorPanel.Visible = true;
                Messenge.ForeColor = Color.Red;
                Messenge.Text = "Есть пустые поля";
            }
        }
        private void ButtonReg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
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
                PhoneTextBox.ForeColor = Color.Gray;
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
                LoginTextBox.ForeColor = Color.Gray;
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
