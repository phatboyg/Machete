namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 277 Healthcare Information Status Notification
    /// </summary>
    public interface HISN277 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<ISNT277> Transactions { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}