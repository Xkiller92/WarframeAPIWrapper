using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class VoidTrader : Activity
    {
        public Trader traderData { get; set; }
        public VoidTrader(string device)
        {
            activity = "voidTrader";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            traderData = new Trader();

            await request.RequestItem(traderData, requestBody);
        }
    }


    public class Trader
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string character { get; set; }
        public string location { get; set; }
        public Inventory[] inventory { get; set; }
        public string psId { get; set; }
        public bool active { get; set; }
        public string startString { get; set; }
        public string endString { get; set; }
    }

    public class Inventory
    {
        public string item { get; set; }
        public int ducats { get; set; }
        public int credits { get; set; }
    }
}
