// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M01_MF (Group) - 
    /// </summary>
    public interface MFN_M01_MF :
        HL7Template
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// Hxx
        /// </summary>
        Segment<HL7Segment> Hxx { get; }
    }
}