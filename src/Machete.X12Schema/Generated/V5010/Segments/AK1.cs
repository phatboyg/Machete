using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface AK1 :
        X12Segment
    {
        Value<string> FunctionalIdCode { get; }
        Value<string> GroupCtrlNumber { get; }
        Value<string> VerReleaseIdCode { get; }
    }
}
