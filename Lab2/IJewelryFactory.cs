namespace Lab2
{
    /// <summary>
    /// Abstract factory
    /// </summary>
    public interface IJewelryFactory
    {
        Earring GetEarring();
        Rings GetRings();
        Chains GetChains();
        Pendants GetPendants();
        Bracelets GetBracelets();
    }
}
