﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public Book(string itemId, string title, double price)
        {
            base.ItemId = itemId;
            Title = title;
            Price = price;
        }
        public Book(string itemId):
        
            this (itemId, "", 0.0)
        {
        }
        public Book(string itemId, string title):
        
            this (itemId, title, 0.0)
        {
        }
        public override string ToString()
        {
            string convertBookPropertiesToString;
            convertBookPropertiesToString = "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price.ToString();
            return convertBookPropertiesToString;
        }
    }
}
