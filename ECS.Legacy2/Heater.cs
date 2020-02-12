using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy2
{
    class Heater: IHeater
    {
        public ILogger logger {private get; set; }

        public void TurnOn()
        {
            logger.PrintOn();
        }

        public void TurnOff()
        {
            logger.PrintOff();
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
