// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OM7 (SegmentMap) - Additional Basic Attributes
    /// </summary>
    public class OM7Map :
        HL7V26SegmentMap<OM7>
    {
        public OM7Map()
        {
            Id = "OM7";

            Name = "Additional Basic Attributes";

            Value(x => x.SequenceNumberTestObservationMasterFile, 1, x => x.IsRequired());
            Entity(x => x.UniversalServiceIdentifier, 2, x => x.IsRequired());
            Entity(x => x.CategoryIdentifier, 3);
            Value(x => x.CategoryDescription, 4);
            Value(x => x.CategorySynonym, 5);
            Value(x => x.EffectiveTestServiceStartDateTime, 6, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.EffectiveTestServiceEndDateTime, 7, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.TestServiceDefaultDurationQuantity, 8);
            Entity(x => x.TestServiceDefaultDurationUnits, 9);
            Value(x => x.TestServiceDefaultFrequency, 10);
            Value(x => x.ConsentIndicator, 11);
            Entity(x => x.ConsentIdentifier, 12);
            Value(x => x.ConsentEffectiveStartDateTime, 13, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ConsentEffectiveEndDateTime, 14, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Value(x => x.ConsentIntervalQuantity, 15);
            Entity(x => x.ConsentIntervalUnits, 16);
            Value(x => x.ConsentWaitingPeriodQuantity, 17);
            Entity(x => x.ConsentWaitingPeriodUnits, 18);
            Value(x => x.EffectiveDateTimeOfChange, 19, x => x.Converter = HL7.HL7ValueConverters.VariableLongDateTime);
            Entity(x => x.EnteredBy, 20);
            Entity(x => x.OrderableAtLocation, 21);
            Value(x => x.FormularyStatus, 22);
            Value(x => x.SpecialOrderIndicator, 23);
            Entity(x => x.PrimaryKeyValueCDM, 24);
        }
    }
}