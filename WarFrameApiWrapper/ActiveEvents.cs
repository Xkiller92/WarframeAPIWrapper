using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class ActiveEvents : Activity
    {
        public List<EventData> events = new List<EventData>();

        public ActiveEvents(string device)
        {
            activity = "events";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            await request.RequestItem(events, requestBody);
        }
    }

    public class EventData
    {
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public int maximumScore { get; set; }
        public int currentScore { get; set; }
        public float smallInterval { get; set; }
        public float largeInterval { get; set; }
        public string faction { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public string node { get; set; }
        public string[] concurrentNodes { get; set; }
        public string victimNode { get; set; }
        public string scoreLocTag { get; set; }
        public Reward[] rewards { get; set; }
        public bool expired { get; set; }
        public int health { get; set; }
        public string affiliatedWith { get; set; }
        public Job[] jobs { get; set; }
        public Interimstep[] interimSteps { get; set; }
        public Progresssteps[] progressSteps { get; set; }
        public int progressTotal { get; set; }
        public bool showTotalAtEndOfMission { get; set; }
        public bool isPersonal { get; set; }
        public bool isCommunity { get; set; }
        public string[] regionDrops { get; set; }
        public string[] archwingDrops { get; set; }
        public string asString { get; set; }
        public Metadata metadata { get; set; }
        public int[] completionBonuses { get; set; }
        public string scoreVar { get; set; }
        public DateTime altExpiry { get; set; }
        public DateTime altActivation { get; set; }
        public Nextalt nextAlt { get; set; }
    }

    public class Progresssteps
    {
        public string type { get; set; }
        public int progressAmt { get; set; }
    }

    public class Metadata
    {
    }

    public class Nextalt
    {
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
    }


    public class Interimstep
    {
        public int goal { get; set; }
        public Reward reward { get; set; }
        public Message message { get; set; }
        public int winnerCount { get; set; }
    }

    public class Message
    {
        public string sender { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string senderIcon { get; set; }
        public string[] attachments { get; set; }
    }

}
