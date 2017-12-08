namespace Machete.TranslateConfiguration
{
    using System.Collections.Generic;
    using Visitors;


    public interface ITranslatorBuilderPropertyScanner<out TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Scan the properties of the target type, invoking the visitor as needed
        /// </summary>
        /// <param name="excludeProperties"></param>
        /// <param name="visitor"></param>
        void ScanProperties(HashSet<string> excludeProperties, ITranslateBuilderPropertyVisitor<TSchema> visitor);
    }
}