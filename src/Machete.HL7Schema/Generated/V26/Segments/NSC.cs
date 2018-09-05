// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// NSC (Segment) - Application Status Change
    /// </summary>
    public interface NSC :
        HL7V26Segment
    {
        /// <summary>
        /// NSC-1: Application Change Type
        /// </summary>
        Value<string> ApplicationChangeType { get; }

        /// <summary>
        /// NSC-2: Current CPU
        /// </summary>
        Value<string> CurrentCPU { get; }

        /// <summary>
        /// NSC-3: Current Fileserver
        /// </summary>
        Value<string> CurrentFileServer { get; }

        /// <summary>
        /// NSC-4: Current Application
        /// </summary>
        Value<HD> CurrentApplication { get; }

        /// <summary>
        /// NSC-5: Current Facility
        /// </summary>
        Value<HD> CurrentFacility { get; }

        /// <summary>
        /// NSC-6: New CPU
        /// </summary>
        Value<string> NewCPU { get; }

        /// <summary>
        /// NSC-7: New Fileserver
        /// </summary>
        Value<string> NewFileServer { get; }

        /// <summary>
        /// NSC-8: New Application
        /// </summary>
        Value<HD> NewApplication { get; }

        /// <summary>
        /// NSC-9: New Facility
        /// </summary>
        Value<HD> NewFacility { get; }
    }
}