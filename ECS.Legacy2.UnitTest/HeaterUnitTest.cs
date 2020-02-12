using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy2.UnitTest
{
    [TestFixture]

    class HeaterUnitTest
    {
        private IHeater heater;
        private FakeLogger fake;

        [SetUp]
        public void SetUp()
        {

        }

    }

    public class FakeLogger : ILogger
    {
        public int value = 0;

        public void PrintOn()
        {
            value = 1;
        }

        public void PrintOff()
        {
            value = 2;
        }
    }
}
