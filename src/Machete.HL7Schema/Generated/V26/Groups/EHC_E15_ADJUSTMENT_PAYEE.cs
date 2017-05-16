// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E15_ADJUSTMENT_PAYEE (Group) - 
    /// </summary>
    public interface EHC_E15_ADJUSTMENT_PAYEE :
        HL7Layout
    {
        /// <summary>
        /// ADJ
        /// </summary>
        Segment<ADJ> ADJ { get; }

        /// <summary>
        /// ROL
        /// </summary>
        Segment<ROL> ROL { get; }
    }
}