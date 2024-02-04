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
    public partial class Dats : Form
    {
        public Dats()
        {
            InitializeComponent();
            FioMain.Text = DataBank.FioReg;
        }

        private void Dats_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephone_StationDataSet.Date". При необходимости она может быть перемещена или удалена.
            this.dateTableAdapter.Fill(this.telephone_StationDataSet.Date);

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

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }
    }
}
