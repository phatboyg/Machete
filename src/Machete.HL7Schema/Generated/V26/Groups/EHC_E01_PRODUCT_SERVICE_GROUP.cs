// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E01_PRODUCT_SERVICE_GROUP (Group) - 
    /// </summary>
    public interface EHC_E01_PRODUCT_SERVICE_GROUP :
        HL7V26Layout
    {
        /// <summary>
        /// PSG
        /// </summary>
        Segment<PSG> PSG { get; }

        /// <summary>
        /// LOC
        /// </summary>
        SegmentList<LOC> LOC { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// PATIENT_INFO
        /// </summary>
        LayoutList<EHC_E01_PATIENT_INFO> PatientInfo { get; }

        /// <summary>
        /// PRODUCT_SERVICE_LINE_ITEM
        /// </summary>
        LayoutList<EHC_E01_PRODUCT_SERVICE_LINE_ITEM> ProductServiceLineItem { get; }

        /// <summary>
        /// PROCEDURE
        /// </summary>
        LayoutList<EHC_E01_PROCEDURE> Procedure { get; }

        /// <summary>
        /// INVOICE_PROCESSING
        /// </summary>
        LayoutList<EHC_E01_INVOICE_PROCESSING> InvoiceProcessing { get; }
    }
}