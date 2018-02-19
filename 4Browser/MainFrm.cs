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
    public partial class MainFrm : Form
    {
        FormWindowState normalWindowState;
        FormBorderStyle normalBorderStyle;
        Point normalLocation;
        bool kioskMode = false;

        int url1Index = 0;
        int url2Index = 0;
        int url3Index = 0;
        int url4Index = 0;

        Timer timer;

        public MainFrm()
        {
            normalLocation = this.Location;
            normalWindowState = this.WindowState;
            normalBorderStyle = this.FormBorderStyle;
            InitializeComponent();
            LoadSettings();           
        }
        private void LoadSettings()
        {
            url1Index = 0;
            url2Index = 0;
            url3Index = 0;
            url4Index = 0;
            RefressPages(null, null);
            LoadTimerSettings();

            if (Properties.Settings.Default.KioskMode != kioskMode)
            {
                SwichKioskMode();
            }
        }

        private void LoadTimerSettings()
        {
            if (timer == null)
            {
                timer = new Timer ();
                timer.Tick += RefressPages;
            }

            timer.Stop();

            if (Properties.Settings.Default.RefressTimeout > 0)
            {
                timer.Interval = 1000 * Properties.Settings.Default.RefressTimeout;
                timer.Start();
            }
        }

        private void SwichKioskMode()
        {
            if (!kioskMode) // TopMost = Kiosk mode
            {
                kioskMode = true;
                normalLocation = Location;
                normalWindowState = WindowState;
                normalBorderStyle = FormBorderStyle;
#if !DEBUG
                TopMost = true;                
#endif
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                WinApi.SetWinFullScreen(Handle);
            }
            else
            {
                kioskMode = false;
                TopMost = false;
                FormBorderStyle = normalBorderStyle;
                WindowState = normalWindowState;
                Location = normalLocation;
            }
        }

        private static string[] SplitUrls(string Urls)
        {
            return Urls.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        //Event handler
        private void RefressPages(object sender, EventArgs e)
        {
            if (timer != null ) timer.Stop();

            String[] urls;

            urls = SplitUrls(Properties.Settings.Default.Urls1);

            if (urls.Length == 0)
            { webBrowser1.Navigate("About:blank"); }
            else
            {
                url1Index %= urls.Length;
                webBrowser1.Navigate(urls[url1Index++]);
            }

            urls = SplitUrls(Properties.Settings.Default.Urls2); ;

            if (urls.Length == 0)
            { webBrowser2.Navigate("About:blank"); }
            else
            {
                url2Index %= urls.Length;
                webBrowser2.Navigate(urls[url2Index++]);
            }

            urls = SplitUrls(Properties.Settings.Default.Urls3);

            if (urls.Length == 0)
            { webBrowser3.Navigate("About:blank"); }
            else
            {
                url3Index %= urls.Length;
                webBrowser3.Navigate(urls[url3Index++]);
            }

            urls = SplitUrls(Properties.Settings.Default.Urls4);

            if (urls.Length == 0)
            { webBrowser4.Navigate("About:blank"); }
            else
            {
                url4Index %= urls.Length;
                webBrowser4.Navigate(urls[url4Index++]);
            }

            if (timer != null) timer.Start();

        }

        //Overrides
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F11:

                    SwichKioskMode();
                    return true;
                case Keys.F12:
                    timer.Stop();
                    using (SettingsFrm setting = new SettingsFrm())
                    {
                        if (setting.ShowDialog() == DialogResult.OK)
                            LoadSettings();

                    }

                    return true;
                default:
                    // Call the base class
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

    }
}
