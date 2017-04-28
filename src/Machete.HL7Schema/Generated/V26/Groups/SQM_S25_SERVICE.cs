// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SQM_S25_SERVICE (Group) - 
    /// </summary>
    public interface SQM_S25_SERVICE :
        HL7Template
    {
        /// <summary>
        /// AIS
        /// </summary>
        Segment<AIS> AIS { get; }

        /// <summary>
        /// APR
        /// </summary>
        Segment<APR> APR { get; }
    }
}