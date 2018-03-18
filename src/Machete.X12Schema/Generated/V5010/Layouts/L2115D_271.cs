namespace Machete.X12Schema.V5010.Layouts
{
    using X12;


    public interface L2115D_271 :
        X12Layout
    {
        Segment<III> EligibilityOrBenefitAdditionalInformation { get; }
    }
}