namespace Lab2_2
{
    class BuySweetPackage
    {
        private SweetPackageBuilder _sweetPackageBuilder;
        public void SetPackageBuilder(SweetPackageBuilder builder)
        {
            _sweetPackageBuilder = builder;
        }
        public SweetPackage GetSweetPackage()
        {
            return _sweetPackageBuilder.GetMySweetPackage();
        }
        public void ConstructSweetPackage()
        {
            _sweetPackageBuilder.CreateNewSweetPackage();
            _sweetPackageBuilder.SetName();
            _sweetPackageBuilder.SetLollipops();
            _sweetPackageBuilder.SetChocolates();
            _sweetPackageBuilder.SetWaffles();
            _sweetPackageBuilder.SetDragees();
            _sweetPackageBuilder.CalculatePrice();
        }
    }
}
