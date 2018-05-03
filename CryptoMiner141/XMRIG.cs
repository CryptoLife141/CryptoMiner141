using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMiner141
{
    public class XMRIG
    {
        public string Algo { get; set; }
        public string Version { get; set; }
        public string Worker_id { get; set; }
        public XMRigHashrate Hashrate { get; set; }
    }

    public class XMRigHashrate
    {
        public JArray Total { get; set; }
        public int Highest { get; set; }
        public int Threads { get; set; }
    }

}
