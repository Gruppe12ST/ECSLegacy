using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy2
{
    public interface ITempSensor
    {
        IRandom random {set;}
        int GetTemp();
        bool RunSelfTest();
    }
}
