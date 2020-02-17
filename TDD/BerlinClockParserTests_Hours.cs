using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BerlinClock.TDD
{
    public partial class BerlinClockParserTests
    {
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataTestMethod]
        public void GetHoursFirstRow_AllLumpsOff(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("OOOO", _sut.GetHoursFirstRow());
        }

        
        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [DataTestMethod]
        public void GetHoursFirstRow_OneLumpOn(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("ROOO", _sut.GetHoursFirstRow());
        }

        
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(12)]
        [DataRow(13)]
        [DataRow(14)]
        [DataTestMethod]
        public void GetHoursFirstRow_TwoLumpsOn(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("RROO", _sut.GetHoursFirstRow());
        }

        
        [DataRow(15)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(18)]
        [DataRow(19)]
        [DataTestMethod]
        public void GetHoursFirstRow_ThreeLumpsOn(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("RRRO", _sut.GetHoursFirstRow());
        }

        [DataRow(20)]
        [DataRow(21)]
        [DataRow(22)]
        [DataRow(23)]
        [DataTestMethod]
        public void GetHoursFirstRow_AllLumpsOn(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("RRRR", _sut.GetHoursFirstRow());
        }

        [DataRow(0)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(15)]
        [DataRow(20)]
        [DataTestMethod]
        public void GetHoursSecondRow_AllLumpsOff(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("OOOO", _sut.GetHoursSecondRow());
        }


        [DataRow(1)]
        [DataRow(6)]
        [DataRow(11)]
        [DataRow(16)]
        [DataRow(21)]
        [DataTestMethod]
        public void GetHoursSecondRow_OneLumpOn(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("ROOO", _sut.GetHoursSecondRow());
        }


        [DataRow(2)]
        [DataRow(7)]
        [DataRow(12)]
        [DataRow(17)]
        [DataRow(22)]
        [DataTestMethod]
        public void GetHoursSecondRow_TwoLumpsOn(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("RROO", _sut.GetHoursSecondRow());
        }


        [DataRow(3)]
        [DataRow(8)]
        [DataRow(13)]
        [DataRow(18)]
        [DataRow(23)]
        [DataTestMethod]
        public void GetHoursSecondRow_ThreeLumpsOn(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("RRRO", _sut.GetHoursSecondRow());
        }

        [DataRow(4)]
        [DataRow(9)]
        [DataRow(14)]
        [DataRow(19)]
        [DataTestMethod]
        public void GetHoursSecondRow_AllLumpsOn(int hours)
        {
            var time = TimeSpan.FromHours(hours);
            _sut.SetTime(time);
            Assert.AreEqual("RRRR", _sut.GetHoursSecondRow());
        }
    }
}
