namespace Machete.FormatterConfiguration
{
    using System.Collections.Generic;
    using Configuration;


    public class FormatterConfigurator<TSchema> :
        IFormatterConfigurator<TSchema>,
        ISpecification
        where TSchema : Entity
    {
        protected ISchema<TSchema> Schema { get; }

        protected FormatterConfigurator(ISchema<TSchema> schema)
        {
            Schema = schema;
        }

        IEnumerable<ValidateResult> ISpecification.Validate()
        {
            if (Schema == null)
                yield return this.Null("Schema");

            foreach (var result in Validate())
            {
                yield return result;
            }
        }

        protected virtual IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }
    }
}