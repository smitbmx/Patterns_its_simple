﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Laptop
    {
        public string MonitorResolution { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string HDD { get; set; }
        public string Battery { get; set; }

        public override string ToString()
        {
            return string.Concat(MonitorResolution, " ", Processor, " ", Memory, " ", HDD, " ", Battery);
        }
    }
}
