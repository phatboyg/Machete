namespace Machete.Tests
{
    using NUnit.Framework;
    using Tools;


    [TestFixture]
    public class Using_the_sequence_number_generator
    {
        [Test]
        public void Should_start_at_the_seed_and_increment()
        {
            SequenceNumber number = new SequenceNumber();

            Assert.That(number.Current, Is.EqualTo(0));

            Assert.That(number.Next(), Is.EqualTo(1));

            Assert.That(number.Current, Is.EqualTo(1));
        }

        [Test]
        public void Should_support_nested_increments()
        {
            SequenceNumber number = new SequenceNumber();

            Assert.That(number.Next(), Is.EqualTo(1));

            Assert.That(number.Of<A>().Next(), Is.EqualTo(1));

            Assert.That(number.Of<A>().Of<B>().Next(), Is.EqualTo(1));

            Assert.That(number.Of<A>().Next(), Is.EqualTo(2));

            Assert.That(number.Of<A>().Of<B>().Next(), Is.EqualTo(1));

            Assert.That(number.Next(), Is.EqualTo(2));

            Assert.That(number.Of<A>().Next(), Is.EqualTo(1));
        }


        class A
        {
        }


        class B
        {
        }
    }
}