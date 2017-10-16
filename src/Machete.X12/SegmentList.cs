namespace Machete.X12
{
    using Segments;


    public interface SegmentList<TSegment> :
        EntityList<TSegment>
        where TSegment : X12Segment
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
            where T : X12Segment
        {
            return Cached<T>.MissingSegmentList;
        }


        static class Cached<T>
            where T : X12Segment
        {
            public static readonly SegmentList<T> MissingSegmentList = GetMissingValue();

            static SegmentList<T> GetMissingValue()
            {
                return new MissingSegmentList<T>();
            }
        }
    }
}