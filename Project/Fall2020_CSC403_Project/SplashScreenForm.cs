using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Timer tmr;
        private void SplashScreenForm_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            //FrmLevel lvl = new FrmLevel();
            //lvl.Show();
            this.Close();
        }
    }
}
