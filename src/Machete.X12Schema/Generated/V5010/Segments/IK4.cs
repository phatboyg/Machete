using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface IK4 : X12Segment
    {
        Value<string> PositionInSegment { get; }
        Value<string> DataElementRefNumber { get; }
        Value<string> ImpleDataSynErCode { get; }
        Value<string> CopyOfBadDataElement { get; }
    }
}
