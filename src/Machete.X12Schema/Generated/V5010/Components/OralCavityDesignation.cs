namespace Machete.X12Schema.V5010.Components
{
    using X12;


    public interface OralCavityDesignation :
        X12Component
    {
        Value<string> CavityDesignationCode1 { get; }
        
        Value<string> CavityDesignationCode2 { get; }
        
        Value<string> CavityDesignationCode3 { get; }
        
        Value<string> CavityDesignationCode4 { get; }
        
        Value<string> CavityDesignationCode5 { get; }
    }
}