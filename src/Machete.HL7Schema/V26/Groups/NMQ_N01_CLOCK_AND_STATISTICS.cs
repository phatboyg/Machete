// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// NMQ_N01_CLOCK_AND_STATISTICS (Group) - 
    /// </summary>
    public interface NMQ_N01_CLOCK_AND_STATISTICS :
        HL7V26Layout
    {
        /// <summary>
        /// NCK
        /// </summary>
        Segment<NCK> NCK { get; }

        /// <summary>
        /// NST
        /// </summary>
        Segment<NST> NST { get; }

        /// <summary>
        /// NSC
        /// </summary>
        Segment<NSC> NSC { get; }
    }
}