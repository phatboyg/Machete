namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837PTests :
        X12MacheteTestHarness<X12v5010, X12Entity>
    {
        [Test]
        public void Test()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*DENTAL ASSOCIATES*****XX*4567890123
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
NM1*87*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
NM1*PE*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*2U*587654321
HL*2*1*22*1
NM1*IL*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
NM1*PR*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
CLM*26403774*200***11:B:1*Y**Y*I
DTP*431*D8*20061109
REF*G1*111222333444
HI✽ABK:8901✽BF:87200✽BF:5559
HI✽BP:8901✽BF:87200✽BF:5559
HI✽BG:8901✽BG:87200✽BG:5559✽BG:5979
NM1*DN*2*KILDARE ASSOCIATES*****XX*1581234567
REF*G2*R555588
NM1*82*2*KILDARE ASSOCIATES*****XX*1581234567
REF*G2*R555588
NM1*77*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
REF*G2*R555588
NM1*DQ*2*KILDARE ASSOCIATES*****XX*1581234567
REF*G2*R555588
NM1*PW*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
NM1*45*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
SBR*P********CI
AMT*D*411
AMT*A8*273
AMT*EAF*75
OI***Y*P**Y
NM1*IL*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
REF*SY*R555588
NM1*PR*2*KILDARE ASSOCIATES*****XX*1581234567
N3*2345 OCEAN BLVD
N4*MI
REF*2U*R555588
NM1*DN*1*SMITH*JACK****MI*T55TY666
REF*0B*R555588
NM1*82*1*SMITH*JACK****MI*T55TY666
REF*0B*R555588
NM1*77*2*KEY INSURANCE COMPANY*****PI*999996666
REF*0B*98765
NM1*DQ*2*KEY INSURANCE COMPANY*****PI*999996666
REF*0B*98765
NM1*85*1*KILDARE*BEN****XX*6789012345
REF*G2*R555588
LX*1
SV1*HC:99211:25*12.25*UN*1*11**1:2:3**Y
LIN**N4*01234567891
REF*XZ*123456
NM1*82*1*DOE*JANE*C***XX*1234567804
REF*G2*12345
NM1*QB*2******XX*1234567891
REF*G2*12345
NM1*77*2*ABCCLINIC*****XX*1234567891
REF*G2*12345
NM1*DQ*1*DOE*JOHN*B***XX*1234567891
REF*G2*12345
NM1*DK*1*RICHARDSON*TRENT****XX*1234567891
REF*G2*12345
NM1*DN*1*WELBY*MARCUS*W**JR*XX*1234567891
REF*G2*12345
NM1*PW*2
N3*2345 OCEAN BLVD
N4*MI
NM1*45*2
N3*2345 OCEAN BLVD
N4*MI
SVD*43*55*HC:84550**3
LQ*UT*01.02
SE*29*0002
IEA*1*176073292";

            var entityResult = Parser.Parse(message);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

                var query = entityResult.CreateQuery(layout);

                var queryResult = entityResult.Query(query);

                Assert.IsNotNull(queryResult);
                Assert.IsTrue(queryResult.HasResult);

                var transaction = queryResult.Select(x => x.Transaction)[0];

                Assert.IsNotNull(transaction, "Transaction");
                Assert.IsTrue(transaction.HasValue, "Transaction");

                AssertLoop1000A(transaction);
                AssertLoop1000B(transaction);
                AssertLoop2000A(transaction);
                AssertLoop2010AA(transaction);
                AssertLoop2010AB(transaction);
                AssertLoop2010AC(transaction);
                AssertLoop2000B(transaction);
                AssertLoop2010BA(transaction);
                AssertLoop2010BB(transaction);
                AssertLoop2000C(transaction);
                AssertLoop2010CA(transaction);
                AssertLoop2300(transaction);
                AssertLoop2310A(transaction);
                AssertLoop2310B(transaction);
                AssertLoop2310C(transaction);
                AssertLoop2310D(transaction);
                AssertLoop2310E(transaction);
                AssertLoop2310F(transaction);
                AssertLoop2320(transaction);
                AssertLoop2330A(transaction);
                AssertLoop2330B(transaction);
                AssertLoop2330C(transaction);
                AssertLoop2330D(transaction);
                AssertLoop2330E(transaction);
                AssertLoop2330F(transaction);
                AssertLoop2330G(transaction);
                AssertLoop2400(transaction);
                AssertLoop2410(transaction);
                AssertLoop2420A(transaction);
                AssertLoop2420B(transaction);
                AssertLoop2420C(transaction);
                AssertLoop2420D(transaction);
                AssertLoop2420E(transaction);
                AssertLoop2420F(transaction);
                AssertLoop2420G(transaction);
                AssertLoop2420H(transaction);
                AssertLoop2430(transaction);
                AssertLoop2440(transaction);
            });
        }

        void AssertLoop2440(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2440);
                
            var qualifierCode = loop[0]
                .Select(x => x.FormIdentificationCode)
                .Select(x => x.QualifierCode);
            
            Assert.IsNotNull(loop, "L2440");
            Assert.IsTrue(loop.HasValue, "L2440");
            Assert.IsTrue(qualifierCode.HasValue, "L2440");
            Assert.IsTrue(qualifierCode.IsPresent, "L2440");
            Assert.AreEqual("UT", qualifierCode.ValueOrDefault(), "L2440 - LQ");
        }

        void AssertLoop2430(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2430);
                
            var identificationCode = loop[0]
                .Select(x => x.LineAdjudicationInformation)
                .Select(x => x.IdentificationCode);
            
            Assert.IsNotNull(loop, "L2430");
            Assert.IsTrue(loop.HasValue, "L2430");
            Assert.IsTrue(identificationCode.HasValue, "L2430");
            Assert.IsTrue(identificationCode.IsPresent, "L2430");
            Assert.AreEqual("43", identificationCode.ValueOrDefault(), "L2430 - SVD");
        }

        void AssertLoop2420H(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2420H);
                
            var location = loop
                .Select(x => x.AmbulanceDropOffLocation)
                .Select(x => x.EntityIdentifierCode);
            
            Assert.IsNotNull(loop, "L2420G");
            Assert.IsTrue(loop.HasValue, "L2420G");
            Assert.IsTrue(location.HasValue, "L2420G");
            Assert.IsTrue(location.IsPresent, "L2420G");
            Assert.AreEqual("45", location.ValueOrDefault(), "L2420G - NM1");
        }

        void AssertLoop2420G(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2420G);
                
            var location = loop
                .Select(x => x.AmbulancePickUpLocation)
                .Select(x => x.EntityIdentifierCode);
            
            Assert.IsNotNull(loop, "L2420G");
            Assert.IsTrue(loop.HasValue, "L2420G");
            Assert.IsTrue(location.HasValue, "L2420G");
            Assert.IsTrue(location.IsPresent, "L2420G");
            Assert.AreEqual("PW", location.ValueOrDefault(), "L2420G - NM1");
        }

        void AssertLoop2420F(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2420F);
                
            var provider = loop[0]
                .Select(x => x.ReferringProvider)
                .Select(x => x.EntityIdentifierCode);

            var secondaryIdentification = loop[0]
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsNotNull(loop, "L2420E");
            Assert.IsTrue(loop.HasValue, "L2420E");
            Assert.IsTrue(provider.HasValue, "L2420E");
            Assert.IsTrue(provider.IsPresent, "L2420E");
            Assert.IsTrue(secondaryIdentification.HasValue, "L2420E");
            Assert.IsTrue(secondaryIdentification.IsPresent, "L2420E");
            Assert.AreEqual("DN", provider.ValueOrDefault(), "L2420E - NM1");
            Assert.AreEqual("G2", secondaryIdentification.ValueOrDefault(), "L2420E - REF");
        }

        void AssertLoop2420E(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2420E);
                
            var provider = loop
                .Select(x => x.OrderingProvider)
                .Select(x => x.EntityIdentifierCode);

            var secondaryIdentification = loop
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsNotNull(loop, "L2420D");
            Assert.IsTrue(loop.HasValue, "L2420D");
            Assert.IsTrue(provider.HasValue, "L2420D");
            Assert.IsTrue(provider.IsPresent, "L2420D");
            Assert.IsTrue(secondaryIdentification.HasValue, "L2420D");
            Assert.IsTrue(secondaryIdentification.IsPresent, "L2420C");
            Assert.AreEqual("DK", provider.ValueOrDefault(), "L2420D - NM1");
            Assert.AreEqual("G2", secondaryIdentification.ValueOrDefault(), "L2420D - REF");
        }

        void AssertLoop2420D(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2420D);
                
            var provider = loop
                .Select(x => x.SupervisingProvider)
                .Select(x => x.EntityIdentifierCode);

            var secondaryIdentification = loop
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsNotNull(loop, "L2420D");
            Assert.IsTrue(loop.HasValue, "L2420D");
            Assert.IsTrue(provider.HasValue, "L2420D");
            Assert.IsTrue(provider.IsPresent, "L2420D");
            Assert.IsTrue(secondaryIdentification.HasValue, "L2420D");
            Assert.IsTrue(secondaryIdentification.IsPresent, "L2420C");
            Assert.AreEqual("DQ", provider.ValueOrDefault(), "L2420D - NM1");
            Assert.AreEqual("G2", secondaryIdentification.ValueOrDefault(), "L2420D - REF");
        }

        void AssertLoop2420C(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2420C);
                
            var provider = loop
                .Select(x => x.ServiceFacilityLocation)
                .Select(x => x.EntityIdentifierCode);

            var secondaryIdentification = loop
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsNotNull(loop, "L2420C");
            Assert.IsTrue(loop.HasValue, "L2420C");
            Assert.IsTrue(provider.HasValue, "L2420C");
            Assert.IsTrue(provider.IsPresent, "L2420C");
            Assert.IsTrue(secondaryIdentification.HasValue, "L2420C");
            Assert.IsTrue(secondaryIdentification.IsPresent, "L2420C");
            Assert.AreEqual("77", provider.ValueOrDefault(), "L2420C - NM1");
            Assert.AreEqual("G2", secondaryIdentification.ValueOrDefault(), "L2420C - REF");
        }

        void AssertLoop2420B(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2420B);
                
            var provider = loop
                .Select(x => x.PurchasedServiceProvider)
                .Select(x => x.EntityIdentifierCode);

            var secondaryIdentification = loop
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsNotNull(loop, "L2420B");
            Assert.IsTrue(loop.HasValue, "L2420B");
            Assert.IsTrue(provider.HasValue, "L2420B");
            Assert.IsTrue(provider.IsPresent, "L2420B");
            Assert.IsTrue(secondaryIdentification.HasValue, "L2420B");
            Assert.IsTrue(secondaryIdentification.IsPresent, "L2420B");
            Assert.AreEqual("QB", provider.ValueOrDefault(), "L2420B - NM1");
            Assert.AreEqual("G2", secondaryIdentification.ValueOrDefault(), "L2420B - REF");
        }

        void AssertLoop2420A(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2420A);
                
            var provider = loop
                .Select(x => x.RenderingProvider)
                .Select(x => x.EntityIdentifierCode);

            var secondaryIdentification = loop
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsNotNull(loop, "L2420A");
            Assert.IsTrue(loop.HasValue, "L2420A");
            Assert.IsTrue(provider.HasValue, "L2420A");
            Assert.IsTrue(provider.IsPresent, "L2420A");
            Assert.IsTrue(secondaryIdentification.HasValue, "L2420A");
            Assert.IsTrue(secondaryIdentification.IsPresent, "L2420A");
            Assert.AreEqual("82", provider.ValueOrDefault(), "L2420A - NM1");
            Assert.AreEqual("G2", secondaryIdentification.ValueOrDefault(), "L2400 - REF");
        }

        void AssertLoop2410(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400)[0]
                .Select(x => x.Loop2410);
                
            var qualifier = loop
                .Select(x => x.DrugIdentification)
                .Select(x => x.Qualifier);

            var drugAssociationNumber = loop
                .Select(x => x.PrescriptionOrCompoundDrugAssociationNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assert.IsNotNull(loop, "L2410");
            Assert.IsTrue(loop.HasValue, "L2410");
            Assert.IsTrue(qualifier.HasValue, "L2410");
            Assert.IsTrue(qualifier.IsPresent, "L2410");
            Assert.IsTrue(drugAssociationNumber.HasValue, "L2410");
            Assert.IsTrue(drugAssociationNumber.IsPresent, "L2410");
            Assert.AreEqual("N4", qualifier.ValueOrDefault(), "L2410 - LIN");
            Assert.AreEqual("XZ", drugAssociationNumber.ValueOrDefault(), "L2410 - REF");
        }

        void AssertLoop2400(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2400);
                
            Assert.IsNotNull(loop, "L2400");
            Assert.IsTrue(loop.HasValue, "L2400");
        }

        void AssertLoop1000A(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop1000A)[0]
                .Select(x => x.Submitter);
                
            Assert.IsNotNull(loop, "L1000A");
            Assert.IsTrue(loop.HasValue, "L1000A");
            Assert.AreEqual("41", loop.Select(x => x.EntityIdentifierCode).ValueOrDefault(), "L1000A - NM1");
        }

        void AssertLoop1000B(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop1000B)[0]
                .Select(x => x.Receiver);
                
            Assert.IsNotNull(loop, "L1000B");
            Assert.IsTrue(loop.HasValue, "L1000B");
            Assert.AreEqual("40", loop.Select(x => x.EntityIdentifierCode).ValueOrDefault(), "L1000B - NM1");
        }

        void AssertLoop2000A(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000A)[0];
                
            Assert.IsNotNull(loop, "L2000A");
            Assert.IsTrue(loop.HasValue, "L2000A");
            Assert.AreEqual("20", loop.Select(x => x.HierarchicalLevel).Select(x => x.LevelCode).ValueOrDefault(), "L2000A - HL");
        }

        void AssertLoop2010AA(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000A)[0]
                .Select(x => x.Loop2010AA)
                .Select(x => x.BillingProvider);
                
            Assert.IsNotNull(loop, "L2010AC");
            Assert.IsTrue(loop.HasValue, "L2010AC");
            Assert.AreEqual("85", loop.Select(x => x.EntityIdentifierCode).ValueOrDefault(), "L2010AC - NM1");
        }

        void AssertLoop2010AB(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000A)[0]
                .Select(x => x.Loop2010AB)
                .Select(x => x.PayToAddressName);
                
            Assert.IsNotNull(loop, "L2010AB");
            Assert.IsTrue(loop.HasValue, "L2010AB");
            Assert.AreEqual("87", loop.Select(x => x.EntityIdentifierCode).ValueOrDefault(), "L2010AB - NM1");
        }

        void AssertLoop2010AC(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000A)[0]
                .Select(x => x.Loop2010AC)
                .Select(x => x.PayToPlanName);
                
            Assert.IsNotNull(loop, "L2010AC");
            Assert.IsTrue(loop.HasValue, "L2010AC");
            Assert.AreEqual("PE", loop.Select(x => x.EntityIdentifierCode).ValueOrDefault(), "L2010AC - NM1");
        }

        void AssertLoop2000B(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA);
                
            Assert.IsNotNull(loop, "L2010BB");
            Assert.IsTrue(loop.HasValue, "L2010BB");
        }

        void AssertLoop2010BA(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.Subscriber);
                
            Assert.IsNotNull(loop, "L2010BA");
            Assert.IsTrue(loop.HasValue, "L2010BA");
            Assert.AreEqual("IL", loop.Select(x => x.EntityIdentifierCode).ValueOrDefault(), "L2010BA - NM1");
        }

        void AssertLoop2010BB(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BB)
                .Select(x => x.Payer);
                
            Assert.IsNotNull(loop, "L2010BB");
            Assert.IsTrue(loop.HasValue, "L2010BB");
            Assert.AreEqual("PR", loop.Select(x => x.EntityIdentifierCode).ValueOrDefault());
        }

        void AssertLoop2000C(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.HierarchicalLevel);
                
            Assert.IsNotNull(loop, "L2000C");
            Assert.IsTrue(loop.HasValue, "L2000C");
            Assert.AreEqual("23", loop.Select(x => x.LevelCode).ValueOrDefault());
        }

        void AssertLoop2010CA(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2010CA);
                
            Assert.IsNotNull(loop, "L2310A");
            Assert.IsTrue(loop.HasValue, "L2310A");
            Assert.AreEqual("QC", loop.Select(x => x.Patient).Select(x => x.EntityIdentifierCode).ValueOrDefault());
        }

        void AssertLoop2300(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0];
                
            Assert.IsNotNull(loop, "L2300");
            Assert.IsTrue(loop.HasValue, "L2300");

            string typeCode = loop
                .Select(x => x.HealthcareDiagnosisCode)
                .Select(x => x.HealthCareCodeInformation1)
                .Select(x => x.DiagnosisTypeCode)
                .ValueOrDefault();
            
            // int count = 0;
            // for (int i = 0;; i++)
            // {
            //     if (!loop.Select(x => x.ConditionInformation).TryGetValue(i, out var condition))
            //     {
            //         count = i;
            //         break;
            //     }
            // }
            //
            // Assert.AreEqual(4, count);
        }

        void AssertLoop2310A(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2310A)[0];
                
            Assert.IsNotNull(loop, "L2310A");
            Assert.IsTrue(loop.HasValue, "L2310A");
            Assert.AreEqual("DN", loop.Select(x => x.ReferringProvider).Select(x => x.EntityIdentifierCode).ValueOrDefault());
        }

        void AssertLoop2310B(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2310B);
                
            Assert.IsNotNull(loop, "L2310B");
            Assert.IsTrue(loop.HasValue, "L2310B");
            Assert.AreEqual("82", loop.Select(x => x.RenderingProvider).Select(x => x.EntityIdentifierCode).ValueOrDefault());
        }

        void AssertLoop2310C(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2310C);
                
            Assert.IsNotNull(loop, "L2310D");
            Assert.IsTrue(loop.HasValue, "L2310D");
            Assert.AreEqual("77", loop.Select(x => x.ServiceFacilityLocation).Select(x => x.EntityIdentifierCode).ValueOrDefault());
        }

        void AssertLoop2310D(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2310D);
                
            Assert.IsNotNull(loop, "L2310D");
            Assert.IsTrue(loop.HasValue, "L2310D");
            Assert.AreEqual("DQ", loop.Select(x => x.SupervisingProvider).Select(x => x.EntityIdentifierCode).ValueOrDefault());
        }

        void AssertLoop2310E(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2310E);
                
            Assert.IsNotNull(loop, "L2310E");
            Assert.IsTrue(loop.HasValue, "L2310E");
            Assert.AreEqual("PW", loop.Select(x => x.AmbulancePickUpLocation).Select(x => x.EntityIdentifierCode).ValueOrDefault());
        }

        void AssertLoop2310F(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2310F);
                
            Assert.IsNotNull(loop, "L2310F");
            Assert.IsTrue(loop.HasValue, "L2310F");
            Assert.AreEqual("45", loop.Select(x => x.AmbulanceDropOffLocation).Select(x => x.EntityIdentifierCode).ValueOrDefault());
        }

        void AssertLoop2320(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2320)[0]
                .Select(x => x.SubscriberInformation);
            
            Assert.IsNotNull(loop, "L2320");
            Assert.IsTrue(loop.HasValue, "L2320");
            Assert.AreEqual("P", loop.Select(x => x.PayerResponsibilitySequenceNumberCode).ValueOrDefault(), "L2320 - SBR");
        }

        void AssertLoop2330G(Layout<T837P> transaction)
        {
            var loop = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2320)[0]
                .Select(x => x.Loop2330G);

            var payerBillingProvider = loop
                .Select(x => x.OtherPayerBillingProvider)
                .Select(x => x.EntityIdentifierCode);

            var otherPayerBillingProviderSecondaryIdentification = loop
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assert.IsNotNull(loop, "L2330G");
            Assert.IsNotNull(payerBillingProvider, "L2330G - REF");
            Assert.IsNotNull(otherPayerBillingProviderSecondaryIdentification, "L2330G - REF");
            Assert.IsTrue(loop.HasValue);
            Assert.IsTrue(payerBillingProvider.HasValue);
            Assert.IsTrue(otherPayerBillingProviderSecondaryIdentification.HasValue);
            Assert.IsTrue(payerBillingProvider.IsPresent);
            Assert.IsTrue(otherPayerBillingProviderSecondaryIdentification.IsPresent);
            Assert.AreEqual("85", payerBillingProvider.ValueOrDefault());
            Assert.AreEqual("G2", otherPayerBillingProviderSecondaryIdentification.ValueOrDefault());
        }

        void AssertLoop2330F(Layout<T837P> transaction)
        {
            var otherPayerSupervisingProvider = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2320)[0]
                .Select(x => x.Loop2330F);

            var payerSupervisingProvider = otherPayerSupervisingProvider
                .Select(x => x.OtherPayerSupervisingProvider)
                .Select(x => x.EntityIdentifierCode);

            var payerSupervisingProviderSecondaryIdentification = otherPayerSupervisingProvider
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assert.IsNotNull(otherPayerSupervisingProvider, "L2330");
            Assert.IsNotNull(payerSupervisingProvider, "l2330f - NM1");
            Assert.IsNotNull(payerSupervisingProviderSecondaryIdentification, "l2330f - REF");
            Assert.IsTrue(otherPayerSupervisingProvider.HasValue);
            Assert.IsTrue(payerSupervisingProvider.HasValue);
            Assert.IsTrue(payerSupervisingProviderSecondaryIdentification.HasValue);
            Assert.IsTrue(payerSupervisingProvider.IsPresent);
            Assert.IsTrue(payerSupervisingProviderSecondaryIdentification.IsPresent);
        }

        void AssertLoop2330E(Layout<T837P> transaction)
        {
            var otherPayerServiceFacilityLocation = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2320)[0]
                .Select(x => x.Loop2330E);

            var facilityLocation = otherPayerServiceFacilityLocation
                .Select(x => x.OtherPayerServiceFacilityLocation)
                .Select(x => x.EntityIdentifierCode);

            var payerServiceFacilityLocationSecondaryIdentification = otherPayerServiceFacilityLocation
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assert.IsNotNull(otherPayerServiceFacilityLocation, "L2330E");
            Assert.IsNotNull(facilityLocation, "L2330E - NM1");
            Assert.IsNotNull(payerServiceFacilityLocationSecondaryIdentification, "L2330E - REF");
            Assert.IsTrue(otherPayerServiceFacilityLocation.HasValue);
            Assert.IsTrue(facilityLocation.HasValue);
            Assert.IsTrue(payerServiceFacilityLocationSecondaryIdentification.HasValue);
            Assert.IsTrue(facilityLocation.IsPresent);
            Assert.IsTrue(payerServiceFacilityLocationSecondaryIdentification.IsPresent);
            Assert.AreEqual("77", facilityLocation.ValueOrDefault());
            Assert.AreEqual("0B", payerServiceFacilityLocationSecondaryIdentification.ValueOrDefault());
        }

        void AssertLoop2330D(Layout<T837P> transaction)
        {
            var otherPayerRenderingProvider = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2320)[0]
                .Select(x => x.Loop2330D);

            var payerRenderingProvider = otherPayerRenderingProvider
                .Select(x => x.OtherPayerRenderingProvider)
                .Select(x => x.EntityIdentifierCode);

            var payerRenderingProviderSecondaryIdentification = otherPayerRenderingProvider
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assert.IsNotNull(otherPayerRenderingProvider, "L2320");
            Assert.IsNotNull(payerRenderingProvider, "L2330D - NM1");
            Assert.IsNotNull(payerRenderingProviderSecondaryIdentification, "L2330D - REF");
            Assert.IsTrue(otherPayerRenderingProvider.HasValue);
            Assert.IsTrue(payerRenderingProvider.HasValue);
            Assert.IsTrue(payerRenderingProviderSecondaryIdentification.HasValue);
            Assert.IsTrue(payerRenderingProvider.IsPresent);
            Assert.IsTrue(payerRenderingProviderSecondaryIdentification.IsPresent);
        }

        void AssertLoop2330C(Layout<T837P> transaction)
        {
            var otherPayerReferringProvider = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2320)[0]
                .Select(x => x.Loop2330C)[0];

            var referringProvider = otherPayerReferringProvider
                .Select(x => x.OtherPayerReferringProvider)
                .Select(x => x.EntityIdentifierCode);

            var referringProviderSecondaryIdentification = otherPayerReferringProvider
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assert.IsNotNull(otherPayerReferringProvider, "L2330C");
            Assert.IsNotNull(referringProvider, "L2330C - NM1");
            Assert.IsNotNull(referringProviderSecondaryIdentification, "L2330C - REF");
            Assert.IsTrue(otherPayerReferringProvider.HasValue);
            Assert.IsTrue(referringProvider.HasValue);
            Assert.IsTrue(referringProviderSecondaryIdentification.HasValue);
            Assert.IsTrue(referringProviderSecondaryIdentification.IsPresent);
            Assert.AreEqual("DN", referringProvider.ValueOrDefault());
            Assert.AreEqual("0B", referringProviderSecondaryIdentification.ValueOrDefault());
        }

        void AssertLoop2330B(Layout<T837P> transaction)
        {
            var otherPayerName = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2320)[0]
                .Select(x => x.Loop2330B);

            var payer = otherPayerName
                .Select(x => x.OtherPayer)
                .Select(x => x.EntityIdentifierCode);

            var payerSecondaryIdentification = otherPayerName
                .Select(x => x.SecondaryIdentification)[0]
                .Select(x => x.ReferenceIdentificationQualifier);

            Assert.IsNotNull(otherPayerName, "L2330B");
            Assert.IsNotNull(payer, "L2330B - NM1");
            Assert.IsNotNull(payerSecondaryIdentification, "L2330B - REF");
            Assert.IsTrue(otherPayerName.HasValue);
            Assert.IsTrue(payer.HasValue);
            Assert.IsTrue(payerSecondaryIdentification.HasValue);
            Assert.IsTrue(payer.IsPresent);
            Assert.IsTrue(payerSecondaryIdentification.IsPresent);
            Assert.AreEqual("PR", payer.ValueOrDefault());
            Assert.AreEqual("2U", payerSecondaryIdentification.ValueOrDefault());
        }

        void AssertLoop2330A(Layout<T837P> transaction)
        {
            var otherSubscriberName = transaction
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2320)[0]
                .Select(x => x.Loop2330A);

            var subscribingProvider = otherSubscriberName
                .Select(x => x.OtherSubscriber)
                .Select(x => x.EntityIdentifierCode);

            var subscriberProviderSecondaryIdentification = otherSubscriberName
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);

            Assert.IsNotNull(otherSubscriberName, "L2330A");
            Assert.IsNotNull(subscribingProvider, "L2330A - NM1");
            Assert.IsNotNull(subscriberProviderSecondaryIdentification, "L2330A - REF");
            Assert.IsTrue(otherSubscriberName.HasValue);
            Assert.IsTrue(subscribingProvider.HasValue);
            Assert.IsTrue(subscriberProviderSecondaryIdentification.HasValue);
            Assert.IsTrue(subscribingProvider.IsPresent);
            Assert.IsTrue(subscriberProviderSecondaryIdentification.IsPresent);
            Assert.AreEqual("IL", subscribingProvider.ValueOrDefault());
            Assert.AreEqual("SY", subscriberProviderSecondaryIdentification.ValueOrDefault());
        }
    }
}