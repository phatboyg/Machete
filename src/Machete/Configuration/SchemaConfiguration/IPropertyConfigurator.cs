namespace Machete.SchemaConfiguration
{
    /// <summary>
    /// Schema property configurator
    /// </summary>
    public interface IPropertyConfigurator
    {
        /// <summary>
        /// Specifies the fragment position of the value
        /// </summary>
        int Position { set; }

        /// <summary>
        /// Specifies the value is required, and must be present
        /// </summary>
        bool Required { set; }

        /// <summary>
        /// Specifies the minimum length of the value, in characters
        /// </summary>
        int MinLength { set; }

        /// <summary>
        /// Specifies the maximum length of the value, in characters
        /// </summary>
        int MaxLength { set; }

        /// <summary>
        /// Specify the formatting options
        /// </summary>
        FormatOptions Formatting { set; }
    }


    public interface IPropertyConfigurator<T> :
        IPropertyConfigurator
    {
        IValueConverter<T> Converter { set; }

        IValueFormatter<T> Formatter { set; }
    }
}