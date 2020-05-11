namespace Machete.X12
{
    using System;


    public class UnmatchedDateTimeRange :
        DateTimeRange
    {
        public UnmatchedDateTimeRange(bool hasStartDate, bool hasEndDate)
        {
            HasStartDate = hasStartDate;
            HasEndDate = hasEndDate;
        }

        public UnmatchedDateTimeRange(TextSpan startDateText, DateTimeOffset startDate, TextSpan endDateText, DateTimeOffset endDate, bool hasStartDate, bool hasEndDate)
        {
            HasStartDate = hasStartDate;
            HasEndDate = hasEndDate;
            StartSpan = hasStartDate ? startDateText : throw new ValueMissingException("Start date value is missing.");
            StartDate = hasStartDate ? startDate : throw new ValueMissingException("Start date value is missing.");
            EndSpan = hasEndDate ? endDateText : throw new ValueMissingException("End date value is missing.");
            EndDate = hasEndDate ? endDate : throw new ValueMissingException("End date value is missing.");
        }

        public TextSpan StartSpan { get; }
        public DateTimeOffset StartDate { get; }
        public TextSpan EndSpan { get; }
        public DateTimeOffset EndDate { get; }
        public bool HasStartDate { get; }
        public bool HasEndDate { get; }
    }
}