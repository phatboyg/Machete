namespace Machete.SchemaConfiguration
{
    public interface IDateTimePropertyConfigurator<TValue> :
        IPropertyConfigurator
    {
        IValueConverter<TValue> Converter { set; }
    }
}