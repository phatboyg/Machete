namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Layout277Tests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test]
        public void Verify_can_parse_multiple_REF_segments_condition()
        {
            string message = @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~
ST*277*0001*005010X214~
BHT*0085*08*277X2140001*20060205*1635*TH~
HL*1**20*1~
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00~
TRN*1*200102051635S00001ABCDEF~
DTP*050*D8*20060205~
DTP*009*D8*20060205~
HL*2*1*21*1~
NM1*41*2*BEST BILLING SERVICE*****46*S00001~
TRN*2*2002020542857~
STC*A0:16:PR*20060205*WQ*1000~
QTY*90*1~
QTY*AA*2~
AMT*YU*200~
AMT*YY*800~
HL*3*2*19*1~
NM1*85*2*SMITH CLINIC*****FI*123456789~
HL*4*3*PT~
NM1*QC*1*DOE*JOHN****MI*00ABCD1234~
TRN*2*DOE01428~
STC*A0:16:PR*20060205*WQ*200~
REF*1K*22029500123407X~
REF*D9*22029500123407X~
REF*BLT*22029500123407X~
DTP*472*RD8*20060128-20060131~
SVC*HC:22305:22*350*****1~
STC*A3:122**U*******A3:153:82~
REF*FJ*11~
SE*37*0001~
GE*1*1~
IEA*1*000026531~";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            IParser<X12Entity, HCA277> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HCA277> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.Transactions)[0].Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0].Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            Assert.IsTrue(result.Select(x => x.Transactions).HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].Select(x => x.PatientDetail).HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].Select(x => x.PatientDetail)[0].HasValue);
            
            string institutionalBillTypeIdentification = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.InstitutionalBillTypeIdentification)
                .Select(x => x.ReferenceIdentificationQualifier)
                .ValueOrDefault();

            string payerClaimControlNumber = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.PayerClaimControlNumber)
                .Select(x => x.ReferenceIdentificationQualifier)
                .ValueOrDefault();

            string claimIdNumberForClearinghouseAndOtherTransmissionItermediaries = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.ClaimIdNumberForClearinghouseAndOtherTransmissionIntermediaries)
                .Select(x => x.ReferenceIdentificationQualifier)
                .ValueOrDefault();
            
            Assert.IsNotNull(institutionalBillTypeIdentification);
            Assert.IsNotNull(payerClaimControlNumber);
            Assert.IsNotNull(claimIdNumberForClearinghouseAndOtherTransmissionItermediaries);
            Assert.IsNotEmpty(institutionalBillTypeIdentification);
            Assert.IsNotEmpty(payerClaimControlNumber);
            Assert.IsNotEmpty(claimIdNumberForClearinghouseAndOtherTransmissionItermediaries);
            Assert.AreEqual("BLT", institutionalBillTypeIdentification);
            Assert.AreEqual("1K", payerClaimControlNumber);
            Assert.AreEqual("D9", claimIdNumberForClearinghouseAndOtherTransmissionItermediaries);
        }

        [Test]
        public void Verify_can_parse_TotalRejectedQuantity_when_TotalAcceptedQuantity_missing_condition()
        {
            string message = @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~
ST*277*0001*005010X214~
BHT*0085*08*277X2140001*20060205*1635*TH~
HL*1**20*1~
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00~
TRN*1*200102051635S00001ABCDEF~
DTP*050*D8*20060205~
DTP*009*D8*20060205~
HL*2*1*21*1~
NM1*41*2*BEST BILLING SERVICE*****46*S00001~
TRN*2*2002020542857~
STC*A0:16:PR*20060205*WQ*1000~
QTY*AA*2~
AMT*YU*200~
AMT*YY*800~
HL*3*2*19*1~
NM1*85*2*SMITH CLINIC*****FI*123456789~
HL*4*3*PT~
NM1*QC*1*DOE*JOHN****MI*00ABCD1234~
TRN*2*DOE01428~
STC*A0:16:PR*20060205*WQ*200~
REF*1K*22029500123407X~
REF*D9*22029500123407X~
REF*BLT*22029500123407X~
DTP*472*RD8*20060128-20060131~
SVC*HC:22305:22*350*****1~
STC*A3:122**U*******A3:153:82~
REF*FJ*11~
SE*37*0001~
GE*1*1~
IEA*1*000026531~";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            IParser<X12Entity, HCA277> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HCA277> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.Transactions)[0].Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0].Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            Assert.IsTrue(result.Select(x => x.Transactions).HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].HasValue);

            string totalRejectedQuantity = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier)
                .ValueOrDefault();
            
            Assert.AreEqual("AA", totalRejectedQuantity);

            Value<string> totalAcceptedQuantity = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalAcceptedQuantity.HasValue);
        }

        [Test]
        public void Verify_can_parse_TotalAcceptedQuantity_when_TotalRejectedQuantity_missing_condition()
        {
            string message = @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~
ST*277*0001*005010X214~
BHT*0085*08*277X2140001*20060205*1635*TH~
HL*1**20*1~
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00~
TRN*1*200102051635S00001ABCDEF~
DTP*050*D8*20060205~
DTP*009*D8*20060205~
HL*2*1*21*1~
NM1*41*2*BEST BILLING SERVICE*****46*S00001~
TRN*2*2002020542857~
STC*A0:16:PR*20060205*WQ*1000~
QTY*90*1~
AMT*YU*200~
AMT*YY*800~
HL*3*2*19*1~
NM1*85*2*SMITH CLINIC*****FI*123456789~
HL*4*3*PT~
NM1*QC*1*DOE*JOHN****MI*00ABCD1234~
TRN*2*DOE01428~
STC*A0:16:PR*20060205*WQ*200~
REF*1K*22029500123407X~
REF*D9*22029500123407X~
REF*BLT*22029500123407X~
DTP*472*RD8*20060128-20060131~
SVC*HC:22305:22*350*****1~
STC*A3:122**U*******A3:153:82~
REF*FJ*11~
SE*37*0001~
GE*1*1~
IEA*1*000026531~";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            IParser<X12Entity, HCA277> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HCA277> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.Transactions)[0].Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0].Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            Assert.IsTrue(result.Select(x => x.Transactions).HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].HasValue);

            string totalAcceptedQuantity = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedQuantity)
                .Select(x => x.QuantityQualifier)
                .ValueOrDefault();
            
            Assert.AreEqual("90", totalAcceptedQuantity);

            Value<string> totalRejectedQuantity = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedQuantity)
                .Select(x => x.QuantityQualifier);
            
            Assert.IsFalse(totalRejectedQuantity.HasValue);
        }

        [Test]
        public void Verify_can_parse_TotalAcceptedAmount_and_TotalRejectedAmount_condition()
        {
            string message = @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~
ST*277*0001*005010X214~
BHT*0085*08*277X2140001*20060205*1635*TH~
HL*1**20*1~
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00~
TRN*1*200102051635S00001ABCDEF~
DTP*050*D8*20060205~
DTP*009*D8*20060205~
HL*2*1*21*1~
NM1*41*2*BEST BILLING SERVICE*****46*S00001~
TRN*2*2002020542857~
STC*A0:16:PR*20060205*WQ*1000~
QTY*90*1~
QTY*AA*2~
AMT*YU*200~
AMT*YY*800~
HL*3*2*19*1~
NM1*85*2*SMITH CLINIC*****FI*123456789~
HL*4*3*PT~
NM1*QC*1*DOE*JOHN****MI*00ABCD1234~
TRN*2*DOE01428~
STC*A0:16:PR*20060205*WQ*200~
REF*1K*22029500123407X~
REF*D9*22029500123407X~
REF*BLT*22029500123407X~
DTP*472*RD8*20060128-20060131~
SVC*HC:22305:22*350*****1~
STC*A3:122**U*******A3:153:82~
REF*FJ*11~
SE*37*0001~
GE*1*1~
IEA*1*000026531~";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            IParser<X12Entity, HCA277> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HCA277> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.Transactions)[0].Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0].Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            Assert.IsTrue(result.Select(x => x.Transactions).HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].HasValue);

            Value<string> totalAcceptedAmount = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalAcceptedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalAcceptedAmount.HasValue);
            Assert.IsTrue(totalAcceptedAmount.IsPresent);
            Assert.AreEqual("YU", totalAcceptedAmount.ValueOrDefault());

            Value<string> totalRejectedAmount = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.InformationReceiverDetail)[0]
                .Select(x => x.InformationReceiverApplicationTraceIdentifier)
                .Select(x => x.TotalRejectedAmount)
                .Select(x => x.AmountQualifierCode);
            
            Assert.IsTrue(totalRejectedAmount.HasValue);
            Assert.IsTrue(totalRejectedAmount.IsPresent);
            Assert.AreEqual("YY", totalRejectedAmount.ValueOrDefault());
        }

        [Test]
        public void METHOD()
        {
            string message = @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~
ST*277*0001*005010X214~
BHT*0085*08*277X2140001*20060205*1635*TH~
HL*1**20*1~
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00~
TRN*1*200102051635S00001ABCDEF~
DTP*050*D8*20060205~
DTP*009*D8*20060205~
HL*2*1*21*1~
NM1*41*2*BEST BILLING SERVICE*****46*S00001~
TRN*2*2002020542857~
STC*A0:16:PR*20060205*WQ*1000~
QTY*90*1~
QTY*AA*2~
AMT*YU*200~
AMT*YY*800~
HL*3*2*19*1~
NM1*85*2*SMITH CLINIC*****FI*123456789~
HL*4*3*PT~
NM1*QC*1*DOE*JOHN****MI*00ABCD1234~
TRN*2*DOE01428~
STC*A0:16:PR*20060205*WQ*200~
REF*1K*22029500123407X~
REF*D9*22029500123407X~
REF*BLT*22029500123407X~
DTP*472*RD8*20060128-20060131~
SVC*HC:22305:22*350*****1~
STC*A3:122**U*******A3:153:82~
REF*FJ*11~
REF*XZ*11~
SE*37*0001~
GE*1*1~
IEA*1*000026531~";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            IParser<X12Entity, HCA277> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HCA277> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.Transactions)[0].Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0].Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            Assert.IsTrue(result.Select(x => x.Transactions).HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].HasValue);

            var itemIdentification = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.ServiceLineInformation)[0]
                .Select(x => x.ItemIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(itemIdentification.HasValue);
            Assert.IsTrue(itemIdentification.IsPresent);
            Assert.AreEqual("FJ", itemIdentification.ValueOrDefault());

            var pharmacyPrescriptionNumber = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.ServiceLineInformation)[0]
                .Select(x => x.PharmacyPrescriptionNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(pharmacyPrescriptionNumber.HasValue);
            Assert.IsTrue(pharmacyPrescriptionNumber.IsPresent);
            Assert.AreEqual("XZ", pharmacyPrescriptionNumber.ValueOrDefault());
        }

        [Test]
        public void Verify_can_parse_ServiceLineItemIdentification_and_PharmacyPresciptionNumber()
        {
            string message = @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~
ST*277*0001*005010X214~
BHT*0085*08*277X2140001*20060205*1635*TH~
HL*1**20*1~
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00~
TRN*1*200102051635S00001ABCDEF~
DTP*050*D8*20060205~
DTP*009*D8*20060205~
HL*2*1*21*1~
NM1*41*2*BEST BILLING SERVICE*****46*S00001~
TRN*2*2002020542857~
STC*A0:16:PR*20060205*WQ*1000~
QTY*90*1~
QTY*AA*2~
AMT*YU*200~
AMT*YY*800~
HL*3*2*19*1~
NM1*85*2*SMITH CLINIC*****FI*123456789~
HL*4*3*PT~
NM1*QC*1*DOE*JOHN****MI*00ABCD1234~
TRN*2*DOE01428~
STC*A0:16:PR*20060205*WQ*200~
REF*1K*22029500123407X~
REF*D9*22029500123407X~
REF*BLT*22029500123407X~
DTP*472*RD8*20060128-20060131~
SVC*HC:22305:22*350*****1~
STC*A3:122**U*******A3:153:82~
REF*FJ*11~
REF*XZ*11~
SE*37*0001~
GE*1*1~
IEA*1*000026531~";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            IParser<X12Entity, HCA277> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HCA277> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.Transactions)[0].Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0].Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            Assert.IsTrue(result.Select(x => x.Transactions).HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].HasValue);

            var itemIdentification = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.ServiceLineInformation)[0]
                .Select(x => x.ItemIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(itemIdentification.HasValue);
            Assert.IsTrue(itemIdentification.IsPresent);
            Assert.AreEqual("FJ", itemIdentification.ValueOrDefault());

            var pharmacyPrescriptionNumber = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.ServiceLineInformation)[0]
                .Select(x => x.PharmacyPrescriptionNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(pharmacyPrescriptionNumber.HasValue);
            Assert.IsTrue(pharmacyPrescriptionNumber.IsPresent);
            Assert.AreEqual("XZ", pharmacyPrescriptionNumber.ValueOrDefault());
        }

        [Test]
        public void Verify_can_parse_ServiceLineItemIdentification_with_PharmacyPresciptionNumber_missing()
        {
            string message = @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~
ST*277*0001*005010X214~
BHT*0085*08*277X2140001*20060205*1635*TH~
HL*1**20*1~
NM1*AY*2*FIRST CLEARINGHOUSE*****46*CLHR00~
TRN*1*200102051635S00001ABCDEF~
DTP*050*D8*20060205~
DTP*009*D8*20060205~
HL*2*1*21*1~
NM1*41*2*BEST BILLING SERVICE*****46*S00001~
TRN*2*2002020542857~
STC*A0:16:PR*20060205*WQ*1000~
QTY*90*1~
QTY*AA*2~
AMT*YU*200~
AMT*YY*800~
HL*3*2*19*1~
NM1*85*2*SMITH CLINIC*****FI*123456789~
HL*4*3*PT~
NM1*QC*1*DOE*JOHN****MI*00ABCD1234~
TRN*2*DOE01428~
STC*A0:16:PR*20060205*WQ*200~
REF*1K*22029500123407X~
REF*D9*22029500123407X~
REF*BLT*22029500123407X~
DTP*472*RD8*20060128-20060131~
SVC*HC:22305:22*350*****1~
STC*A3:122**U*******A3:153:82~
REF*FJ*11~
SE*37*0001~
GE*1*1~
IEA*1*000026531~";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCA277, X12Entity> layout));

            IParser<X12Entity, HCA277> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HCA277> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.Transactions)[0].Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0].Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            Assert.IsTrue(result.Select(x => x.Transactions).HasValue);
            Assert.IsTrue(result.Select(x => x.Transactions)[0].HasValue);

            var itemIdentification = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.ServiceLineInformation)[0]
                .Select(x => x.ItemIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsTrue(itemIdentification.HasValue);
            Assert.IsTrue(itemIdentification.IsPresent);
            Assert.AreEqual("FJ", itemIdentification.ValueOrDefault());

            var pharmacyPrescriptionNumber = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.PatientDetail)[0]
                .Select(x => x.ClaimStatusTrackingNumber)[0]
                .Select(x => x.ServiceLineInformation)[0]
                .Select(x => x.PharmacyPrescriptionNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsFalse(pharmacyPrescriptionNumber.HasValue);
            Assert.IsFalse(pharmacyPrescriptionNumber.IsPresent);
        }
    }
}