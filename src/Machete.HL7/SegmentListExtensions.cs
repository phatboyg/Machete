namespace Machete.HL7
{
    using System.Collections.Generic;


    public static class SegmentListExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="segments"></param>
        /// <typeparam name="TSegment"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Segment<TSegment>> ToEnumerable<TSegment>(this SegmentList<TSegment> segments)
            where TSegment : HL7Segment
        {
            for (int i = 0; ; i++)
            {
                if (!segments.TryGetValue(i, out var segment))
                    break;

                if (segment.HasValue)
                    yield return segment;
            }
        }
    }
}