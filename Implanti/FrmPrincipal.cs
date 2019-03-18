using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Implanti.Source;
using Exception = System.Exception;

namespace Implanti
{
    public partial class FrmPrincipal : Form
    {
        private ListenerDatabase listener;
        private Timer t1;

        public FrmPrincipal()
        {
            InitializeComponent();
            listener = new ListenerDatabase();
            t1 = new Timer();
            t1.Interval = Convert.ToInt32(new IniFile("Settings.ini").Read("TempoDesaparecer", "Definicoes"));

            tmrRegistro.Enabled = true;
            tmrRegistro.Start();
            tmrRegistro.Interval = Convert.ToInt32(new IniFile("Settings.ini").Read("TempoVerificador", "Definicoes"));
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                toolBar.Icon = SystemIcons.Application;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                toolBar.Visible = false;               
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }        

        private void tmrRegistro_Tick(object sender, EventArgs e)
        {
            if (listener.RetrieveData())
            {
                this.WindowState = FormWindowState.Normal;
                t1.Enabled = true;
                t1.Start();

                t1.Tick += new EventHandler(timer1_Tick);
            }            
        }

        private void panel2_VisibleChanged(object sender, EventArgs e)
        {            
            if (!this.Visible)
            {
                //toolBar.Icon = SystemIcons.Application;
                //toolBar.BalloonTipText = "Seu formulário foi minimizado!";
                //toolBar.ShowBalloonTip(1000);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(txtTroco.Text);

                lblValor.Text = $"{total - listener.value}";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtTroco_OnValueChanged(object sender, EventArgs e)
        {
            t1.Enabled = true;
            t1.Interval = 30000;

            if (!t1.Enabled)
            {
                t1.Start();
                t1.Tick += new EventHandler(timer1_Tick);
            }

            //Implementar regex
            //var regex = new Regex(@"\$\d+\.\d{2}");

            //if (!regex.Match(this.txtTroco.Text))
            //{

            //}
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }

            t1.Stop();
        }
    }
}