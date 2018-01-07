namespace Machete.Tests
{
    using System.Collections.Generic;
    using Machete.Parsers;
    using NUnit.Framework;


    [TestFixture]
    public class Specifying_a_take_query_argument
    {
        [Test]
        public void Should_only_take_that_many_elements()
        {
            var subject = new[] {1, 2, 3, 4, 5};

            var anyParser = new AnyParser<int>();

            IParser<int, IReadOnlyList<int>> query = (from x in anyParser
                select x).Take(2);

            Result<Cursor<int>, IReadOnlyList<int>> result = query.Execute(subject);

            Assert.IsTrue(result.HasResult);
            Assert.AreEqual(2, result.Result.Count);
        }

        [Test]
        public void Should_only_take_that_many_elements_and_include_the_payload()
        {
            var subject = new[] {1, 2, 3, 4, 5};

            var anyParser = new AnyParser<int>();

            IParser<int, IReadOnlyList<int>> query = (from x in anyParser
                select x).Take(2);

            Result<Cursor<int>, IReadOnlyList<int>> result = query.Execute(subject, new MyPayload{Value = "Hello"});

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