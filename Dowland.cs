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
    public partial class Dowland : Form
    {
        public Dowland()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Dowland_Load(object sender, EventArgs e)
        {

        }
    }
}
