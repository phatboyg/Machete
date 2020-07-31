namespace Machete.X12.Tests.Layouts
{
    using System;
    using Testing;
    using X12Schema.V5010;
    using NUnit.Framework;


    [TestFixture]
    public class Parsing810TransactionTests :
        X12MacheteTestHarness<X12v5010, X12Entity>
    {
        [Test]
        public void Test()
        {
            string message =
                @"ISA*01*0000000000*01*0000000000*ZZ*ABCDEFGHIJKLMNO*ZZ*123456789012345*101127*1719*U*00400*000003438*0*P*>
GS*IN*4405197800*999999999*20101205*1710*1320*X*004010VICS
ST*810*1004
BIG*20101204*217224*20101204*P792940
REF*DP*099
REF*IA*99999
N1*ST**92*123
ITD*01*3***0**60
IT1*1*4*EA*8.60**UP*999999330023
IT1*2*2*EA*15.00**UP*999999330115
IT1*3*2*EA*7.30**UP*999999330146
IT1*4*4*EA*17.20**UP*999999330184
IT1*5*8*EA*4.30**UP*999999330320
IT1*6*4*EA*4.30**UP*999999330337
IT1*7*6*EA*1.50**UP*999999330634
IT1*8*6*EA*1.50**UP*999999330641
TDS*21740
CAD*****GTCT**BM*99999
CTT*8
SE*18*1004
GE*1*1320
IEA*1*000001320";
 
            var parseResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<F810, X12Entity> layout));

            var query = parseResult.CreateQuery(layout);

            var queryResult = parseResult.Query(query);

            Assert.IsTrue(queryResult.HasResult);

            var idCode = queryResult
                .Select(x => x.Transaction)[0]
                .Select(x => x.LoopN1)[0]
                .Select(x => x.PartyIdentification)
                .Select(x => x.IdCode)
                .ValueOrDefault();
            
            Console.WriteLine(idCode);
        }
    }
}