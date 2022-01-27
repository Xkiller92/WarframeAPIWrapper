using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFrameApiWrapper
{
    public class Reward
    {
        public Counteditem[] countedItems { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string[] items { get; set; }
        public string itemString { get; set; }
    }

    public class Counteditem
    {
        public int count { get; set; }
        public string type { get; set; }
    }

    public class Job
    {
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string[] rewardPool { get; set; }
        public string type { get; set; }
        public int[] enemyLevels { get; set; }
        public int[] standingStages { get; set; }
        public int minMR { get; set; }
    }
}
