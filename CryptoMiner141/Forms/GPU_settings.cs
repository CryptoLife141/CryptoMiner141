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
    public partial class GPU_settings : Form
    {
        string config_path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public GPU_settings()
        {
            InitializeComponent();
            cb_crypto.SelectedIndex = 0;
        }

        private void cb_crypto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbText = cb_crypto.Text;

            LoadCcminerconfigJson(getCrypto());
        }

        private void btn_saveConfig_Click(object sender, EventArgs e)
        {
            SaveCcminerConfigJson();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCcminerconfigJson(string algo)
        {
            string json = File.ReadAllText(config_path + "/Miner/GPU/ccminer/config_" + algo + ".json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            //jsonObj["pools"][0]["url"] = tb_urlPool.Text;
            tb_urlPool.Text = jsonObj["url"];
            tb_username.Text = jsonObj["user"];
            tb_password.Text = jsonObj["pass"];
        }

        private void SaveCcminerConfigJson()
        {
            string crypto = getCrypto();
            string json = File.ReadAllText(config_path + "/Miner/GPU/ccminer/config_" + crypto + ".json");
            dynamic jsonObj  =Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["url"] = tb_urlPool.Text;
            jsonObj["user"] = tb_username.Text;
            jsonObj["pass"] = tb_password.Text;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            string batFileText = "@echo off" + Environment.NewLine + "start /low %~dp0\\ccminer-x64.exe -a " + jsonObj["algo"] + " -o stratum+tcp://" + jsonObj["url"] + " -u " + jsonObj["user"] + " -p " + jsonObj["pass"];
            File.WriteAllText(config_path + "/Miner/GPU/ccminer/config_" + crypto + ".json", output);
            File.WriteAllText(config_path + "/Miner/GPU/ccminer/" + crypto + ".bat", batFileText);
        }

        private string getCrypto()
        {
            if (cb_crypto.SelectedItem.ToString() == "VTC (Vertcoin) - lyra2v2")
            {
                return "VTC";
            }
            else if (cb_crypto.SelectedItem.ToString() == "TZC (Trezarcoin) - neoscrypt")
            {
                return "TZC";
            }
            else if (cb_crypto.SelectedItem.ToString() == "BTCP (Bitcoin Private) - equihash")
            {
                return "BTCP";
            }
            else
            {
                return "null";
            }
        }
    }
}
