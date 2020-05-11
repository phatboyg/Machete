namespace Machete.HL7.Formatters
{
    using System;
    using Machete.Formatters;


    public interface ILayoutFormatterBuilder<TLayout, in TSchema>
    where TSchema : Layout
    where TLayout : TSchema
    {
        ILayoutFormatter<T> GetLayoutFormatter<T>()
            where T : TSchema;

        void Add(int position, ILayoutPropertyFormatter<TLayout> formatter);

        // ILayoutFormatterFactory<TLayout> Factory { set; }
    }


    public interface ILayoutPropertyFormatter<in TLayout>
    where TLayout : Layout
    {
        void Format(FormatLayoutContext<TLayout> context);
    }


    public interface FormatLayoutContext<out TLayout> :
        IContext
    where TLayout : Layout
    {
        TLayout Layout { get; }
        
        IFormatProvider CurrentCulture { get; }
        
        int Position { get; }

        void Append(TextSlice slice);

        void Append(string text);

        void Append(char c);

        void Clear();

        // FormatSegmentContext<T> CreateSegmentContext<T>(Segment<T> segment);

        FormatLayoutContext<T> CreateLayoutContext<T>(T layout)
            where T : Layout;

        void Trim(int position);
    }


    public interface FormatSegmentContext<out T>
        where T : HL7Segment
    {
        Segment<T> Segment { get; }
    }
}