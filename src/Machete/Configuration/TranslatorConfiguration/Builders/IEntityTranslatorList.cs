namespace Machete.TranslatorConfiguration.Builders
{
    public interface IEntityTranslatorList<TSchema>
        where TSchema : Entity
    {
        void Add<T>(IEntityTranslator<T, TSchema> translator)
            where T : TSchema;

        IEntityTranslator<TSchema> Build();
    }
}