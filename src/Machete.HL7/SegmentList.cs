namespace Machete.HL7
{
    using Segments;


    public interface SegmentList<TSegment> :
        EntityList<TSegment>
        where TSegment : HL7Segment
    {
        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        new Segment<TSegment> this[int index] { get; }

        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        /// <param name="value">The output value</param>
        /// <returns>True if the value exists, otherwise false.</returns>
        bool TryGetValue(int index, out Segment<TSegment> value);
    }


    public static class SegmentList
    {
        public static SegmentList<T> Missing<T>()
            where T : HL7Segment
        {
            return Cached<T>.MissingSegmentList;
        }


        static class Cached<T>
            where T : HL7Segment
        {
            public static readonly SegmentList<T> MissingSegmentList = new MissingSegmentList<T>();
        }
    }
}