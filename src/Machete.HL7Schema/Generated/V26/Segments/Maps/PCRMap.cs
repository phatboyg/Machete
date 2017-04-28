// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PCR (SegmentMap) - Possible Causal Relationship
    /// </summary>
    public class PCRMap :
        HL7SegmentMap<PCR>
    {
        public PCRMap()
        {
            Id = "PCR";

            Name = "Possible Causal Relationship";

            Entity(x => x.ImplicatedProduct, 1, x => {x.Required = true;});
            Value(x => x.GenericProduct, 2);
            Entity(x => x.ProductClass, 3);
            Entity(x => x.TotalDurationOfrapy, 4);
            Value(x => x.ProductManufactureDate, 5, x => {x.Format = "LONGDATETIME5";});
            Value(x => x.ProductExpirationDate, 6, x => {x.Format = "LONGDATETIME6";});
            Value(x => x.ProductImplantationDate, 7, x => {x.Format = "LONGDATETIME7";});
            Value(x => x.ProductExplantationDate, 8, x => {x.Format = "LONGDATETIME8";});
            Value(x => x.SingleUseDevice, 9);
            Entity(x => x.IndicationForProductUse, 10);
            Value(x => x.ProductProblem, 11);
            Value(x => x.ProductSerialLotNumber, 12);
            Value(x => x.ProductAvailableForInspection, 13);
            Entity(x => x.ProductEvaluationPerformed, 14);
            Entity(x => x.ProductEvaluationStatus, 15);
            Entity(x => x.ProductEvaluationResults, 16);
            Value(x => x.EvaluatedProductSource, 17);
            Value(x => x.DateProductReturnedToManufacturer, 18, x => {x.Format = "LONGDATETIME18";});
            Value(x => x.DeviceOperatorQualifications, 19);
            Value(x => x.RelatedneAssessment, 20);
            Value(x => x.ActionTakenInResponseToEvent, 21);
            Value(x => x.EventCausalityObservations, 22);
            Value(x => x.IndirectExposureMechanism, 23);
        }
    }
}