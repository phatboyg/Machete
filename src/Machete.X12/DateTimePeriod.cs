namespace Machete.X12
{
    using System;
    using System.Globalization;
    using System.Runtime.Serialization;
    using TextParsers;
    using Texts;


    [Serializable]
    public class DateTimePeriod :
        IComparable<string>,
        ISerializable,
        IComparable<DateTimePeriod>,
        IEquatable<DateTimePeriod>
    {
        readonly string Text;
        readonly string[] _dateTimePatterns = {
            "yyyyMMdd",
            "MMddyyyy",
            "yyyyMMd",
            "yy",
            "MMYYYY"
        };

        DelimitedTextParser _parser;

        public DateTimePeriod()
        {
            _parser = new DelimitedTextParser('-');
        }

        public DateTimePeriod(SerializationInfo info, StreamingContext context)
        {
            Text = info.GetString("Text");
            _parser = new DelimitedTextParser('-');
        }

        public DateTimePeriod(string text)
        {
            Text = text;
            _parser = new DelimitedTextParser('-');
        }

        /// <summary>
        /// Try to get a date/time.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool TryGetDateTime(out DateTimeOffset date)
        {
            if (DateTimeOffset.TryParseExact(Text, _dateTimePatterns, CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite, out var value))
            {
                date = value;
                return true;
            }

            date = default;
            return false;
        }

        /// <summary>
        /// Try to get a range of dates, times, or date/times.
        /// </summary>
        /// <param name="dateTimeRange"></param>
        /// <returns></returns>
        public bool TryGetDateTimeRange(out DateTimeRange dateTimeRange)
        {
            try
            {
                var parsedText = new StringText(Text);
                var parsedResult = _parser.Parse(parsedText);

                string startDateText = parsedText.ToString(parsedResult.Result);
                string endDateText = parsedText.ToString(parsedResult.Next);

                bool hasStartDate = DateTimeOffset.TryParseExact(startDateText, _dateTimePatterns, CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite, out var startDate);
                bool hasEndDate = DateTimeOffset.TryParseExact(endDateText, _dateTimePatterns, CultureInfo.InvariantCulture, DateTimeStyles.AllowInnerWhite, out var endDate);
            
                if (hasStartDate && hasEndDate)
                {
                    dateTimeRange = new MatchedDateTimeRange(parsedResult.Result, startDate, parsedResult.Next, endDate, hasStartDate, hasEndDate);
                    return true;
                }

                dateTimeRange = new UnmatchedDateTimeRange(parsedResult.Result, startDate, parsedResult.Next, endDate, hasStartDate, hasEndDate);
                return false;
            }
            catch
            {
                dateTimeRange = new UnmatchedDateTimeRange(false, false);
                return false;
            }
        }

        public int CompareTo(DateTimePeriod other) => string.Compare(Text, other.Text, StringComparison.Ordinal);

        public bool Equals(DateTimePeriod other)
        {
            if (ReferenceEquals(null, other))
                return false;
            
            if (ReferenceEquals(this, other))
                return true;

            return Equals(other.Text, Text);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            
            if (ReferenceEquals(this, obj))
                return true;
            
            if (obj.GetType() != typeof(DateTimePeriod))
                return false;

            return Equals((DateTimePeriod)obj);
        }

        public override int GetHashCode() => Text != null ? Text.GetHashCode() : 0;

        public override string ToString() => Text ?? string.Empty;

        public int CompareTo(string other) => string.Compare(Text, other, StringComparison.Ordinal);

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Text", Text);
        }

        public static bool operator ==(DateTimePeriod left, DateTimePeriod right) => Equals(left, right);

        public static bool operator !=(DateTimePeriod left, DateTimePeriod right) => !Equals(left, right);

        public static bool operator <(DateTimePeriod left, DateTimePeriod right) => string.CompareOrdinal(left.Text, right.Text) < 0;

        public static bool operator >(DateTimePeriod left, DateTimePeriod right) => string.CompareOrdinal(left.Text, right.Text) > 0;

        public static implicit operator DateTimePeriod(string value) => new DateTimePeriod(value);

        public static implicit operator string(DateTimePeriod value) => value == null ? null : value.Text;
    }
}