namespace Lab2
{
    /// <summary>
    /// Concrete factory
    /// </summary>
    public class SilverJewerlyFactory : IJewelryFactory
    {
        public Bracelets GetBracelets()
        {
            return new SilverBracelets();
        }
        public Chains GetChains()
        {
            return new SilverChains();
        }
        public Earring GetEarring()
        {
            return new SilverEarring();
        }
        public Pendants GetPendants()
        {
            return new SilverPendants();
        }
        public Rings GetRings()
        {
            return new SilverRings();
        }
    }
}
