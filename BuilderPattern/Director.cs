using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class Director
    {
        private IBuilder _build;

        public Director(IBuilder build)
        {
            _build = build;
        }

        public void Asc(){
            Console.WriteLine(_build.StepOne());
            Console.WriteLine(_build.StepTwo());
            Console.WriteLine(_build.StepThree());
        }

        public void Desc(){
            Console.WriteLine(_build.StepThree());            
            Console.WriteLine(_build.StepTwo());
            Console.WriteLine(_build.StepOne());
        }
            
        
    }
}