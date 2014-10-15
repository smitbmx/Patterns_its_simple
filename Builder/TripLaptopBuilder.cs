using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class TripLaptopBuilder : LaptopBuilder
    {
        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1920X1080";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core i5 2 GHz";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "4 Gb";
        }

        public override void SetHDD()
        {
            Laptop.HDD = "500 Gb";
        }

        public override void SetBattery()
        {
            Laptop.Battery = "8 lbs";
        }
    }
}
