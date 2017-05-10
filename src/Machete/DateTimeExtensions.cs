namespace Machete
{
    using System;


    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns a Givent a <see cref="Value{TValue}.Value"/> and a destination <see cref="TimeZoneInfo"/>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="destinationTimeZone"></param>
        /// <returns></returns>
        /// <exception cref="ValueConversionException"></exception>
        public static DateTimeOffset ConvertTo(this DateTimeOffset dateTime, TimeZoneInfo destinationTimeZone)
        {
            if (dateTime == null)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            return TimeZoneInfo.ConvertTime(dateTime, destinationTimeZone);
        }

        public static DateTimeOffset ConvertTo(this DateTime dateTime, TimeZoneInfo destinationTimeZone)
        {
            if (dateTime == null)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            return TimeZoneInfo.ConvertTime(dateTime, destinationTimeZone);
        }

        //public static DateTimeOffset ToUtc(this DateTimeOffset value)
        //{
        //    if (value == null)
        //        throw new ValueConversionException("The value cannot be converted because it is null or missing.");

        //    TimeSpan offset = value.Offset;
        //    //DateTimeOffset dateTimeOffset = new DateTimeOffset(value.DateTime, offset);

        //    DateTime dateTime = TimeZoneInfo.ConvertTimeToUtc(value.DateTime);
        //    DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTime, value.Offset);

        //    return dateTimeOffset;
        //    //return dateTimeOffset;
        //    //return TimeZoneInfo.ConvertTime(dateTime, offset);
        //}
    }
}