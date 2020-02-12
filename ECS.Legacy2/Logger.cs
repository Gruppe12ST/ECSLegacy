using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy2
{
    class Logger: ILogger
    {
        public void PrintOn()
        {
            Console.WriteLine("Heater is on");
        }

        public void PrintOff()
        {
            Console.WriteLine("Heater is off");
        }
    }
}
