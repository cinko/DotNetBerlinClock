using System;
using System.Collections.Generic;

namespace BerlinClock.Classes
{
    public class BerlinClockParser : IBerlinClockParser
    {
        private const int _hoursPerLamp = 5;
        private const int _minutesPerLamp = 5;

        private const int _maxHourLamps = 4;
        private const int _maxMinutesFirstRowLamps = 11;
        private const int _maxMinutesSecondRowLamps = 4;


        private TimeSpan _time;

        public void SetTime(TimeSpan time)
        {
            _time = time;
        }

        public string GetBlinkingLamp()
        {
            var isEvenSecond = _time.Seconds % 2 == 0;
            return (isEvenSecond ? Lamp.Yellow : Lamp.Off).ToString();
        }

        public string GetHoursFirstRow()
        {
            // Remark 2 - see readme.md file
            var lampsOn = (int)_time.TotalHours / _hoursPerLamp;
            return RenderLamps(_maxHourLamps, lampsOn, Lamp.Red);
        }

        public string GetHoursSecondRow()
        {
            // Remark 3 - see readme.md file
            var lampsOn = (int)_time.TotalHours % _hoursPerLamp;
            return RenderLamps(_maxHourLamps, lampsOn, Lamp.Red);
        }

        public string GetMinutesFirstRow()
        {
            var lampsOn = _time.Minutes / _minutesPerLamp;
            return RenderLamps(_maxMinutesFirstRowLamps, lampsOn, Lamp.Yellow, Lamps.MarkQuarters);
        }

        public string GetMinutesSecondRow()
        {
            var lampsOn = _time.Minutes % _minutesPerLamp;
            return RenderLamps(_maxMinutesSecondRowLamps, lampsOn, Lamp.Yellow);
        }

        private string RenderLamps(int max, int on, char color, Lamps type = Lamps.NoQuarters)
        {
            return string.Join(string.Empty, RenderLampsIterator(max, on, color, type));
        }

        private IEnumerable<char> RenderLampsIterator(int max, int on, char color, Lamps type)
        {
            for (int i = 1; i <= max; i++)
            {
                var isOn = i <= on;
                var isQuarter = i % 3 == 0;

                if (type == Lamps.MarkQuarters && isOn && isQuarter)
                {
                    yield return Lamp.Red;
                    continue;
                }

                yield return isOn ? color : Lamp.Off;
            }
        }
    }
}
