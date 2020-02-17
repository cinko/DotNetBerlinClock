using BerlinClock.Classes;
using System;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private readonly IBerlinClockParser _berlinClockParser;

        public TimeConverter()
        {
            // This should be injected
            _berlinClockParser = new BerlinClockParser();
        }

        public string convertTime(string aTime)
        {
            TimeSpan time;

            // Remark 1 - see readme.md file
            if (aTime.StartsWith("24"))
                time = TimeSpan.FromHours(24);
            else
                time = TimeSpan.Parse(aTime);

            _berlinClockParser.SetTime(time);

            var output = new StringBuilder();
            output.AppendLine(_berlinClockParser.GetBlinkingLamp());
            output.AppendLine(_berlinClockParser.GetHoursFirstRow());
            output.AppendLine(_berlinClockParser.GetHoursSecondRow());
            output.AppendLine(_berlinClockParser.GetMinutesFirstRow());
            output.Append(_berlinClockParser.GetMinutesSecondRow());

            return output.ToString();
        }
    }
}
