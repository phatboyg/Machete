namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2100E_276 :
        X12Layout
    {
        Segment<NM1> Dependent { get; }
    }
}