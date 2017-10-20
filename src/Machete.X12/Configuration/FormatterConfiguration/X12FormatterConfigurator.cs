namespace Machete.X12.Configuration.FormatterConfiguration
{
    using Formatters;
    using Machete.FormatterConfiguration;
    using Machete.Formatters;


    public class X12FormatterConfigurator<TSchema> :
        FormatterConfigurator<TSchema>,
        IX12FormatterConfigurator<TSchema>
        where TSchema : X12Entity
    {
        public X12FormatterConfigurator(ISchema<TSchema> schema)
            : base(schema)
        {
        }

        public IFormatter<TSchema> Build()
        {
            return new X12Formatter<TSchema>(Schema);
        }
    }
}