// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;


    /// <summary>
    /// PCR (Segment) - Possible Causal Relationship
    /// </summary>
    public interface PCR :
        HL7V26Segment
    {
        /// <summary>
        /// PCR-1: Implicated Product
        /// </summary>
        Value<CWE> ImplicatedProduct { get; }

        /// <summary>
        /// PCR-2: Generic Product
        /// </summary>
        Value<string> GenericProduct { get; }

        /// <summary>
        /// PCR-3: Product Class
        /// </summary>
        Value<CWE> ProductClass { get; }

        /// <summary>
        /// PCR-4: Total Duration Of Therapy
        /// </summary>
        Value<CQ> TotalDurationOfTherapy { get; }

        /// <summary>
        /// PCR-5: Product Manufacture Date
        /// </summary>
        Value<DateTimeOffset> ProductManufactureDate { get; }

        /// <summary>
        /// PCR-6: Product Expiration Date
        /// </summary>
        Value<DateTimeOffset> ProductExpirationDate { get; }

        /// <summary>
        /// PCR-7: Product Implantation Date
        /// </summary>
        Value<DateTimeOffset> ProductImplantationDate { get; }

        /// <summary>
        /// PCR-8: Product Explantation Date
        /// </summary>
        Value<DateTimeOffset> ProductExplantationDate { get; }

        /// <summary>
        /// PCR-9: Single Use Device
        /// </summary>
        Value<string> SingleUseDevice { get; }

        /// <summary>
        /// PCR-10: Indication For Product Use
        /// </summary>
        Value<CWE> IndicationForProductUse { get; }

        /// <summary>
        /// PCR-11: Product Problem
        /// </summary>
        Value<string> ProductProblem { get; }

        /// <summary>
        /// PCR-12: Product Serial/Lot Number
        /// </summary>
        Value<string> ProductSerialLotNumber { get; }

        /// <summary>
        /// PCR-13: Product Available For Inspection
        /// </summary>
        Value<string> ProductAvailableForInspection { get; }

        /// <summary>
        /// PCR-14: Product Evaluation Performed
        /// </summary>
        Value<CWE> ProductEvaluationPerformed { get; }

        /// <summary>
        /// PCR-15: Product Evaluation Status
        /// </summary>
        Value<CWE> ProductEvaluationStatus { get; }

        /// <summary>
        /// PCR-16: Product Evaluation Results
        /// </summary>
        Value<CWE> ProductEvaluationResults { get; }

        /// <summary>
        /// PCR-17: Evaluated Product Source
        /// </summary>
        Value<string> EvaluatedProductSource { get; }

        /// <summary>
        /// PCR-18: Date Product Returned To Manufacturer
        /// </summary>
        Value<DateTimeOffset> DateProductReturnedToManufacturer { get; }

        /// <summary>
        /// PCR-19: Device Operator Qualifications
        /// </summary>
        Value<string> DeviceOperatorQualifications { get; }

        /// <summary>
        /// PCR-20: Relatedness Assessment
        /// </summary>
        Value<string> RelatednessAssessment { get; }

        /// <summary>
        /// PCR-21: Action Taken In Response To The Event
        /// </summary>
        Value<string> ActionTakenInResponseToEvent { get; }

        /// <summary>
        /// PCR-22: Event Causality Observations
        /// </summary>
        Value<string> EventCausalityObservations { get; }

        /// <summary>
        /// PCR-23: Indirect Exposure Mechanism
        /// </summary>
        Value<string> IndirectExposureMechanism { get; }
    }
}