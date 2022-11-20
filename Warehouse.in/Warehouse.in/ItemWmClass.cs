using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.@in
{
    class Item
    {
        private string id;
        private string items;
        private int quantity;
        private string category;

        public string Id { get => id; set => id = value; }
        public string Items { get => items; set => items = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Category { get => category; set => category = value; }
    }

    class food : Item
    {
        private DateTime expiredDate;

        public DateTime ExpiredDate { get => expiredDate; set => expiredDate = value; }
    }
    class beverage : Item
    {
        private int capacity;

        public int Capacity { get => capacity; set => capacity = value; }
    }

    class furniture : Item
    {
        private string madeOf;

        public string MadeOf { get => madeOf; set => madeOf = value; }
    }
}