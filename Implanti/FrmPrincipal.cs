using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Implanti.Source;

namespace Implanti
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            //Cria um ini
            //var myIni = new IniFile("Settings.ini");

            //Cria um ini com a key User, value 123 e Section Settings
            //myIni.Write("User", "123", "Settings");

            //Lê o valor da key, na section
            //myIni.Read("User", "Settings")
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                toolBar.Icon = SystemIcons.Application;
                toolBar.BalloonTipText = "Seu formulário foi minimizado!";
                toolBar.ShowBalloonTip(1000);
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

        private void btnTroco_Click(object sender, EventArgs e)
        {
            ListenerDatabase listener = new ListenerDatabase();
        }
    }
}