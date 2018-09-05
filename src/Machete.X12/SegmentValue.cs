namespace Machete
{
    using X12;
    using X12.Segments;


    public static class SegmentValue
    {
        /// <summary>
        /// A missing value is one that has no value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Segment<T> Missing<T>()
            where T : X12Segment
        {
            return Cached<T>.Missing;
        }

        
        static class Cached<T>
            where T : X12Segment
        {
            public static readonly Segment<T> Missing = new MissingSegment<T>();
        }
    }
}