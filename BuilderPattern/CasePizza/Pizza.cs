using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.CasePizza
{
    public class Pizza
    {
        public string? Mass { get; set; }
        public string? Sauce { get; set; }
        public string? Fill { get; set; }
        public string? Size { get; set; }
        public bool? isFolded { get; set; }

        public Pizza()
        {
        }

        public Pizza(string size, string masa, string salsa, string relleno, bool doblar) : this()
        {
            Size = size;
            Mass = masa;
            Sauce = salsa;
            Fill = relleno;
            isFolded = doblar;
        }
    }
}