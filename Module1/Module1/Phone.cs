namespace Module1
{
    public interface IPhone
    {
        string GetModel();
        double GetPrice();
    }
    public interface IPhoneFactory
    {
        IPhone CreatePhone();
        IDeliveryInfo CreateDeliveryInfo();
    }
    public class USPhone : IPhone
    {

        public string GetModel() => "iPhone 14";
        public double GetPrice() => 999.99;
    }
    public class EasternPhone : IPhone
    {
        public string GetModel() => "iPhone 13";
        public double GetPrice() => 699.99;
    }
    public class USPhoneFactory : IPhoneFactory
    {
        public IPhone CreatePhone() => new USPhone();
        public IDeliveryInfo CreateDeliveryInfo() => new USDeliveryInfo();
    }

    public class EasternPhoneFactory : IPhoneFactory
    {
        public IPhone CreatePhone() => new EasternPhone();
        public IDeliveryInfo CreateDeliveryInfo() => new EasternDeliveryInfo();
    }
}
