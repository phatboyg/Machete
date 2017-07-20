namespace Machete.HL7
{
    using System;


    public static class HL7ValueExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Segment{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, Segment<T>> getter)
            where TSegment : HL7Entity
            where T : HL7Entity
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
        /// <typeparam name="TSegement"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static Value<TValue> Select<TSegement, TValue>(this Segment<TSegement> source, Func<TSegement, Value<TValue>> getter)
            where TSegement : HL7Entity
        {
            if (source == null || !source.HasValue)
                return Value.Missing<TValue>();

            return getter(source.Value) ?? Value.Missing<TValue>();
        }

        /// <summary>
        /// Safely returns the <see cref="Segment{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static Segment<TSegment> Select<TCursor, TLayout, TSegment>(this Result<Cursor<TCursor>, TLayout> source, Func<TLayout, Segment<TSegment>> getter)
            where TSegment : HL7Entity
        {
            if (source == null || !source.HasValue)
                return Segment.Missing<TSegment>();

            return getter(source.Value) ?? Segment.Missing<TSegment>();
        }

        /// <summary>
        /// Safely returns the <see cref="Segment{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static Segment<TSegment> Select<TLayout, TSegment>(this Layout<TLayout> source, Func<TLayout, Segment<TSegment>> getter)
            where TLayout : Layout
            where TSegment : HL7Entity
        {
            if (source == null)
                return Segment.Missing<TSegment>();

            return getter(source.Value) ?? Segment.Missing<TSegment>();
        }
    }
}