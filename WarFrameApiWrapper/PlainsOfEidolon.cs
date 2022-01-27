using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class PlainsOfEidolon : Activity
    {
        public CetusData cetusData { get; set; }

        public PlainsOfEidolon(string device)
        {
            activity = "cetusCycle";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            cetusData = new CetusData();

            await request.RequestItem(cetusData, requestBody);
        }
    }


    public class CetusData
    {
        public string id { get; set; }
        public string expiry { get; set; }
        public string activation { get; set; }
        public bool isDay { get; set; }
        public string state { get; set; }
        public string timeLeft { get; set; }
        public bool isCetus { get; set; }
        public string shortString { get; set; }
    }
}
