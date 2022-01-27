using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class CambionDrift : Activity
    {
        public CambionData data { get; set; }

        public CambionDrift(string device)
        {
            activity = "cambionCycle";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            data = new CambionData();

            await request.RequestItem(data, requestBody);
        }
    }


    public class CambionData
    {
        public string id { get; set; }
        public string expiry { get; set; }
        public string activation { get; set; }
        public string active { get; set; }
        public string timeLeft { get; set; }
    }

}
