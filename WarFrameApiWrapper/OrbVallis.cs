using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class OrbVallis : Activity
    {
        public OrbData OrbData { get; set; }

        public OrbVallis(string device)
        {
            activity = "vallisCycle";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            OrbData = new OrbData();

            await request.RequestItem(OrbData, requestBody);
        }
    }


    public class OrbData
    {
        public string id { get; set; }
        public string expiry { get; set; }
        public string timeLeft { get; set; }
        public bool isWarm { get; set; }
    }
}
