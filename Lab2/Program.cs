using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IJewelryFactory silverFactory = new SilverJewerlyFactory();
            Rings rings = silverFactory.GetRings();
            Earring earring = silverFactory.GetEarring();
            Chains chains = silverFactory.GetChains();
            Pendants pendants = silverFactory.GetPendants();
            Bracelets bracelets = silverFactory.GetBracelets();

            Console.WriteLine($"I've got {rings.Name}, {earring.Name}, {chains.Name}, {pendants.Name} and {bracelets.Name}");

            IJewelryFactory goldenFactory = new GoldenJewerlyFactory();
            rings = goldenFactory.GetRings();
            earring = goldenFactory.GetEarring();
            chains = goldenFactory.GetChains();
            pendants = goldenFactory.GetPendants();
            bracelets = goldenFactory.GetBracelets();
            Console.WriteLine($"I've got {rings.Name}, {earring.Name}, {chains.Name}, {pendants.Name} and {bracelets.Name}");
        }
    }
}
