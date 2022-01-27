using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFrameApiWrapper
{
    public class Mod : Usables
    {
        public ModData modData { get; set; }

        public Mod(string modName)
        {
            ItemName = modName;
            Category = "mods";
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            modData = new ModData();

            await request.RequestItem(modData, requestBody);
        }


        public class ModData
        {
            public string name { get; set; }
            public string uniqueName { get; set; }
            public Patchlog[] patchlogs { get; set; }
            public string description { get; set; }
            public string type { get; set; }
            public bool tradable { get; set; }
            public Introduced introduced { get; set; }
            public string category { get; set; }
            public string productCategory { get; set; }
            public string imageName { get; set; }
            public string estimatedVaultDate { get; set; }
            public int baseDrain { get; set; }
            public string compatName { get; set; }
            public int fusionLimit { get; set; }
            public Levelstat[] levelStats { get; set; }
            public string polarity { get; set; }
            public bool transmutable { get; set; }
        }
        public class Introduced
        {
            public string name { get; set; }
            public string url { get; set; }
            public string[] aliases { get; set; }
            public string parent { get; set; }
            public string date { get; set; }
        }

        public class Patchlog
        {
            public string name { get; set; }
            public DateTime date { get; set; }
            public string url { get; set; }
            public string additions { get; set; }
            public string changes { get; set; }
            public string fixes { get; set; }
        }

        public class Levelstat
        {
            public string[] stats { get; set; }
        }
    }
}
