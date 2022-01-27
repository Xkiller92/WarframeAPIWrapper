using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class Syndicates : Activity
    {
        public List<SyndicateData> syndicateData { get; set; }

        public Syndicates(string device)
        {
            activity = "syndicateMissions";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            syndicateData = new List<SyndicateData>();

            await request.RequestItem(syndicateData, requestBody);
        }
    }

    public class SyndicateData
    {
        public string[] nodes { get; set; }
        public string eta { get; set; }
        public Job[] jobs { get; set; }
        public string syndicate { get; set; }
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
    }
}
