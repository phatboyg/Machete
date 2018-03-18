namespace Machete.X12
{
    using System;


    public static class X12SegmentExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, Value<T>> projector)
            where TSegment : X12Segment
        {
            if (source == null || !source.HasValue)
                return Value.Missing<T>();

            return projector(source.Value) ?? Value.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ValueList<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, ValueList<T>> projector)
            where TSegment : X12Segment
        {
            if (source == null || !source.HasValue)
                return ValueList.Missing<T>();

            return projector(source.Value) ?? ValueList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Segment{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, Segment<T>> projector)
            where TSegment : X12Segment
            where T : X12Segment
        {
            if (source == null || !source.HasValue)
                return Segment.Missing<T>();

            return projector(source.Value) ?? Segment.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static SegmentList<T> Select<TSegment, T>(this Segment<TSegment> source, Func<TSegment, SegmentList<T>> projector)
            where TSegment : X12Segment
            where T : X12Segment
        {
            if (source == null || !source.HasValue)
                return SegmentList.Missing<T>();

            return projector(source.Value) ?? SegmentList.Missing<T>();
        }
        
        /// <summary>
        /// Returns true if the entity is empty (doesn't contain any text beyond the segmentId)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool IsEmpty(this X12Entity entity)
        {
            return !entity.ParsedText.TryGetSlice(1, out _);
        }
    }
}