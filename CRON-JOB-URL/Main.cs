using CRON_JOB_URL.CronNET;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CRON_JOB_URL
{
    public partial class Main : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private readonly CronDaemon cron_daemon = new CronDaemon();

        public Main()
        {
            InitializeComponent();

            // get version
            getVersion();

            // init cronJob
            cronJob();
        }

        public void getVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fileInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            lb_version.Text = "Version " + fileInfo.FileVersion;
        }

        public async void runJob()
        {
            string urlBase = Properties.Settings.Default.BaseUrl;
            var responseString = await client.GetStringAsync(urlBase);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(responseString);
            string message = item["message"];
            string datetime = item["dateTime"];

            string textMessage = datetime + " - " + message;

            tb_log.Invoke(new Action(() => tb_log.Text += textMessage.ToString() + Environment.NewLine));
        }

        public void cronJob()
        {
            var d = new CronDaemon();
            // get CronJob from setting.
            var cronschedule = Properties.Settings.Default.CronJob;
            d.AddJob(cronschedule, () => { runJob(); });
            d.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
