namespace Machete.Tests
{
    using NUnit.Framework;
    using Slices;
    using Texts;


    [TestFixture]
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

        [Test]
        public void Should_be_able_to_combine_text()
        {
            ParseText input = new StringText("abcdefg");

            var first = input.GetSubText(new TextSpan(0, 3));
            var second = input.GetSubText(new TextSpan(4, 3));

            var composite = new CompositeText(new[] {first, second});

            var text = composite.ToString();

            Assert.That(text, Is.EqualTo("abcefg"));
        }

        [Test]
        public void Should_be_able_to_combine_slices()
        {
            ParseText input = new StringText("abcdefg");

            var first = input.GetSubText(new TextSpan(0, 3));
            var second = input.GetSubText(new TextSpan(4, 3));

            TextSlice firstSlice = new ParseTextSlice(first, new TextSpan(0, first.Length));
            TextSlice secondSlice = new ParseTextSlice(second, new TextSpan(0, second.Length));

            var composite = new CompositeTextSlice(firstSlice, secondSlice);

            var text = composite.Text.ToString();

            Assert.That(text, Is.EqualTo("abcefg"));
        }
    }
}