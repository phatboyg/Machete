namespace Machete.HL7
{
    using System;


    public static class HL7SegmentExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static Value<TValue> Select<TSegment, TValue>(this Segment<TSegment> source, Func<TSegment, Value<TValue>> getter)
            where TSegment : HL7Segment
        {
            if (source == null || !source.HasValue)
                return Value.Missing<TValue>();

            return getter(source.Value) ?? Value.Missing<TValue>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static ValueList<TValue> Select<TSegment, TValue>(this Segment<TSegment> source, Func<TSegment, ValueList<TValue>> getter)
            where TSegment : HL7Segment
        {
            if (source == null || !source.HasValue)
                return ValueList.Missing<TValue>();

            return getter(source.Value) ?? ValueList.Missing<TValue>();
        }
    }
}