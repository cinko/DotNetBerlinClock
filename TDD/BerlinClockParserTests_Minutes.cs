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
        public void GetMinutesFirstRow_AllLumpsOff(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("OOOOOOOOOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(5)]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        [DataRow(9)]
        [DataTestMethod]
        public void GetMinutesFirstRow_OneLumpOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YOOOOOOOOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(10)]
        [DataRow(11)]
        [DataRow(12)]
        [DataRow(13)]
        [DataRow(14)]
        [DataTestMethod]
        public void GetMinutesFirstRow_TwoLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYOOOOOOOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(15)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(18)]
        [DataRow(19)]
        [DataTestMethod]
        public void GetMinutesFirstRow_ThreeLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYROOOOOOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(20)]
        [DataRow(21)]
        [DataRow(22)]
        [DataRow(23)]
        [DataRow(24)]
        [DataTestMethod]
        public void GetMinutesFirstRow_FourLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYRYOOOOOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(25)]
        [DataRow(26)]
        [DataRow(27)]
        [DataRow(28)]
        [DataRow(29)]
        [DataTestMethod]
        public void GetMinutesFirstRow_FiveLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYRYYOOOOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(30)]
        [DataRow(31)]
        [DataRow(32)]
        [DataRow(33)]
        [DataRow(34)]
        [DataTestMethod]
        public void GetMinutesFirstRow_SixLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYRYYROOOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(35)]
        [DataRow(36)]
        [DataRow(37)]
        [DataRow(38)]
        [DataRow(39)]
        [DataTestMethod]
        public void GetMinutesFirstRow_SevenLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYRYYRYOOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(40)]
        [DataRow(41)]
        [DataRow(42)]
        [DataRow(43)]
        [DataRow(44)]
        [DataTestMethod]
        public void GetMinutesFirstRow_EightLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYRYYRYYOOO", _sut.GetMinutesFirstRow());
        }

        [DataRow(45)]
        [DataRow(46)]
        [DataRow(47)]
        [DataRow(48)]
        [DataRow(49)]
        [DataTestMethod]
        public void GetMinutesFirstRow_NineLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYRYYRYYROO", _sut.GetMinutesFirstRow());
        }

        [DataRow(50)]
        [DataRow(51)]
        [DataRow(52)]
        [DataRow(53)]
        [DataRow(54)]
        [DataTestMethod]
        public void GetMinutesFirstRow_TenLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYRYYRYYRYO", _sut.GetMinutesFirstRow());
        }

        [DataRow(55)]
        [DataRow(56)]
        [DataRow(57)]
        [DataRow(58)]
        [DataRow(59)]
        [DataTestMethod]
        public void GetMinutesFirstRow_ElevenLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYRYYRYYRYY", _sut.GetMinutesFirstRow());
        }

        [DataRow(0)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(15)]
        [DataRow(20)]
        [DataRow(25)]
        [DataRow(30)]
        [DataRow(35)]
        [DataRow(40)]
        [DataRow(45)]
        [DataRow(50)]
        [DataRow(55)]
        [DataTestMethod]
        public void GetMinutesSecondRow_AllLumpsOff(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("OOOO", _sut.GetMinutesSecondRow());
        }

        [DataRow(1)]
        [DataRow(6)]
        [DataRow(11)]
        [DataRow(16)]
        [DataRow(21)]
        [DataRow(26)]
        [DataRow(31)]
        [DataRow(36)]
        [DataRow(41)]
        [DataRow(46)]
        [DataRow(51)]
        [DataRow(56)]
        [DataTestMethod]
        public void GetMinutesSecondRow_OneLumpOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YOOO", _sut.GetMinutesSecondRow());
        }

        [DataRow(2)]
        [DataRow(7)]
        [DataRow(12)]
        [DataRow(17)]
        [DataRow(22)]
        [DataRow(27)]
        [DataRow(32)]
        [DataRow(37)]
        [DataRow(42)]
        [DataRow(47)]
        [DataRow(52)]
        [DataRow(57)]
        [DataTestMethod]
        public void GetMinutesSecondRow_TwoLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYOO", _sut.GetMinutesSecondRow());
        }

        [DataRow(3)]
        [DataRow(8)]
        [DataRow(13)]
        [DataRow(18)]
        [DataRow(23)]
        [DataRow(28)]
        [DataRow(33)]
        [DataRow(38)]
        [DataRow(43)]
        [DataRow(48)]
        [DataRow(53)]
        [DataRow(58)]
        [DataTestMethod]
        public void GetMinutesSecondRow_ThreeLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYYO", _sut.GetMinutesSecondRow());
        }

        [DataRow(4)]
        [DataRow(9)]
        [DataRow(14)]
        [DataRow(19)]
        [DataRow(24)]
        [DataRow(29)]
        [DataRow(34)]
        [DataRow(39)]
        [DataRow(44)]
        [DataRow(49)]
        [DataRow(54)]
        [DataRow(59)]
        [DataTestMethod]
        public void GetMinutesSecondRow_AllLumpsOn(int minutes)
        {
            var time = TimeSpan.FromMinutes(minutes);
            _sut.SetTime(time);
            Assert.AreEqual("YYYY", _sut.GetMinutesSecondRow());
        }
    }
}
