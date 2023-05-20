using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.CasePizza
{
    public class HawaianaBuilder : PizzaBuilder
    {
        public HawaianaBuilder(string size)
        {
            _pizza = new Pizza
            {
                Size = size
            };
        }
        public override void StepPrepareMass()
        {
            _pizza.Mass = "Soft";
        }

        public override void StepAddSauce()
        {
            _pizza.Sauce = "Sweet";
        }

        public override void StepPrepareFill()
        {
            _pizza.Fill = "pineapple+tomato+ham";
        }
    }
}