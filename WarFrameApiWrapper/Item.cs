using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFrameApiWrapper
{
    public class Item : Usables
    {
        public ItemData itemData { get; set; }

        public Item(string itemName)
        {
            ItemName = itemName;
            Category = "items";
        }

        public override async Task InitAsync()
        {
            requestBody = GenRequest();

            Request request = new Request();

            itemData = new ItemData();

            await request.RequestItem(itemData, requestBody);
        }


        public class ItemData
        {
            public string name { get; set; }
            public string uniqueName { get; set; }
            public Patchlog[] patchlogs { get; set; }
            public Components[] components { get; set; }
            public string description { get; set; }
            public string type { get; set; }
            public bool tradable { get; set; }
            public Introduced introduced { get; set; }
            public string category { get; set; }
            public string productCategory { get; set; }
            public string imageName { get; set; }
            public string estimatedVaultDate { get; set; }
        }

        public class Components
        {
            public string uniqueName { get; set; }
            public string  name { get; set; }
            public string description { get; set; }
            public int itemCount { get; set; }
            public string imageName { get; set; }
            public bool tradable { get; set; }
            public string[] drops { get; set; }
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

    }
}
