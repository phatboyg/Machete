namespace Machete.TranslateConfiguration
{
    using System;


    public interface ITranslateEntityUsingConfigurator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// Specify the translate to use for the entity
        /// </summary>
        /// <param name="specificationFactory"></param>
        /// <typeparam name="T"></typeparam>
        void Using<T>(Func<T> specificationFactory)
            where T : IEntityTranslatorSpecification<TEntity, TEntity, TSchema>;

        /// <summary>
        /// Specify the translate to use for the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Using<T>()
            where T : IEntityTranslatorSpecification<TEntity, TEntity, TSchema>, new();

        /// <summary>
        /// Specify a translate inline without having to define a separate class
        /// </summary>
        /// <param name="configure"></param>
        void By(Action<IEntityTranslatorConfigurator<TEntity, TEntity, TSchema>> configure);
    }
}