using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public interface IBuilder
    {
        public string StepOne();

        public string StepTwo();

        public string StepThree();

    }
}