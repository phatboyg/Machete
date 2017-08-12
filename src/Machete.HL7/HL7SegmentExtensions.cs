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
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, Value<T>> getter)
            where TSegment : HL7Segment
        {
            if (source == null || !source.HasValue)
                return Value.Missing<T>();

            return getter(source.Value) ?? Value.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ValueList<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, ValueList<T>> getter)
            where TSegment : HL7Segment
        {
            if (source == null || !source.HasValue)
                return ValueList.Missing<T>();

            return getter(source.Value) ?? ValueList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Segment{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, Segment<T>> getter)
            where TSegment : HL7Segment
            where T : HL7Segment
        {
            if (source == null || !source.HasValue)
                return Segment.Missing<T>();

            return getter(source.Value) ?? Segment.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static SegmentList<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, SegmentList<T>> getter)
            where TSegment : HL7Segment
            where T : HL7Segment
        {
            if (source == null || !source.HasValue)
                return SegmentList.Missing<T>();

            return getter(source.Value) ?? SegmentList.Missing<T>();
        }
    }
}