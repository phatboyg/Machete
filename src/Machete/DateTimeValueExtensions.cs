namespace Machete
{
    using System;
    using Values;


    public static class DateTimeValueExtensions
    {
        /// <summary>
        /// Converts the current date/time (<see cref="DateTimeOffset"/>) to the specified time zone (<see cref="TimeZoneInfo"/>)
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="destinationTimeZone"></param>
        /// <returns>Returns <see cref="DateTimeOffset"/> specified by <see cref="TimeZoneInfo"/></returns>
        /// <exception cref="ValueConversionException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static Value<DateTimeOffset> ToTimeZone(this Value<DateTimeOffset> dateTime, TimeZoneInfo destinationTimeZone)
        {
            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime));
            if (destinationTimeZone == null)
                throw new ArgumentNullException(nameof(destinationTimeZone));

            if (!dateTime.HasValue)
                return dateTime;

            try
            {
                return new ConvertedValue<DateTimeOffset>(dateTime.Slice, TimeZoneInfo.ConvertTime(dateTime.Value, destinationTimeZone));
            }
            catch (Exception exception)
            {
                throw new ValueConversionException($"The DateTimeOffset could not be converted to the specified time zone: {destinationTimeZone.StandardName}", exception);
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
        public static Value<DateTimeOffset> ToOffset(this Value<DateTimeOffset> dateTime, TimeSpan offset)
        {
            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime));
            if (offset == null)
                throw new ArgumentNullException(nameof(offset));

            if (!dateTime.HasValue)
                return dateTime;

            try
            {
                return new ConvertedValue<DateTimeOffset>(dateTime.Slice, new DateTimeOffset(dateTime.Value.DateTime, offset));
            }
            catch (Exception exception)
            {
                throw new ValueConversionException($"The DateTimeOffset could not be converted to the specified offset: {offset}", exception);
            }
        }

        /// <summary>
        /// Converts the current date/time (<see cref="DateTime"/>) to <see cref="DateTimeOffset"/>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Value<DateTimeOffset> ToDateTimeOffset(this Value<DateTime> dateTime)
        {
            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime));

            if (!dateTime.HasValue)
                return new MissingValue<DateTimeOffset>(dateTime.Slice);

            return new ConvertedValue<DateTimeOffset>(dateTime.Slice, new DateTimeOffset(dateTime.Value));
        }

        /// <summary>
        /// Converts the current date/time (<see cref="DateTime"/>) to the specified time zone (<see cref="TimeZoneInfo"/>)
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="offset"></param>
        /// <returns>Returns <see cref="DateTimeOffset"/> specified by <see cref="TimeZoneInfo"/></returns>
        /// <exception cref="ValueConversionException"></exception>
        public static Value<DateTimeOffset> ToDateTimeOffset(this Value<DateTime> dateTime, TimeSpan offset)
        {
            if (dateTime == null)
                throw new ArgumentNullException(nameof(dateTime));

            if (offset == null)
                throw new ArgumentNullException(nameof(offset));

            if (!dateTime.HasValue)
                return new MissingValue<DateTimeOffset>(dateTime.Slice);

            try
            {
                return new ConvertedValue<DateTimeOffset>(dateTime.Slice, new DateTimeOffset(dateTime.Value, offset));
            }
            catch (Exception e)
            {
                throw new ValueConversionException("The value cannot be converted because it is null or missing.", e);
            }
        }
    }
}