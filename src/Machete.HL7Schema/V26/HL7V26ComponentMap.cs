namespace Machete.HL7Schema.V26
{
    using HL7;


    /// <summary>
    /// HL7ComponentMap V26
    /// </summary>
    public abstract class HL7V26ComponentMap<TComponent> :
        HL7ComponentMap<TComponent, HL7V26Component>
        where TComponent : class, HL7V26Component
    {
    }
}