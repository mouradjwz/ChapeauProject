using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Drinks : Item
    {
        public string Drink_Name { get; set; }
        public int Drink_Type { get; set; } //0 - Soft Drinks, 1 - Beers, 2 - Wines, 3 - Spirits, 4 - Warm Drinks
    }
}
