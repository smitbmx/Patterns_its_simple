using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class GamingLaptopBuilder : LaptopBuilder
    {
        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1900X1200";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core 2 Duo, 3.2 GHz";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "6144 Mb";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "1 TB";
        }

        public override void SetBattery()
        {
            Laptop.Battery = "6 lbs";
        }
    }
}
