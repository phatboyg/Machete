namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LH6 :
        X12Segment
    {
        Value<string> Name { get; }
        
        Value<string> HazardousCertificationCode { get; }
        
        Value<string> HazardousCertificationDeclaration1 { get; }
        
        Value<string> HazardousCertificationDeclaration2 { get; }
    }
}