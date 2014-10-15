using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class NewElectricitySystem : INewElectricitySystem
    {
        public string MatchWideSocket()
        {
            return "220V";
        }
    }
}
