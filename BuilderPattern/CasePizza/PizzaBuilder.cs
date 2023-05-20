using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.CasePizza
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public string? Size { get; set; }

        public Pizza GetPizza() { return _pizza; }

        public virtual void StepPrepareMass()
        {

        }
        public virtual void StepAddSauce()
        {
        }

        public virtual void StepPrepareFill()
        {

        }
        public virtual void StepFoldPizza(){

        }

    }
}