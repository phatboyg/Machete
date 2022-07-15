namespace MacheteToo.Tests;

using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Text;
using NUnit.Framework;
using Parsers;


public class Taking_a_subset_of_elements
{
    [Test]
    public void Should_take_that_many_elements()
    {
        var subject = new[] { 1, 2, 3, 4, 5 };

        var anyParser = new AnyParser<int>();

        var query = (from x in anyParser
            select x).Take(2);

        var result = query.Execute(subject);

        Assert.IsNotNull(result.Value);
        Assert.AreEqual(2, result.Value.Length);

        Assert.AreEqual(new[] { 1, 2 }, result.Value.ToArray());
    }

    [Test]
    public void Should_support_a_run_of_characters()
    {
        var subject = "aaaabbbbccccdddd";

        var anyParser = new AnyMemoryParser<char>();

        var rangeParser = anyParser.Char('a', 'b', 'c').ZeroOrMore();

        var result = rangeParser.Parse(new ReadOnlyMemory<char>(subject.ToCharArray()));

        Assert.IsTrue(result.Value.HasValue);
        Assert.That(result.Value!.Value.Length, Is.EqualTo(12));
    }

    const string _message = @"MSH|^~\&|MACHETELAB|^DOSC|MACHETE|18779|20130405125146269||ORM^O01|1999077678|P|2.3|||AL|AL
PID|1|000000000026|60043^^^MACHETE^MRN||MACHETE^JOE||19890909|F|||123 SEASAME STREET^^Oakland^CA^94600||5101234567|5101234567||||||||||||||||N
PD1|M|F|N||||F|
NTE|1||IN42
PV1|1|O|||||92383^Machete^Janice||||||||||||12345|||||||||||||||||||||||||201304051104
PV2||||||||20150615|20150616|1||||||||||||||||||||||||||N
IN1|1|||MACHETE INC|1234 Fruitvale ave^^Oakland^CA^94601^USA||5101234567^^^^^510^1234567|074394|||||||A1|MACHETE^JOE||19890909|123 SEASAME STREET^^Oakland^CA^94600||||||||||||N|||||666889999|0||||||F||||T||60043^^^MACHETE^MRN
GT1|1|60043^^^MACHETE^MRN|MACHETE^JOE||123 SEASAME STREET^^Oakland^CA^94600|5416666666|5418888888|19890909|F|P
AL1|1|FA|^pollen allergy|SV|jalubu daggu||
ORC|NW|PRO2350||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11636^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
DG1|1|I9|788.64^URINARY HESITANCY^I9|URINARY HESITANCY
OBX|1||URST^Urine Specimen Type^^^||URN
NTE|1||abc
NTE|2||dsa
ORC|NW|PRO2351||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11637^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R
ORC|NW|PRO2352||XO934N|||^^^^^R||20130405125144|91238^Machete^Joe||92383^Machete^Janice
OBR|1|PRO2350||11638^Urinalysis, with Culture if Indicated^L|||20130405135133||||N|||||92383^Machete^Janice|||||||||||^^^^^R";

    [Test]
    public void Should_split_the_lines()
    {
        var strings = _message.Split(Environment.NewLine);

        Assert.That(strings.Length, Is.EqualTo(19));
    }

    [Test]
    public void Should_split_the_lines_and_elements()
    {
        var strings = _message.Split(Environment.NewLine);

        Assert.That(strings.Length, Is.EqualTo(19));

        var elements = strings[0].Split('|');

        Assert.That(elements.Length, Is.EqualTo(16));
    }

    [Test]
    public void Should_split_the_lines_using_parser()
    {
        var bytes = Encoding.UTF8.GetBytes(_message);

        var parser = new LineTextParser();

        var sequence = new ReadOnlySequence<byte>(bytes);
        var reader = PipeReader.Create(sequence);
        var result = parser.Parse(reader);

        Assert.That(result.IsValid);

        int count = 0;
        while (result.IsValid)
        {
            count++;

            result = parser.Parse(reader);
        }

        Assert.That(count, Is.EqualTo(19));
    }

    [Test]
    public void Should_split_the_lines_using_parser_and_then_elements()
    {
        var bytes = Encoding.UTF8.GetBytes(_message);

        var parser = new LineTextParser();
        var elementParser = new ReadToStringParser("|");

        var sequence = new ReadOnlySequence<byte>(bytes);
        var reader = PipeReader.Create(sequence);
        var result = parser.Parse(reader);

        Assert.That(result.IsValid);

        var elementResult = elementParser.Parse(result.Buffer);

        int count = 0;
        while (elementResult.IsValid)
        {
            count++;

            elementResult = elementParser.Parse(elementResult.Next);
        }

        Assert.That(count, Is.EqualTo(16));
    }
}