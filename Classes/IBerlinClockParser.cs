using System;

namespace BerlinClock.Classes
{
    public interface IBerlinClockParser
    {
        void SetTime(TimeSpan time);

        string GetBlinkingLamp();
        string GetHoursFirstRow();
        string GetHoursSecondRow();
        string GetMinutesFirstRow();
        string GetMinutesSecondRow();
    }
}