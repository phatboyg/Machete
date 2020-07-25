namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class PALMap :
        X12SegmentMap<PAL, X12Entity>
    {
        public PALMap()
        {
            Id = "PAL";
            Name = "Pallet Information";
            
            Value(x => x.PalletTypeCode, 1, x => x.MinLength(1).MaxLength(2));
            Value(x => x.PalletTiers, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.PalletBlocks, 3, x => x.MinLength(1).MaxLength(3));
            Value(x => x.Pack, 4, x => x.MinLength(1).MaxLength(6));
            Value(x => x.UnitWeight, 5, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode1, 6, x => x.FixedLength(2));
            Value(x => x.Length, 7, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Width, 8, x => x.MinLength(1).MaxLength(8));
            Value(x => x.Height, 9, x => x.MinLength(1).MaxLength(8));
            Value(x => x.UnitOrBasisForMeasurementCode2, 10, x => x.FixedLength(2));
            Value(x => x.GrossWeightPerPack1, 11, x => x.MinLength(1).MaxLength(9));
            Value(x => x.UnitOrBasisForMeasurementCode3, 12, x => x.FixedLength(2));
            Value(x => x.GrossWeightPerPack2, 13, x => x.MinLength(1).MaxLength(9));
            Value(x => x.UnitOrBasisForMeasurementCode4, 14, x => x.FixedLength(2));
            Value(x => x.PalletExchangeCode, 15, x => x.FixedLength(1));
            Value(x => x.InnerPack, 16, x => x.MinLength(1).MaxLength(6));
        }
    }
}