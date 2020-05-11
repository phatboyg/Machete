namespace Machete.X12
{
    using System;


    public class MatchedDateTimeRange :
        DateTimeRange
    {
        public MatchedDateTimeRange(TextSpan startDateText, DateTimeOffset startDate, TextSpan endDateText, DateTimeOffset endDate, bool hasStartDate, bool hasEndDate)
        {
            StartSpan = startDateText;
            StartDate = startDate;
            EndSpan = endDateText;
            EndDate = endDate;
            HasStartDate = hasStartDate;
            HasEndDate = hasEndDate;
        }

        public TextSpan StartSpan { get; }
        public DateTimeOffset StartDate { get; }
        public TextSpan EndSpan { get; }
        public DateTimeOffset EndDate { get; }
        public bool HasStartDate { get; }
        public bool HasEndDate { get; }
    }
}