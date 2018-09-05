namespace Machete
{
    using HL7;
    using HL7.Segments;


    public static class SegmentValue
    {
        /// <summary>
        /// A missing value is one that has no value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Missing<T>()
            where T : HL7Segment
        {
            return Cached<T>.Missing;
        }

        
        static class Cached<T>
            where T : HL7Segment
        {
            public static readonly Segment<T> Missing = new MissingSegment<T>();
        }
    }
}