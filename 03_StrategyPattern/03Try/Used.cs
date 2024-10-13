using _03_StrategyPattern._03Try.Compresses;
using _03_StrategyPattern._03Try.Overlays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StrategyPattern._03Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 03 =================");

            var videoStorage = new VideoStorage();

            videoStorage.Storage("VayVayKhiar", new KMVCompress(), new NotChangeOverlay());
            videoStorage.Storage("VayVayKhiar", new HavijiCompress(), new BlackAndWhiteOverlay());


            Console.WriteLine("=============================================");

        }
    }
}
