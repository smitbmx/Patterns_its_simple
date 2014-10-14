using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class HardProcessor
    {
        private int start;

        public HardProcessor(int start)
        {
            this.start = start;
            LoggerSingleton.GetInstance().Log("Processor just created.");
        }

        public int ProcessorTo(int end)
        {
            int sum = 0;
            for (int i = start; i <= end; ++i)
            {
                sum += 1;
            }

            LoggerSingleton.GetInstance().Log(string.Format("Processor just calculated some value {0}", sum));

            return sum;
        }
    }
}
