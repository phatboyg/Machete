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
        /// Returns a count of segments in <see cref="SegmentList{TSegment}"/>
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static int Count<TSegment>(this SegmentList<TSegment> source)
            where TSegment : HL7Segment
        {
            if (source == null || !source.HasValue)
                return 0;

            Segment<TSegment> segment;
            int i = 0;
            for (;; i++)
                if (!source.TryGetValue(i, out segment))
                    break;

            return i;
        }
    }
}