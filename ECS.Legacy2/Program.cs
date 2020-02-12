using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy2
{
    class Program
    {
        static void Main(string[] args)
        {
            int threshold = 28;
            ITempSensor sensor = new TempSensor();
            IRandom random = new RandomProvider();
            sensor.random = random;

            IHeater heater = new Heater();
            ILogger logger = new Logger();
            heater.logger = logger;

            ECS ecs = new ECS(threshold, sensor, heater);

            ecs.Regulate();
            ecs.SetThreshold(20);
            ecs.Regulate();
        }
    }
}
