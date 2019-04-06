namespace Machete.TranslatorConfiguration
{
    public interface ITranslateEntityCreatorUsingConfigurator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        void Using<T>()
            where T : IEntityCreatorSpecification<TEntity, TSchema>, new();

        /// <summary>
        /// Specify a translate inline without having to define a separate class
        /// </summary>
        /// <param name="configure"></param>
//        void By(Action<IEntityCreatorConfigurator<TEntity, TSchema>> configure);
    }
}