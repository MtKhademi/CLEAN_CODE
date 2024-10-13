using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StrategyPattern._01Try
{
    internal class VideoStorage
    {
        public void Storage(string file, int compressType, int overlayType)
        {
            if (compressType == 0)
            {
                Console.WriteLine($"Compress {file} with algorithm KMV");
            }
            else if (compressType == 1)
            {
                Console.WriteLine($"Compress {file} with algorithm MP4");
            }
            else if (compressType == 2)
            {
                Console.WriteLine($"Compress {file} with algorithm MWEB");
            }
            else
                throw new ArgumentOutOfRangeException("Please select correct Compress");


            if (overlayType == 0)
            {
                Console.WriteLine($"Overlay {file} with not any algorithm");
            }
            else if (overlayType == 1)
            {
                Console.WriteLine($"Overlay {file} with BlackAndWhite algorithm");
            }
            else if (overlayType == 2)
            {
                Console.WriteLine($"Overlay {file} with Green algorithm");
            }
            else
                throw new ArgumentOutOfRangeException("Please select correct Overlay");


            Console.WriteLine($"Storage {file} is success");

        }
    }
}
