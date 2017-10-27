namespace Machete.Testing
{
    using System;
    using Formatters;


    public abstract class MacheteTestHarness<TSchema> :
        IMacheteTestHarness<TSchema>
        where TSchema : Entity
    {
        readonly Lazy<ISchema<TSchema>> _schema;
        readonly Lazy<IEntityParser<TSchema>> _parser;
        readonly Lazy<IFormatter<TSchema>> _formatter;

        public MacheteTestHarness()
        {
            _schema = new Lazy<ISchema<TSchema>>(CreateSchema);
            _parser = new Lazy<IEntityParser<TSchema>>(() => CreateParser(Schema));
            _formatter = new Lazy<IFormatter<TSchema>>(() => CreateFormatter(Schema));
        }

        public ISchema<TSchema> Schema => _schema.Value;
        public IEntityParser<TSchema> Parser => _parser.Value;
        public IFormatter<TSchema> Formatter => _formatter.Value;

        protected abstract ISchema<TSchema> CreateSchema();
        protected abstract IEntityParser<TSchema> CreateParser(ISchema<TSchema> schema);
        protected abstract IFormatter<TSchema> CreateFormatter(ISchema<TSchema> schema);
    }
}