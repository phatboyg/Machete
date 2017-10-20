﻿namespace Machete.X12.Tests
{
    using NUnit.Framework;
    using Schema.Segments;
    using Testing;
    using X12Schema.Generated.V5010;


    [TestFixture]
    public class Creating_the_text_harness :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test]
        public void Should_create_the_parser()
        {
            Assert.IsNotNull(Parser);
        }

        [Test]
        public void Should_be_able_to_parse_the_x12_document()
        {
            const string example271 =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";


            var parsed = Parser.Parse(example271);

            Assert.That(parsed.TryGetEntity(0, out ISA isa), Is.True);

            Assert.That(isa.SegmentId.HasValue, Is.True);
            Assert.That(isa.SegmentId.Value, Is.EqualTo("ISA"));

            Assert.That(isa.SenderId.HasValue, Is.True);
            Assert.That(isa.SenderId.Value, Is.EqualTo("MACHETE"));


            Assert.That(parsed.TryGetEntity(1, out GS gs), Is.True);
        }
    }
}