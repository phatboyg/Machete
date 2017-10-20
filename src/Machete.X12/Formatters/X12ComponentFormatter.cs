namespace Machete.X12.Formatters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;
    using Machete.Formatters;


    public class X12ComponentFormatter<TComponent, TSchema> :
        IEntityFormatter<TComponent>
        where TComponent : TSchema, X12Component
        where TSchema : Entity
    {
        readonly X12FormatterSettings _settings;
        readonly IEntityPropertyFormatter<TComponent>[] _formatters;

        public X12ComponentFormatter(IEnumerable<IEntityPropertyFormatter<TComponent>> formatters)
        {
            _formatters = formatters.ToArray();

            _settings = new X12FormatterSettings();
        }

        public void Format(FormatContext context, TComponent entity)
        {
            int length = 0;

            var componentContext = context.CreateEntityContext(entity);

            var formatContext = componentContext.SetLevel(x => FormatLevel.Component);

            var separator = formatContext.Level == FormatLevel.Component ? _settings.SubElementSeparator : _settings.ElementSeparator;

            for (int i = 0; i < _formatters.Length; i++)
            {
                if (i > 0)
                {
                    context.Append(separator);
                }

                int position = context.Position;

                _formatters[i].Format(componentContext.CreateEntityContext(entity));

                if (position < context.Position)
                    length = context.Position;
            }

            if (length == 0)
                context.Clear();
            else
            {
                context.Trim(length);
            }
        }

        public void Format<T>(FormatContext context, T entity)
            where T : Entity
        {
            var obj = (object) entity;
            if (obj is TComponent)
            {
                Format(context, (TComponent) obj);
            }
            else
                throw new ArgumentException($"Argument entity type was {TypeCache.GetShortName(entity.GetType())}, expected {TypeCache<TComponent>.ShortName}");
        }

        public Type EntityType => typeof(TComponent);
    }
}