using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Browser
{
    public partial class SettingsFrm : Form
    {
        public SettingsFrm()
        {
            InitializeComponent();

            this.txtUrls1.Text = Properties.Settings.Default.Urls1 ;
            this.txtUrls2.Text = Properties.Settings.Default.Urls2;
            this.txtUrls3.Text = Properties.Settings.Default.Urls3;
            this.txtUrls4.Text = Properties.Settings.Default.Urls4;
            this.checkBox1.Checked = Properties.Settings.Default.KioskMode ;
            this.numericUpDown1.Value = Properties.Settings.Default.RefressTimeout ;
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Urls1 = this.txtUrls1.Text;
            Properties.Settings.Default.Urls2 = this.txtUrls2.Text;
            Properties.Settings.Default.Urls3 = this.txtUrls3.Text;
            Properties.Settings.Default.Urls4 = this.txtUrls4.Text;

            Properties.Settings.Default.KioskMode = this.checkBox1.Checked;

            Properties.Settings.Default.RefressTimeout = Decimal.ToInt32(numericUpDown1.Value );
            
            Properties.Settings.Default.Save();
        }
    }
}
