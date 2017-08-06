namespace Machete.TranslateConfiguration.Visitors
{
    using System.Reflection;


    public class EntityCopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema> :
        CopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly ITranslateBuilderPropertyReflector<ITranslateBuilderPropertyVisitor<TSchema>, TSchema> _reflector;

        public EntityCopyTranslateBuilderPropertyVisitor(IEntityTranslateBuilder<TResult, TInput, TSchema> builder)
            : base(builder)
        {
            _reflector = new EntityTranslateBuilderPropertyReflector<ITranslateBuilderPropertyVisitor<TSchema>, TResult, TInput, TSchema>();
        }

        public override void Property(PropertyInfo property)
        {
            _reflector.Property(this, property);
        }
    }
}