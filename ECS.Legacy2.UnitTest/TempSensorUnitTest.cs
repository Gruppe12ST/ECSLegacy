using System;
using NUnit.Framework;


namespace ECS.Legacy2.UnitTest
{
    [TestFixture]
    public class TempSensorUnitTest
    {
        private FakeRandom fake;
        private ITempSensor uut;
        [SetUp]
        public void SetUp()
        {
            fake = new FakeRandom();
            uut = new TempSensor();
        }
        [TestCase(31)]
        [TestCase(-4)]
        [TestCase(44)]
        [TestCase(13)]
        public void GetTemp(int værdi)
        {
            fake.value = værdi;
            uut.random = fake;

            int resultat = uut.GetTemp();

            Assert.That(resultat,Is.EqualTo(værdi));
        }
    }

    public class FakeRandom:IRandom
    {
        public int value { get; set; }
        private IRandom _randomImplementation;
        public int GetRandom()
        {
            return value;
        }

    }
}
