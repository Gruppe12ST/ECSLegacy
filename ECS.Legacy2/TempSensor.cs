using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy2
{
    class TempSensor: ITempSensor
    {
        public IRandom random { private get; set; }

        public int GetTemp()
        {
           return random.GetRandom();
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
