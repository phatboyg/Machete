using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface CTX :
        X12Segment
    {
        Value<string> ContextIdentificat { get; }
        Value<string> SegmentIDCode { get; }
        Value<string> SegmentPosInTS { get; }
        Value<string> LoopIDCode { get; }
        Value<string> PositionInSegment { get; }
        Value<string> ReferenceInSegment { get; }

    }
}
