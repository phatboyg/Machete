namespace Machete.X12Schema.V5010
{
    using System;
    using X12;


    public interface Y6 :
        X12Segment
    {
        Value<string> AuthorityIdentifierCode { get; }
        
        Value<string> Authority { get; }
        
        Value<DateTime> AuthorityDate { get; }
    }
}