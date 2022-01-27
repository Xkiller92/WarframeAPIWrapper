using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class Invasions : Activity
    {
        public List<Invasion> invasions = new List<Invasion>();

        public Invasions(string device)
        {
            activity = "invasions";
            platform = device;
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            await request.RequestItem(invasions, requestBody);
        }
    }

    public class Invasion
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public Attacker attacker { get; set; }
        public Attackerreward attackerReward { get; set; }
        public string attackingFaction { get; set; }
        public bool completed { get; set; }
        public float completion { get; set; }
        public int count { get; set; }
        public Defender defender { get; set; }
        public Defenderreward defenderReward { get; set; }
        public string defendingFaction { get; set; }
        public string desc { get; set; }
        public string eta { get; set; }
        public string node { get; set; }
        public string nodeKey { get; set; }
        public int requiredRuns { get; set; }
        public string[] rewardTypes { get; set; }
        public string startString { get; set; }
        public bool vsInfestation { get; set; }
    }

    public class Attacker
    {
        public Reward reward { get; set; }
        public string faction { get; set; }
        public string factionKey { get; set; }
    }

    public class Attackerreward
    {
        public Counteditem1[] countedItems { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string[] items { get; set; }
        public string itemString { get; set; }
    }

    public class Counteditem1
    {
        public int count { get; set; }
        public string type { get; set; }
    }

    public class Defender
    {
        public Reward1 reward { get; set; }
        public string faction { get; set; }
        public string factionKey { get; set; }
    }

    public class Reward1
    {
        public Counteditem2[] countedItems { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string[] items { get; set; }
        public string itemString { get; set; }
    }

    public class Counteditem2
    {
        public int count { get; set; }
        public string type { get; set; }
    }

    public class Defenderreward
    {
        public Counteditem3[] countedItems { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string[] items { get; set; }
        public string itemString { get; set; }
    }

    public class Counteditem3
    {
        public int count { get; set; }
        public string type { get; set; }
    }
}
