namespace Lab2_2
{
    class EconomPackageBuilder : SweetPackageBuilder
    {
        public EconomPackageBuilder(double priceLollipops, double priceChocolates, double priceWaffles, double priceDragees)
            : base(priceLollipops, priceChocolates, priceWaffles, priceDragees) { }

        public override void SetName()
        {
            SweetPackage.Name = "Lasunka";
        }

        public override void SetLollipops()
        {
            SweetPackage.WeightLollipops = 0.5;
        }

        public override void SetChocolates()
        {
            SweetPackage.WeightChocolates = 0.3;
        }

        public override void SetWaffles()
        {
            SweetPackage.WeightWaffles = 0.2;
        }

        public override void SetDragees()
        {
            SweetPackage.WeightDragees = 0.1;
        }

        //public override void CalculatePrice()
        //{
        //    SweetPackage.TotalPrice = SweetPackage.WeightLollipops * PriceLollipops +
        //                        SweetPackage.WeightChocolates * PriceChocolates +
        //                        SweetPackage.WeightWaffles * PriceWaffles +
        //                        SweetPackage.WeightDragees * PriceDragees;
        //}
    }
}
