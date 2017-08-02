namespace Machete.TranslateConfiguration
{
    using System.Collections.Generic;
    using System.Reflection;
    using Internals.Extensions;


    public class EntityTranslateBuilderPropertyScanner<TResult, TInput, TSchema> :
        ITranslateBuilderPropertyScanner<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        public void ScanProperties(HashSet<string> excludeProperties, ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema> visitor)
        {
            foreach (PropertyInfo property in GetAllProperties())
            {
                if (excludeProperties.Contains(property.Name))
                    continue;

                visitor.Property(property);
            }
        }

        protected virtual IEnumerable<PropertyInfo> GetAllProperties()
        {
            return typeof(TResult).GetAllProperties();
        }
    }
}