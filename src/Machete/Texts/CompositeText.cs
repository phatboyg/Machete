namespace Machete.Texts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Internals.Extensions;


    public class CompositeText :
        ParseText
    {
        readonly ParseText[] _segments;
        readonly int _length;
        readonly int[] _segmentOffsets;

        public CompositeText(ParseText[] segments)
        {
            Debug.Assert(segments != null);
            Debug.Assert(segments.Length > 0);

            _segments = segments;

            ComputeLength(segments, out _length);

            _segmentOffsets = ComputeSegmentOffsets(segments);
        }

        static int[] ComputeSegmentOffsets(ParseText[] segments)
        {
            var segmentOffsets = new int[segments.Length];
            int offset = 0;
            for (int i = 0; i < segmentOffsets.Length; i++)
            {
                segmentOffsets[i] = offset;
                offset += segments[i].Length;
            }

            return segmentOffsets;
        }

        public override int Length => _length;

        public override char this[int position]
        {
            get
            {
                int segment;
                int offset;
                GetSegmentAndOffset(position, out segment, out offset);
                return _segments[segment][offset];
            }
        }

        public override int Compare(string comparator, int index, TextSpan span, StringComparison comparison)
        {
            CheckSpanInLength(span);

            return string.Compare(comparator, index, ToString(span), span.Start, span.Length, comparison);
        }

        public override ParseText GetSubText(TextSpan span)
        {
            CheckSpanInLength(span);

            var startIndex = span.Start;
            var count = span.Length;

            int segmentIndex;
            int segmentOffset;
            GetSegmentAndOffset(startIndex, out segmentIndex, out segmentOffset);

            List<ParseText> newSegments = new List<ParseText>(_segments.Length - segmentIndex);
            while (segmentIndex < _segments.Length && count > 0)
            {
                var segment = _segments[segmentIndex];
                var copyLength = Math.Min(count, segment.Length - segmentOffset);

                newSegments.Add(segment.GetSubText(new TextSpan(segmentOffset, copyLength)));

                count -= copyLength;
                segmentIndex++;
                segmentOffset = 0;
            }

            return new CompositeText(newSegments.ToArray());
        }

        void GetSegmentAndOffset(int position, out int index, out int offset)
        {
            int segmentIndex = _segmentOffsets.BinarySearch(position);

            index = segmentIndex >= 0 ? segmentIndex : (~segmentIndex - 1);
            offset = position - _segmentOffsets[index];
        }

        bool CheckCopyToArguments(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            if (destination == null)
                throw new ArgumentNullException(nameof(destination));

            if (sourceIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(sourceIndex));

            if (destinationIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(destinationIndex));

            if (count < 0 || count > this.Length - sourceIndex || count > destination.Length - destinationIndex)
                throw new ArgumentOutOfRangeException(nameof(count));

            return count > 0;
        }

        public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            if (!CheckCopyToArguments(sourceIndex, destination, destinationIndex, count))
                return;

            int segIndex;
            int segOffset;
            GetSegmentAndOffset(sourceIndex, out segIndex, out segOffset);

            while (segIndex < _segments.Length && count > 0)
            {
                var segment = _segments[segIndex];
                var copyLength = Math.Min(count, segment.Length - segOffset);

                segment.CopyTo(segOffset, destination, destinationIndex, copyLength);

                count -= copyLength;
                destinationIndex += copyLength;
                segIndex++;
                segOffset = 0;
            }
        }

        static void ComputeLength(ParseText[] segments, out int length)
        {
            length = 0;
            for (int i = 0; i < segments.Length; i++)
            {
                var segment = segments[i];
                length += segment.Length;
            }
        }
    }
}