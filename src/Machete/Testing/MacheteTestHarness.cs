namespace Machete.Testing
{
    using System;


    public abstract class MacheteTestHarness<TSchema>
        where TSchema : Entity
    {
        readonly Lazy<ISchema<TSchema>> _schema;
        readonly Lazy<IParser<TSchema>> _parser;

        public MacheteTestHarness()
        {
            _schema = new Lazy<ISchema<TSchema>>(CreateSchema);
            _parser = new Lazy<IParser<TSchema>>(() => CreateParser(Schema));
        }

        public ISchema<TSchema> Schema => _schema.Value;
        public IParser<TSchema> Parser => _parser.Value;

        protected abstract ISchema<TSchema> CreateSchema();
        protected abstract IParser<TSchema> CreateParser(ISchema<TSchema> schema);
    }
}