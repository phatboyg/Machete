
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


## Design Principles

Machete was born out of more than 10 years of R&D and in that time period, we have established some unwritten rules around how we chose to implement certain APIs and functionality that we will formalize here.

##### Use proven Computer Science

The challenge of translating healthcare specifications to parsing libraries written in specific programming languages can be challenging at times. 
Not only does one have to deal with the challenges associated with the specification, there are many challenges around choosing a particular language or using particular algorithms to solve problems. 
That said, most parsing libraries tend to favor using particular programming paradigms throughout, even when it doesn't make sense to do so. Our philosophy is simple, do whatever makes the most sense for the situation. 
Although we chose to implement Machete in an Object Oriented Programming (OOP) language, we recognize that sometimes it will make sense to use OOP and other times it will make sense to use other paradigms like Functional Programming (FP). That said, we chose to implement Machete using mainly FP concepts. 
The rationale behind this was that FP provides some really powerful concepts and metaphors around speed and reliability that we felt were paramount to building a high performance healthcare parsing library. 
From monads, applicative functors, and higher-order functions, to functional purity, function honesty, and lazy evaluation, Machete is based on 70 years of mathematical theory and computer science.


##### Make it difficult to fail
- Maintain data fidelity during parsing operations (i.e. you are not allowed to operate directly on source data)
- Enforce user-defined immutable in-memory data structures
- Model classes are generated at runtime by Machete
- APIs should be singularly focused on doing one thing well (e.g. you cannot manipulate data from the parsing API)


##### Do no harm
- Throw exceptions only in exceptional cases (e.g. when message headers are missing, etc.)
- Always return an object to the caller even in situations when the input is invalid


##### Fast but predictable
- Parsing must be fast but consistently evaluate to the same output given the same input
- Small memory footprint


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

# Parsing Text

Parsing is the most fundamental operation that can be performed within Machete. Machete defines four Higher-order Parsers (HOP) that are publicly accessible through the parsing API. In particular, Machete implements the following HOPs:

| HOP       | Description                                                                                                                                                                                                                          |
|:----------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Layout    | Parses and returns predefined data structures given a pattern T of *Layout\<T\>*                                                                                                                                                     |
| LINQ      | Given an ad hoc query pattern expressed with LINQ to HL7/X12, parses and returns either anonymous or predefined data structures                                                                                                      |
| Entity    | Given an exact location within source data scoped by a transaction, parses and returns predefined data structures T of type *Entity\<T\>* or *EntityList\<T\>*                                                                       |
| Streaming | Parses either a random block of data or a block of data defined by a transaction within a set from a large data file into predefined data structures T of type *Entity\<T\>*, *EntityList\<T\>*, *Layout\<T\>*, or *LayoutList\<T\>* |

Similar to the functional programming concept Higher-order Functions (HOF), we refer to the aforementioned parsers as being higher-order because each is composed of lower level parsers that exhibit characteristics specific to their function. For example, assume we wanted to express collecting the insurance information—that is, either an IN1 or IN2 segment—from an ORM R01 (i.e. Order) message, we might
write a query that looks like this...

```c#
var query = parse.Query(q =>
    from msh in q.Select<MSH>()
    from pid in q.Select<PID>()
    from insurance in q.Select<IN1>().Or<HL7Entity, HL7Segment, IN1, IN2>(q.Select<IN2>())
    select insurance);
```

The HOP defined above is composed of at least five parsers that are visible (e.g. *Select* and *Or*). What you don't see is the text parsers underneath doing things like parsing line terminators, delimiters, etc. Each parser understands how to do its job without understanding anything about the other. The HOP—LINQ to HL7 parser in our example—is responsible for binding lower level parsers together with the intent of returning a single result so that the data can be subsequently be accessed. 


<br/>

**Step 1:** Initialize a Higher-order Parser

*If parsing a single message, then call the parser like so...*
```c#
var parse = parser.Parse(message);
```

Note that the above code snippet works for initializing *Entity*, *Layout*, and *LINQ* parsers.

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

<br/>

*If querying using layout patterns, then you can do something like this...*

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

###### LINQ to HL7
```c#
var query = parse.Query(q =>
            from msh in q.Select<MSH>()
            from skip in q.Except<HL7Segment, ORC>().ZeroOrMore()
            from orc in q.Select<ORC>().ZeroOrMore()
            select orc);
```

###### LINQ to X12
```c#
var query = schema.CreateQuery(q =>
                from isa in q.Select<ISA>()
                from skip in q.Except<X12Segment, NM1>().ZeroOrMore()
                from nm1 in q.Select<NM1>()
                select nm1);
```

<br/>

#### Advanced LINQ

Below is a more advanced example of the LINQ parser in action. Notice that there are several sub-queries within the query that is eventually returned.
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

<br/>

Unlike other parsing libraries that provide LINQ support through returning POCOs and encouraging the use of .NET's LINQ facility to query over said objects, Machete extends LINQ to provide a mechanism to compose parsers for specific use cases.

| Parser         | Description                                                                                                                                                                                                                    | Example                                 |
|:---------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------|
| **Select**     | Iterate over several items in a set, projecting them onto a defined variable.                                                                                                                                                  | [example](#using-the-select-parser)     |
| **SelectMany** | Iterate over an array of parsed entities, within a field of *ValueList\<T\>*, then iterate over a structure that has one or more entities (e.g. segment), *Entity\<T\>*, returning a one-dimensional array of projected items. | [example](#using-the-selectmany-parser) |
| **Except**     | Iterate over an array of entities excluding them all until reaching the specified entity, subsequently returning a one-dimensional array of excluded entities.                                                                 | [example](#using-the-except-parser)     |
| **Where**      | Returns a parser if the filter condition evaluates to true.                                                                                                                                                                    | [example](#using-the-where-parser)      |

<br/>

Machete provides the below extensions for the above parsers.

| Extension           | Description                                                                                                                                                                              | Example                           |
|:--------------------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------|
| **Skip**            | Skip over one or more entities, moving the cursor to the matched location and returning a list of skipped entities up to the match point.                                                | [example](#using-skip)            |
| **SkipUntil**       | Skip until the specified entity is matched, moving the cursor to the matched location and returning a list of skipped entities including the entity that serves as the match condition.  | [example](#using-skipuntil)       |
| **Take**            | Return a list of *n* entities after the entity has been selected.                                                                                                                        | [example](#using-take)            |
| **TakeWhile**       | Take the specified entities from the message starting from the current position of the cursor so long as the condition is true.                                                          | [example](#using-takewhile)       |
| **OneOrMore**       | Return a list of 1 or *n* parsed entities.                                                                                                                                               | [example](#using-oneormore)       |
| **ZeroOrMore**      | Return a list of 0 or *n* parsed entities.                                                                                                                                               | [example](#using-zeroormore)      |
| **Optional**        | Returns zero or exactly one parsed entity.                                                                                                                                               | [example](#using-optional)        |
| **Or**              | Return an alternative element if the Select parser does not return with a valid item.                                                                                                    | [example](#using-or)              |
| **Then**            | Return a different item after the entity has been selected.                                                                                                                              | [example]()                       |
| **SingleOrDefault** | Returns the single parsed entity from the list, if there is only a single entity, otherwise, it returns the default value.                                                               | [example](#using-singleordefault) |
| **FirstOrDefault**  | Returns the first parsed entity in the list, or the default value if the list is empty. The entire list is parsed, but only the first item is returned. The remaining items are ignored. | [example](#using-firstordefault)  |
| **One**             | Returns a parsed entity as a singular list instead of a single entity.                                                                                                                   | [example](#using-one)             |
| **Peek**            |                                                                                                                                                                                          | [example](#using-one)             |



**Step 3:** Accessing data

```c#
string placerGroupNumber = result.Result.Tests[0].ORC.PlacerGroupNumber.Select(x => x.EntityIdentifier).ValueOrDefault();
```

Note: Use the *Select* and *ValueOrDefault* methods to prevent exceptions from bubbling up to the caller when attempting to access fields.


#### Parser Examples

###### Using the WHERE parser

```c#
var result = entityResult.Query(q =>
                from msh in q.Select<MSH>()
                from obr in q.Select<OBR>()
                    .Select(x => x.PlacerOrderNumber)
                    .Select(x => x.UniversalId)
                    .Where(x => x.IsEqualTo("PRO2350"))
                    .ZeroOrMore()
                select new
                {
                    MSH = msh,
                    Tests = obr
                });
```

###### Using the Select parser

```c#
var result = parsed.Query(q =>
                from msh in q.Select<MSH>()
                select msh);
```

###### Using the Except parser

```c#
var result = parsed.Query(q =>
                from ignored in q.Except<X12Segment, PER>().ZeroOrMore()
                from nm1 in q.Select<NM1>()
                select nm1;
```

###### Using the SelectMany parser

```c#

```

###### Using Skip

```c#
var result = parse.Query(q => from msh in q.Select<MSH>()
                    from ignored in q.Select<HL7Segment>().Skip(q.Select<NTE>())
                    from notes in q.Select<NTE>()
                    select notes);
```

###### Using SkipUntil

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from orc in q.Select<HL7Segment>().SkipUntil(q.Select<ORC>()).ZeroOrMore()
                select orc);
```

###### Using Take

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from insurance in q.Select<IN1>().Take(2)
                select insurance);
```

###### Using TakeWhile

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from insurance in q.Select<IN1>().TakeWhile(x => x.GroupNumber.HasValue)
                select insurance);
```

###### Using OneOrMore

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from notes in q.Select<NTE>().OneOrMore()
                select notes);

```

###### Using ZeroOrMore

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from notes in q.Select<NTE>().ZeroOrMore()
                select notes);
```

###### Using One

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from notes in q.Select<NTE>().One()
                select notes);
```

###### Using Or

```c#
var query = entityResult.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from insurance in q.Select<IN1>().Or<HL7Entity, HL7Segment, IN1, IN2>(q.Select<IN2>())
                select insurance);
```

###### Using FirstOrDefault

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from insurance in q.Select<IN1>().ZeroOrMore().FirstOrDefault()
                select insurance);
```

###### Using SingleOrDefault

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from pid in q.Select<PID>()
                from insurance in q.Select<IN1>().ZeroOrMore().SingleOrDefault()
                select insurance);
```

###### Using Optional

```c#
var result = parse.Query(q =>
                from msh in q.Select<MSH>()
                from evn in q.Select<EVN>().Optional()
                select new { MSH = msh, EVN = evn });
```


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

## Enforcing Data Fidelity

Enforcing data fidelity is paramount in Machete. It's not good enough to be fast if the parser reinforces state mutation by design. Parsing and manipulating source data through the same API construct within the same context can lead to state mutation. State mutation happens when a mutable object is changed unpredictably during execution causing side effects in the caller, which can result in the caller executing randomly. This is the worst possible outcome in the context of debugging large scale, data-driven healthcare systems. When we say we enforce this by design we mean the following:

*1. Parsing is immutable and so are the returned objects.* Machete enforces this characteristic through the introduction of the below monadic algebraic data types.

| Type                | Description                                                                                                                                     | Example                       |
|:--------------------|:------------------------------------------------------------------------------------------------------------------------------------------------|:------------------------------|
| **Value\<T\>**      | This data type represents a single value, which can be of any allowed value type (e.g. string, int, long, bool, DateTime, DateTimeOffset, etc.) | [example](#using-valuet)      |
| **ValueList\<T\>**  | This data type represents a read-only list of Value\<T\>                                                                                        | [example](#using-valuelistt)  |
| **Layout\<T\>**     | This data type encapsulates a single layout, which is composed of Entity\<T\> and EntityList\<T\>                                               | [example](#using-layoutt)     |
| **LayoutList\<T\>** | This data type represents a read-only list of Layout\<T\>                                                                                       | [example](#using-layoutlistt) |
| **Entity\<T\>**     | This data type encapsulates a single entity (i.e. complex type), which is composed of Value\<T\> and ValueList\<T\>                             | [example](#using-entityt)     |
| **EntityList\<T\>** | This data type represents a read-only list of Entity\<T\>                                                                                       | [example](#using-entitylistt) |


Each of the above data types are self composable. For example, a Layout\<T\> data type can be composed of other Layout\<T\> data types. That said, depth and breath of defining composable models are limited only by the associated rules as implemented by the parser. The six aforementioned data types fall into the following categories:
- **Complex**—data types (i.e. Layout\<T\> and Entity\<T\>) that are used to model a message within a transaction set or a group of entities within a single message. These data types are composed of other container data types (e.g. Layout\<T\> and Entity\<T\>).
- **Primitive**—data types (i.e. Value\<T\>) that are used to define entity containers—that is, containers that implement Entity\<T\>. These data types are composed of language primitives (e.g. int, bool, etc.), value types (e.g. DateTimeOffset, etc.), and complex data types (e.g. Entity\<T\>).

Complex data types are configured by data configurators describing the structure of the contained data types. In contrast, primitive data types are not required to be configured.

The model remains immutable because the schema is implemented at runtime by Machete based on the defined entities (i.e. Entity\<T\> and Layout\<T\>) so there is no opportunity to inject code that can eventually be used to mutate the state of the parse in the caller.

<br/>

*2. Changes to the parse can only be made through the Translation API, which works off of a copy of the parsed data.* This is extremely important because Machete does not allow source data to manipulated by design. While other parsing libraries make it simple to manipulate data through the parsing API, Machete's approach effectively makes debugging caller code easier since the only place where data is manipulated is explicitly in the translates you build.

<br/>

*3. Since Machete parses text data through the lens of an object, it is plausible that the text data will not always match the defined schema model, which means that there must be a mechanism to get at the raw source data.* An example of this would be if a model was defined to have a field of, say, type integer, and the text consists of alphanumeric data. When attempts are made to access the data an exception will be thrown and bubbled up to the caller because it cannot strongly type the returned text into an integer. In such a case, you would probably want access to the raw text data. In such a scenario, Machete provides two mechanisms to facilitate the creation of stable parsing algorithms in the caller:

- **Select**-an applicative functor (aka *applicative*) that guarentees that accessing the field in situations where it is missing will not throw an exception.
- **ValueOrDefault**-a method that safely executes the chain by attempting to call the Value property, swallowing any and all exceptions thrown and returning a type default or user-defined default to the caller.

```c#
string messageCode = result
    .Select(x => x.MessageType)
    .Select(x => x.MessageCode)
    .ValueOrDefault();
```
<br/>


#### Monadic Algebraic Data Type Examples


###### Using Value\<T\>

```c#
public interface ID :
    HL7Component
{
    Value<string> Identifier { get; }
}
```

###### Using ValueList\<T\>

```c#
public interface ID :
    HL7Component
{
    ValueList<string> Names { get; }
}
```

###### Using Layout\<T\>

```c#
public interface OrderTest :
    HL7Layout
{
    Segment<ORC> ORC { get; }
    Segment<OBR> OBR { get; }
}
```

###### Using LayoutList\<T\>

```c#
public interface Order :
    HL7Layout
{
    Segment<PID> PID { get; }
    LayoutList<OrderTest> Tests { get; }
}
```

###### Using Entity\<T\>

```c#
public interface IN1 :
    HL7Segment
{
    Value<int> SetId { get; }
    Value<CWE> InsurancePlanId { get; }
}
```

###### Using EntityList\<T\>

```c#
public interface Order :
    HL7Layout
{
    SegmentList<IN1> Insurance { get; }
}
```


## License
Licensed under the terms of [Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0)