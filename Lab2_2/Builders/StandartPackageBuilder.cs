namespace Lab2_2
{
    class StandartPackageBuilder : SweetPackageBuilder
    {
        public StandartPackageBuilder(double priceLollipops, double priceChocolates, double priceWaffles, double priceDragees)
            : base(priceLollipops, priceChocolates, priceWaffles, priceDragees) { }

        public override void SetName()
        {
            SweetPackage.Name = "Namunayko";
        }

        public override void SetLollipops()
        {
            SweetPackage.WeightLollipops = 0.6;
        }

        public override void SetChocolates()
        {
            SweetPackage.WeightChocolates = 0.4;
        }

        public override void SetWaffles()
        {
            SweetPackage.WeightWaffles = 0.3;
        }

        public override void SetDragees()
        {
            SweetPackage.WeightDragees = 0.2;
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
