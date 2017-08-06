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
            where T : IEntityTranslateSpecification<TEntity, TEntity, TSchema>;

        /// <summary>
        /// Specify the translate to use for the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Using<T>()
            where T : IEntityTranslateSpecification<TEntity, TEntity, TSchema>, new();
    }
}