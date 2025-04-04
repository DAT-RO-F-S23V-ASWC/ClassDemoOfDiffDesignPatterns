using System;
using System.Collections.Generic;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.facade
{
    class Facade
    {
        private SubSystem1 _sub1 = new SubSystem1();
        private SubSystem2 _sub2 = new SubSystem2();

        public void InsertNote(string str)
        {
            _sub1.InsertNote(str);
        }

        public void NewShopItem(string str)
        {
            _sub2.AddShopItem(str);
        }

        public List<String> GetShoppingList()
        {
            return _sub2.MyShoppingList();
        }

    }
}
