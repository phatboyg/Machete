namespace Machete
{
    using System;


    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts the current date/time (<see cref="DateTimeOffset"/>) to the specified time zone (<see cref="TimeZoneInfo"/>)
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="destinationTimeZone"></param>
        /// <returns>Returns <see cref="DateTimeOffset"/> specified by <see cref="TimeZoneInfo"/></returns>
        /// <exception cref="ValueConversionException"></exception>
        public static DateTimeOffset ConvertTo(this DateTimeOffset dateTime, TimeZoneInfo destinationTimeZone)
        {
            if (dateTime == null || destinationTimeZone == null)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            return TimeZoneInfo.ConvertTime(dateTime, destinationTimeZone);
        }

        /// <summary>
        /// Converts the current date/time (<see cref="DateTime"/>) to the specified time zone (<see cref="TimeZoneInfo"/>)
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="destinationTimeZone"></param>
        /// <returns>Returns <see cref="DateTimeOffset"/> specified by <see cref="TimeZoneInfo"/></returns>
        /// <exception cref="ValueConversionException"></exception>
        public static DateTimeOffset ConvertTo(this DateTime dateTime, TimeZoneInfo destinationTimeZone)
        {
            if (dateTime == null || destinationTimeZone == null)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            return TimeZoneInfo.ConvertTime(dateTime, destinationTimeZone);
        }

        /// <summary>
        /// Converts the current date/time (<see cref="DateTime"/>) to the specified time zone (<see cref="TimeSpan"/>)
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="destinationTimeZone"></param>
        /// <returns>Returns <see cref="DateTimeOffset"/> specified by <see cref="TimeZoneInfo"/></returns>
        /// <exception cref="ValueConversionException"></exception>
        public static DateTimeOffset ConvertTo(this DateTime dateTime, TimeSpan destinationTimeZone)
        {
            if (dateTime == null || destinationTimeZone == null)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            return new DateTimeOffset(dateTime, destinationTimeZone);
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