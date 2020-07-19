namespace Machete.HL7Schema.V26
{
    using HL7;


    /// <summary>
    /// HL7LayoutMap V26
    /// </summary>
    public abstract class HL7V26LayoutMap<TLayout> :
        HL7LayoutMap<TLayout, HL7V26Entity>
        where TLayout : HL7V26Layout
    {
    }
}