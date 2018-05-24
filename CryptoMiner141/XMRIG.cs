using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoMiner141
{
    public class XMRIG
    {
        public string Algo { get; set; }
        public string Version { get; set; }
        public string Worker_id { get; set; }
        public string HugePages { get; set; }
        public XMRigHashrate Hashrate { get; set; }
    }

    public class XMRigHashrate
    {
        public JArray Total { get; set; }
        public int Highest { get; set; }
        public int Threads { get; set; }
    }

    public class MyThreadHandle
    {
        /*XMRIG xmrig;

        public MyThreadHandle(XMRIG xmrig)
        {
            this.xmrig = xmrig;
        }

        public void SetParam(XMRIG xmrigParam)
        {
            this.xmrig = xmrigParam;
        }*/

        public void ThreadLoop()
        {
            while (Thread.CurrentThread.IsAlive)
            {
                Thread.Sleep(500);

                var json = new System.Net.WebClient().DownloadString("http://127.0.0.1:23333");

                //Console.WriteLine(json);

                JObject xmrjson = JObject.Parse(json);

                XMRIG xmrig = new XMRIG
                {
                    Algo = (string)xmrjson["algo"],
                    Version = (string)xmrjson["version"],
                    Worker_id = (string)xmrjson["worker_id"],
                    HugePages = (string)xmrjson["hugepages"],
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
                for (int i = 0; i < Form1.checkedListBoxMiner.Items.Count; i++)
                {
                    if (Regex.IsMatch(Form1.checkedListBoxMiner.Items[i].ToString(), @"\bCPU\b"))
                    {
                        //String contains CPU
                        Console.WriteLine("Something");
                        SetText("CPU Mining : Hashrate = " + xmrig.Hashrate.Total[0].ToString() + "H/s, Algorithm = " + xmrig.Algo.ToString() + ", Version = " + xmrig.Version.ToString() + ", HugePages activated = " + xmrig.HugePages.ToString());
                    }
                    else
                    {
                        //String not contains CPU
                        Console.WriteLine("Nothing");
                    }
                }
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (Form1.checkedListBoxMiner.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Form1.checkedListBoxMiner.Invoke(d, new object[] { text });
            }
            else
            {
                for (int i = 0; i < Form1.checkedListBoxMiner.Items.Count; i++)
                {
                    if (Regex.IsMatch(Form1.checkedListBoxMiner.Items[i].ToString(), @"\bCPU\b"))
                    {
                        Form1.checkedListBoxMiner.Items[i] = text;
                    }
                }
            }
        }
    }
}
