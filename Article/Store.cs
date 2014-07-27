using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class Store
    {
        private Article[] _array = new Article[5] { 
            new Article("Towel", "Auchan", 20.50), 
            new Article("Detergent", "Auchan", 45.25), 
            new Article("Shower Gel", "Auchan", 25.00), 
            new Article("Bread", "Auchan", 10.00), 
            new Article("Peach", "Auchan", 30.00) };

        public Article this[int index]
        {
            get
            {
                return _array[index];
            }

        }

        public Article this[string name]
        {
            get
            {
                foreach (Article item in _array)
                {
                    if(item.ItemName == name)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
    }
}
