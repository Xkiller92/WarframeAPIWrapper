using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class VoidFissures : Activity
    {
        public List<FissuresData> fissuresData = new List<FissuresData>();

        public VoidFissures(string device)
        {
            activity = "fissures";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            await request.RequestItem(fissuresData, requestBody);
        }
    }

    public class FissuresData
    {
        public string node { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
        public string missionType { get; set; }
        public string tier { get; set; }
        public int tierNum { get; set; }
        public string enemy { get; set; }
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public bool isStorm { get; set; }
    }
}
