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
            this.capacity = capacity;
        }
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private readonly List<Item> items;

        public IReadOnlyCollection<Item> Items
        {
            get
            {
                return this.items.AsReadOnly();
            }
        }

        private int load;

        public int Load
        {
            get { return load; }
            set { load = value; }
        }

        public void AddItem(Item item)
        {
            if (this.load + item.Weight > this.capacity)
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
