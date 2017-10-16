using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Machete.X12Schema.V5010
{
    using Machete.X12;
    public interface AK2 :
        X12Segment
    {
        Value<string> IdCode { get; }
        Value<string> ControlNumber { get; }
        Value<string> ImpleConvReference { get; }
    }
}
