using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneStation
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            FioMain.Text = DataBank.FioReg;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephone_StationDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.telephone_StationDataSet.User);

        }

        private void FioMain_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dats dats = new Dats();
            dats.Show();
        }
    }
}
