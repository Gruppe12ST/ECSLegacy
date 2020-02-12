using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy2
{
    public interface IHeater
    {
        ILogger logger { set; }
        void TurnOn();
        void TurnOff();
        bool RunSelfTest();

    }
}
