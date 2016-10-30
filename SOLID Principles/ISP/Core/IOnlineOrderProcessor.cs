namespace ISP.Core
{
    public interface IOnlineOrderProcessor
    {
        bool ValidateCardInfo(CardInfo obj);
    }
}