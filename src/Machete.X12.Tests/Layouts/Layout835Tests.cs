namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Layout835Tests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test]
        public void Test()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*835*212900796
BPR*I*98229.13*C*ACH*CCP*01*021300556*DA*320993201765*1141797357**01*222370440*DA*7900644837*20180627
TRN*1*021300078111613*1141797357
REF*EV*00DJ
DTM*405*20180611
N1*PR*NYSDOH
N3*OFFICE OF HEALTH INSURANCE PROGRAMS*CORNING TOWER, EMPIRE STATE PLAZA
N4*ALBANY*NY*122370080
PER*BL*PROVIDER SERVICES*TE*321321321*UR*www.default.org
N1*PE*OPERATIONS ASSOCIATES LLC*XX*3333333333
N4*NEW YORK*NY*104701104
REF*TJ*8524556
LX*1
CLP*555555555555*1*1269.55*0**MC*11111111111*21*4
CAS*CO*26*1269.55
NM1*QC*1*SMITH*BOB****MI*CH21785G
NM1*74*1*SMITH*BOB*E
NM1*82*1******XX*8888888888888
REF*EA*00446771
REF*9A*3839
DTM*232*20171216
DTM*233*20171221
QTY*CA*5
SE*1301*212900796
GE*1*176073292
IEA*1*176073292";
 
            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HCPA835, X12Entity> layout));

            IParser<X12Entity, HCPA835> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HCPA835> result = entityResult.Query(query);

            Assert.IsTrue(result.HasResult);
        }
    }
}