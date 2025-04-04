using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.adaptor
{
    public class Adaptor1:IAdaptor
    {
        private DemoAdaptee1 adap1;

        public Adaptor1()
        {
            adap1 = new DemoAdaptee1();
        }

        public string Request(string str)
        {
            return adap1.KindOfPerson(str);
        }
    }
}
