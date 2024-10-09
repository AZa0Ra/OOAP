namespace Module1
{
    public interface IDeliveryInfo
    {
        string GetDeliveryTime();
        double GetDeliveryCost();
    }
    public class USDeliveryInfo : IDeliveryInfo
    {
        public string GetDeliveryTime() => "5-7 days";
        public double GetDeliveryCost() => 20.0;
    }

    public class EasternDeliveryInfo : IDeliveryInfo
    {
        public string GetDeliveryTime() => "3-5 days";
        public double GetDeliveryCost() => 10.0;
    }
}
