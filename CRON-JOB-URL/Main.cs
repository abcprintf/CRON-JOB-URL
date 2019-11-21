using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRON_JOB_URL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void getVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fileInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            lb_version.Text = fileInfo.FileVersion;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
