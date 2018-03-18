namespace Machete.X12.Tests
{
    using System;
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;
    using X12Schema.V5010.Layouts;


    [TestFixture]
    public class Using_a_layout_on_any_message :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test]
        public void Should_match_a_valid_message()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";


            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.That(Schema.TryGetLayout(out ILayoutParserFactory<X12MessageLayout, X12Entity> layout), Is.True);

            IParser<X12Entity, X12MessageLayout> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, X12MessageLayout> result = entityResult.Query(query);

            Assert.That(result.HasResult, Is.True);
            Assert.That(result.Select(x => x.ISA), Is.Not.Null);
            Assert.That(result.Select(x => x.ISA).HasValue, Is.True);

            Value<DateTime> isaDate = result.Select(x => x.ISA).Select(x => x.Date);
            Assert.That(isaDate.HasValue, Is.True);
            Assert.That(isaDate.Value, Is.EqualTo(new DateTime(2009, 6, 1, 4, 6, 0)));

            Assert.That(result.Select(x => x.GS).HasValue, Is.True);
            Assert.That(result.Select(x => x.TransactionSetHeader).HasValue, Is.True);
        }
    }
}