namespace Machete.ParserConfiguration.Configurators
{
    using System.Collections.Generic;
    using Configuration;


    public class ParserConfigurator<TSchema> :
        IParserConfigurator<TSchema>,
        ISpecification
        where TSchema : Entity
    {
        protected ISchema<TSchema> Schema { get; }

        protected ParserConfigurator(ISchema<TSchema> schema)
        {
            Schema = schema;
        }

        public IEnumerable<ValidateResult> Validate()
        {
            if (Schema == null)
                yield return this.Null("Schema");
        }
    }
}