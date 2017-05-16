namespace Machete
{
    public interface IDateTimePropertyConfigurator<TValue> :
        IPropertyConfigurator
    {
        IValueConverter<TValue> Converter { set; }
    }
}