namespace Lab2_2
{
    public class SweetPackage
    {
        public string Name { get; set; }
        public double WeightLollipops { get; set; }
        public double WeightChocolates { get; set; }
        public double WeightWaffles { get; set; }
        public double WeightDragees { get; set; }
        public double TotalPrice { get; set; }

        public override string ToString()
        {
            return $"Package: {Name}\n" +
                $"Lollipops: {WeightLollipops} kg\nChocolates: {WeightChocolates}" +
                $" kg\nWaffles: {WeightWaffles} kg\nDragees: {WeightDragees} kg\nTotalPrice: {TotalPrice} uah";
        }
    }
}
