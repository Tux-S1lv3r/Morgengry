using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        low, medium, high
    };
    public class Amulet : Merchandise
    {
        public string Design { get; set; }
        public Level Quality { get; set; }
        public Amulet(string itemId, Level quality, string design)
        {
            base.ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId):
            this (itemId, Level.medium, "")
        { 

        }
        public Amulet(string itemId, Level quality):
            this(itemId, quality, "")
        {

        }
        public override string ToString()
        {
            string convertAmuletPropertiesToString;
            convertAmuletPropertiesToString = "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design.ToString();
            return convertAmuletPropertiesToString;
        }
    }
}
