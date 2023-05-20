using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BuilderEs : IBuilder
    {
        public string StepOne()
        {
            return "Uno";
        }

        public string StepThree()
        {
            return "Tres";
        }

        public string StepTwo()
        {
           return "Dos"; 
        }
    }
}