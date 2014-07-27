using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class Article
    {
        private string _itemName;

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        private string _storeName;
        private double _price;

        public Article(string itemName, string storeName, double price)
        {
            this._itemName = itemName;
            this._storeName = storeName;
            this._price = price;
        }

        public override string ToString()
        {
            return String.Format("Product name: {0}, \n Store: {1}, \n Price: {2}", _itemName, _storeName, _price);
        }
    }
}
