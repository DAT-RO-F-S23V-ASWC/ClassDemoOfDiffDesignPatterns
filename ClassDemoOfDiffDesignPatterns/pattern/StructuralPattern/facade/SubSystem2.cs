using System;
using System.Collections.Generic;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.facade
{
    class SubSystem2
    {
        private List<String> shoppingList = new List<string>();

        public SubSystem2()
        {
            shoppingList.Clear();
            shoppingList.Add("milk");
            shoppingList.Add("salt");
        }

        public List<String> MyShoppingList()
        {
            return shoppingList;
        }

        public void AddShopItem(String anotherItem)
        {
            shoppingList.Add(anotherItem);
        }
    }
}
