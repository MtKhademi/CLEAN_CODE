using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StrategyPattern._02Try
{
    internal class VideoStorage
    {
        public void Storage(string file, CompressAlgorithm compressType, OverlayAlgorithm overlayType)
        {
            if (compressType == CompressAlgorithm.KMV)
            {
                Console.WriteLine($"Compress {file} with algorithm KMV");
            }
            else if (compressType == CompressAlgorithm.MP4)
            {
                Console.WriteLine($"Compress {file} with algorithm MP4");
            }
            else if (compressType == CompressAlgorithm.MWEB)
            {
                Console.WriteLine($"Compress {file} with algorithm MWEB");
            }
            else
                throw new ArgumentOutOfRangeException("Please select correct Compress");


            if (overlayType == OverlayAlgorithm.NotSet)
            {
                Console.WriteLine($"Overlay {file} with not any algorithm");
            }
            else if (overlayType == OverlayAlgorithm.BlackAndWhite)
            {
                Console.WriteLine($"Overlay {file} with BlackAndWhite algorithm");
            }
            else if (overlayType == OverlayAlgorithm.Green)
            {
                Console.WriteLine($"Overlay {file} with Green algorithm");
            }
            else
                throw new ArgumentOutOfRangeException("Please select correct Overlay");


            Console.WriteLine($"Storage {file} is success");

        }
    }
}
