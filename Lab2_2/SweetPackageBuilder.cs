namespace Lab2_2
{
    abstract class SweetPackageBuilder
    {
        protected SweetPackage SweetPackage { get; private set; }
        protected double PriceLollipops { get; }
        protected double PriceChocolates { get; }
        protected double PriceWaffles { get; }
        protected double PriceDragees { get; }

        public SweetPackageBuilder(double priceLollipops, double priceChocolates, double priceWaffles, double priceDragees)
        {
            PriceLollipops = priceLollipops;
            PriceChocolates = priceChocolates;
            PriceWaffles = priceWaffles;
            PriceDragees = priceDragees;
        }

        public void CreateNewSweetPackage()
        {
            SweetPackage = new SweetPackage();
        }

        public SweetPackage GetMySweetPackage()
        {
            return SweetPackage;
        }

        public abstract void SetName();
        public abstract void SetLollipops();
        public abstract void SetChocolates();
        public abstract void SetWaffles();
        public abstract void SetDragees();
        //public abstract void CalculatePrice();
        public void CalculatePrice()
        {
            SweetPackage.TotalPrice = SweetPackage.WeightLollipops * PriceLollipops +
                    SweetPackage.WeightChocolates * PriceChocolates +
                    SweetPackage.WeightWaffles * PriceWaffles +
                    SweetPackage.WeightDragees * PriceDragees;
        }
    }
}
