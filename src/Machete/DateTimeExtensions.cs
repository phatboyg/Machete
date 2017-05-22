﻿namespace Machete
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
        /// <exception cref="ArgumentNullException"></exception>
        public static DateTimeOffset ConvertTo(this Value<DateTimeOffset> dateTime, TimeZoneInfo destinationTimeZone)
        {
            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime));

            if (destinationTimeZone == null)
                throw new ArgumentNullException(nameof(destinationTimeZone));

            if (!dateTime.HasValue)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            try
            {
                return TimeZoneInfo.ConvertTime(dateTime.Value, destinationTimeZone);
            }
            catch (Exception e)
            {
                throw new ValueConversionException("The value cannot be converted because it is null or missing.", e);
            }
        }

        /// <summary>
        /// Converts the current date/time (<see cref="DateTimeOffset"/>) to the specified offset (<see cref="TimeSpan"/>)
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ValueConversionException"></exception>
        public static DateTimeOffset ConvertTo(this Value<DateTimeOffset> dateTime, TimeSpan offset)
        {
            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime));

            if (offset == null)
                throw new ArgumentNullException(nameof(offset));

            if (!dateTime.HasValue)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            try
            {
                DateTimeOffset dt = new DateTimeOffset(dateTime.Value.DateTime, offset);

                return dt;
            }
            catch (Exception e)
            {
                throw new ValueConversionException("The value cannot be converted because it is null or missing.", e);
            }
        }

        /// <summary>
        /// Converts the current date/time (<see cref="DateTime"/>) to <see cref="DateTimeOffset"/>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static DateTimeOffset ConvertTo(this Value<DateTime> dateTime)
        {
            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime));

            if (!dateTime.HasValue)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            DateTimeOffset dt = new DateTimeOffset(dateTime.Value);

            return dt;
        }

        /// <summary>
        /// Converts the current date/time (<see cref="DateTime"/>) to the specified time zone (<see cref="TimeZoneInfo"/>)
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="offset"></param>
        /// <returns>Returns <see cref="DateTimeOffset"/> specified by <see cref="TimeZoneInfo"/></returns>
        /// <exception cref="ValueConversionException"></exception>
        public static DateTimeOffset ConvertTo(this Value<DateTime> dateTime, TimeSpan offset)
        {
            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime));
            
            if (offset == null)
                throw new ArgumentNullException(nameof(offset));

            if (!dateTime.HasValue)
                throw new ValueConversionException("The value cannot be converted because it is null or missing.");

            try
            {
                DateTimeOffset dt = new DateTimeOffset(dateTime.Value, offset);

                return dt;
            }
            catch (Exception e)
            {
                throw new ValueConversionException("The value cannot be converted because it is null or missing.", e);
            }
        }
    }
}