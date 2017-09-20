namespace Machete.HL7
{
    using System;


    public static class HL7ResultExtensions
    {
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
            where TLayout : HL7Layout
            where TSegment : HL7Segment
        {
            if (source == null || !source.HasResult)
                return Segment.Missing<TSegment>();

            return getter(source.Result) ?? Segment.Missing<TSegment>();
        }

        /// <summary>
        /// Safely returns the <see cref="SegmentList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static SegmentList<TSegment> Select<TCursor, TLayout, TSegment>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, SegmentList<TSegment>> getter)
            where TLayout : HL7Layout
            where TSegment : HL7Segment
        {
            if (result == null || !result.HasResult)
                return SegmentList.Missing<TSegment>();

            return getter(result.Result) ?? SegmentList.Missing<TSegment>();
        }
    }
}