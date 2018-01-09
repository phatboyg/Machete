namespace Machete.HL7
{
    using System;


    public class OutOfRangeSegment<T> :
        Segment<T>
        where T : HL7Segment
    {
        readonly int _index;
        readonly int _count;

        public OutOfRangeSegment(int index, int count)
        {
            _index = index;
            _count = count;
        }

        public Type EntityType => typeof(T);
        public bool HasValue => false;
        public T Value => throw new SegmentOutOfRangeException($"The index is out of range (index: {_index}, count: {_count})");

        public override string ToString()
        {
            return string.Empty;
        }
    }
}