using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public abstract class Usables
    {
        [JsonIgnore]
        public string  ItemName { get; set; }
        [JsonIgnore]
        public string  Category { get; set; }
        [JsonIgnore]
        public string requestBody { get; set; }

        public string GenRequest()
        {
            string requestBody = $"/{Category}/{ItemName}";

            return requestBody;
        }

        public virtual async Task InitAsync()
        {

        }
    }
}
