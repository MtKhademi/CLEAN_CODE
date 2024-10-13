using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StrategyPattern._01Try
{
    internal static class Used
    {
        public static void UsedExample()
        {

            Console.WriteLine("==================== TRY 01 =================");

            var videoStorage = new VideoStorage();
            videoStorage.Storage("VayVayKhiar", 0, 0);
            try
            {
                videoStorage.Storage("VayVayKhiar", 5, 6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("=============================================");

        }
    }
}
