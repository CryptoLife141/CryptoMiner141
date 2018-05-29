using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMiner141
{
    public partial class Form1 : Form
    {
        public static JArray textCPUMining;
        Thread t;
        //Thread updateApp;

        public Form1()
        {
            InitializeComponent();
        }

        public void btn_startMining_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(checkedListBoxMiner.Text);

            foreach (object itemChecked in checkedListBoxMiner.CheckedItems)
            {
                if (Regex.IsMatch(itemChecked.ToString(), @"\bCPU\b"))
                {
                    System.Diagnostics.Process.Start(@"Miner\CPU\xmrig\Monero.bat");

                    MyThreadHandle threadHandle = new MyThreadHandle();
                    t = new Thread(new ThreadStart(threadHandle.ThreadLoop));
                    t.Start();
                }

                if (Regex.IsMatch(itemChecked.ToString(), @"\bGPU\b"))
                {
                    System.Diagnostics.Process.Start(@"Miner\GPU\ccminer\BTCP.bat");
                }
            }

            //updateApp = new Thread(new ThreadStart(UpdateAppThread));
            //updateApp.Start();
        }

        private void btn_stopMining_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(System.Diagnostics.Process Proc in System.Diagnostics.Process.GetProcessesByName("xmrig"))
                {
                    Proc.Kill();
                    t.Abort();
                    //updateApp.Abort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("XMRig" + ex.Message);
            }

            try
            {
                foreach (System.Diagnostics.Process Proc in System.Diagnostics.Process.GetProcessesByName("ccminer-x64"))
                {
                    Proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CCMinerx64" + ex.Message);
            }
        }

        private void checkedListBoxMiner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settings settingsForm = new settings();

            settingsForm.ShowDialog();
        }

        //public static void UpdateAppThread()
        //{
        //    while (Thread.CurrentThread.IsAlive)
        //    {
        //        Thread.Sleep(500);

        //        //if (checkedListBoxMiner.Items.Cast<string>().Contains("CPU Mining"))
        //        //{
        //        //    int a = checkedListBoxMiner.Items.IndexOf("CPU Mining");
        //        //    //string text = Encoding.Default.GetString(textCPUMining);
        //        //    //Console.WriteLine(a);
        //        //    //checkedListBoxMiner.Items[a] = "CPU Mining : " + textCPUMining;
        //        //    //checkedListBoxMiner.Items.RemoveAt(a);
        //        //    //checkedListBoxMiner.Items.Insert(a, "CPU Mining : " + textCPUMining);
        //        //}
        //    }
        //    //checkedListBoxMiner.Items[0] = "test";
        //}
    }
}
