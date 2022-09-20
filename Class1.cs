using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehousein
{
    class WarehouseManager
{
        private int _wmId;

        public int WMID
        {
            get { return _wmId; }
        }

        public void CheckRequest(item)
        {

        }

        public void InputItem(item)
        {

        }

        public void SendUpdate(item)
        {

        }
    }

    class Item
    {
        private int _itemId;
        private string _name;
        private int _quantity;
        private string _category;

        public int ItemID
        {
            get { return _itemId; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
