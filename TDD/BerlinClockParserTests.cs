using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.TDD
{
    [TestClass]
    public partial class BerlinClockParserTests
    {
        private readonly IBerlinClockParser _sut;

        public BerlinClockParserTests()
        {
            _sut = new BerlinClockParser();
        }

        [TestMethod]
        public void GetBlinkingLamp_0seconds_LampIsYellow()
        {
            var time = TimeSpan.FromSeconds(0);
            _sut.SetTime(time);
            Assert.AreEqual(Lamp.Yellow.ToString(), _sut.GetBlinkingLamp());
        }

        [TestMethod]
        public void GetBlinkingLamp_oddSeconds_LampIsOff()
        {
            var time = TimeSpan.FromSeconds(1);
            _sut.SetTime(time);
            Assert.AreEqual(Lamp.Off.ToString(), _sut.GetBlinkingLamp());
        }

        [TestMethod]
        public void GetBlinkingLamp_evenSeconds_LampIsYellow()
        {
            var time = TimeSpan.FromSeconds(2);
            _sut.SetTime(time);
            Assert.AreEqual(Lamp.Yellow.ToString(), _sut.GetBlinkingLamp());
        }
    }
}
