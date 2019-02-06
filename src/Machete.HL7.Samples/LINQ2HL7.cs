namespace Machete.HL7.Samples
{
    public class LINQ2HL7 :
        IQueryMessage
    {
        readonly IEntityParser<HL7Entity> _parser;

        public LINQ2HL7(IEntityParser<HL7Entity> parser)
        {
            _parser = parser;
        }

        public void DoWork(string message)
        {
            var result = _parser.Parse(message);
            
//            result.Query(q =>)
        }

        public Patient GetPatient(string message)
        {
            var result = _parser.Parse(message);

            result.Query(q =>
            {
                var obxQuery = from obx in q.Select<OBX>()
                    from nte in q.Select<NTE>().ZeroOrMore()
                    select new
                    {
                        OBX = obx,
                        NTE = nte
                    };

                var obrQuery = from obr in q.Select<OBR>()
                    from dg1 in q.Select<DG1>().Optional()
                    from obx in obxQuery.Optional()
                    select new
                    {
                        OBR = obr,
                        DG1 = dg1,
                        OBX = obx
                    };

                var testQuery = from orc in q.Select<ORC>()
                    from obr in obrQuery.ZeroOrMore()
                    select new
                    {
                        ORC = orc,
                        OBR = obr
                    };

                return from msh in q.Select<MSH>()
                    from nte in q.Select<NTE>().ZeroOrMore()
                    from skip in q.Except<HL7Segment, ORC>().ZeroOrMore()
                    from tests in testQuery.ZeroOrMore()
                    select tests;
            });
        }
    }


    public interface IQueryMessage
    {
        Patient GetPatient(string message);
    }


    public interface Patient
    {
    }
}