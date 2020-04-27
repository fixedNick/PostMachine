﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMachine
{
    class Item
    {
        private static List<Item> Items = new List<Item>();
        private static Int32 CurrentAvailableId = 0;

        public Int32 Id { get; private set; }
        public string Name { get; private set; }
        public string Description{ get; private set; }
        public double Price { get; private set; }
        public List<string> Photos { get; private set; } = new List<string>();
        // TKey -> Community ID
        // TValue -> Last post time
        public Dictionary<Int32, DateTime> PostTime { get; private set; }


        public Item(string name, string description, double price, ICollection<string> photos)
        {
            this.Id = CurrentAvailableId++;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Photos = photos.ToList();
        }
    }
}