using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public abstract class Activity
    {
        [JsonIgnore]
        public string platform { get; set; }
        [JsonIgnore]
        public string activity { get; set; }
        [JsonIgnore]
        public string requestBody { get; set; }

        public string GenRequest()
        {
            string requestBody = $"/{platform}/{activity}";

            return requestBody;
        }

        public virtual async Task InitAsync()
        {

        }
    }
}
