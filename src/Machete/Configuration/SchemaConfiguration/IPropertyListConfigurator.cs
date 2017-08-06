namespace Machete.SchemaConfiguration
{
    public interface IPropertyListConfigurator<out TValue> :
        IPropertyConfigurator
    {
        void SetRange();
        void SetList();
        void SetSingle();
    }
}