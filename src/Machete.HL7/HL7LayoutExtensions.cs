namespace Machete.HL7
{
    using System;
    using System.Diagnostics;


    public static class HL7LayoutExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Segment{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static Segment<TSegment> Select<TLayout, TSegment>(this Layout<TLayout> source, Func<TLayout, Segment<TSegment>> projector)
            where TLayout : Layout
            where TSegment : HL7Segment
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return Segment.Missing<TSegment>();

            return projector(source.Value) ?? Segment.Missing<TSegment>();
        }

        /// <summary>
        /// Safely returns the <see cref="Segment{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static SegmentList<TSegment> Select<TLayout, TSegment>(this Layout<TLayout> source, Func<TLayout, SegmentList<TSegment>> projector)
            where TLayout : Layout
            where TSegment : HL7Segment
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return SegmentList.Missing<TSegment>();

            return projector(source.Value) ?? SegmentList.Missing<TSegment>();
        }
    }
}