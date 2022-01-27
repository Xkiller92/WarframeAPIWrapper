using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class KuvaMissions : Activity
    {
        public List<KuvaData> kuvaData = new List<KuvaData>();

        public KuvaMissions(string device)
        {
            activity = "kuva";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            await request.RequestItem(kuvaData, requestBody);
        }
    }


    public class KuvaData
    {
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string node { get; set; }
        public string enemy { get; set; }
        public string type { get; set; }
        public string node_type { get; set; }
        public bool archwing { get; set; }
        public bool sharkwing { get; set; }
    }
}
