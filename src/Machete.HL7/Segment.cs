namespace Machete.HL7
{
    using Segments;


    public interface Segment<out TSegment> :
        Entity<TSegment>
        where TSegment : HL7Segment
    {
    }


    public static class Segment
    {
        /// <summary>
        /// A missing value is one that is not present, and has no value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Missing<T>()
            where T : HL7Segment
        {
            return Cached<T>.MissingSegment;
        }

        /// <summary>
        /// An empty value is one that is present, but has no value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Empty<T>()
            where T : HL7Segment
        {
            return Cached<T>.EmptySegment;
        }

        /// <summary>
        /// Similar to a missing value for a SegmentList in that it is not present and has no value.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> OutOfRange<T>(int index, int count)
            where T : HL7Segment
        {
            return new OutOfRangeSegment<T>(index, count);
        }


        static class Cached<T>
            where T : HL7Segment
        {
            public static readonly Segment<T> MissingSegment = new MissingSegment<T>();
            public static readonly Segment<T> EmptySegment = new EmptySegment<T>();
        }
    }
}