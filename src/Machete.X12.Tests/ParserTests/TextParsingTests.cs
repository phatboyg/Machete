namespace Machete.X12.Tests.ParserTests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Schema.Segments;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class TextParsingTests :
        X12MacheteTestHarness<V5010, X12Entity>
    {
        [Test, Explicit("need to figure out why this is breaking")]
        public void Should_throw_exception_when_space_before_segment_delimiter2()
        {
//            const string message =
//                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X ~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            string message = @"ISA*00*          *00*          *ZZ*123456789      *ZZ*MDOL837        *171213*1124*^*00501*121324415*1*P*:~GS*HC*123456789*MDOL837*20171213*1124*121324415*X*005010X222A1~ST*837*eddf17d28*005010X222A1~BHT*0019*00*eddf17d28*20171213*1124*CH~NM1*41*2*JD Peach, MD, LTD*****46*123456789~PER*IC*BILLING MANAGER*TE*6106784552~NM1*40*2*MDOL*****46*MDOL837~HL*1**20*1~PRV*BI*PXC*193400000X~NM1*85*2*JD Peach, MD, LTD*****XX*1234567890~N3*3855 Key Ave~N4*Fish Spring*PA*777777777~REF*EI*123456789~HL*2*1*22*0~SBR*P*18*******MC~NM1*IL*1*Losa*ROSA*M***MI*50782026~N3*14 ZIONS Perch RD~N4*Thoma*PA*195559501~DMG*D8*19570206*F~NM1*PR*2*AMERIHEALTH  MERCY/CARITAS*****PI*22248~N3*PO Box 7118~N4*London*KY*40742~CLM*11111*125***11:B:1*Y*A*Y*Y~HI*ABK:H43811*ABF:H5319~NM1*DN*1*Easter*PAUL*J***XX*1407854961~NM1*82*1*Loot*LUCY****XX*1750384855~PRV*PE*PXC*207W00000X~LX*1~SV1*HC:92012*125*UN*1***1:2~DTP*472*D8*20171110~REF*6R*156188~HL*3**20*1~PRV*BI*PXC*193400000X~NM1*85*2*JD Peach, MD, LTD*****XX*1234567890~N3*3855 Key Ave~N4*Fish Spring*PA*777777777~REF*EI*123456789~SE*36*eddf17d28~GE*1*121324415~IEA*1*121324415~";
            
            var parsed = Parser.Parse(message);
            var result = parsed.Query(q =>
                from isa in q.Select<ISA>()
                from gs in q.Select<GS>()
                from unknown in q.Except<X12Segment, GE>().ZeroOrMore()
                select new
                {
                    ISA = isa,
                    GS = gs,
                    EverythingElse = unknown
                });

            IReadOnlyList<X12Segment> segments = result.Select(x => x.EverythingElse).ValueOrDefault();

            foreach (var segment in segments)
                Console.WriteLine(segment);

            Assert.AreEqual(36, segments.Count);
        }

        [Test]
        public void Should_not_throw_exception_when_segment_delimiter_missing()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*271*4321*005010X279
BHT*0022*11*10001234*20060501*1319
HL*1**20*1
NM1*PR*2*THE COMPANY*Joe****PI*842610001
HL*2*1*21*1
NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035
HL*3*2*22*1
NM1*IL*1*SMITH*JOHN****MI*123456789
N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X
N4*Atlanta*GA*30000
HL*4*3*23*0
TRN*2*93175-012547*9877281234
NM1*03*1*SMITH*JOHNNY
N3*PO BOX 12345*Suite X
N4*Atlanta*GA*30000
DMG*D8*19600409*M
HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877
DTP*346*D8*20060101
MPI*C*AO*A**L3
EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3
REF*Y4*653745725*5010 CASE DESCRIPTION 3H
EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5
LS*2120
NM1*P3*1*JONES*MARCUS****XX*1003853409
LE*2120~SE*25*4321
GE*1*1
IEA*1*000026531";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from isa in q.Select<ISA>()
                from gs in q.Select<GS>()
                from st in q.Select<ST>()
                from bht in q.Select<BHT>()
                from hl in q.Select<HL>()
                from nm1 in q.Select<NM1>()
                from skip in q.Except<X12Segment, X12Segment>().ZeroOrMore()
                select new
                {
                    ISA = isa,
                    GS = gs,
                    NM1 = nm1
                });
            
            Assert.IsNotNull(result.Result);
            Assert.AreEqual("Joe", result.Select(x => x.NM1).Select(x => x.FirstName).ValueOrDefault());
        }

        [Test]
        public void Should_handle_multiple_whitespace_for_segment_delimiter()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*271*4321*005010X279
BHT*0022*11*10001234*20060501*1319     
HL*1**20*1
NM1*PR*2*THE COMPANY*Joe****PI*842610001
HL*2*1*21*1
NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035     
HL*3*2*22*1
NM1*IL*1*SMITH*JOHN****MI*123456789      
N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X
N4*Atlanta*GA*30000
HL*4*3*23*0
TRN*2*93175-012547*9877281234
NM1*03*1*SMITH*JOHNNY
N3*PO BOX 12345*Suite X     
N4*Atlanta*GA*30000
DMG*D8*19600409*M
HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877
DTP*346*D8*20060101     
MPI*C*AO*A**L3
EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3
REF*Y4*653745725*5010 CASE DESCRIPTION 3H
EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5
LS*2120
NM1*P3*1*JONES*MARCUS****XX*1003853409
LE*2120~SE*25*4321
GE*1*1
IEA*1*000026531";

            var parsed = Parser.Parse(message);

            var result = parsed.Query(q =>
                from isa in q.Select<ISA>()
                from gs in q.Select<GS>()
                from st in q.Select<ST>()
                from bht in q.Select<BHT>()
                from hl in q.Select<HL>()
                from nm1 in q.Select<NM1>()
                from skip in q.Except<X12Segment, X12Segment>().ZeroOrMore()
                select new
                {
                    ISA = isa,
                    GS = gs,
                    NM1 = nm1
                });
            
            Assert.IsNotNull(result.Result);
            Assert.AreEqual("Joe", result.Select(x => x.NM1).Select(x => x.FirstName).ValueOrDefault());
        }

        [Test]
        public void Should_throw_exception_when_sub_element_delimiter_missing()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P* ~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            Assert.Throws<MacheteParserException>(() =>
            {
                var parsed = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_throw_exception_when_sub_element_delimiter_letter()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*X~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            Assert.Throws<MacheteParserException>(() =>
            {
                var parsed = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_throw_exception_when_sub_element_delimiter_digit()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*1~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            Assert.Throws<MacheteParserException>(() =>
            {
                var parsed = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_throw_exception_when_repetition_delimiter_is_missing()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406**00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            Assert.Throws<MacheteParserException>(() =>
            {
                var parsed = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_throw_exception_when_repetition_delimiter_is_letter_or_digit()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*U*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            Assert.Throws<MacheteParserException>(() =>
            {
                var parsed = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_throw_exception_when_repetition_delimiter_is_digit()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*1*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            Assert.Throws<MacheteParserException>(() =>
            {
                var parsed = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_throw_exception_when_element_delimiter_is_missing()
        {
            const string message =
                @"ISA *03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            Assert.Throws<MacheteParserException>(() =>
            {
                var parsed = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_throw_exception_when_ISA_missing()
        {
            const string message =
                @"ISS*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";

            Assert.Throws<MacheteParserException>(() =>
            {
                var parsed = Parser.Parse(message);
            });
        }

        [Test]
        public void Should_be_able_to_parse_when_ISA_is_preceeded_by_whitespace()
        {
            const string message =
                @" ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:~GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279~ST*271*4321*005010X279~BHT*0022*11*10001234*20060501*1319~HL*1**20*1~NM1*PR*2*THE COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*1~NM1*IL*1*SMITH*JOHN****MI*123456789~N3*PO BOX 12345laskdjflaskdjflasjdflsajdflkasjdlfjalsdjflaskjdfl*Suite X~N4*Atlanta*GA*30000~HL*4*3*23*0~TRN*2*93175-012547*9877281234~NM1*03*1*SMITH*JOHNNY~N3*PO BOX 12345*Suite X~N4*Atlanta*GA*30000~DMG*D8*19600409*M~HI*BK:123*BF:34555*BF:566677*BK:456*BF:3877~DTP*346*D8*20060101~MPI*C*AO*A**L3~EB*F*IND*55^CB^77***29***DY*33**Y**1:2:3~REF*Y4*653745725*5010 CASE DESCRIPTION 3H~EB*1*IND*55^PT*MA**24*26**LA*10**Y**4:5~LS*2120~NM1*P3*1*JONES*MARCUS****XX*1003853409~LE*2120~SE*25*4321~GE*1*1~IEA*1*000026531~";
 
            var parsed = Parser.Parse(message);
            var result = parsed.Query(q =>
                from isa in q.Select<ISA>()
                from gs in q.Select<GS>()
                select new
                {
                    ISA = isa,
                    GS = gs
                });
            
            Assert.AreEqual("HB", result.Select(x => x.GS).Select(x => x.FunctionalIdentifierCode).ValueOrDefault());
        }
    }
}