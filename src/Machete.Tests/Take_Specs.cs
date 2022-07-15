namespace Machete.Tests
{
    using System.Buffers;
    using NUnit.Framework;
    using Parsers;


    [TestFixture]
    public class Specifying_a_take_query_argument
    {
        [Test]
        public void Should_only_take_that_many_elements()
        {
            var subject = new[] { 1, 2, 3, 4, 5 };

            var anyParser = new AnyParser<int>();

            var query = (from x in anyParser select x).Take(2);

            var result = query.Execute(subject);

            Assert.IsTrue(result.HasResult);
            Assert.AreEqual(2, result.Result.Count);

            Assert.That(result.Result[0], Is.EqualTo(1));
            Assert.That(result.Result[1], Is.EqualTo(2));
        }

        [Test]
        public void Should_only_take_that_many_elements_from_memory()
        {
            var subject = new[] { 1, 2, 3, 4, 5 };

            var anyParser = new AnyParserV2<int>();

            var query = (from x in anyParser
                select x).Take(2);

            var result = query.Execute(subject);

            Assert.IsTrue(result.HasResult);
            Assert.AreEqual(2, result.Result.Length);
        }

        [Test]
        public void Should_only_take_that_many_elements_and_include_the_payload()
        {
            var subject = new[] { 1, 2, 3, 4, 5 };

            var anyParser = new AnyParser<int>();

            var query = (from x in anyParser
                select x).Take(2);

            var result = query.Execute(subject, new MyPayload { Value = "Hello" });

            Assert.IsTrue(result.HasResult);
            Assert.AreEqual(2, result.Result.Count);

            Assert.That(result.Next.HasContext(typeof(MyPayload)), Is.True);

            Assert.That(result.Next.TryGetContext(out MyPayload payload), Is.True);

            Assert.That(payload.Value, Is.EqualTo("Hello"));
        }


        class MyPayload
        {
            public string Value { get; set; }
        }
    }
}