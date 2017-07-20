namespace Machete.HL7
{
    using Segments;


    public interface Segment<out TSegment> :
        Entity<TSegment>
        where TSegment : HL7Entity
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
            where T : HL7Entity
        {
            return SegmentCached<T>.MissingSegment;
        }

        /// <summary>
        /// An empty value is one that is present, but has no value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Empty<T>()
            where T : HL7Entity
        {
            return SegmentCached<T>.EmptySegment;
        }


        static class SegmentCached<T>
            where T : HL7Entity
        {
            public static readonly Segment<T> MissingSegment = GetMissingSegment();
            public static readonly Segment<T> EmptySegment = GetEmptySegment();

            static Segment<T> GetEmptySegment()
            {
                return new EmptySegment<T>();
            }

            static Segment<T> GetMissingSegment()
            {
                return new MissingSegment<T>();
            }
        }
    }
}