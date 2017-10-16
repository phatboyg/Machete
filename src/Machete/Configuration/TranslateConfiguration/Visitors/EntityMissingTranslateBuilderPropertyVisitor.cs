namespace Machete.TranslateConfiguration.Visitors
{
    using System.Reflection;


    public class EntityMissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> : 
        MissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly ITranslateBuilderPropertyReflector<EntityMissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>, TSchema> _reflector;

        public EntityMissingTranslateBuilderPropertyVisitor(IEntityTranslateBuilder<TResult, TInput, TSchema> builder)
            : base(builder)
        {
            _reflector = new EntityTranslateBuilderPropertyReflector<EntityMissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>, TResult, TInput, TSchema>();
        }

        public override void Property(PropertyInfo property)
        {
            _reflector.Property(this, property);
        }
    }
}