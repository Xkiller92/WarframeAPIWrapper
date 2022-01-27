using System;
using System.Threading.Tasks;
using WarFrameApiWrapper;
using System.Collections.Generic;

namespace WarframeApiTester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Mod item = new Mod("Galvanized Aptitude");

            await item.InitAsync();

            Console.WriteLine(item.modData.description);
        }
    }
}
