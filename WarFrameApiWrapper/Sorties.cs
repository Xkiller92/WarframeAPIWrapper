using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class Sorties : Activity
    {
        public SortieData sortieData { get; set; }
        public Sorties(string device)
        {
            activity = "sortie";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            sortieData = new SortieData();

            await request.RequestItem(sortieData, requestBody);
        }
    }

    public class SortieData
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string rewardPool { get; set; }
        public Variant[] variants { get; set; }
        public string boss { get; set; }
        public string faction { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
    }

    public class Variant
    {
        public string node { get; set; }
        public string boss { get; set; }
        public string missionType { get; set; }
        public string planet { get; set; }
        public string modifier { get; set; }
        public string modifierDescription { get; set; }
    }
}
