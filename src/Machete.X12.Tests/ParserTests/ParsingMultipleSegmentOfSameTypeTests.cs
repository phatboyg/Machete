namespace Machete.X12.Tests.ParserTests
{
    using NUnit.Framework;
    using Testing;
    using TestSchema;


    [TestFixture]
    public class ParsingMultipleSegmentOfSameType :
        X12MacheteTestHarness<TestX12Entity, X12Entity>
    {
        [Test]
        public void Test1()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*835*212900796
PER*CX*PROVIDER SERVICES*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES*TE*321321321*UR*www.default.org
PER*IC*PROVIDER SERVICES*TE*321321321*UR*www.default.org
SE*1301*212900796
GE*1*176073292
IEA*1*176073292";
 
            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<LayoutCondition1Issue, X12Entity> layout));

            IParser<X12Entity, LayoutCondition1Issue> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, LayoutCondition1Issue> result = entityResult.Query(query);

            Assert.IsTrue(result.HasResult);

            var businessContactInformation = result
                .Select(x => x.BusinessContactInformation)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(businessContactInformation.HasValue);
            Assert.IsTrue(businessContactInformation.IsPresent);
            Assert.AreEqual("CX", businessContactInformation.ValueOrDefault());

            var technicalContact = result
                .Select(x => x.TechnicalContactInformation)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(technicalContact.HasValue);
            Assert.IsTrue(technicalContact.IsPresent);
            Assert.AreEqual("BL", technicalContact.ValueOrDefault());

            var payerWebsite = result
                .Select(x => x.PayerWebsite)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(payerWebsite.HasValue);
            Assert.IsTrue(payerWebsite.IsPresent);
            Assert.AreEqual("IC", payerWebsite.ValueOrDefault());
        }

        [Test]
        public void Test2()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*835*212900796
PER*CX*PROVIDER SERVICES*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 1*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 2*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 3*TE*321321321*UR*www.default.org
SE*1301*212900796
GE*1*176073292
IEA*1*176073292";
 
            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<LayoutCondition2Issue, X12Entity> layout));

            IParser<X12Entity, LayoutCondition2Issue> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, LayoutCondition2Issue> result = entityResult.Query(query);

            Assert.IsTrue(result.HasResult);

            var businessContactInformation = result
                .Select(x => x.BusinessContactInformation)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(businessContactInformation.HasValue);
            Assert.IsTrue(businessContactInformation.IsPresent);
            Assert.AreEqual("CX", businessContactInformation.ValueOrDefault());

            Assert.IsTrue(result.Select(x => x.TechnicalContactInformation).HasValue);
            
            foreach (var contact in result.Select(x => x.TechnicalContactInformation).ToEnumerable())
            {
                Assert.IsTrue(contact.Select(x => x.ContactFunctionCode).HasValue);
                Assert.IsTrue(contact.Select(x => x.ContactFunctionCode).IsPresent);
                Assert.AreEqual("BL", contact.Select(x => x.ContactFunctionCode).ValueOrDefault());
            }
        }

        [Test]
        public void Test3()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*835*212900796
PER*CX*PROVIDER SERVICES*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 1*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 2*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 3*TE*321321321*UR*www.default.org
PER*IC*PROVIDER SERVICES*TE*321321321*UR*www.default.org
SE*1301*212900796
GE*1*176073292
IEA*1*176073292";
 
            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<LayoutCondition3Issue, X12Entity> layout));

            IParser<X12Entity, LayoutCondition3Issue> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, LayoutCondition3Issue> result = entityResult.Query(query);

            Assert.IsTrue(result.HasResult);

            var businessContactInformation = result
                .Select(x => x.BusinessContactInformation)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(businessContactInformation.HasValue);
            Assert.IsTrue(businessContactInformation.IsPresent);
            Assert.AreEqual("CX", businessContactInformation.ValueOrDefault());

            Assert.IsTrue(result.Select(x => x.TechnicalContactInformation).HasValue);
            
            foreach (var contact in result.Select(x => x.TechnicalContactInformation).ToEnumerable())
            {
                Assert.IsTrue(contact.Select(x => x.ContactFunctionCode).HasValue);
                Assert.IsTrue(contact.Select(x => x.ContactFunctionCode).IsPresent);
                Assert.AreEqual("BL", contact.Select(x => x.ContactFunctionCode).ValueOrDefault());
            }

            var payerWebsite = result
                .Select(x => x.PayerWebsite)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(payerWebsite.HasValue);
            Assert.IsTrue(payerWebsite.IsPresent);
            Assert.AreEqual("IC", payerWebsite.ValueOrDefault());
        }

        [Test]
        public void Test4()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*835*212900796
PER*CX*PROVIDER SERVICES*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 1*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 2*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 3*TE*321321321*UR*www.default.org
SE*1301*212900796
GE*1*176073292
IEA*1*176073292";
 
            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<LayoutCondition3Issue, X12Entity> layout));

            IParser<X12Entity, LayoutCondition3Issue> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, LayoutCondition3Issue> result = entityResult.Query(query);

            Assert.IsTrue(result.HasResult);

            var businessContactInformation = result
                .Select(x => x.BusinessContactInformation)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(businessContactInformation.HasValue);
            Assert.IsTrue(businessContactInformation.IsPresent);
            Assert.AreEqual("CX", businessContactInformation.ValueOrDefault());

            Assert.IsTrue(result.Select(x => x.TechnicalContactInformation).HasValue);
            
            foreach (var contact in result.Select(x => x.TechnicalContactInformation).ToEnumerable())
            {
                Assert.IsTrue(contact.Select(x => x.ContactFunctionCode).HasValue);
                Assert.IsTrue(contact.Select(x => x.ContactFunctionCode).IsPresent);
                Assert.AreEqual("BL", contact.Select(x => x.ContactFunctionCode).ValueOrDefault());
            }

            var payerWebsite = result
                .Select(x => x.PayerWebsite)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsFalse(payerWebsite.HasValue);
            Assert.IsFalse(payerWebsite.IsPresent);
        }

        [Test]
        public void Test5()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*835*212900796
PER*BL*PROVIDER SERVICES 1*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 2*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES 3*TE*321321321*UR*www.default.org
PER*IC*PROVIDER SERVICES*TE*321321321*UR*www.default.org
SE*1301*212900796
GE*1*176073292
IEA*1*176073292";
 
            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<LayoutCondition3Issue, X12Entity> layout));

            IParser<X12Entity, LayoutCondition3Issue> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, LayoutCondition3Issue> result = entityResult.Query(query);

            Assert.IsTrue(result.HasResult);

            var businessContactInformation = result
                .Select(x => x.BusinessContactInformation)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsFalse(businessContactInformation.HasValue);
            Assert.IsFalse(businessContactInformation.IsPresent);

            Assert.IsTrue(result.Select(x => x.TechnicalContactInformation).HasValue);
            
            foreach (var contact in result.Select(x => x.TechnicalContactInformation).ToEnumerable())
            {
                Assert.IsTrue(contact.Select(x => x.ContactFunctionCode).HasValue);
                Assert.IsTrue(contact.Select(x => x.ContactFunctionCode).IsPresent);
                Assert.AreEqual("BL", contact.Select(x => x.ContactFunctionCode).ValueOrDefault());
            }

            var payerWebsite = result
                .Select(x => x.PayerWebsite)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(payerWebsite.HasValue);
            Assert.IsTrue(payerWebsite.IsPresent);
            Assert.AreEqual("IC", payerWebsite.ValueOrDefault());
        }

        [Test]
        public void Test6()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*835*212900796
PER*CX*PROVIDER SERVICES*TE*321321321*UR*www.default.org
PER*BL*PROVIDER SERVICES*TE*321321321*UR*www.default.org
PER*IC*PROVIDER SERVICES*TE*321321321*UR*www.default.org
SE*1301*212900796
GE*1*176073292
IEA*1*176073292";
 
            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<LayoutCondition1Issue, X12Entity> layout));

            IParser<X12Entity, LayoutCondition1Issue> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, LayoutCondition1Issue> result = entityResult.Query(query);

            Assert.IsTrue(result.HasResult);

            var businessContactInformation = result
                .Select(x => x.BusinessContactInformation)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(businessContactInformation.HasValue);
            Assert.IsTrue(businessContactInformation.IsPresent);
            Assert.AreEqual("CX", businessContactInformation.ValueOrDefault());

            var technicalContact = result
                .Select(x => x.TechnicalContactInformation)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(technicalContact.HasValue);
            Assert.IsTrue(technicalContact.IsPresent);
            Assert.AreEqual("BL", technicalContact.ValueOrDefault());

            var payerWebsite = result
                .Select(x => x.PayerWebsite)
                .Select(x => x.ContactFunctionCode);
            
            Assert.IsTrue(payerWebsite.HasValue);
            Assert.IsTrue(payerWebsite.IsPresent);
            Assert.AreEqual("IC", payerWebsite.ValueOrDefault());
        }
    }
}