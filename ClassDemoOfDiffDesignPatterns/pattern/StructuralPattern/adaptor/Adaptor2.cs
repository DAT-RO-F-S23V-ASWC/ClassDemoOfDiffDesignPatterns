using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.adaptor
{
    public class Adaptor2:IAdaptor
    {
        private DemoAdaptee2 adap2 = new DemoAdaptee2();


        public string Request(string str)
        {
            return adap2.Upper(str);
        }
    }
}
