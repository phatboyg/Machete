namespace Machete.Translators
{
    public interface IEntityCreatorFactory<TSchema>
        where TSchema : Entity
    {
        IEntityCreator<TSchema> Create(TranslatorFactoryContext<TSchema> context);
    }
}