
## Machete
### Cut through the Crap!

![Machete](machete_thin_outline_small.png)

Machete is a parser, object mapper, and query engine for processing sophisticated text.

> Machete will also include translation and formatting, but those features have yet to be developed.

Machete is highly optimized and leverages efficient parsing algorithms combined with lazy text evaluation, which reduce memory usage, limit garbage collection, and defer string allocations, resulting in blazing fast performance.

Machete fully supports asynchronous processing of text, including streams, making it perfect for building high-volume, multi-threaded, distributed systems.

**HL7**

Machete was designed from the ground up to support HL7 messages and can parse and map segments, fields, components, and subcomponents. Machete supports multiple HL7 versions, which can be used simultaneously without conflict.

<br/>

**X12**

Machete was also designed from the ground up to support X12 transactions and can parse and map segments, elements, and sub-elements. Machete supports multiple X12 versions, which can be used simultaneously without conflict. In addition, loops and conditional parsing is also supported.

<br/>


[![nuget](https://img.shields.io/nuget/v/Machete.NET.svg)](https://www.nuget.org/packages/Machete.NET/)
[![Join the chat at https://gitter.im/PhatBoyG-Machete/Lobby](https://badges.gitter.im/PhatBoyG-Machete/Lobby.svg)](https://gitter.im/PhatBoyG-Machete/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Build status](https://ci.appveyor.com/api/projects/status/github/phatboyg/machete?branch=develop&svg=true)](https://ci.appveyor.com/api/projects/status/github/phatboyg/machete)
[![Test status](https://img.shields.io/appveyor/tests/phatboyg/machete/develop.svg)](https://ci.appveyor.com/project/phatboyg/machete/build)


## Developing Machete

Machete is written entirely in C# and was developed using JetBrains Rider. It supports the standard .NET framework (>= 4.5.2), as well as .NET Standard (>= 2.1.0), allowing it to be used on any .NET compatible platform (e.g. Windows, macOS, Linux, etc.). Machete has been tested on Windows 7, 8, and 10 (.NET Framework and .NET Core) macOS (Mono and .NET Core)


## NuGet the Bits

If you are working in HL7, you need the following NuGet packages:<br/>
Machete.NET<br/>
Machete.HL7<br/>
Machete.HL7Schema
<br/><br/>
If you are working in X12, you need the following NuGet packaged:<br/>
Machete.NET<br/>
Machete.X12<br/>
Machete.X12Schema


## Registering Machete Components

Before using any of Machete's APIs, components must be registered. Below represents which components that must be registered and in what scenarios should they be registered.

<br/>

**Step 1:** Register the Machete components you need<br/><br/>
*If parsing and/or translating a message, register a schema and parser like so...*

**HL7**
```c#
var schema = Machete.Schema.Factory.CreateHL7<HL7Entity>(cfg => cfg.AddFromNamespaceContaining<MSH>());
var parser = Machete.Parser.Factory.CreateHL7(schema);
```
**X12**
```c#
var schema = Machete.Schema.Factory.CreateX12<X12Entity>(cfg => cfg.AddFromNamespaceContaining<ISA>());
var parser = Machete.Parser.Factory.CreateX12(schema);
```

<br/>

Please note that calling the *AddFromNamespaceContaining* method assumes that your schema entities are in the same namespace. So, the above examples will register the default schema, which is in the same namespace by convention. However, if you wanted to register your schema entities alongside the default schema then you would do something like this...

```c#
var schema = Machete.Schema.Factory.CreateHL7<HL7Entity>(cfg =>
    {
        cfg.AddFromNamespaceContaining<MSH>());
        cfg.AddFromNamespaceContaining<YourSchemaEntity>();
    };
```
 
Since registering the schema is expensive, consider using the singleton pattern. In other words, the schema should only be registered once in your application. You can use your favorite DI container or those do it yourselfers, you can look at HL7MacheteTestHarness or X12MacheteTestHarness for examples.
<br/><br/>

*If using the formatter to encode in-memory schema objects into other formats, register these formatters like so...*

**HL7**
```c#
var formatter = Machete.Formatter.Factory.CreateHL7(schema);
```
**X12**
```c#
var formatter = Machete.Formatter.Factory.CreateX12(schema);
```
<br/>

DI container example (**Autofac**)
```c#
public class MacheteModule :
        Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.Register(context => Machete.Schema.Factory.CreateHL7<HL7Entity>(x => x.AddFromNamespaceContaining<MSH>()))
            .SingleInstance()
            .As<ISchema<HL7Entity>>();

        builder.Register(context =>
            {
                var schema = context.Resolve<ISchema<HL7Entity>>();

                return Machete.Formatter.Factory.CreateHL7(schema);
            })
            .SingleInstance()
            .As<IFormatter<HL7Entity>>();
        
        builder.Register(context =>
            {
                var schema = context.Resolve<ISchema<HL7Entity>>();

                return Machete.Parser.Factory.CreateHL7(schema);
            })
            .SingleInstance()
            .As<IEntityParser<HL7Entity>>();
    }
}
```

<br/>

## Parsing Text Data

Parsing is the most fundamental operation that can be performed within Machete. Below are the various ways for the various specifications for which a parsing operation can be performed.

<br/>

**Step 1:** Initialize a parser

*If parsing a single message, then call the parser like so...*
```c#
var parse = parser.Parse(message);
```

<br/>

*If parsing a string of multiple messages, then call the streaming parser like so...*
```c#
using (var stream = new StringReader(message))
{
    StreamText text = await new TextReaderStreamTextReader(stream, Environment.NewLine).Text;
    var parse = await parser.ParseStream(text, new TextSpan(0, text.Length));
    
    ...
}
```
<br/>

*If parsing a file of a single message or multiple messages, then call the streaming parser like so...*
```c#
using (var stream = File.OpenRead(file))
{
    StreamText text = await new StreamTextReader(stream).Text;
    var parse = await parser.ParseStream(text, new TextSpan(0, text.Length));
    
    ...
}
```
<br/>

**Step 2:** Query the message

*If querying entities, then you can do something like this...*

**HL7**
```c#
while (parse.HasResult)
{
    while (parse.TryGetEntity(index, out HL7Segment segment))
    {
        ...
    }

    result = await parse.NextAsync();
}
```
**X12**
```c#
while (parse.HasResult)
{
    while (parse.TryGetEntity(index, out X12Segment segment))
    {
        ...
    }

    result = await parse.NextAsync();
}
```

<br/>

*If querying using layout patterns, then you can do something like this...*

**HL7**
```c#
using (var stream = File.OpenRead(file))
{
    var text = await new StreamTextReader(stream).Text;
    var parse = await parser.ParseStream(text, new TextSpan(0, text.Length));

    if (!schema.TryGetLayout(out ILayoutParserFactory<ORM_O01, HL7Entity> layout))
        return;

    while (parse.HasResult)
    {
        IParser<HL7Entity, ORM_O01> query = parse.CreateQuery(layout);
        Result<Cursor<HL7Entity>, ORM_O01> queryResult = parse.Query(query);
        
        if (queryResult.HasResult)
        {
            ...
        }
        
        result = await result.NextAsync();
    }
}
```
**X12**
```c#
using (var stream = File.OpenRead(file))
{
    var text = await new StreamTextReader(stream).Text;
    var parse = await parser.ParseStream(text, new TextSpan(0, text.Length));

    if (!schema.TryGetLayout(out ILayoutParserFactory<HCPA835, X12Entity> layout))
        return;

    while (parse.HasResult)
    {
        IParser<X12Entity, HCPA835> query = parse.CreateQuery(layout);
        Result<Cursor<X12Entity>, HCPA835> queryResult = parse.Query(query);
        
        if (queryResult.HasResult)
        {
            ...
        }
        
        result = await result.NextAsync();
    }
}
```

<br/>

*If querying using LINQ, then you can do something like this...*

**LINQ to HL7**
```c#
var query = parse.Query(q =>
    {
        var obxQuery = from obx in q.Select<OBX>()
            from nte in q.Select<NTE>().ZeroOrMore()
            select new
            {
                OBX = obx,
                NTE = nte
            };

        var obrQuery = from obr in q.Select<OBR>()
            from dg1 in q.Select<DG1>().Optional()
            from obx in obxQuery.Optional()
            select new
            {
                OBR = obr,
                DG1 = dg1,
                OBX = obx
            };

        var testQuery = from orc in q.Select<ORC>()
            from obr in obrQuery.ZeroOrMore()
            select new
            {
                ORC = orc,
                OBR = obr
            };

        return from msh in q.Select<MSH>()
            from nte in q.Select<NTE>().ZeroOrMore()
            from skip in q.Except<HL7Segment, ORC>().ZeroOrMore()
            from tests in testQuery.ZeroOrMore()
            select new
            {
                MSH = msh,
                Notes = nte,
                Tests = tests
            };
    });
```

**LINQ to X12**
```c#
var query = schema.CreateQuery(q =>
                from isa in q.Select<ISA>()
                from skip in q.Except<X12Segment, NM1>().ZeroOrMore()
                from nm1 in q.Select<NM1>()
                select nm1);
```

<br/>



| Parser                                     | Description                                                                                                                                                                                                                                                                   | Function          |
|:-------------------------------------------|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:------------------|
| **Select**                                 | Iterate over several items in a set, projecting them onto a defined variable.                                                                                                                                                                                                 | Projection        |
| **SelectMany**                             | Iterate over an array of items (e.g. components or elements depending on the specification), within a field of *ValueList<T>*, then iterate over a structure that has one or more entities (e.g. segment), *Entity<T>*, returning a one-dimensional array of projected items. | Project & Flatten |
| **Except**                                 | Iterate over an array of items excluding them all until reaching the specified entity, subsequently returning a one-dimensional array of excluded entities.                                                                                                                   | Exclusion         |
| **Skip, SkipUntil**                        | Skip over one or more entities, returning a one-dimensional array of skipped entities, *Entity<T>*, while moving the cursor to the resultant skipped location.                                                                                                                | Skip              |
| **Take, TakeWhile, ZeroOrMore, OneOrMore** | Return an array of n items after the entity has been selected.                                                                                                                                                                                                                | Take              |
| **Optional, Or**                           | Return an item conditional after the entity has been selected.                                                                                                                                                                                                                | Conditional       |
| **Then**                                   | Return a different item after the entity has been selected.                                                                                                                                                                                                                   | Continuation      |
|                                            |                                                                                                                                                                                                                                                                               |                   |



**Step 3:** Accessing data

```c#
string placerGroupNumber = result.Result.Tests[0].ORC.PlacerGroupNumber.Select(x => x.EntityIdentifier).ValueOrDefault();
```

Note: Use the *Select* and *ValueOrDefault* methods to prevent exceptions from bubbling up to the caller when attempting to access fields.

<br/>

## Translating Parsed Data

If you need to change the parsed data, then Machete provides a separate API from the parsing API since the message being parsed is immutable. Below are the steps necessary to translate the data.

<br/>

**Step 1:** Define a translate
```c#
public class MessageTranslation :
    HL7Translation<HL7Entity>
{
    public MessageTranslation()
    {
        Translate<MSH>(x => x.Using<ReplaceSendingApplication>());
    }
}

public class ReplaceSendingApplication :
    HL7SegmentTranslation<MSH, HL7Entity>
{
    public ReplaceSendingApplication()
    {
        Copy(x => x.ReceivingApplication, x => x.SendingApplication);

        Set(x => x.CreationDateTime, x => DateTimeOffset.UtcNow);
    }
}
```

<br/>

**Step 2:** Get a translator from the schema based on the translate defined in step 1
```c#
var translator = schema.GetTranslator<MessageTranslation>();
```

<br/>

**Step 3:** Translate the parsed data using the translator created in step 2


```c#
var translateResult = await translator.Translate(parse);
```

<br/>

## Formatting Objects

It is common to use in-memory objects within algorithms but those objects need to encoded before they can be transmitted with other systems. In Machete, this is how you would use the default formatter to output a text string representation of in-memory objects. 
```c#
using (var memoryStream = new MemoryStream())
{
    var formatted = await formatter.FormatAsync(memoryStream, input);

    string text = Encoding.UTF8.GetString(memoryStream.ToArray());
    
    ...
}
```

If you just want to cut through the crap, you can just call the extension method that ships with Machete like so...

```c#
var formatted = await Formatter.FormatToStringAsync(parse);
```
Currently, the formatter supports ParseResult, EntityResult, and TranslateResult.


<br/>

## Creating Schema

Although Machete ships with default schemas in both HL7 and X12 that adhere to those corresponding specifications, we felt that it was equally necessary to provide a mechanism to generate your own schema.

<br/>

*If defining a data type, follow the below steps.*

**Step 1:** Define the data type
```c#
public interface ID :
    HL7Component
{
    Value<string> Identifier { get; }
    Value<HD> AssigningAuthority { get; }
    Value<string> IdentifierTypeCode { get; }
    Value<DateTimeOffset> IssueDateTime { get; }
}
```

<br/>

**Step 2:** Define the data configurator
```c#
public class IDMap :
    HL7ComponentMap<ID, HL7Component>
{
    public IDMap()
    {
        Value(x => x.Identifier, 0, x => x.IsRequired());
        Entity(x => x.AssigningAuthority, 1);
        Value(x => x.IdentifierTypeCode, 2);
        Value(x => x.IssueDateTime, 3, x => x.IsRequired());
    }
}
```
Please note that when configuring components the first available index is 0 since field components do not have identifiers like segments (e.g. PID, MSH, etc.).

<br/>


*If defining a segment, follow the below steps.*

**Step 1:** Define a segment
```c#
public interface PatientDemographics :
    HL7Segment
{
    Value<ID> AccountIdentifier { get; }
    Value<ID> SSN { get; }
    Value<string> FirstName { get; }
    Value<string> LastName { get; }
    Value<string> MiddleName { get; }
    Value<string> Suffix { get; }
    Value<string> Prefix { get; }
    Value<string> Gender { get; }
    Value<DateTime> DateOfBirth { get; }
    Value<string> Address { get; }
    Value<string> City { get; }
    Value<string> Region { get; }
    Value<string> ZipCode { get; }
}
```

<br/>

**Step 2:** Define the data configurator
```c#
public class PatientDemographicsMap :
    HL7SegmentMap<PatientDemographics, HL7Entity>
{
    public PatientDemographicsMap()
    {
        Id = "ZPD";
        Name = "Patient Demographics";

        Entity(x => x.AccountIdentifier, 1, x => x.IsRequired());
        Entity(x => x.SSN, 2, x => x.IsRequired());
        Value(x => x.FirstName, 3, x => x.IsRequired());
        Value(x => x.LastName, 4, x => x.IsRequired());
        Value(x => x.MiddleName, 5);
        Value(x => x.Suffix, 6);
        Value(x => x.Prefix, 7);
        Value(x => x.Gender, 8, x => x.IsRequired());
        Value(x => x.DateOfBirth, 9, x => x.IsRequired());
        Value(x => x.Address, 9, x => x.IsRequired());
        Value(x => x.City, 9, x => x.IsRequired());
        Value(x => x.Region, 9, x => x.IsRequired());
        Value(x => x.ZipCode, 9, x => x.IsRequired());
    }
}
```

<br/>

*If defining a layout, follow the below steps.*

**Step 1:** Define the layout
```c#
public interface Order :
    HL7Layout
{
    Segment<ORC> ORC { get; }
    Segment<OBR> OBR { get; }
    Segment<DG1> DG1 { get; }
    Segment<OBX> OBX { get; }
    SegmentList<NTE> Notes { get; }
    Segment<PatientDemographics> ZPD { get; }
}
```

<br/>

**Step 2:** Define the data configurator
```c#
public class OrderMap :
    HL7LayoutMap<Order, HL7Entity>
{
    public OrderMap()
    {
        Segment(x => x.ORC, 0, x => x.IsRequired());
        Segment(x => x.OBR, 1, x => x.IsRequired());
        Segment(x => x.DG1, 2);
        Segment(x => x.OBX, 3, x => x.IsRequired());
        Segment(x => x.Notes, 4);
        Segment(x => x.ZPD, 5, x => x.IsRequired());
    }
}
```

<br/>

Please note that all defined schema is immutable. We enforce this during initialization of the schema at runtime, which is the reason for the initial performance hit and why the Machete components should be registered only once. Due to this design, you are not allowed to add setters to the backing class, which means that if you were to add a setter to the defined schema it would not have a supporting implementation. Therefore, we are able to enforce and maintain data fidelity throughout parsing operations. For the caller, this translates into faster and more consistent execution. For the developer, this means you never have to debug the parsing operation for bugs that might have been injected by custom logic in the caller.

<br/>

*Registering your new schema is easy, just do the following...*
```c#
var schema = Machete.Schema.Factory.CreateHL7<HL7Entity>(cfg =>
    {
        cfg.AddFromNamespaceContaining<MSH>());
        cfg.AddFromNamespaceContaining<PatientDemographics>();
    };
```
This will register both entity and corresponding data configurator for your schema because, by convention, they should all be in the same base namespace.

## License
Licensed under the terms of [Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0)