namespace Machete.X12
{
    using System;
    using System.Diagnostics;


    public static class X12LayoutExtensions
    {
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
            where TSegment : X12Segment
        {
            Debug.Assert(source != null);

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
        public static SegmentList<TSegment> Select<TLayout, TSegment>(this Layout<TLayout> source, Func<TLayout, SegmentList<TSegment>> getter)
            where TLayout : Layout
            where TSegment : X12Segment
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return SegmentList.Missing<TSegment>();

            return getter(source.Value) ?? SegmentList.Missing<TSegment>();
        }
    }
}