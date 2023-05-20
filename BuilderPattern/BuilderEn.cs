using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BuilderEn : IBuilder
    {
        public string StepOne()
        {
            return "One";
        }

        public string StepTwo()
        {
            return "Three";
        }

        public string StepThree()
        {
            return "Two";
        }
    }
}