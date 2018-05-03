using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMiner141
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_startMining_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBoxMiner.CheckedItems)
            {
                if (itemChecked.ToString() == "CPU Mining")
                {
                    System.Diagnostics.Process.Start(@"Miner\CPU\xmrig-2.6.0\Monero.bat");

                    var json = new System.Net.WebClient().DownloadString("http://127.0.0.1:23333");

                    //Console.WriteLine(json);

                    JObject xmrjson = JObject.Parse(json);

                    XMRIG xmrig = new XMRIG
                    {
                        Algo = (string)xmrjson["algo"],
                        Version = (string)xmrjson["version"],
                        Worker_id = (string)xmrjson["worker_id"],
                        Hashrate = new XMRigHashrate
                        {
                            Total = (JArray)xmrjson["hashrate"]["total"] as JArray,
                            Highest = (int)xmrjson["hashrate"]["highest"]
                        }
                    };

                    //Console.WriteLine("Algo : " + xmrig.Algo);
                    //Console.WriteLine("Version : " + xmrig.Version);
                    //Console.WriteLine("Worker_ID : " + xmrig.Worker_id);
                    Console.WriteLine("hashrate : " + xmrig.Hashrate.Total);
                    Console.WriteLine("highest : " + xmrig.Hashrate.Highest);
                     
                }

                if (itemChecked.ToString() == "GPU Mining")
                {
                    System.Diagnostics.Process.Start(@"Miner\GPU\ccminer\Vertcoin.bat");
                }
            }
        }

        private void btn_stopMining_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(System.Diagnostics.Process Proc in System.Diagnostics.Process.GetProcessesByName("xmrig"))
                {
                    Proc.Kill();
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
    }
}
