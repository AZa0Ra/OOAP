namespace Lab2
{
    public abstract class Jewerly
    {
        public string Name { get; }
        protected Jewerly(string name)
        {
            Name = name;
        }
    }
}
