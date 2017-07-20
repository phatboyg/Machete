# Machete
### Cut through the Crap!

Machete is a parser, object mapper, and query engine for processing sophisticated text.

> Machete will also include translation and formatting, but those features have yet to be developed.

Machete is highly optimized and leverages efficient parsing algorithms combined with lazy text evaluation, which reduce memory usage, limit garbage collection, and defer string allocations, resulting in blazing fast performance.

Machete fully supports asynchronous processing of text, including streams, making it a perfect for building high-volume, multi-threaded, and distributed systems.


## HL7

Machete was designed from the ground up to support HL7 messages and can parse and map segments, fields, components, and subcomponents. Machete supports multiple HL7 versions, which can be used simultaneously without conflict.


## X12

Machete was also designed to support X12 messages, support will be coming soon.


## Developing Machete

Machete is written entirely in C# and was developed using JetBrains Rider. It supports the standard .NET framework, as well as .NET Standard, allowing it to be used on any .NET compatible platform.


