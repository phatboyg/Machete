namespace Machete.TranslateConfiguration
{
    using System.Collections.Generic;


    public interface ITranslateBuilderPropertyScanner<TResult, TInput, TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        /// <summary>
        /// Scan the properties of the target type, invoking the visitor as needed
        /// </summary>
        /// <param name="excludeProperties"></param>
        /// <param name="visitor"></param>
        void ScanProperties(HashSet<string> excludeProperties, ITranslateBuilderPropertyVisitor<TResult, TInput, TSchema> visitor);
    }
}