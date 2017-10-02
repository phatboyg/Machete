namespace Machete.Tests
{
    using NUnit.Framework;


    public class Creating_a_text_parser
    {
        [Test]
        public void Should_be_similar_and_easy()
        {
            var parser = Parser.Factory.CreateText(x => x.Char(char.IsLetter).OneOrMore());

            var parsed = parser.Parse("ABCD");

            Assert.IsTrue(parsed.HasResult);

            Assert.That(parsed.Result.Length, Is.EqualTo(4));
        }
    }
}