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
            heater = new Heater();
            fake = new FakeLogger();
        }

        [TestCase(2)]
        public void TurnOff(int værdi)
        {
            heater.logger = fake;
            heater.TurnOff();
            int resultat = fake.value;

            Assert.That(resultat,Is.EqualTo(værdi));
        }

        [TestCase(1)]
        public void TurnOn(int værdi)
        {
            heater.logger = fake;
            heater.TurnOn();
            int resultat = fake.value;

            Assert.That(resultat, Is.EqualTo(værdi));
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
