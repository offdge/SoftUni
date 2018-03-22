using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public abstract class Bag
    {
        public Bag(int capacity)
        {
            this.items = new List<Item>();
            this.Capacity = capacity;
        }

        private int capacity = 100;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private List<Item> items;

        public IReadOnlyCollection<Item> Items
        {
            get
            {
                return this.items.AsReadOnly();
            }
        }

        private int Load => this.items.Sum(i => i.Weight);

        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            items.Add(item);
        }

        public Item GetItem (string name)
        {
           if (items.Count == 0)
           {
               throw new InvalidOperationException("Bag is empty!");
           }
           if (!items.Any(x=>x.GetType().Name == name))
           {
               throw new ArgumentException($"No item with name {name} in bag!");
           }

            var item = this.items.First(x => x.GetType().Name == name);
            this.items.Remove(item);
            return item;
        }
    }
}
