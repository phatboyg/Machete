// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using System;
    using HL7;
    using HL7.SchemaConfiguration;


    /// <summary>
    /// HL7SchemaFactoryExtensions
    /// </summary>
    public static class HL7V26SchemaFactoryExtensions
    {
        public static ISchema<HL7V26Entity> CreateHL7Version26(this ISchemaFactorySelector selector, Action<IHL7SchemaConfigurator<HL7V26Entity>> configure = null)
        {
            return selector.CreateHL7<HL7V26Entity>(x =>
            {
                x.AddFromNamespaceContaining<HL7Version26>();

                configure?.Invoke(x);
            });
        }
    }
}