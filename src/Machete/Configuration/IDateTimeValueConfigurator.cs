namespace Machete
{
    public interface IDateTimeValueConfigurator<TValue> :
        IValueConfigurator<TValue>
    {
        IValueConverter<TValue> Converter { set; }
    }
}