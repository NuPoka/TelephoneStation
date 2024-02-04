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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FioMain.Text = DataBank.FioReg;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephone_StationDataSet.Tarif". При необходимости она может быть перемещена или удалена.
            this.tarifTableAdapter.Fill(this.telephone_StationDataSet.Tarif);

        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            DataBank.FioReg = FioMain.Text;
            Users users = new Users();
            users.ShowDialog();
            this.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DataBank.FioReg = FioMain.Text;
            Dats dats = new Dats();
            dats.ShowDialog();
            this.Show();
            this.Hide();
        }
    }
}
