using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMiner141.Forms
{
    public partial class CPU_settings : Form
    {
        string config_path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public CPU_settings()
        {
            InitializeComponent();
            cb_crypto.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_saveConfig_Click(object sender, EventArgs e)
        {
            SaveXMRIGConfigJson();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cb_crypto.Text);
            string cbText = cb_crypto.Text;

            if (cbText == "XMR (Monero) - CryptonightV7")
            {
                LoadXMRIGconfigJson("XMR");
            }
        }

        private void LoadXMRIGconfigJson(string algo)
        {
            string json = File.ReadAllText(config_path + "/Miner/CPU/xmrig/config_" + algo + ".json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            //jsonObj["pools"][0]["url"] = tb_urlPool.Text;
            tb_urlPool.Text = jsonObj["pools"][0]["url"];
            tb_username.Text = jsonObj["pools"][0]["user"];
            tb_password.Text = jsonObj["pools"][0]["pass"];
        }

        private void SaveXMRIGConfigJson()
        {
            string crypto = getCrypto();
            string json = File.ReadAllText(config_path + "/Miner/CPU/xmrig/config_" + crypto + ".json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["pools"][0]["url"] = tb_urlPool.Text;
            jsonObj["pools"][0]["user"] = tb_username.Text;
            jsonObj["pools"][0]["pass"] = tb_password.Text;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(config_path + "/Miner/CPU/xmrig/config_" + crypto + ".json", output);
        }

        private string getCrypto()
        {
            if (cb_crypto.SelectedItem.ToString() == "XMR (Monero) - CryptonightV7")
            {
                Console.WriteLine("crypto XMR");
                return "XMR";
            }
            else
            {
                return "null";
            }
        }
    }
}
