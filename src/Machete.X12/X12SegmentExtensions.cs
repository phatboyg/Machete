namespace Machete.X12
{
    using System;
    using System.Diagnostics;


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
            Debug.Assert(source != null);

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
            Debug.Assert(source != null);

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
            Debug.Assert(source != null);

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
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return SegmentList.Missing<T>();

            return projector(source.Value) ?? SegmentList.Missing<T>();
        }
        
        /// <summary>
        /// Returns true if the entity is empty (doesn't contain any text beyond the segmentId)
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public static bool IsEmpty(this X12Segment segment)
        {
            Debug.Assert(segment != null);

            if (segment == null)
                return true;
            
            return !segment.ParsedText.TryGetSlice(1, out _);
        }

        /// <summary>
        /// Returns true if the component is empty (doesn't contain any text beyond the segmentId)
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public static bool IsEmpty(this X12Component component)
        {
            Debug.Assert(component != null);

            if (component == null)
                return true;

            for (int i = 0;; i++)
            {
                if (!component.ParsedText.TryGetSlice(i, out var nextSlice))
                    return true;

                if (nextSlice.TryGetSlice(0, out _))
                    return false;
            }
        }
    }
}