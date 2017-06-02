namespace Machete.Testing
{
    using System;


    public abstract class MacheteTestHarness<TSchema> :
        IMacheteTestHarness<TSchema>
        where TSchema : Entity
    {
        readonly Lazy<ISchema<TSchema>> _schema;
        readonly Lazy<IParser<TSchema>> _parser;
        readonly Lazy<IStructure<TSchema>> _structure;

        public MacheteTestHarness()
        {
            _schema = new Lazy<ISchema<TSchema>>(CreateSchema);
            _parser = new Lazy<IParser<TSchema>>(() => CreateParser(Schema));
            _structure = new Lazy<IStructure<TSchema>>(() => CreateStructure(Schema));
        }

        public ISchema<TSchema> Schema => _schema.Value;
        public IParser<TSchema> Parser => _parser.Value;
        public IStructure<TSchema> Structure => _structure.Value;

        protected abstract ISchema<TSchema> CreateSchema();
        protected abstract IParser<TSchema> CreateParser(ISchema<TSchema> schema);
        protected abstract IStructure<TSchema> CreateStructure(ISchema<TSchema> schema);
    }
}