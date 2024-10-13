﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StrategyPattern._03Try.Compresses
{
    internal class MP4Compress : ICompress
    {
        public void Compress(string file)
        {
            Console.WriteLine($"Compress {file} with algorithm MP4");
        }
    }
}
