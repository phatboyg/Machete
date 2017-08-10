﻿namespace Machete.HL7.Tests.Segments
{
    public interface NumericArraySegment :
        HL7Segment
    {
        Value<NA> Array1 { get; }
        Value<NA> Array2 { get; }
        Value<NA> Array3 { get; }
    }
}