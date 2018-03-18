namespace Machete.X12
{
    using System;


    public static class X12ResultExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Segment{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static Segment<TSegment> Select<TCursor, TLayout, TSegment>(this Result<Cursor<TCursor>, TLayout> source, Func<TLayout, Segment<TSegment>> projector)
            where TLayout : X12Layout
            where TSegment : X12Segment
        {
            if (source == null || !source.HasResult)
                return Segment.Missing<TSegment>();

            return projector(source.Result) ?? Segment.Missing<TSegment>();
        }

        /// <summary>
        /// Safely returns the <see cref="SegmentList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static SegmentList<TSegment> Select<TCursor, TLayout, TSegment>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, SegmentList<TSegment>> projector)
            where TLayout : X12Layout
            where TSegment : X12Segment
        {
            if (result == null || !result.HasResult)
                return SegmentList.Missing<TSegment>();

            return projector(result.Result) ?? SegmentList.Missing<TSegment>();
        }
    }
}