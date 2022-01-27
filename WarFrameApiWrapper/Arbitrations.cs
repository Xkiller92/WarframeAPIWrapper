using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class Arbitrations : Activity
    {
        public Arbitration Arbitration { get; set; }
        public Arbitrations(string device)
        {
            activity = "arbitration";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            Arbitration = new Arbitration();

            await request.RequestItem(Arbitration, requestBody);
        }
    }


    public class Arbitration
    {
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string node { get; set; }
        public string enemy { get; set; }
        public string type { get; set; }
        public bool archwing { get; set; }
        public bool sharkwing { get; set; }
    }

}
