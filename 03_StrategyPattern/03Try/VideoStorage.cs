using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StrategyPattern._03Try
{
    internal class VideoStorage
    {
        public void Storage(string file, ICompress compress, IOverlay overlay)
        {

            compress.Compress(file);

            overlay.Overlay(file);


            Console.WriteLine($"Storage {file} is success");

        }
    }
}
