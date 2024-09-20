namespace Lab2
{
    public class GoldenJewerlyFactory : IJewelryFactory
    {
        public Bracelets GetBracelets()
        {
            return new GoldenBracelets();
        }
        public Chains GetChains()
        {
            return new GoldenChains();
        }
        public Earring GetEarring()
        {
            return new GoldenEarring();
        }
        public Pendants GetPendants()
        {
            return new GoldenPendants();

        }
        public Rings GetRings()
        {
            return new GoldenRings();
        }
    }
}
