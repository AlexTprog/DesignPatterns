using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.CasePizza
{
    public class Kitchen
    {
        private PizzaBuilder?_pizzaBuilder;

        public void ReceiveNextPizza(PizzaBuilder builder){
            _pizzaBuilder = builder;
        }

        public void CookPizzaStepByStep(){
            _pizzaBuilder.StepPrepareMass();
            _pizzaBuilder.StepAddSauce();
            _pizzaBuilder.StepPrepareFill();
        }

        public Pizza PreparePizza{
            get {return _pizzaBuilder.GetPizza();}
        }
    }
}