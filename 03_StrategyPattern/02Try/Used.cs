using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StrategyPattern._02Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 02 =================");

            var videoStorage = new VideoStorage();
            videoStorage.Storage("VayVayKhiar", CompressAlgorithm.KMV, OverlayAlgorithm.NotSet);

            try
            {
                videoStorage.Storage("VayVayKhiar", (CompressAlgorithm)5, (OverlayAlgorithm)6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("=============================================");

        }
    }
}
