using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
        public class Incursions : Activity
        {
        public List<IncursionData> incursions = new List<IncursionData>();

            public Incursions(string device)
            {
                activity = "steelPath";
                platform = device;
            }

            public override async Task InitAsync()
            {
                requestBody = GenRequest();

                Request request = new Request();

                await request.RequestItem(incursions, requestBody);
            }
        }


        public class IncursionData
        {
            public DateTime activation { get; set; }
            public DateTime expiry { get; set; }
            public Currentreward currentReward { get; set; }
            public string remaining { get; set; }
            public Rotation[] rotation { get; set; }
            public Evergreen[] evergreens { get; set; }
            public Incursion incursion { get; set; }
        }

        public class Currentreward
        {
            public string name { get; set; }
            public int cost { get; set; }
        }

        public class Incursion
        {
            public string id { get; set; }
            public DateTime activation { get; set; }
            public DateTime expiry { get; set; }
        }

        public class Rotation
        {
            public string name { get; set; }
            public int cost { get; set; }
        }

        public class Evergreen
        {
            public string name { get; set; }
            public int cost { get; set; }
        }

    
}
